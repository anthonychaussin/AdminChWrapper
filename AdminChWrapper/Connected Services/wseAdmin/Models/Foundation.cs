using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models
{
    /// <summary>
    /// The foundation type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class Foundation
    {
        /// <summary>
        /// Gets or sets the foundation date.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public DatePartiallyKnown foundationDate { get; set; }

        /// <summary>
        /// Gets or sets the foundation reason.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public FoundationReason foundationReason { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether foundation reason specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool foundationReasonSpecified { get; set; }
    }
}