using System.Diagnostics;

namespace WseAdmin.Models.UidEntity
{
    /// <summary>
    /// The uid entity search response.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class UidEntitySearchResponse
    {
        /// <summary>
        /// Gets or sets the uid entity search result item.
        /// </summary>
        [XmlElementAttribute("uidEntitySearchResultItem", Order = 0)]
        public UidEntitySearchResultItem[]? uidEntitySearchResultItem { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public object? extension { get; set; }
    }
}