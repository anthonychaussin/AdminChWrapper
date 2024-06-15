global using System.CodeDom.Compiler;
global using System.Xml;
global using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

using WseAdmin.Models.UidEntity;

namespace WseAdmin.Models
{
    /// <summary>
    /// The public services client.
    /// </summary>
    [GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class PublicServicesClient : ClientBase<IPublicServices>, IPublicServices
    {
        /// <summary>
        /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
        /// </summary>
        /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
        /// <param name="clientCredentials">Informations d'identification du client</param>
        static partial void ConfigureEndpoint(ServiceEndpoint serviceEndpoint, ClientCredentials clientCredentials);

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicServicesClient"/> class.
        /// </summary>
        public PublicServicesClient() :
                base(PublicServicesClient.GetDefaultBinding(), PublicServicesClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPublicServices.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicServicesClient"/> class.
        /// </summary>
        /// <param name="endpointConfiguration">The endpoint configuration.</param>
        public PublicServicesClient(EndpointConfiguration endpointConfiguration) :
                base(PublicServicesClient.GetBindingForEndpoint(endpointConfiguration), PublicServicesClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicServicesClient"/> class.
        /// </summary>
        /// <param name="endpointConfiguration">The endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public PublicServicesClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(PublicServicesClient.GetBindingForEndpoint(endpointConfiguration), new EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicServicesClient"/> class.
        /// </summary>
        /// <param name="endpointConfiguration">The endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public PublicServicesClient(EndpointConfiguration endpointConfiguration, EndpointAddress remoteAddress) :
                base(PublicServicesClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicServicesClient"/> class.
        /// </summary>
        /// <param name="binding">The binding.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public PublicServicesClient(Binding binding, EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        /// <summary>
        /// Gets the organisation sample async.
        /// </summary>
        /// <returns>A System.Threading.Tasks.Task&lt;WseAdmin.Organisation&gt;.</returns>
        public Task<Organisation.Organisation> GetOrganisationSampleAsync()
        {
            return base.Channel.GetOrganisationSampleAsync();
        }

        /// <summary>
        /// Gets the by u i d async.
        /// </summary>
        /// <param name="uid">The uid.</param>
        /// <returns>A System.Threading.Tasks.Task&lt;WseAdmin.Organisation[]&gt;.</returns>
        public Task<Organisation.Organisation[]> GetByUIDAsync(UidStructure uid)
        {
            return base.Channel.GetByUIDAsync(uid);
        }

        /// <summary>
        /// Searches the async.
        /// </summary>
        /// <param name="searchParameters">The search parameters.</param>
        /// <param name="config">The config.</param>
        /// <returns>A System.Threading.Tasks.Task&lt;WseAdmin.UidEntitySearchResponse&gt;.</returns>
        public Task<UidEntitySearchResponse> SearchAsync(UidEntityPublicSearchRequest searchParameters, SearchConfiguration config)
        {
            return base.Channel.SearchAsync(searchParameters, config);
        }

        /// <summary>
        /// Validates the vat number async.
        /// </summary>
        /// <param name="vatNumber">The vat number.</param>
        /// <returns>A System.Threading.Tasks.Task&lt;bool&gt;.</returns>
        public Task<bool> ValidateVatNumberAsync(string vatNumber)
        {
            try
            {
                return base.Channel.ValidateVatNumberAsync(vatNumber);
            }
            catch (Exception)
            {
                return Task.FromResult(false);
            }
        }

        /// <summary>
        /// Validates the u i d async.
        /// </summary>
        /// <param name="uid">The uid.</param>
        /// <returns>A System.Threading.Tasks.Task&lt;bool&gt;.</returns>
        public Task<bool> ValidateUIDAsync(string uid)
        {
            return base.Channel.ValidateUIDAsync(uid);
        }

        /// <summary>
        /// Opens the async.
        /// </summary>
        /// <returns>A System.Threading.Tasks.Task.</returns>
        public virtual Task OpenAsync() => Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginOpen(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndOpen));

        /// <summary>
        /// Gets the binding for endpoint.
        /// </summary>
        /// <param name="endpointConfiguration">The endpoint configuration.</param>
        /// <returns>A System.ServiceModel.Channels.Binding.</returns>
        private static Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if (endpointConfiguration != EndpointConfiguration.BasicHttpBinding_IPublicServices)
            {
                throw new InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
            }

            return new BasicHttpBinding(securityMode: BasicHttpSecurityMode.Transport)
            {
                MaxBufferSize = int.MaxValue,
                ReaderQuotas = XmlDictionaryReaderQuotas.Max,
                MaxReceivedMessageSize = int.MaxValue,
                AllowCookies = true,
            };
        }

        /// <summary>
        /// Gets the endpoint address.
        /// </summary>
        /// <param name="endpointConfiguration">The endpoint configuration.</param>
        /// <returns>A System.ServiceModel.EndpointAddress.</returns>
        private static EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if (endpointConfiguration != EndpointConfiguration.BasicHttpBinding_IPublicServices)
            {
                throw new InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
            }

            return new EndpointAddress("https://www.uid-wse.admin.ch/V5.0/PublicServices.svc");
        }

        /// <summary>
        /// Gets the default binding.
        /// </summary>
        /// <returns>A System.ServiceModel.Channels.Binding.</returns>
        private static Binding GetDefaultBinding() => PublicServicesClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPublicServices);

        /// <summary>
        /// Gets the default endpoint address.
        /// </summary>
        /// <returns>A System.ServiceModel.EndpointAddress.</returns>
        private static EndpointAddress GetDefaultEndpointAddress() => PublicServicesClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPublicServices);

        /// <summary>
        /// The endpoint configuration.
        /// </summary>
        public enum EndpointConfiguration
        {
            BasicHttpBinding_IPublicServices,
        }
    }
}