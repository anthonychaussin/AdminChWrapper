using System.Diagnostics;
using WseAdmin.Enums.CommercialRegister;

namespace WseAdmin.Models.CommercialRegisterInformation
{
    /// <summary>
    /// The commercial register information type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class CommercialRegisterInformation
    {
        /// <summary>
        /// Gets or sets the commercial register status.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public CommercialRegisterStatus commercialRegisterStatus { get; set; }

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
        /// Gets or sets the commercial register name translation.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 2)]
        public string commercialRegisterNameTranslation { get; set; }

        /// <summary>
        /// Gets or sets the commercial register entry date.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 3)]
        public DateTime commercialRegisterEntryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether commercial register entry date specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool commercialRegisterEntryDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets the commercial register liquidation date.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 4)]
        public DateTime commercialRegisterLiquidationDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether commercial register liquidation date specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool commercialRegisterLiquidationDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets the commercial register enterprise type.
        /// </summary>
        [XmlElementAttribute(Order = 5)]
        public CommercialRegisterEnterprise commercialRegisterEnterpriseType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether commercial register enterprise type specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool commercialRegisterEnterpriseTypeSpecified { get; set; }
    }
}