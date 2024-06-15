using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models
{
    /// <summary>
    /// The search configuration.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse-shared/2")]
    public partial class SearchConfiguration
    {
        /// <summary>
        /// Gets or sets the search mode.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public SearchMode searchMode { get; set; } = SearchMode.Auto;

        /// <summary>
        /// Gets or sets the max number of records.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public int maxNumberOfRecords { get; set; } = 10;

        /// <summary>
        /// Gets or sets a value indicating whether search name and address history.
        /// </summary>
        [XmlElementAttribute(Order = 2)]
        public bool searchNameAndAddressHistory { get; set; }
    }
}