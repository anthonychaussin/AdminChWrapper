using System.Diagnostics;

namespace WseAdmin.Models.UidEntity
{
    /// <summary>
    /// The uid entity search result item.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class UidEntitySearchResultItem
    {
        /// <summary>
        /// Gets or sets the organisation.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public required Organisation.Organisation organisation { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public int rating { get; set; } = 0;

        /// <summary>
        /// Gets or sets a value indicating whether history is match.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public bool isHistoryMatch { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        [XmlElementAttribute(Order = 3)]
        public object? extension { get; set; }
    }
}