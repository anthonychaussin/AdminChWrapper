using System.Diagnostics;
using WseAdmin.Models.Organisation;
using WseAdmin.Models.Person;

namespace WseAdmin.Models.Address
{
    /// <summary>
    /// The mail address type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0010/7")]
    public partial class MailAddress
    {
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        [XmlElementAttribute("organisation", typeof(OrganisationMailAddressInfo), Order = 0)]
        [XmlElementAttribute("person", typeof(PersonMailAddressInfo), Order = 0)]
        public object Item { get; set; }

        /// <summary>
        /// Gets or sets the address information.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public AddressInformation addressInformation { get; set; }
    }
}