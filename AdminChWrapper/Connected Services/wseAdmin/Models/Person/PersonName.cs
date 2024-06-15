using System.Diagnostics;

namespace WseAdmin.Models.Person
{
    /// <summary>
    /// The person name type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse/5")]
    public partial class PersonName
    {
        /// <summary>
        /// Gets or sets the official name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 0)]
        public string officialName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string firstName { get; set; }
    }
}