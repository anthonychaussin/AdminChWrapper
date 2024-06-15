using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models
{
    /// <summary>
    /// The date partially known type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class DatePartiallyKnown
    {
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        [XmlElementAttribute("year", typeof(string), DataType = "gYear", Order = 0)]
        [XmlElementAttribute("yearMonth", typeof(string), DataType = "gYearMonth", Order = 0)]
        [XmlElementAttribute("yearMonthDay", typeof(DateTime), DataType = "date", Order = 0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item { get; set; }

        /// <summary>
        /// Gets or sets the item element name.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        [XmlIgnoreAttribute()]
        public ItemChoice ItemElementName { get; set; }
    }
}