using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models
{
    /// <summary>
    /// The liquidation type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0098/5")]
    public partial class Liquidation
    {
        /// <summary>
        /// Gets or sets the liquidation date.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public DatePartiallyKnown liquidationDate { get; set; }

        /// <summary>
        /// Gets or sets the liquidation start date.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public DatePartiallyKnown liquidationStartDate { get; set; }

        /// <summary>
        /// Gets or sets the liquidation reason.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public LiquidationReason liquidationReason { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether liquidation reason specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool liquidationReasonSpecified { get; set; }
    }
}