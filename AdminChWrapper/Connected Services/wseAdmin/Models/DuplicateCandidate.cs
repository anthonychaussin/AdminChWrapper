using System.Diagnostics;
using WseAdmin.Enums.UidReg;
using WseAdmin.Models.UidEntity;

namespace WseAdmin.Models
{
    /// <summary>
    /// The duplicate candidate type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class DuplicateCandidate
    {
        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public uint rating { get; set; } = 0;

        /// <summary>
        /// Gets or sets the uid.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public UidStructure uid { get; set; }

        /// <summary>
        /// Gets or sets the organisation name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 2)]
        public string organisationName { get; set; }

        /// <summary>
        /// Gets or sets the organisation additional name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 3)]
        public string? organisationAdditionalName { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 4)]
        public string? street { get; set; }

        /// <summary>
        /// Gets or sets the swiss zip code.
        /// </summary>
        [XmlElementAttribute(Order = 5)]
        public uint? swissZipCode { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 6)]
        public string? town { get; set; }

        /// <summary>
        /// Gets or sets the uidreg status enterprise detail.
        /// </summary>
        [XmlElementAttribute(Order = 7)]
        public UidRegStatusEnterpriseDetail uidregStatusEnterpriseDetail { get; set; }

        /// <summary>
        /// Gets or sets the uidreg organisation type.
        /// </summary>
        [XmlElementAttribute("uidregOrganisationType", Order = 8)]
        public UidRegOrganisation uidregOrganisationType { get; set; }
    }
}