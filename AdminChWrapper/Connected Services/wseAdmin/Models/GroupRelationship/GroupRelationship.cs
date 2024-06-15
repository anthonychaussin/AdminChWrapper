using System.Diagnostics;

using WseAdmin.Enums;

namespace WseAdmin.Models.GroupRelationship
{
    /// <summary>
    /// The group relationship type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class GroupRelationship
    {
        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 0)]
        public string groupName { get; set; }

        /// <summary>
        /// Gets or sets the organisation membership role.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public OrganisationMembershipRole organisationMembershipRole { get; set; }

        /// <summary>
        /// Gets or sets the group participant.
        /// </summary>
        [XmlElementAttribute("groupParticipant", Order = 2)]
        public GroupRelationshipGroupParticipant[] groupParticipant { get; set; }
    }
}