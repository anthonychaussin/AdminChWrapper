using System.Diagnostics;

using WseAdmin.Enums.UidReg;

namespace WseAdmin.Models.UidEntity
{
    /// <summary>
    /// The uidreg information public search type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class UidregInformationPublicSearch
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
        /// Gets or sets a value indicating whether uidreg uid service.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public bool uidregUidService { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether uidreg uid service specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool uidregUidServiceSpecified { get; set; }
    }
}