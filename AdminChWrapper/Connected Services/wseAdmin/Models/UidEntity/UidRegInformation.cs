using System.Diagnostics;
using WseAdmin.Enums.UidReg;

namespace WseAdmin.Models.UidEntity
{
    /// <summary>
    /// The uidreg information type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class UidRegInformation
    {
        /// <summary>
        /// Gets or sets the uidreg status enterprise detail.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public UidRegStatusEnterpriseDetail uidregStatusEnterpriseDetail { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether uidreg status enterprise detail specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool uidregStatusEnterpriseDetailSpecified { get; set; }

        /// <summary>
        /// Gets or sets the uidreg public status.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public UidRegPublicStatus uidregPublicStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether uidreg public status specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool uidregPublicStatusSpecified { get; set; }

        /// <summary>
        /// Gets or sets the uidreg organisation type.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public UidRegOrganisation uidregOrganisationType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether uidreg organisation type specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool uidregOrganisationTypeSpecified { get; set; }

        /// <summary>
        /// Gets or sets the uidreg liquidation reason.
        /// </summary>
        [XmlElementAttribute(Order = 3)]
        public UidRegLiquidationReason uidregLiquidationReason { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether uidreg liquidation reason specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool uidregLiquidationReasonSpecified { get; set; }

        /// <summary>
        /// Gets or sets the uidreg source.
        /// </summary>
        [XmlElementAttribute("uidregSource", Order = 4)]
        public UidRegSource[] uidregSource { get; set; }

        /// <summary>
        /// Gets or sets the uid replacement.
        /// </summary>
        [XmlElementAttribute(Order = 5)]
        public UidStructure uidReplacement { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether uidreg uid service.
        /// </summary>
        [XmlElementAttribute(Order = 6)]
        public bool uidregUidService { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether uidreg uid service specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool uidregUidServiceSpecified { get; set; }

        /// <summary>
        /// Gets or sets the uidreg translation.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 7)]
        public string uidregTranslation { get; set; }
    }
}