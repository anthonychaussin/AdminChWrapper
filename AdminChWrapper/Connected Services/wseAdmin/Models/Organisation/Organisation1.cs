using System.Diagnostics;
using WseAdmin.Models.Address;

namespace WseAdmin.Models.Organisation
{
    /// <summary>
    /// The organisation type1.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(TypeName = "Organisation", Namespace = "http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class Organisation1
    {
        /// <summary>
        /// Gets or sets the organisation identification.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public OrganisationIdentification organisationIdentification { get; set; }

        /// <summary>
        /// Gets or sets the uid branche text.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string uidBrancheText { get; set; }

        /// <summary>
        /// Gets or sets the n o g a code.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 2)]
        public string NOGACode { get; set; }

        /// <summary>
        /// Gets or sets the foundation.
        /// </summary>
        [XmlElementAttribute(Order = 3)]
        public Foundation foundation { get; set; }

        /// <summary>
        /// Gets or sets the liquidation.
        /// </summary>
        [XmlElementAttribute(Order = 4)]
        public Liquidation liquidation { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [XmlElementAttribute("address", Order = 5)]
        public OrganisationAddress[] address { get; set; } = [];

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        [XmlElementAttribute(Order = 6)]
        public Contact contact { get; set; }

        /// <summary>
        /// Gets or sets the language of correspondance.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 7)]
        public string languageOfCorrespondance { get; set; }
    }
}