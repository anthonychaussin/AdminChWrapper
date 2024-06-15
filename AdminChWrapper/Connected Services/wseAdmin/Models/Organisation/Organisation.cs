using AdminChWrapper.Models;
using System.Diagnostics;
using WseAdmin.Models.Person;
using WseAdmin.Models.UidEntity;

namespace WseAdmin.Models.Organisation
{
    /// <summary>
    /// The organisation type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class Organisation : IOrganisation
    {
        /// <summary>
        /// Gets or sets the organisation.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public required Organisation1 organisation { get; set; }

        /// <summary>
        /// Gets or sets the uidreg information.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public UidRegInformation? uidregInformation { get; set; }

        /// <summary>
        /// Gets or sets the commercial register information.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public CommercialRegisterInformation.CommercialRegisterInformation? commercialRegisterInformation { get; set; }

        /// <summary>
        /// Gets or sets the vat register information.
        /// </summary>
        [XmlElementAttribute(Order = 3)]
        public VatRegisterInformation.VatRegisterInformation? vatRegisterInformation { get; set; }

        /// <summary>
        /// Gets or sets the lei register information.
        /// </summary>
        [XmlElementAttribute(Order = 4)]
        public LeiRegisterInformation? leiRegisterInformation { get; set; }

        /// <summary>
        /// Gets or sets the group relationship.
        /// </summary>
        [XmlElementAttribute("groupRelationship", Order = 5)]
        public GroupRelationship.GroupRelationship[]? groupRelationship { get; set; }

        /// <summary>
        /// Gets or sets the involved person.
        /// </summary>
        [XmlElementAttribute("involvedPerson", Order = 6)]
        public InvolvedPerson[]? involvedPerson { get; set; }
    }
}