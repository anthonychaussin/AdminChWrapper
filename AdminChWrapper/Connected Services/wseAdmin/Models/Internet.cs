using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models
{
    /// <summary>
    /// The internet type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class Internet
    {
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        [XmlElementAttribute("internetCategory", typeof(InternetCategory), Order = 0)]
        [XmlElementAttribute("otherInternetCategory", typeof(string), DataType = "token", Order = 0)]
        public object Item { get; set; }

        /// <summary>
        /// Gets or sets the internet address.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string internetAddress { get; set; }

        /// <summary>
        /// Gets or sets the validity.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public DateRange validity { get; set; }
    }
}