using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models.Address
{
    /// <summary>
    /// The address type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class Address
    {
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        [XmlElementAttribute("addressCategory", typeof(AddressCategory), Order = 0)]
        [XmlElementAttribute("otherAddressCategory", typeof(string), DataType = "token", Order = 0)]
        public object Item { get; set; }

        /// <summary>
        /// Gets or sets the postal address.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public MailAddress postalAddress { get; set; }

        /// <summary>
        /// Gets or sets the validity.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public DateRange validity { get; set; }
    }
}