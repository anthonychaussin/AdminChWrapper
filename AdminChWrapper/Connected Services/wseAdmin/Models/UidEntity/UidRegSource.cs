using System.Diagnostics;
using WseAdmin.Enums.UidReg;

namespace WseAdmin.Models.UidEntity
{
    /// <summary>
    /// The uid reg source type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0108/5")]
    public partial class UidRegSource
    {
        /// <summary>
        /// Gets or sets the uid.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public UidStructure uid { get; set; }

        /// <summary>
        /// Gets or sets the relation type.
        /// </summary>
        [XmlElementAttribute(Order = 1)]
        public UidRegSourceRelation relationType { get; set; }

        /// <summary>
        /// Gets or sets the registration date.
        /// </summary>
        [XmlElementAttribute(DataType = "date", Order = 2)]
        public DateTime registrationDate { get; set; }

        /// <summary>
        /// Gets or sets the registration status.
        /// </summary>
        [XmlElementAttribute(Order = 3)]
        public UidRegSourceRegistrationStatus registrationStatus { get; set; }
    }
}