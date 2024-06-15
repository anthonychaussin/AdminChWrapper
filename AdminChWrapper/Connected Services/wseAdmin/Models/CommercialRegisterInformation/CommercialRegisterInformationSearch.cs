using System.Diagnostics;
using WseAdmin.Enums.CommercialRegister;

namespace WseAdmin.Models.CommercialRegisterInformation
{
    /// <summary>
    /// The commercial register information search type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class CommercialRegisterInformationSearch
    {
        /// <summary>
        /// Gets or sets the commercial register status.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public CommercialRegisterStatus commercialRegisterStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether commercial register status specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool commercialRegisterStatusSpecified { get; set; }

        /// <summary>
        /// Gets or sets the commercial register entry status.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public CommercialRegisterEntryStatus commercialRegisterEntryStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether commercial register entry status specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool commercialRegisterEntryStatusSpecified { get; set; }

        /// <summary>
        /// Gets or sets the commercial register entry date.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 2)]
        public DateTime commercialRegisterEntryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether commercial register entry date specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool commercialRegisterEntryDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets the commercial register liquidation date.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 3)]
        public DateTime? commercialRegisterLiquidationDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether commercial register liquidation date specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool commercialRegisterLiquidationDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets the commercial register enterprise type.
        /// </summary>
        [XmlElementAttribute(Order = 4)]
        public CommercialRegisterEnterprise commercialRegisterEnterpriseType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether commercial register enterprise type specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool commercialRegisterEnterpriseTypeSpecified { get; set; }
    }
}