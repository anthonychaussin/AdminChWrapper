using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models.Address
{
    /// <summary>
    /// The address search type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class AddressSearch
    {
        /// <summary>
        /// Gets or sets the address line1.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 0)]
        public string addressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line2.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string addressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 2)]
        public string street { get; set; }

        /// <summary>
        /// Gets or sets the house number.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 3)]
        public string houseNumber { get; set; }

        /// <summary>
        /// Gets or sets the post office box number.
        /// </summary>
        [XmlElementAttribute(Order = 4)]
        public uint postOfficeBoxNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether post office box number specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool postOfficeBoxNumberSpecified { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 5)]
        public string town { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [XmlElementAttribute("EGID", typeof(uint), Order = 6)]
        [XmlElementAttribute("cantonAbbreviation", typeof(CantonAbbreviation), Order = 6)]
        [XmlElementAttribute("foreignZipCode", typeof(string), DataType = "token", Order = 6)]
        [XmlElementAttribute("municipalityId", typeof(int), Order = 6)]
        [XmlElementAttribute("swissZipCode", typeof(uint), Order = 6)]
        [XmlElementAttribute("swissZipCodeAddOn", typeof(string), Order = 6)]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        /// <summary>
        /// Gets or sets the items element name.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order = 7)]
        [XmlIgnoreAttribute()]
        public ItemsChoice2[] ItemsElementName { get; set; }

        /// <summary>
        /// Gets or sets the country id i s o2.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 8)]
        public string countryIdISO2 { get; set; }
    }
}