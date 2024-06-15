using System.Diagnostics;

namespace WseAdmin.Models.Person
{
    /// <summary>
    /// The named person id type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0044/4")]
    public partial class NamedPersonId
    {
        /// <summary>
        /// Gets or sets the person id category.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 0)]
        public string personIdCategory { get; set; }

        /// <summary>
        /// Gets or sets the person id.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string personId { get; set; }
    }
}