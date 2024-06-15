using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models.Person
{
    /// <summary>
    /// The person mail address info type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0010/7")]
    public partial class PersonMailAddressInfo
    {
        /// <summary>
        /// Gets or sets the mr mrs.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public CivilStatusTitles mrMrs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether mr mrs specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool mrMrsSpecified { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 2)]
        public string firstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 3)]
        public string lastName { get; set; }
    }
}