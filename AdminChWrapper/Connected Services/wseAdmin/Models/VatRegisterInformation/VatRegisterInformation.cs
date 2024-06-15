using System.Diagnostics;
using WseAdmin.Enums;
using WseAdmin.Models.UidEntity;

namespace WseAdmin.Models.VatRegisterInformation
{
    /// <summary>
    /// The vat register information type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class VatRegisterInformation
    {
        /// <summary>
        /// Gets or sets the vat status.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public VatStatus vatStatus { get; set; }

        /// <summary>
        /// Gets or sets the vat entry status.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public VatEntryStatus vatEntryStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether vat entry status specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool vatEntryStatusSpecified { get; set; }

        /// <summary>
        /// Gets or sets the vat entry date.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 2)]
        public DateTime vatEntryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether vat entry date specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool vatEntryDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets the vat liquidation date.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 3)]
        public DateTime vatLiquidationDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether vat liquidation date specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool vatLiquidationDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets the uid vat.
        /// </summary>
        [XmlElementAttribute(Order = 4)]
        public UidStructure uidVat { get; set; }
    }
}