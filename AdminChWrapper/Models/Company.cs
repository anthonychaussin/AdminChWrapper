using System.Text.RegularExpressions;
using wseAdmin;

namespace AdminChWrapper.Models
{
    public partial class Company : IOrganisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public List<string> TranslatedNames { get; set; }
        public Address Address { get; set; }
        public string NormalizedVAT { get {  return "CHE-" + this.Id.ToString().Substring(0,3) + '.' + this.Id.ToString().Substring(3, 3) + '.' + this.Id.ToString().Substring(6, 3); } }

        public Company(organisationType organisationType) 
        {
            var organisation = organisationType.organisation;
            Id = int.Parse(organisation.organisationIdentification.uid.uidOrganisationId);
            Name = organisation.organisationIdentification.organisationName;
            LegalName = organisation.organisationIdentification.organisationLegalName;
            TranslatedNames = ListTranslatedNameParser(organisationType.commercialRegisterInformation?.commercialRegisterNameTranslation);
            var address = organisation.address.First();
            Address = new Address
            {
                Line1 = address.addressLine1,
                Line2 = address.addressLine2,
                Street = address.street,
                Number = address.houseNumber,
                Town = address.town,
            };
        }

        public static List<string> ListTranslatedNameParser(string? translatedNames)
        {
            if (translatedNames is null)
                return new List<string>();

            return TranslatedNamesSplitter().Replace(translatedNames, " § ").Split(" § ").ToList().ConvertAll(n => n.Trim('(').Trim(')').Trim());
        }

        [GeneratedRegex(@"\) \(")]
        private static partial Regex TranslatedNamesSplitter();
    }
}
