using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models
{
    /// <summary>
    /// The lei register information type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class LeiRegisterInformation
    {
        /// <summary>
        /// Gets or sets the initial registration date.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 0)]
        public DateTime initialRegistrationDate { get; set; }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 1)]
        public DateTime expirationDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether expiration date specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool expirationDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets the registration status.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public LeiRegisterInformationTypeRegistrationStatus registrationStatus { get; set; }
    }
}