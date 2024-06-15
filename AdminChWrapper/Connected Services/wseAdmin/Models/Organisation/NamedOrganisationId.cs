using System.Diagnostics;

namespace WseAdmin.Models.Organisation
{
    /// <summary>
    /// The named organisation id type.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.ech.ch/xmlns/eCH-0097/5")]
    public partial class NamedOrganisationId
    {
        /// <summary>
        /// Gets or sets the organisation id category.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 0)]
        public string organisationIdCategory { get; set; }

        /// <summary>
        /// Gets or sets the organisation id.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string organisationId { get; set; }
    }
}