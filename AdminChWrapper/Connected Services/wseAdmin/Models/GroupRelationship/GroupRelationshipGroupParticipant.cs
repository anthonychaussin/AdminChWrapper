using System.Diagnostics;
using WseAdmin.Enums;
using WseAdmin.Models.UidEntity;

namespace WseAdmin.Models.GroupRelationship
{
    /// <summary>
    /// The group relationship type group participant.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class GroupRelationshipGroupParticipant
    {
        /// <summary>
        /// Gets or sets the participant.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public UidStructure participant { get; set; }

        /// <summary>
        /// Gets or sets the participant role.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public OrganisationMembershipRole participantRole { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether participant role specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool participantRoleSpecified { get; set; }
    }
}