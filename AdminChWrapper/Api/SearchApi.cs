using AdminChWrapper.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;
using wseAdmin;

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
        public Dictionary<int, organisationType> Organizations { get; set; } = [];

        /// <summary>
        /// Gets or sets the bad v a t.
        /// </summary>
        public List<int> BadVAT { get; set; } = [0, 1001001];

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        public SearchApi()
        {
            Organizations = LoadJson().ToDictionary(o => int.Parse(o.organisation.organisationIdentification.uid.uidOrganisationId), o => o);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <param name="organisations">The organisations.</param>
        public SearchApi(List<organisationType> organisations)
        {
            Organizations = organisations.ToDictionary(o => int.Parse(o.organisation.organisationIdentification.uid.uidOrganisationId), o => o);
        }

        /// <summary>
        /// Searches the.
        /// </summary>
        /// <param name="searchRequest">The search request.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        /// <returns>A Task.</returns>
        public static Task<uidEntitySearchResponse> Search(uidEntityPublicSearchRequest searchRequest, searchConfiguration searchConfiguration)
        {
            return new PublicServicesClient().SearchAsync(searchRequest, searchConfiguration);
        }

        /// <summary>
        /// Vats the search.
        /// </summary>
        /// <param name="vatIDE">The vat i d e.</param>
        /// <returns>A T.</returns>
        public T VatSearch<T>(int vatIDE) where T : IOrganisation
        {
            if (Organizations.Count > 0 && Organizations.TryGetValue(vatIDE, out var organisationFinded))
            {
                return typeof(T) == typeof(organisationType) ? (T)(object)organisationFinded : (T)(object)new Company(organisationFinded);
            }

            if (BadVAT.Contains(vatIDE))
            {
                throw new Exception("Vat number is incorect or not accessible");
            }

            var isValide = false;
            try
            {
                isValide = new PublicServicesClient().ValidateUIDAsync("CHE" + vatIDE).Result;
            }
            catch { }

            if (isValide)
            {
                try
                {
                    var result = Search(
                new uidEntityPublicSearchRequest
                {
                    Item = new uidStructureType { uidOrganisationId = vatIDE.ToString() },
                },
                new searchConfiguration
                {
                    searchMode = searchMode.Auto,
                    maxNumberOfRecords = 1,
                    searchNameAndAddressHistory = false,
                }).Result.uidEntitySearchResultItem.First().organisation;

                    AddToOrganisation(int.Parse(result.organisation.organisationIdentification.uid.uidOrganisationId), result);

                    return typeof(T) == typeof(organisationType) ? (T)(object)result : (T)(object)new Company(result);
                }
                catch
                {
                    throw new Exception("Vat number not found");
                }
            }
            else
            {
                BadVAT.Add(vatIDE);
                throw new Exception("Vat number is incorect or not accessible");
            }
        }

        /// <summary>
        /// Vats the search.
        /// </summary>
        /// <param name="vatIDE">The vat i d e.</param>
        /// <returns>A T.</returns>
        public T VatSearch<T>(string vatIDE) where T : IOrganisation
        {
            var organisation = VatSearch<organisationType>(int.Parse(VATParser().Replace(vatIDE.ToLower(), String.Empty)));

            return typeof(T) == typeof(organisationType) ? (T)(object)organisation : (T)(object)new Company(organisation);
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
        private static List<organisationType> LoadJson()
        {
            using (var r = new StreamReader(JSON_PATH))
            {
                return JsonConvert.DeserializeObject<List<organisationType>>(r.ReadToEnd()) ?? [];
            }
        }

        /// <summary>
        /// Adds the to organisation.
        /// </summary>
        /// <param name="organisationId">The organisation id.</param>
        /// <param name="organisation">The organisation.</param>
        private void AddToOrganisation(int organisationId, organisationType organisation)
        {
            if (this.Organizations.TryAdd(organisationId, organisation))
            {
                using (var fs = File.Open(JSON_PATH, FileMode.Open))
                {
                    fs.Seek(-1, SeekOrigin.End);
                    var mySerializedJSONObjAsBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(organisation));
                    fs.Write(mySerializedJSONObjAsBytes, 0, mySerializedJSONObjAsBytes.Length);
                    fs.Write(BRACKETBYTE, 0, 1);
                    fs.SetLength(fs.Position);
                }
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