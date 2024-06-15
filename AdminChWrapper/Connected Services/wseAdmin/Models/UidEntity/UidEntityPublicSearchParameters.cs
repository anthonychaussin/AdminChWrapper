using System.Diagnostics;
using WseAdmin.Models.Address;
using WseAdmin.Models.CommercialRegisterInformation;
using WseAdmin.Models.Person;
using WseAdmin.Models.VatRegisterInformation;

namespace WseAdmin.Models.UidEntity
{
    /// <summary>
    /// The uid entity public search parameters.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class UidEntityPublicSearchParameters
    {
        /// <summary>
        /// Gets or sets the organisation name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 0)]
        public string? organisationName { get; set; }

        /// <summary>
        /// Gets or sets the person name.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public PersonName? personName { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public AddressSearch? address { get; set; }

        /// <summary>
        /// Gets or sets the legal form.
        /// </summary>
        [XmlElementAttribute("legalForm", Order = 3)]
        public string[]? legalForm { get; set; }

        /// <summary>
        /// Gets or sets the uidreg information.
        /// </summary>
        [XmlElementAttribute(Order = 4)]
        public UidregInformationPublicSearch? uidregInformation { get; set; }

        /// <summary>
        /// Gets or sets the commercial register information.
        /// </summary>
        [XmlElementAttribute(Order = 5)]
        public CommercialRegisterInformationSearch? commercialRegisterInformation { get; set; }

        /// <summary>
        /// Gets or sets the vat register information.
        /// </summary>
        [XmlElementAttribute(Order = 6)]
        public VatRegisterInformationSearch? vatRegisterInformation { get; set; }
    }
}