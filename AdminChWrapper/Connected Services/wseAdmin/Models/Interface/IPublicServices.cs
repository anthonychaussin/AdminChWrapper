using System.ServiceModel;
using WseAdmin.Models;
using WseAdmin.Models.Errors;
using WseAdmin.Models.Organisation;
using WseAdmin.Models.UidEntity;

namespace WseAdmin
{
    /// <summary>
    /// The public services.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [ServiceContract(Namespace = "http://www.uid.admin.ch/xmlns/uid-wse", ConfigurationName = "WseAdmin.Interface.IPublicServices")]
    public interface IPublicServices
    {
        /// <summary>
        /// Gets the organisation sample async.
        /// </summary>
        /// <returns>A Task&lt;WseAdmin.Organisation&gt;.</returns>
        [OperationContract(Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSample", ReplyAction = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSampleResponse")]
        [FaultContract(typeof(SecurityFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSamplesecurityFaultFault", Name = "securityFault")]
        [FaultContract(typeof(BusinessFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSamplebusinessFaultFault", Name = "businessFault")]
        [FaultContract(typeof(InfrastructureFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetOrganisationSampleinfrastructureFaultFault", Name = "infrastructureFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(ServiceFault))]
        Task<Organisation> GetOrganisationSampleAsync();

        /// <summary>
        /// Gets the Organisations by uid async.
        /// </summary>
        /// <param name="uid">The uid.</param>
        /// <returns>A Task&lt;WseAdmin.Organisation[]&gt;.</returns>
        [OperationContract(Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUID", ReplyAction = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUIDResponse")]
        [FaultContract(typeof(SecurityFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUIDsecurityFaultFault", Name = "securityFault")]
        [FaultContract(typeof(BusinessFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUIDbusinessFaultFault", Name = "businessFault")]
        [FaultContract(typeof(InfrastructureFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/GetByUIDinfrastructureFaultFault", Name = "infrastructureFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(ServiceFault))]
        Task<Organisation[]> GetByUIDAsync(UidStructure uid);

        /// <summary>
        /// Search async.
        /// </summary>
        /// <param name="searchParameters">The search parameters.</param>
        /// <param name="config">The config.</param>
        /// <returns>A Task&lt;WseAdmin.UidEntitySearchResponse&gt;.</returns>
        [OperationContract(Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/Search", ReplyAction = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/SearchResponse")]
        [FaultContract(typeof(SecurityFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/SearchsecurityFaultFault", Name = "securityFault")]
        [FaultContract(typeof(BusinessFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/SearchbusinessFaultFault", Name = "businessFault")]
        [FaultContract(typeof(InfrastructureFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/SearchinfrastructureFaultFault", Name = "infrastructureFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(ServiceFault))]
        Task<UidEntitySearchResponse> SearchAsync(UidEntityPublicSearchRequest searchParameters, SearchConfiguration config);

        /// <summary>
        /// Validates the organisation vat number async.
        /// </summary>
        /// <param name="vatNumber">The vat number.</param>
        /// <returns>A Task&lt;bool&gt;.</returns>
        [OperationContract(Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumber", ReplyAction = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumberResponse")]
        [FaultContract(typeof(SecurityFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumbersecurityFaultFault", Name = "securityFault")]
        [FaultContract(typeof(BusinessFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumberbusinessFaultFault", Name = "businessFault")]
        [FaultContract(typeof(InfrastructureFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateVatNumberinfrastructureFaultFault", Name = "infrastructureFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(ServiceFault))]
        Task<bool> ValidateVatNumberAsync(string vatNumber);

        /// <summary>
        /// Validates the organisation uid async.
        /// </summary>
        /// <param name="uid">The uid.</param>
        /// <returns>A Task&lt;bool&gt;.</returns>
        [OperationContract(Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUID", ReplyAction = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUIDResponse")]
        [FaultContract(typeof(SecurityFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUIDsecurityFaultFault", Name = "securityFault")]
        [FaultContract(typeof(BusinessFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUIDbusinessFaultFault", Name = "businessFault")]
        [FaultContract(typeof(InfrastructureFault), Action = "http://www.uid.admin.ch/xmlns/uid-wse/IPublicServices/ValidateUIDinfrastructureFaultFault", Name = "infrastructureFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(ServiceFault))]
        Task<bool> ValidateUIDAsync(string uid);
    }
}