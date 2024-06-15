using System.Diagnostics;

namespace WseAdmin.Models
{
    /// <summary>
    /// The date range type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class DateRange
    {
        /// <summary>
        /// Gets or sets the date from.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 0)]
        public DateTime dateFrom { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether date from specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool dateFromSpecified { get; set; }

        /// <summary>
        /// Gets or sets the date to.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 1)]
        public DateTime dateTo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether date to specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool dateToSpecified { get; set; }
    }
}