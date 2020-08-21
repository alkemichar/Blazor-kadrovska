// Reference: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll, 2019-08-06T08:44:51.3843847+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll, 2019-12-04T00:18:52.0000000+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Configuration\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.dll, 2018-12-07T22:01:00.0000000+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll, 2019-07-24T05:27:10.0000000+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll, 2018-09-15T09:29:49.1539900+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.Composition\v4.0_4.0.0.0__b77a5c561934e089\System.ComponentModel.Composition.dll, 2018-09-15T09:29:50.3572090+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Autofac.Integration.Wcf.dll, 2018-05-24T21:27:04.0000000+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Activation\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Activation.dll, 2018-09-15T09:29:50.5603499+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel\v4.0_4.0.0.0__b77a5c561934e089\System.ServiceModel.dll, 2019-06-01T05:32:20.0000000+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Web\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Web.dll, 2018-09-15T09:29:49.0602321+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_64\System.Web\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.dll, 2019-11-23T07:10:04.6795651+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Interfaces.dll, 2019-11-22T09:51:52.4494419+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.Interfaces.dll, 2020-05-01T21:44:44.3542955+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Logging.Interfaces.dll, 2019-11-22T09:51:49.3737380+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Processing.Interfaces.dll, 2019-11-22T09:51:52.0244211+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Utilities.dll, 2019-11-22T09:51:49.5247721+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.XmlSerialization.dll, 2019-11-22T09:51:52.2235370+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Web.dll, 2019-11-22T09:51:55.2544520+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Plugins\Rhetos.RestGenerator.dll, 2020-05-01T21:44:45.9465025+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Generated\ServerDom.Model.dll, 2020-05-05T19:59:54.8186110+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Generated\ServerDom.Orm.dll, 2020-05-05T19:59:55.0175658+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Generated\ServerDom.Repositories.dll, 2020-05-05T19:59:55.5915712+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Autofac.dll, 2019-08-15T13:05:20.0000000+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Plugins\Rhetos.Processing.DefaultCommands.Interfaces.dll, 2020-05-01T21:44:44.3602940+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Newtonsoft.Json.dll, 2019-04-22T01:06:16.0000000+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.dll, 2020-05-01T21:44:44.3542955+02:00
// DomGeneratorOptions.Debug = "False"


using Autofac;
using Module = Autofac.Module;
using Rhetos.Dom.DefaultConcepts;
using Rhetos.RestGenerator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Web.Routing;

namespace Rhetos.Rest
{
    public class RestServiceHostFactory : Autofac.Integration.Wcf.AutofacServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            RestServiceHost host = new RestServiceHost(serviceType, baseAddresses);

            return host;
        }
    }

    public class RestServiceHost : ServiceHost
    {
        private Type _serviceType;

        public RestServiceHost(Type serviceType, Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
            _serviceType = serviceType;
        }

        protected override void OnOpening()
        {
            base.OnOpening();
            this.AddServiceEndpoint(_serviceType, new WebHttpBinding("rhetosWebHttpBinding"), string.Empty);
            this.AddServiceEndpoint(_serviceType, new BasicHttpBinding("rhetosBasicHttpBinding"), "SOAP");

            ((ServiceEndpoint)(Description.Endpoints.Where(e => e.Binding is WebHttpBinding).Single())).Behaviors.Add(new WebHttpBehavior()); 
            if (Description.Behaviors.Find<Rhetos.Web.JsonErrorServiceBehavior>() == null)
                Description.Behaviors.Add(new Rhetos.Web.JsonErrorServiceBehavior());
        }
    }

    [System.ComponentModel.Composition.Export(typeof(Module))]
    public class RestServiceModuleConfiguration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ServiceUtility>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceKadrovskaDjelatnik>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceKadrovskaOdjel>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceKadrovskaSektor>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonAutoCodeCache>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonFilterId>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonKeepSynchronizedMetadata>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonExclusiveLock>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonSetLock>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonReleaseLock>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonLogReader>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonLogRelatedItemReader>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonLog>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonAddToLog>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonLogRelatedItem>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonRelatedEventsSource>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonClaim>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonMyClaim>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonPrincipal>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonPrincipalHasRole>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonRole>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonRoleInheritsRole>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonPrincipalPermission>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceCommonRolePermission>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSCheckout>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSDocumentEvent>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSDocumentStatusBeforeEvent>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSComputeDocumentStatus>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSDocumentStatus>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSDocumentVersion>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSDocumentVersionExt>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSFileContent>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSDocumentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RestServiceLightDMSUndoCheckout>().InstancePerLifetimeScope();
            /*InitialCodeGenerator.ServiceRegistrationTag*/
            base.Load(builder);
        }
    }

    [System.ComponentModel.Composition.Export(typeof(Rhetos.IService))]
    public class RestServiceInitializer : Rhetos.IService
    {
        public void Initialize()
        {
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Kadrovska/Djelatnik", 
                new RestServiceHostFactory(), typeof(RestServiceKadrovskaDjelatnik)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Kadrovska/Odjel", 
                new RestServiceHostFactory(), typeof(RestServiceKadrovskaOdjel)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Kadrovska/Sektor", 
                new RestServiceHostFactory(), typeof(RestServiceKadrovskaSektor)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/AutoCodeCache", 
                new RestServiceHostFactory(), typeof(RestServiceCommonAutoCodeCache)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/FilterId", 
                new RestServiceHostFactory(), typeof(RestServiceCommonFilterId)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/KeepSynchronizedMetadata", 
                new RestServiceHostFactory(), typeof(RestServiceCommonKeepSynchronizedMetadata)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/ExclusiveLock", 
                new RestServiceHostFactory(), typeof(RestServiceCommonExclusiveLock)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/SetLock", 
                new RestServiceHostFactory(), typeof(RestServiceCommonSetLock)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/ReleaseLock", 
                new RestServiceHostFactory(), typeof(RestServiceCommonReleaseLock)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/LogReader", 
                new RestServiceHostFactory(), typeof(RestServiceCommonLogReader)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/LogRelatedItemReader", 
                new RestServiceHostFactory(), typeof(RestServiceCommonLogRelatedItemReader)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/Log", 
                new RestServiceHostFactory(), typeof(RestServiceCommonLog)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/AddToLog", 
                new RestServiceHostFactory(), typeof(RestServiceCommonAddToLog)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/LogRelatedItem", 
                new RestServiceHostFactory(), typeof(RestServiceCommonLogRelatedItem)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/RelatedEventsSource", 
                new RestServiceHostFactory(), typeof(RestServiceCommonRelatedEventsSource)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/Claim", 
                new RestServiceHostFactory(), typeof(RestServiceCommonClaim)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/MyClaim", 
                new RestServiceHostFactory(), typeof(RestServiceCommonMyClaim)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/Principal", 
                new RestServiceHostFactory(), typeof(RestServiceCommonPrincipal)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/PrincipalHasRole", 
                new RestServiceHostFactory(), typeof(RestServiceCommonPrincipalHasRole)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/Role", 
                new RestServiceHostFactory(), typeof(RestServiceCommonRole)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/RoleInheritsRole", 
                new RestServiceHostFactory(), typeof(RestServiceCommonRoleInheritsRole)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/PrincipalPermission", 
                new RestServiceHostFactory(), typeof(RestServiceCommonPrincipalPermission)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/Common/RolePermission", 
                new RestServiceHostFactory(), typeof(RestServiceCommonRolePermission)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/Checkout", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSCheckout)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/DocumentEvent", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSDocumentEvent)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/DocumentStatusBeforeEvent", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSDocumentStatusBeforeEvent)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/ComputeDocumentStatus", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSComputeDocumentStatus)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/DocumentStatus", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSDocumentStatus)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/DocumentVersion", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSDocumentVersion)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/DocumentVersionExt", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSDocumentVersionExt)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/FileContent", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSFileContent)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/DocumentRepository", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSDocumentRepository)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute("Rest/LightDMS/UndoCheckout", 
                new RestServiceHostFactory(), typeof(RestServiceLightDMSUndoCheckout)));
            /*InitialCodeGenerator.ServiceInitializationTag*/
        }

        public void InitializeApplicationInstance(System.Web.HttpApplication context)
        {
        }
    }


    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceKadrovskaDjelatnik
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Kadrovska.Djelatnik*/

        public RestServiceKadrovskaDjelatnik(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Kadrovska.Djelatnik*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Kadrovska.Djelatnik*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Kadrovska.Djelatnik*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Kadrovska.Djelatnik> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Kadrovska.Djelatnik>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Kadrovska.Djelatnik> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Kadrovska.Djelatnik>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Kadrovska.Djelatnik>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Kadrovska.Djelatnik> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Kadrovska.Djelatnik>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Kadrovska.Djelatnik GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Kadrovska.Djelatnik>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertKadrovskaDjelatnik(Kadrovska.Djelatnik entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateKadrovskaDjelatnik(string id, Kadrovska.Djelatnik entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteKadrovskaDjelatnik(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Kadrovska.Djelatnik { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Kadrovska.Djelatnik*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceKadrovskaOdjel
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Kadrovska.Odjel*/

        public RestServiceKadrovskaOdjel(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Kadrovska.Odjel*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Kadrovska.Odjel*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Kadrovska.Odjel*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Kadrovska.Odjel> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Kadrovska.Odjel>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Kadrovska.Odjel> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Kadrovska.Odjel>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Kadrovska.Odjel>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Kadrovska.Odjel> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Kadrovska.Odjel>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Kadrovska.Odjel GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Kadrovska.Odjel>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertKadrovskaOdjel(Kadrovska.Odjel entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateKadrovskaOdjel(string id, Kadrovska.Odjel entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteKadrovskaOdjel(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Kadrovska.Odjel { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Kadrovska.Odjel*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceKadrovskaSektor
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Kadrovska.Sektor*/

        public RestServiceKadrovskaSektor(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Kadrovska.Sektor*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Kadrovska.Sektor*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Kadrovska.Sektor*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Kadrovska.Sektor> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Kadrovska.Sektor>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Kadrovska.Sektor> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Kadrovska.Sektor>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Kadrovska.Sektor>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Kadrovska.Sektor> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Kadrovska.Sektor>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Kadrovska.Sektor GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Kadrovska.Sektor>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertKadrovskaSektor(Kadrovska.Sektor entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateKadrovskaSektor(string id, Kadrovska.Sektor entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteKadrovskaSektor(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Kadrovska.Sektor { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Kadrovska.Sektor*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonAutoCodeCache
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.AutoCodeCache*/

        public RestServiceCommonAutoCodeCache(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.AutoCodeCache*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.AutoCodeCache*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.AutoCodeCache*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.AutoCodeCache> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.AutoCodeCache>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.AutoCodeCache> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.AutoCodeCache>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.AutoCodeCache>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.AutoCodeCache> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.AutoCodeCache>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.AutoCodeCache GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.AutoCodeCache>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonAutoCodeCache(Common.AutoCodeCache entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonAutoCodeCache(string id, Common.AutoCodeCache entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonAutoCodeCache(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.AutoCodeCache { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.AutoCodeCache*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonFilterId
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.FilterId*/

        public RestServiceCommonFilterId(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.FilterId*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.FilterId*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.FilterId*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.FilterId> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.FilterId>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.FilterId> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.FilterId>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.FilterId>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.FilterId> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.FilterId>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.FilterId GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.FilterId>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonFilterId(Common.FilterId entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonFilterId(string id, Common.FilterId entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonFilterId(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.FilterId { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.FilterId*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonKeepSynchronizedMetadata
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.KeepSynchronizedMetadata*/

        public RestServiceCommonKeepSynchronizedMetadata(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.KeepSynchronizedMetadata*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.KeepSynchronizedMetadata*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.KeepSynchronizedMetadata*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.KeepSynchronizedMetadata> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.KeepSynchronizedMetadata>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.KeepSynchronizedMetadata> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.KeepSynchronizedMetadata>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.KeepSynchronizedMetadata>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.KeepSynchronizedMetadata> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.KeepSynchronizedMetadata>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.KeepSynchronizedMetadata GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.KeepSynchronizedMetadata>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonKeepSynchronizedMetadata(Common.KeepSynchronizedMetadata entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonKeepSynchronizedMetadata(string id, Common.KeepSynchronizedMetadata entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonKeepSynchronizedMetadata(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.KeepSynchronizedMetadata { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.KeepSynchronizedMetadata*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonExclusiveLock
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.ExclusiveLock*/

        public RestServiceCommonExclusiveLock(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.ExclusiveLock*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.ExclusiveLock*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.ExclusiveLock*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.ExclusiveLock> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.ExclusiveLock>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.ExclusiveLock> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.ExclusiveLock>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.ExclusiveLock>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.ExclusiveLock> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.ExclusiveLock>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.ExclusiveLock GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.ExclusiveLock>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonExclusiveLock(Common.ExclusiveLock entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonExclusiveLock(string id, Common.ExclusiveLock entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonExclusiveLock(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.ExclusiveLock { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.ExclusiveLock*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonSetLock
    {
        private ServiceUtility _serviceUtility;

        public RestServiceCommonSetLock(ServiceUtility serviceUtility) 
        {
            _serviceUtility = serviceUtility;
        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void ExecuteCommonSetLock(Common.SetLock action)
        {
            _serviceUtility.Execute<Common.SetLock>(action);
        }
    }


    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonReleaseLock
    {
        private ServiceUtility _serviceUtility;

        public RestServiceCommonReleaseLock(ServiceUtility serviceUtility) 
        {
            _serviceUtility = serviceUtility;
        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void ExecuteCommonReleaseLock(Common.ReleaseLock action)
        {
            _serviceUtility.Execute<Common.ReleaseLock>(action);
        }
    }


    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonLogReader
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.LogReader*/

        public RestServiceCommonLogReader(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.LogReader*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.LogReader*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.LogReader*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.LogReader> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.LogReader>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.LogReader> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.LogReader>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.LogReader>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.LogReader> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.LogReader>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.LogReader GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.LogReader>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        /*DataStructureInfo AdditionalOperations Common.LogReader*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonLogRelatedItemReader
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.LogRelatedItemReader*/

        public RestServiceCommonLogRelatedItemReader(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.LogRelatedItemReader*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.LogRelatedItemReader*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.LogRelatedItemReader*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.LogRelatedItemReader> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.LogRelatedItemReader>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.LogRelatedItemReader> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.LogRelatedItemReader>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.LogRelatedItemReader>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.LogRelatedItemReader> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.LogRelatedItemReader>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.LogRelatedItemReader GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.LogRelatedItemReader>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        /*DataStructureInfo AdditionalOperations Common.LogRelatedItemReader*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonLog
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.Log*/

        public RestServiceCommonLog(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.Log*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.Log*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.Log*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.Log> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.Log>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.Log> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.Log>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.Log>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.Log> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.Log>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.Log GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.Log>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonLog(Common.Log entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonLog(string id, Common.Log entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonLog(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.Log { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.Log*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonAddToLog
    {
        private ServiceUtility _serviceUtility;

        public RestServiceCommonAddToLog(ServiceUtility serviceUtility) 
        {
            _serviceUtility = serviceUtility;
        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void ExecuteCommonAddToLog(Common.AddToLog action)
        {
            _serviceUtility.Execute<Common.AddToLog>(action);
        }
    }


    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonLogRelatedItem
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.LogRelatedItem*/

        public RestServiceCommonLogRelatedItem(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.LogRelatedItem*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.LogRelatedItem*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("Common.SystemRequiredLog", typeof(Common.SystemRequiredLog)),
                Tuple.Create("SystemRequiredLog", typeof(Common.SystemRequiredLog)),
                /*DataStructureInfo FilterTypes Common.LogRelatedItem*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.LogRelatedItem> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.LogRelatedItem>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.LogRelatedItem> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.LogRelatedItem>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.LogRelatedItem>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.LogRelatedItem> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.LogRelatedItem>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.LogRelatedItem GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.LogRelatedItem>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonLogRelatedItem(Common.LogRelatedItem entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonLogRelatedItem(string id, Common.LogRelatedItem entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonLogRelatedItem(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.LogRelatedItem { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.LogRelatedItem*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonRelatedEventsSource
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.RelatedEventsSource*/

        public RestServiceCommonRelatedEventsSource(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.RelatedEventsSource*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.RelatedEventsSource*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.RelatedEventsSource*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.RelatedEventsSource> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.RelatedEventsSource>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.RelatedEventsSource> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.RelatedEventsSource>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.RelatedEventsSource>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.RelatedEventsSource> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.RelatedEventsSource>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.RelatedEventsSource GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.RelatedEventsSource>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        /*DataStructureInfo AdditionalOperations Common.RelatedEventsSource*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonClaim
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.Claim*/

        public RestServiceCommonClaim(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.Claim*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.Claim*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("Rhetos.Dom.DefaultConcepts.ActiveItems", typeof(Rhetos.Dom.DefaultConcepts.ActiveItems)),
                Tuple.Create("ActiveItems", typeof(Rhetos.Dom.DefaultConcepts.ActiveItems)),
                Tuple.Create("Common.SystemRequiredActive", typeof(Common.SystemRequiredActive)),
                Tuple.Create("SystemRequiredActive", typeof(Common.SystemRequiredActive)),
                /*DataStructureInfo FilterTypes Common.Claim*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.Claim> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.Claim>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.Claim> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.Claim>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.Claim>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.Claim> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.Claim>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.Claim GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.Claim>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonClaim(Common.Claim entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonClaim(string id, Common.Claim entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonClaim(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.Claim { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.Claim*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonMyClaim
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.MyClaim*/

        public RestServiceCommonMyClaim(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.MyClaim*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.MyClaim*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("Common.Claim", typeof(Common.Claim)),
                Tuple.Create("Claim", typeof(Common.Claim)),
                Tuple.Create("IEnumerable<Common.Claim>", typeof(IEnumerable<Common.Claim>)),
                /*DataStructureInfo FilterTypes Common.MyClaim*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.MyClaim> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.MyClaim>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.MyClaim> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.MyClaim>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.MyClaim>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.MyClaim> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.MyClaim>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.MyClaim GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.MyClaim>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        /*DataStructureInfo AdditionalOperations Common.MyClaim*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonPrincipal
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.Principal*/

        public RestServiceCommonPrincipal(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.Principal*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.Principal*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.Principal*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.Principal> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.Principal>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.Principal> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.Principal>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.Principal>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.Principal> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.Principal>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.Principal GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.Principal>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonPrincipal(Common.Principal entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonPrincipal(string id, Common.Principal entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonPrincipal(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.Principal { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.Principal*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonPrincipalHasRole
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.PrincipalHasRole*/

        public RestServiceCommonPrincipalHasRole(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.PrincipalHasRole*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.PrincipalHasRole*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("Common.SystemRequiredPrincipal", typeof(Common.SystemRequiredPrincipal)),
                Tuple.Create("SystemRequiredPrincipal", typeof(Common.SystemRequiredPrincipal)),
                /*DataStructureInfo FilterTypes Common.PrincipalHasRole*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.PrincipalHasRole> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.PrincipalHasRole>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.PrincipalHasRole> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.PrincipalHasRole>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.PrincipalHasRole>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.PrincipalHasRole> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.PrincipalHasRole>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.PrincipalHasRole GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.PrincipalHasRole>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonPrincipalHasRole(Common.PrincipalHasRole entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonPrincipalHasRole(string id, Common.PrincipalHasRole entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonPrincipalHasRole(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.PrincipalHasRole { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.PrincipalHasRole*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonRole
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.Role*/

        public RestServiceCommonRole(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.Role*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.Role*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes Common.Role*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.Role> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.Role>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.Role> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.Role>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.Role>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.Role> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.Role>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.Role GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.Role>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonRole(Common.Role entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonRole(string id, Common.Role entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonRole(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.Role { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.Role*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonRoleInheritsRole
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.RoleInheritsRole*/

        public RestServiceCommonRoleInheritsRole(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.RoleInheritsRole*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.RoleInheritsRole*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("Common.SystemRequiredUsersFrom", typeof(Common.SystemRequiredUsersFrom)),
                Tuple.Create("SystemRequiredUsersFrom", typeof(Common.SystemRequiredUsersFrom)),
                /*DataStructureInfo FilterTypes Common.RoleInheritsRole*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.RoleInheritsRole> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.RoleInheritsRole>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.RoleInheritsRole> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.RoleInheritsRole>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.RoleInheritsRole>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.RoleInheritsRole> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.RoleInheritsRole>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.RoleInheritsRole GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.RoleInheritsRole>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonRoleInheritsRole(Common.RoleInheritsRole entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonRoleInheritsRole(string id, Common.RoleInheritsRole entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonRoleInheritsRole(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.RoleInheritsRole { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.RoleInheritsRole*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonPrincipalPermission
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.PrincipalPermission*/

        public RestServiceCommonPrincipalPermission(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.PrincipalPermission*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.PrincipalPermission*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("Common.SystemRequiredPrincipal", typeof(Common.SystemRequiredPrincipal)),
                Tuple.Create("SystemRequiredPrincipal", typeof(Common.SystemRequiredPrincipal)),
                Tuple.Create("Common.SystemRequiredClaim", typeof(Common.SystemRequiredClaim)),
                Tuple.Create("SystemRequiredClaim", typeof(Common.SystemRequiredClaim)),
                /*DataStructureInfo FilterTypes Common.PrincipalPermission*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.PrincipalPermission> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.PrincipalPermission>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.PrincipalPermission> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.PrincipalPermission>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.PrincipalPermission>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.PrincipalPermission> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.PrincipalPermission>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.PrincipalPermission GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.PrincipalPermission>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonPrincipalPermission(Common.PrincipalPermission entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonPrincipalPermission(string id, Common.PrincipalPermission entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonPrincipalPermission(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.PrincipalPermission { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.PrincipalPermission*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceCommonRolePermission
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization Common.RolePermission*/

        public RestServiceCommonRolePermission(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter Common.RolePermission*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties Common.RolePermission*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("Common.SystemRequiredRole", typeof(Common.SystemRequiredRole)),
                Tuple.Create("SystemRequiredRole", typeof(Common.SystemRequiredRole)),
                Tuple.Create("Common.SystemRequiredClaim", typeof(Common.SystemRequiredClaim)),
                Tuple.Create("SystemRequiredClaim", typeof(Common.SystemRequiredClaim)),
                /*DataStructureInfo FilterTypes Common.RolePermission*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<Common.RolePermission> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<Common.RolePermission>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<Common.RolePermission> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.RolePermission>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<Common.RolePermission>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<Common.RolePermission> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<Common.RolePermission>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Common.RolePermission GetById(string id)
        {
            var result = _serviceUtility.GetDataById<Common.RolePermission>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertCommonRolePermission(Common.RolePermission entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateCommonRolePermission(string id, Common.RolePermission entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteCommonRolePermission(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new Common.RolePermission { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations Common.RolePermission*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSCheckout
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.Checkout*/

        public RestServiceLightDMSCheckout(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.Checkout*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.Checkout*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("LightDMS.MultipleDocumentCheckout", typeof(LightDMS.MultipleDocumentCheckout)),
                Tuple.Create("MultipleDocumentCheckout", typeof(LightDMS.MultipleDocumentCheckout)),
                Tuple.Create("LightDMS.NullDocumentCheckout", typeof(LightDMS.NullDocumentCheckout)),
                Tuple.Create("NullDocumentCheckout", typeof(LightDMS.NullDocumentCheckout)),
                Tuple.Create("LightDMS.SystemRequiredCreatedBy", typeof(LightDMS.SystemRequiredCreatedBy)),
                Tuple.Create("SystemRequiredCreatedBy", typeof(LightDMS.SystemRequiredCreatedBy)),
                Tuple.Create("LightDMS.SystemRequiredCreatedDate", typeof(LightDMS.SystemRequiredCreatedDate)),
                Tuple.Create("SystemRequiredCreatedDate", typeof(LightDMS.SystemRequiredCreatedDate)),
                /*DataStructureInfo FilterTypes LightDMS.Checkout*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.Checkout> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.Checkout>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.Checkout> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.Checkout>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.Checkout>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.Checkout> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.Checkout>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.Checkout GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.Checkout>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertLightDMSCheckout(LightDMS.Checkout entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateLightDMSCheckout(string id, LightDMS.Checkout entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteLightDMSCheckout(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new LightDMS.Checkout { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations LightDMS.Checkout*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSDocumentEvent
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.DocumentEvent*/

        public RestServiceLightDMSDocumentEvent(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.DocumentEvent*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.DocumentEvent*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("Rhetos.Dom.DefaultConcepts.FilterSubtype", typeof(Rhetos.Dom.DefaultConcepts.FilterSubtype)),
                Tuple.Create("FilterSubtype", typeof(Rhetos.Dom.DefaultConcepts.FilterSubtype)),
                /*DataStructureInfo FilterTypes LightDMS.DocumentEvent*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.DocumentEvent> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentEvent>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.DocumentEvent> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentEvent>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentEvent>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.DocumentEvent> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.DocumentEvent>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.DocumentEvent GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.DocumentEvent>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        /*DataStructureInfo AdditionalOperations LightDMS.DocumentEvent*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSDocumentStatusBeforeEvent
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.DocumentStatusBeforeEvent*/

        public RestServiceLightDMSDocumentStatusBeforeEvent(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.DocumentStatusBeforeEvent*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.DocumentStatusBeforeEvent*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes LightDMS.DocumentStatusBeforeEvent*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.DocumentStatusBeforeEvent> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentStatusBeforeEvent>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.DocumentStatusBeforeEvent> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentStatusBeforeEvent>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentStatusBeforeEvent>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.DocumentStatusBeforeEvent> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.DocumentStatusBeforeEvent>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.DocumentStatusBeforeEvent GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.DocumentStatusBeforeEvent>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        /*DataStructureInfo AdditionalOperations LightDMS.DocumentStatusBeforeEvent*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSComputeDocumentStatus
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.ComputeDocumentStatus*/

        public RestServiceLightDMSComputeDocumentStatus(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.ComputeDocumentStatus*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.ComputeDocumentStatus*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes LightDMS.ComputeDocumentStatus*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.ComputeDocumentStatus> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.ComputeDocumentStatus>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.ComputeDocumentStatus> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.ComputeDocumentStatus>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.ComputeDocumentStatus>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.ComputeDocumentStatus> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.ComputeDocumentStatus>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.ComputeDocumentStatus GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.ComputeDocumentStatus>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        /*DataStructureInfo AdditionalOperations LightDMS.ComputeDocumentStatus*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSDocumentStatus
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.DocumentStatus*/

        public RestServiceLightDMSDocumentStatus(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.DocumentStatus*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.DocumentStatus*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes LightDMS.DocumentStatus*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.DocumentStatus> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentStatus>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.DocumentStatus> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentStatus>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentStatus>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.DocumentStatus> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.DocumentStatus>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.DocumentStatus GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.DocumentStatus>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertLightDMSDocumentStatus(LightDMS.DocumentStatus entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateLightDMSDocumentStatus(string id, LightDMS.DocumentStatus entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteLightDMSDocumentStatus(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new LightDMS.DocumentStatus { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations LightDMS.DocumentStatus*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSDocumentVersion
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.DocumentVersion*/

        public RestServiceLightDMSDocumentVersion(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.DocumentVersion*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.DocumentVersion*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("LightDMS.OtherUserDocumentCheckIn", typeof(LightDMS.OtherUserDocumentCheckIn)),
                Tuple.Create("OtherUserDocumentCheckIn", typeof(LightDMS.OtherUserDocumentCheckIn)),
                Tuple.Create("LightDMS.SystemRequiredCreatedBy", typeof(LightDMS.SystemRequiredCreatedBy)),
                Tuple.Create("SystemRequiredCreatedBy", typeof(LightDMS.SystemRequiredCreatedBy)),
                Tuple.Create("LightDMS.SystemRequiredCreatedDate", typeof(LightDMS.SystemRequiredCreatedDate)),
                Tuple.Create("SystemRequiredCreatedDate", typeof(LightDMS.SystemRequiredCreatedDate)),
                Tuple.Create("LightDMS.SystemRequiredVersionNumber", typeof(LightDMS.SystemRequiredVersionNumber)),
                Tuple.Create("SystemRequiredVersionNumber", typeof(LightDMS.SystemRequiredVersionNumber)),
                /*DataStructureInfo FilterTypes LightDMS.DocumentVersion*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.DocumentVersion> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentVersion>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.DocumentVersion> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentVersion>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentVersion>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.DocumentVersion> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.DocumentVersion>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.DocumentVersion GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.DocumentVersion>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertLightDMSDocumentVersion(LightDMS.DocumentVersion entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateLightDMSDocumentVersion(string id, LightDMS.DocumentVersion entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteLightDMSDocumentVersion(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new LightDMS.DocumentVersion { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations LightDMS.DocumentVersion*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSDocumentVersionExt
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.DocumentVersionExt*/

        public RestServiceLightDMSDocumentVersionExt(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.DocumentVersionExt*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.DocumentVersionExt*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes LightDMS.DocumentVersionExt*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.DocumentVersionExt> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentVersionExt>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.DocumentVersionExt> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentVersionExt>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentVersionExt>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.DocumentVersionExt> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.DocumentVersionExt>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.DocumentVersionExt GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.DocumentVersionExt>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        /*DataStructureInfo AdditionalOperations LightDMS.DocumentVersionExt*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSFileContent
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.FileContent*/

        public RestServiceLightDMSFileContent(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.FileContent*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.FileContent*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("LightDMS.ContentIliAzureStorage", typeof(LightDMS.ContentIliAzureStorage)),
                Tuple.Create("ContentIliAzureStorage", typeof(LightDMS.ContentIliAzureStorage)),
                Tuple.Create("LightDMS.SystemRequiredCreatedDate", typeof(LightDMS.SystemRequiredCreatedDate)),
                Tuple.Create("SystemRequiredCreatedDate", typeof(LightDMS.SystemRequiredCreatedDate)),
                /*DataStructureInfo FilterTypes LightDMS.FileContent*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.FileContent> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.FileContent>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.FileContent> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.FileContent>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.FileContent>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.FileContent> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.FileContent>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.FileContent GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.FileContent>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertLightDMSFileContent(LightDMS.FileContent entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateLightDMSFileContent(string id, LightDMS.FileContent entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteLightDMSFileContent(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new LightDMS.FileContent { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations LightDMS.FileContent*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSDocumentRepository
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.DocumentRepository*/

        public RestServiceLightDMSDocumentRepository(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.DocumentRepository*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.DocumentRepository*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                /*DataStructureInfo FilterTypes LightDMS.DocumentRepository*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.DocumentRepository> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentRepository>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.DocumentRepository> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentRepository>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.DocumentRepository>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.DocumentRepository> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.DocumentRepository>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.DocumentRepository GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.DocumentRepository>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertLightDMSDocumentRepository(LightDMS.DocumentRepository entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateLightDMSDocumentRepository(string id, LightDMS.DocumentRepository entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteLightDMSDocumentRepository(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new LightDMS.DocumentRepository { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations LightDMS.DocumentRepository*/
    }
    
    [System.ServiceModel.ServiceContract]
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestServiceLightDMSUndoCheckout
    {
        private ServiceUtility _serviceUtility;
        /*DataStructureInfo AdditionalPropertyInitialization LightDMS.UndoCheckout*/

        public RestServiceLightDMSUndoCheckout(ServiceUtility serviceUtility/*DataStructureInfo AdditionalPropertyConstructorParameter LightDMS.UndoCheckout*/)
        {
            _serviceUtility = serviceUtility;
            /*DataStructureInfo AdditionalPropertyConstructorSetProperties LightDMS.UndoCheckout*/
        }
    
        public static readonly IDictionary<string, Type[]> FilterTypes = new List<Tuple<string, Type>>
            {
                Tuple.Create("LightDMS.DocumentNotCheckouted", typeof(LightDMS.DocumentNotCheckouted)),
                Tuple.Create("DocumentNotCheckouted", typeof(LightDMS.DocumentNotCheckouted)),
                Tuple.Create("LightDMS.OtherUserDocumentUndoCheckout", typeof(LightDMS.OtherUserDocumentUndoCheckout)),
                Tuple.Create("OtherUserDocumentUndoCheckout", typeof(LightDMS.OtherUserDocumentUndoCheckout)),
                Tuple.Create("LightDMS.SystemRequiredCreatedBy", typeof(LightDMS.SystemRequiredCreatedBy)),
                Tuple.Create("SystemRequiredCreatedBy", typeof(LightDMS.SystemRequiredCreatedBy)),
                Tuple.Create("LightDMS.SystemRequiredCreatedDate", typeof(LightDMS.SystemRequiredCreatedDate)),
                Tuple.Create("SystemRequiredCreatedDate", typeof(LightDMS.SystemRequiredCreatedDate)),
                /*DataStructureInfo FilterTypes LightDMS.UndoCheckout*/
            }
            .GroupBy(typeName => typeName.Item1)
            .ToDictionary(g => g.Key, g => g.Select(typeName => typeName.Item2).Distinct().ToArray());

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<LightDMS.UndoCheckout> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.UndoCheckout>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<LightDMS.UndoCheckout> { Records = data.Records };
        }

        [Obsolete]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.UndoCheckout>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<LightDMS.UndoCheckout>(filter, fparam, genericfilter, filters, FilterTypes, 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // [Obsolete] parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<LightDMS.UndoCheckout> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<LightDMS.UndoCheckout>(filter, fparam, genericfilter, filters, FilterTypes, top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public LightDMS.UndoCheckout GetById(string id)
        {
            var result = _serviceUtility.GetDataById<LightDMS.UndoCheckout>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult InsertLightDMSUndoCheckout(LightDMS.UndoCheckout entity)
        {
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            var result = _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void UpdateLightDMSUndoCheckout(string id, LightDMS.UndoCheckout entity)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void DeleteLightDMSUndoCheckout(string id)
        {
            Guid guid;
            if (!Guid.TryParse(id, out guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parametar 'ID'.");
            var entity = new LightDMS.UndoCheckout { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

/*DataStructureInfo AdditionalOperations LightDMS.UndoCheckout*/
    }
    /*InitialCodeGenerator.RhetosRestClassesTag*/

}
