using AdminChWrapper.Models;
using Newtonsoft.Json;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using WseAdmin.Enums;
using WseAdmin.Models;
using WseAdmin.Models.Organisation;
using WseAdmin.Models.UidEntity;

namespace AdminChWrapper.Api
{
    /// <summary>
    /// The search api.
    /// </summary>
    public partial class SearchApi
    {
        private static readonly string JSON_PATH = Path.Combine(".", "resources", "organisations.json");
        private static readonly byte[] BRACKETBYTE = Encoding.UTF8.GetBytes("]");

        /// <summary>
        /// Gets or sets the organizations.
        /// </summary>
        public Dictionary<int, Organisation> Organizations { get; set; } = [];

        /// <summary>
        /// Gets the client base.
        /// </summary>
        public PublicServicesClient ClientBase { get; }

        /// <summary>
        /// Gets or sets the bad v a t.
        /// </summary>
        public List<int> BadVAT { get; set; } = [0, 1001001];

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        public SearchApi() : this(LoadJson()) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <param name="organisations">The organisations.</param>
        public SearchApi(List<Organisation> organisations)
        {
            Organizations = organisations.ToDictionary(o => int.Parse(o.organisation.organisationIdentification.uid.uidOrganisationId), o => o);
            ClientBase = new PublicServicesClient()
            {

            };
        }

        /// <summary>
        /// Searches the.
        /// </summary>
        /// <param name="searchRequest">The search request.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <returns>A Task.</returns>
        public Task<UidEntitySearchResponse> Search(UidEntityPublicSearchRequest searchRequest, SearchConfiguration searchConfiguration)
        {
            return ClientBase.SearchAsync(searchRequest, searchConfiguration);
        }

        /// <summary>
        /// Vats the search.
        /// </summary>
        /// <param name="vatIDE">The vat i d e.</param>
        /// <returns>A T.</returns>
        public T VatSearch<T>(int vatIDE) where T : IOrganisation
        {
            if (BadVAT.Contains(vatIDE))
            {
                throw new Exception("Vat number is incorect or not accessible");
            }

            if (Organizations.Count == 0 || !Organizations.TryGetValue(vatIDE, value: out Organisation organisationFinded))
            {
                if (!ClientBase.ValidateUIDAsync("CHE" + vatIDE).Result)
                {
                    BadVAT.Add(vatIDE);
                    throw new Exception("Vat number is incorect or not accessible");
                }

                try
                {
                    organisationFinded = Search(new UidEntityPublicSearchRequest
                    {
                        Item = new UidStructure { uidOrganisationId = vatIDE.ToString() },
                    },
                    new SearchConfiguration
                    {
                        searchMode = SearchMode.Auto,
                        maxNumberOfRecords = 1,
                        searchNameAndAddressHistory = false,
                    }).Result.uidEntitySearchResultItem[0].organisation;

                    AddToOrganisation(int.Parse(organisationFinded.organisation.organisationIdentification.uid.uidOrganisationId), organisationFinded);
                }
                catch(FaultException e)
                {
                    throw new Exception("Vat number not found", e);
                }
            }

            return typeof(T) == typeof(Organisation) ? (T)(object)organisationFinded : (T)(object)Company.CompanyFromOrganistation(organisationFinded);
        }

        /// <summary>
        /// Vats the search.
        /// </summary>
        /// <param name="vatIDE">The vat i d e.</param>
        /// <returns>A T.</returns>
        public T VatSearch<T>(string vatIDE) where T : IOrganisation
        {
            var organisation = VatSearch<Organisation>(int.Parse(VATParser().Replace(vatIDE.ToLower(), String.Empty)));

            return typeof(T) == typeof(Organisation) ? (T)(object)organisation : (T)(object)Company.CompanyFromOrganistation(organisation);
        }

        /// <summary>
        /// Cleans the cache.
        /// </summary>
        /// <returns>A bool.</returns>
        public bool CleanCache()
        {
            this.Organizations.Clear();
            return Organizations.Count == 0;
        }

        /// <summary>
        /// Loads the json.
        /// </summary>
        /// <returns>A list of organisationTypes.</returns>
        private static List<Organisation> LoadJson()
        {
            using (var r = new StreamReader(JSON_PATH))
            {
                return JsonConvert.DeserializeObject<List<Organisation>>(r.ReadToEnd()) ?? [];
            }
        }

        /// <summary>
        /// Adds the to organisation.
        /// </summary>
        /// <param name="organisationId">The organisation id.</param>
        /// <param name="organisation">The organisation.</param>
        private void AddToOrganisation(int organisationId, Organisation organisation)
        {
            if (this.Organizations.TryAdd(organisationId, organisation))
            {
                using FileStream fs = File.Open(JSON_PATH, FileMode.Open);
                _ = fs.Seek(-1, SeekOrigin.End);
                Byte[] mySerializedJSONObjAsBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(organisation));
                fs.Write(mySerializedJSONObjAsBytes, 0, mySerializedJSONObjAsBytes.Length);
                fs.Write(BRACKETBYTE, 0, 1);
                fs.SetLength(fs.Position);
            }
        }

        /// <summary>
        /// VS the a t parser.
        /// </summary>
        /// <returns>A Regex.</returns>
        [GeneratedRegex(@"[che\-\. ]")]
        private static partial Regex VATParser();
    }
}