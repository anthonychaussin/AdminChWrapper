using System.Diagnostics;
using WseAdmin.Models.Person;

namespace WseAdmin.Models
{
    /// <summary>
    /// The contact type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0046/5")]
    public partial class Contact
    {
        /// <summary>
        /// Gets or sets the local i d.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public NamedPersonId localID { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [XmlElementAttribute("addressType", Order = 1)]
        public Address.Address[] address { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [XmlElementAttribute("emailType", Order = 2)]
        public Email[] email { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [XmlElementAttribute("phoneType", Order = 3)]
        public Phone[] phone { get; set; }

        /// <summary>
        /// Gets or sets the internet.
        /// </summary>
        [XmlElementAttribute("internetType", Order = 4)]
        public Internet[] internet { get; set; }
    }
}