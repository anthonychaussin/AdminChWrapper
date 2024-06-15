using System.Diagnostics;
using WseAdmin.Models.Organisation;

namespace WseAdmin.Models.UidEntity
{
    /// <summary>
    /// The uid entity public search request.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class UidEntityPublicSearchRequest
    {
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        [XmlElementAttribute("otherOrganisationId", typeof(NamedOrganisationId), Order = 0)]
        [XmlElementAttribute("uid", typeof(UidStructure), Order = 0)]
        [XmlElementAttribute("uidEntitySearchParameters", typeof(UidEntityPublicSearchParameters), Order = 0)]
        public object Item { get; set; }
    }
}