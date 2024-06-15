using System.Diagnostics;

namespace WseAdmin.Models.Errors
{
    /// <summary>
    /// The duplicate fault.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class DuplicateFault : ServiceFault
    {
        /// <summary>
        /// Gets or sets the candidates.
        /// </summary>
        [XmlElementAttribute("candidates", Order = 0)]
        public DuplicateCandidate[] candidates { get; set; } = [];

        /// <summary>
        /// Gets or sets the duplicate override code.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string? duplicateOverrideCode { get; set; }
    }
}