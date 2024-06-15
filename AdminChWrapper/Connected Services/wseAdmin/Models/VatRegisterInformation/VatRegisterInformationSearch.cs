using System.Diagnostics;
using WseAdmin.Enums;
using WseAdmin.Models.UidEntity;

namespace WseAdmin.Models.VatRegisterInformation
{
    /// <summary>
    /// The vat register information search type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlType(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class VatRegisterInformationSearch
    {
        /// <summary>
        /// Gets or sets the vat status.
        /// </summary>
        [XmlElement(Order = 0)]
        public VatStatus vatStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether vat status specified.
        /// </summary>
        [XmlIgnore()]
        public bool vatStatusSpecified { get; set; }

        /// <summary>
        /// Gets or sets the vat entry status.
        /// </summary>
        [XmlElement(Order = 1)]
        public VatEntryStatus vatEntryStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether vat entry status specified.
        /// </summary>
        [XmlIgnore()]
        public bool vatEntryStatusSpecified { get; set; }

        /// <summary>
        /// Gets or sets the vat entry date.
        /// </summary>
        [XmlElement(DataType = "date", Order = 2)]
        public DateTime vatEntryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether vat entry date specified.
        /// </summary>
        [XmlIgnore()]
        public bool vatEntryDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets the vat liquidation date.
        /// </summary>
        [XmlElement(DataType = "date", Order = 3)]
        public DateTime vatLiquidationDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether vat liquidation date specified.
        /// </summary>
        [XmlIgnore()]
        public bool vatLiquidationDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets the uid vat.
        /// </summary>
        [XmlElement(Order = 4)]
        public UidStructure uidVat { get; set; }
    }
}