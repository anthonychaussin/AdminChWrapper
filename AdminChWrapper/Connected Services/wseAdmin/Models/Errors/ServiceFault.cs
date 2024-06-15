using System.Diagnostics;

namespace WseAdmin.Models.Errors
{
    /// <summary>
    /// The service fault.
    /// </summary>
    [XmlIncludeAttribute(typeof(InfrastructureFault))]
    [XmlIncludeAttribute(typeof(BusinessFault))]
    [XmlIncludeAttribute(typeof(SecurityFault))]
    [XmlIncludeAttribute(typeof(DuplicateFault))]
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]

    [XmlTypeAttribute(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse-shared/2")]
    public partial class ServiceFault
    {
        /// <summary>
        /// Gets or sets the operation.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 0)]
        public string operation { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 1)]
        public string error { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the error detail.
        /// </summary>
        [XmlElementAttribute(DataType = "token", Order = 2)]
        public string errorDetail { get; set; } = string.Empty;
    }
}