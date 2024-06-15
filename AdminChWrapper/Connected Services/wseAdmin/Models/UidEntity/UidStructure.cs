using System.Diagnostics;
using WseAdmin.Enums;

namespace WseAdmin.Models.UidEntity
{
    /// <summary>
    /// The uid structure type.
    /// </summary>
    [XmlIncludeAttribute(typeof(ReportingRegister))]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0097/5")]
    public partial class UidStructure
    {
        /// <summary>
        /// Gets or sets the uid organisation id categorie.
        /// </summary>
        [XmlElementAttribute(Order = 0)]
        public UidOrganisationIdCategorie uidOrganisationIdCategorie { get; set; }

        /// <summary>
        /// Gets or sets the uid organisation id.
        /// </summary>
        [XmlElementAttribute(DataType = "nonNegativeInteger", Order = 1)]
        public string uidOrganisationId { get; set; }
    }
}