using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models
{
    /// <summary>
    /// The phone type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class Phone
    {
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        [XmlElementAttribute("otherPhoneCategory", typeof(string), DataType = "token", Order = 0)]
        [XmlElementAttribute("phoneCategory", typeof(PhoneCategory), Order = 0)]
        public object Item { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public string phoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the validity.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public DateRange validity { get; set; }
    }
}