using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models.Address
{
    /// <summary>
    /// The address information type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0010/7")]
    public partial class AddressInformation
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
        /// Gets or sets the dwelling number.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 4)]
        public string dwellingNumber { get; set; }

        /// <summary>
        /// Gets or sets the post office box number.
        /// </summary>
        [XmlElementAttribute(Order = 5)]
        public uint postOfficeBoxNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether post office box number specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool postOfficeBoxNumberSpecified { get; set; }

        /// <summary>
        /// Gets or sets the post office box text.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 6)]
        public string postOfficeBoxText { get; set; }

        /// <summary>
        /// Gets or sets the locality.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 7)]
        public string locality { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 8)]
        public string town { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [XmlElementAttribute("foreignZipCode", typeof(string), DataType = "token", Order = 9)]
        [XmlElementAttribute("swissZipCode", typeof(uint), Order = 9)]
        [XmlElementAttribute("swissZipCodeAddOn", typeof(string), Order = 9)]
        [XmlElementAttribute("swissZipCodeId", typeof(int), Order = 9)]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        /// <summary>
        /// Gets or sets the items element name.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order = 10)]
        [XmlIgnoreAttribute()]
        public ItemsChoice1[] ItemsElementName { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [XmlElementAttribute(Order = 11)]
        public Country country { get; set; }
    }
}