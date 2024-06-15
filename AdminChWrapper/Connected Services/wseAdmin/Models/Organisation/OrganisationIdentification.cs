using System.Diagnostics;
using WseAdmin.Models.Organisation;
using WseAdmin.Models.UidEntity;

namespace WseAdmin
{
    /// <summary>
    /// The organisation identification type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0097/5")]
    public partial class OrganisationIdentification
    {
        /// <summary>
        /// Gets or sets the uid.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public UidStructure uid { get; set; }

        /// <summary>
        /// Gets or sets the local organisation id.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public NamedOrganisationId localOrganisationId { get; set; }

        /// <summary>
        /// Gets or sets the other organisation id.
        /// </summary>
        [XmlElementAttribute("OtherOrganisationId", Order = 2)]
        public NamedOrganisationId[] OtherOrganisationId { get; set; }

        /// <summary>
        /// Gets or sets the organisation name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 3)]
        public string organisationName { get; set; }

        /// <summary>
        /// Gets or sets the organisation legal name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 4)]
        public string organisationLegalName { get; set; }

        /// <summary>
        /// Gets or sets the organisation additional name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 5)]
        public string? organisationAdditionalName { get; set; }

        /// <summary>
        /// Gets or sets the legal form.
        /// </summary>
        [XmlElementAttribute(Order = 6)]
        public string legalForm { get; set; }
    }
}