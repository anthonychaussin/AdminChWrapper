using System.Diagnostics;

namespace WseAdmin.Models
{
    /// <summary>
    /// The country type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0010/7")]
    public partial class Country
    {
        /// <summary>
        /// Gets or sets the country id.
        /// </summary>
        [XmlElementAttribute(DataType = "integer", Order = 0)]
        public string countryId { get; set; }

        /// <summary>
        /// Gets or sets the country id iso2.
        /// </summary>
        [XmlElementAttribute("countryIdISO2Type", DataType = "token", Order = 1)]
        public string countryIdISO2 { get; set; }

        /// <summary>
        /// Gets or sets the country name short.
        /// </summary>
        [XmlElementAttribute("countryNameShortType", DataType = "token", Order = 2)]
        public string countryNameShort { get; set; }
    }
}