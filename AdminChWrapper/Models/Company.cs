using System.Text.RegularExpressions;
using wseAdmin;

namespace AdminChWrapper.Models
{
    /// <summary>
    /// The company.
    /// </summary>
    public partial class Company : IOrganisation
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the legal name.
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or sets the translated names.
        /// </summary>
        public List<string> TranslatedNames { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets the normalized v a t.
        /// </summary>
        public string NormalizedVAT
        { get { return "CHE-" + this.Id.ToString().Substring(0, 3) + '.' + this.Id.ToString().Substring(3, 3) + '.' + this.Id.ToString().Substring(6, 3); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        /// <param name="organisationType">The organisation type.</param>
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

        /// <summary>
        /// Lists the translated name parser.
        /// </summary>
        /// <param name="translatedNames">The translated names.</param>
        /// <returns>A list of string.</returns>
        public static List<string> ListTranslatedNameParser(string? translatedNames)
        {
            if (translatedNames is null)
                return [];

            return TranslatedNamesSplitter().Replace(translatedNames, " § ").Split(" § ").ToList().ConvertAll(n => n.Trim('(').Trim(')').Trim());
        }

        /// <summary>
        /// Translateds the names splitter.
        /// </summary>
        /// <returns>A Regex.</returns>
        [GeneratedRegex(@"\) \(")]
        private static partial Regex TranslatedNamesSplitter();
    }
}