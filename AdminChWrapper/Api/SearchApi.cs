using AdminChWrapper.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;
using wseAdmin;

namespace AdminChWrapper.Api
{
    public partial class SearchApi
    {
        private static readonly string JSON_PATH = Path.Combine(".", "resources", "organisations.json");
        private static readonly byte[] BRACKETBYTE = Encoding.UTF8.GetBytes("]");
        public Dictionary<int, organisationType> Organisations { get; set; } = [];
        public List<int> BadVAT { get; set; } = new List<int>() { 0, 1001001 };
        public SearchApi()
        {
            Organisations = LoadJson().ToDictionary(o => int.Parse(o.organisation.organisationIdentification.uid.uidOrganisationId), o => o);
        }
        public SearchApi(List<organisationType> organisations)
        {
            Organisations = organisations.ToDictionary(o => int.Parse(o.organisation.organisationIdentification.uid.uidOrganisationId), o => o);
        }

        public static Task<uidEntitySearchResponse> Search(uidEntityPublicSearchRequest searchRequest, searchConfiguration searchConfiguration)
        {
            return new PublicServicesClient().SearchAsync(searchRequest, searchConfiguration);
        }

        public T VatSearch<T>(int vatIDE) where T : IOrganisation
        {
            if (Organisations.Count > 0 && Organisations.TryGetValue(vatIDE, out var organisationFinded))
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
            catch {}
            

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

        public T VatSearch<T>(string vatIDE) where T : IOrganisation
        {
            var organisation = VatSearch<organisationType>(int.Parse(VATParser().Replace(vatIDE.ToLower(), String.Empty)));

            return typeof(T) == typeof(organisationType) ? (T)(object)organisation : (T)(object)new Company(organisation);
        }

        public bool CleanCache()
        {
            this.Organisations.Clear();
            return Organisations.Count == 0;
        }

        private static List<organisationType> LoadJson()
        {
            using (var r = new StreamReader(JSON_PATH))
            {
                return JsonConvert.DeserializeObject<List<organisationType>>(r.ReadToEnd()) ?? [];
            }
        }

        private void AddToOrganisation(int organisationId, organisationType organisation)
        {
            if (this.Organisations.TryAdd(organisationId, organisation))
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

        [GeneratedRegex(@"[che\-\. ]")]
        private static partial Regex VATParser();
    }
}
