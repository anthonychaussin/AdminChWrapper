using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models.Person
{
    /// <summary>
    /// The involved person type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class InvolvedPerson
    {
        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 0)]
        public string role { get; set; }

        /// <summary>
        /// Gets or sets the vn.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public ulong vn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether vn specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool vnSpecified { get; set; }

        /// <summary>
        /// Gets or sets the official name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 2)]
        public string officialName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 3)]
        public string firstName { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        [XmlElementAttribute(Order = 4)]
        public DatePartiallyKnown dateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the sex.
        /// </summary>
        [XmlElementAttribute(Order = 5)]
        public Sex sex { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sex specified.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool sexSpecified { get; set; }
    }
}