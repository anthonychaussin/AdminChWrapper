using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models.Address
{
    /// <summary>
    /// The organisation address type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class OrganisationAddress
    {
        /// <summary>
        /// Gets or sets the address category.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 0)]
        public string addressCategory { get; set; }

        /// <summary>
        /// Gets or sets the address line1.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string addressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line2.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 2)]
        public string addressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 3)]
        public string street { get; set; }

        /// <summary>
        /// Gets or sets the house number.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 4)]
        public string houseNumber { get; set; }

        /// <summary>
        /// Gets or sets the dwelling number.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 5)]
        public string dwellingNumber { get; set; }

        /// <summary>
        /// Gets or sets the post office box number.
        /// </summary>
        [XmlElementAttribute(Order = 6)]
        public uint postOfficeBoxNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether post office box number specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool postOfficeBoxNumberSpecified { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 7)]
        public string town { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [XmlElementAttribute("EGID", typeof(uint), Order = 8)]
        [XmlElementAttribute("cantonAbbreviation", typeof(CantonAbbreviation), Order = 8)]
        [XmlElementAttribute("foreignZipCode", typeof(string), DataType = "token", Order = 8)]
        [XmlElementAttribute("municipalityId", typeof(int), Order = 8)]
        [XmlElementAttribute("swissZipCode", typeof(uint), Order = 8)]
        [XmlElementAttribute("swissZipCodeAddOn", typeof(string), Order = 8)]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        /// <summary>
        /// Gets or sets the items element name.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order = 9)]
        [XmlIgnoreAttribute()]
        public ItemsChoice[] ItemsElementName { get; set; }

        /// <summary>
        /// Gets or sets the country id i s o2.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 10)]
        public string countryIdISO2 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether deliverable yes no.
        /// </summary>
        [XmlElementAttribute(Order = 11)]
        public bool deliverableYesNo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether deliverable yes no specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool deliverableYesNoSpecified { get; set; }

        /// <summary>
        /// Gets or sets the date of last check.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 12)]
        public DateTime dateOfLastCheck { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether date of last check specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool dateOfLastCheckSpecified { get; set; }
    }
}