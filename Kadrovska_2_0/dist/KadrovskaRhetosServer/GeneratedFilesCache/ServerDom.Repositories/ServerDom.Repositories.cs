// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Autofac.dll, 2019-08-15T13:05:20.0000000+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Extensibility.Interfaces.dll, 2019-11-22T09:51:49.6569621+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Utilities.dll, 2019-11-22T09:51:49.5247721+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Security.Interfaces.dll, 2019-11-22T09:51:52.0805053+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.Composition\v4.0_4.0.0.0__b77a5c561934e089\System.ComponentModel.Composition.dll, 2018-09-15T09:29:50.3572090+02:00
// Reference: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll, 2019-08-06T08:44:51.3843847+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.dll, 2020-05-01T21:44:44.3542955+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Logging.Interfaces.dll, 2019-11-22T09:51:49.3737380+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\EntityFramework.dll, 2015-03-02T09:32:26.0000000+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\EntityFramework.SqlServer.dll, 2015-03-02T09:32:26.0000000+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_64\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll, 2018-10-05T23:08:03.2817044+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll, 2019-07-24T05:27:10.0000000+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Persistence.Interfaces.dll, 2019-11-22T09:51:50.9988900+01:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Plugins\Rhetos.Processing.DefaultCommands.Interfaces.dll, 2020-05-01T21:44:44.3602940+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Rhetos.Processing.Interfaces.dll, 2019-11-22T09:51:52.0244211+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll, 2019-12-04T00:18:52.0000000+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\Microsoft.CSharp\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.CSharp.dll, 2018-09-15T09:29:51.8260748+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Data.DataSetExtensions\v4.0_4.0.0.0__b77a5c561934e089\System.Data.DataSetExtensions.dll, 2018-09-15T09:29:49.0289798+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll, 2018-09-15T09:29:49.1539900+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.Linq.dll, 2018-09-15T09:29:50.5759761+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.Interfaces.dll, 2020-05-01T21:44:44.3542955+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll, 2019-06-01T05:32:20.0000000+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Generated\ServerDom.Model.dll, 2020-05-05T19:59:54.8186110+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Generated\ServerDom.Orm.dll, 2020-05-05T19:59:55.0175658+02:00
// DomGeneratorOptions.Debug = "False"

namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;
    using Autofac;
    /*CommonUsing*/

    public class DomRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public DomRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Kadrovska._Helper._ModuleRepository _Kadrovska;
        public Kadrovska._Helper._ModuleRepository Kadrovska { get { return _Kadrovska ?? (_Kadrovska = new Kadrovska._Helper._ModuleRepository(_repositories)); } }

        private Common._Helper._ModuleRepository _Common;
        public Common._Helper._ModuleRepository Common { get { return _Common ?? (_Common = new Common._Helper._ModuleRepository(_repositories)); } }

        private LightDMS._Helper._ModuleRepository _LightDMS;
        public LightDMS._Helper._ModuleRepository LightDMS { get { return _LightDMS ?? (_LightDMS = new LightDMS._Helper._ModuleRepository(_repositories)); } }

        /*CommonDomRepositoryMembers*/
    }

    public static class Infrastructure
    {
        public static readonly RegisteredInterfaceImplementations RegisteredInterfaceImplementationName = new RegisteredInterfaceImplementations
        {
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonFilterId), @"Common.FilterId" },
            { typeof(Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata), @"Common.KeepSynchronizedMetadata" },
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonClaim), @"Common.Claim" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipal), @"Common.Principal" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalHasRole), @"Common.PrincipalHasRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRole), @"Common.Role" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRoleInheritsRole), @"Common.RoleInheritsRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalPermission), @"Common.PrincipalPermission" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRolePermission), @"Common.RolePermission" },
            /*RegisteredInterfaceImplementationName*/
        };

        public static readonly ApplyFiltersOnClientRead ApplyFiltersOnClientRead = new ApplyFiltersOnClientRead
        {
            /*ApplyFiltersOnClientRead*/
        };

        public static readonly CurrentKeepSynchronizedMetadata CurrentKeepSynchronizedMetadata = new CurrentKeepSynchronizedMetadata
        {
            new Common.KeepSynchronizedMetadata { Target = @"LightDMS.DocumentStatus", Source = @"LightDMS.ComputeDocumentStatus", Context = @"Rhetos.Dsl.DefaultConcepts.SqlQueryableInfo LightDMS.ComputeDocumentStatus '
		SELECT
			ID = document.DocumentID,
			LastEventID = lastEvent.ID,
			CheckedOutToID = CASE WHEN lastEvent.CheckoutID IS NOT NULL THEN lastEvent.CreatedByID ELSE NULL END,			
			IsCheckout = CAST(CASE WHEN lastEvent.CheckoutID IS NOT NULL THEN 1 ELSE 0 END AS BIT),
			LastVersionID = lastVersion.ID
		FROM
			(SELECT DocumentID FROM LightDMS.DocumentEvent GROUP BY DocumentID) document
			OUTER APPLY
			(
				SELECT TOP 1
					ID
				FROM
					LightDMS.DocumentVersion dv
				WHERE dv.DocumentID = document.DocumentID
				ORDER BY dv.CreatedDate DESC, dv.ID DESC
			) lastVersion 
			OUTER APPLY
			(
				SELECT TOP 1
					ID,
					CheckoutID,
					CreatedByID
				FROM
					LightDMS.DocumentEvent dv
				WHERE dv.DocumentID = document.DocumentID
				ORDER BY dv.CreatedDate DESC, dv.ID DESC
			) lastEvent
		WHERE document.DocumentID IS NOT NULL
	'" },
            /*AddKeepSynchronizedMetadata*/
        };

        /*CommonInfrastructureMembers*/
    }

    public class ExecutionContext
    {
        protected Lazy<Rhetos.Persistence.IPersistenceTransaction> _persistenceTransaction;
        public Rhetos.Persistence.IPersistenceTransaction PersistenceTransaction { get { return _persistenceTransaction.Value; } }

        protected Lazy<Rhetos.Utilities.IUserInfo> _userInfo;
        public Rhetos.Utilities.IUserInfo UserInfo { get { return _userInfo.Value; } }

        protected Lazy<Rhetos.Utilities.ISqlExecuter> _sqlExecuter;
        public Rhetos.Utilities.ISqlExecuter SqlExecuter { get { return _sqlExecuter.Value; } }

        protected Lazy<Rhetos.Security.IAuthorizationManager> _authorizationManager;
        public Rhetos.Security.IAuthorizationManager AuthorizationManager { get { return _authorizationManager.Value; } }

        protected Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> _genericRepositories;
        public Rhetos.Dom.DefaultConcepts.GenericRepositories GenericRepositories { get { return _genericRepositories.Value; } }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>() where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>();
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>(string entityName) where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>(entityName);
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<IEntity> GenericRepository(string entityName)
        {
            return GenericRepositories.GetGenericRepository(entityName);
        }

        protected Lazy<Common.DomRepository> _repository;
        public Common.DomRepository Repository { get { return _repository.Value; } }

        public Rhetos.Logging.ILogProvider LogProvider { get; private set; }

        protected Lazy<Rhetos.Security.IWindowsSecurity> _windowsSecurity;
        public Rhetos.Security.IWindowsSecurity WindowsSecurity { get { return _windowsSecurity.Value; } }

        public EntityFrameworkContext EntityFrameworkContext { get; private set; }

        /*ExecutionContextMember*/

        // This constructor is used for automatic parameter injection with autofac.
        public ExecutionContext(
            Lazy<Rhetos.Persistence.IPersistenceTransaction> persistenceTransaction,
            Lazy<Rhetos.Utilities.IUserInfo> userInfo,
            Lazy<Rhetos.Utilities.ISqlExecuter> sqlExecuter,
            Lazy<Rhetos.Security.IAuthorizationManager> authorizationManager,
            Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> genericRepositories,
            Lazy<Common.DomRepository> repository,
            Rhetos.Logging.ILogProvider logProvider,
            Lazy<Rhetos.Security.IWindowsSecurity> windowsSecurity/*ExecutionContextConstructorArgument*/,
            EntityFrameworkContext entityFrameworkContext)
        {
            _persistenceTransaction = persistenceTransaction;
            _userInfo = userInfo;
            _sqlExecuter = sqlExecuter;
            _authorizationManager = authorizationManager;
            _genericRepositories = genericRepositories;
            _repository = repository;
            LogProvider = logProvider;
            _windowsSecurity = windowsSecurity;
            EntityFrameworkContext = entityFrameworkContext;
            /*ExecutionContextConstructorAssignment*/
        }

        // This constructor is used for manual context creation (unit testing)
        public ExecutionContext()
        {
        }
    }

    [System.ComponentModel.Composition.Export(typeof(Autofac.Module))]
    public class AutofacModuleConfiguration : Autofac.Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            builder.RegisterType<DomRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EntityFrameworkConfiguration>().SingleInstance();
            builder.RegisterType<EntityFrameworkContext>()
                .As<EntityFrameworkContext>()
                .As<System.Data.Entity.DbContext>()
                .As<Rhetos.Persistence.IPersistenceCache>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ExecutionContext>().InstancePerLifetimeScope();
            builder.RegisterInstance(Infrastructure.RegisteredInterfaceImplementationName).ExternallyOwned();
            builder.RegisterInstance(Infrastructure.ApplyFiltersOnClientRead).ExternallyOwned();
            builder.RegisterInstance(Infrastructure.CurrentKeepSynchronizedMetadata).ExternallyOwned();
            builder.RegisterType<Kadrovska._Helper.Djelatnik_Repository>().Keyed<IRepository>("Kadrovska.Djelatnik").InstancePerLifetimeScope();
            builder.RegisterType<Kadrovska._Helper.Odjel_Repository>().Keyed<IRepository>("Kadrovska.Odjel").InstancePerLifetimeScope();
            builder.RegisterType<Kadrovska._Helper.Sektor_Repository>().Keyed<IRepository>("Kadrovska.Sektor").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AutoCodeCache_Repository>().Keyed<IRepository>("Common.AutoCodeCache").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.FilterId_Repository>().Keyed<IRepository>("Common.FilterId").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.KeepSynchronizedMetadata_Repository>().Keyed<IRepository>("Common.KeepSynchronizedMetadata").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ExclusiveLock_Repository>().Keyed<IRepository>("Common.ExclusiveLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.SetLock_Repository>().Keyed<IRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.SetLock_Repository>().Keyed<IActionRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ReleaseLock_Repository>().Keyed<IRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ReleaseLock_Repository>().Keyed<IActionRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogReader_Repository>().Keyed<IRepository>("Common.LogReader").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogRelatedItemReader_Repository>().Keyed<IRepository>("Common.LogRelatedItemReader").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Log_Repository>().Keyed<IRepository>("Common.Log").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AddToLog_Repository>().Keyed<IRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AddToLog_Repository>().Keyed<IActionRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogRelatedItem_Repository>().Keyed<IRepository>("Common.LogRelatedItem").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RelatedEventsSource_Repository>().Keyed<IRepository>("Common.RelatedEventsSource").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Claim_Repository>().Keyed<IRepository>("Common.Claim").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.MyClaim_Repository>().Keyed<IRepository>("Common.MyClaim").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Principal_Repository>().Keyed<IRepository>("Common.Principal").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalHasRole_Repository>().Keyed<IRepository>("Common.PrincipalHasRole").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Role_Repository>().Keyed<IRepository>("Common.Role").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RoleInheritsRole_Repository>().Keyed<IRepository>("Common.RoleInheritsRole").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalPermission_Repository>().Keyed<IRepository>("Common.PrincipalPermission").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RolePermission_Repository>().Keyed<IRepository>("Common.RolePermission").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.Checkout_Repository>().Keyed<IRepository>("LightDMS.Checkout").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.DocumentEvent_Repository>().Keyed<IRepository>("LightDMS.DocumentEvent").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.DocumentStatusBeforeEvent_Repository>().Keyed<IRepository>("LightDMS.DocumentStatusBeforeEvent").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.ComputeDocumentStatus_Repository>().Keyed<IRepository>("LightDMS.ComputeDocumentStatus").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.DocumentStatus_Repository>().Keyed<IRepository>("LightDMS.DocumentStatus").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.DocumentVersion_Repository>().Keyed<IRepository>("LightDMS.DocumentVersion").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.DocumentVersionExt_Repository>().Keyed<IRepository>("LightDMS.DocumentVersionExt").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.FileContent_Repository>().Keyed<IRepository>("LightDMS.FileContent").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.DocumentRepository_Repository>().Keyed<IRepository>("LightDMS.DocumentRepository").InstancePerLifetimeScope();
            builder.RegisterType<LightDMS._Helper.UndoCheckout_Repository>().Keyed<IRepository>("LightDMS.UndoCheckout").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.FilterId_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonFilterId>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.KeepSynchronizedMetadata_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Claim_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonClaim>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Principal_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipal>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalHasRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalHasRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Role_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RoleInheritsRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRoleInheritsRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalPermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalPermission>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RolePermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRolePermission>>().InstancePerLifetimeScope();
            /*CommonAutofacConfigurationMembers*/

            base.Load(builder);
        }
    }

    public abstract class RepositoryBase : IRepository
    {
        protected Common.DomRepository _domRepository;
        protected Common.ExecutionContext _executionContext;
    }

    public abstract class ReadableRepositoryBase<TEntity> : RepositoryBase, IReadableRepository<TEntity>
        where TEntity : class, IEntity
    {
        public IEnumerable<TEntity> Load(object parameter, Type parameterType)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Load(parameter, parameterType);
            return (IEnumerable<TEntity>)items;
        }

        public IEnumerable<TEntity> Read(object parameter, Type parameterType, bool preferQuery)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Read(parameter, parameterType, preferQuery);
            return (IEnumerable<TEntity>)items;
        }

        [Obsolete("Use Load() or Query() method.")]
        public abstract TEntity[] All();

        [Obsolete("Use Load() or Query() method.")]
        public TEntity[] Filter(FilterAll filterAll)
        {
            return All();
        }
    }

    public abstract class QueryableRepositoryBase<TQueryableEntity, TEntity> : ReadableRepositoryBase<TEntity>, IQueryableRepository<TQueryableEntity, TEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        [Obsolete("Use Load(ids) or Query(ids) method.")]
        public TEntity[] Filter(IEnumerable<Guid> ids)
        {
            if (!(ids is System.Collections.IList))
                ids = ids.ToList();
            const int BufferSize = 500; // EF 6.1.3 LINQ query has O(n^2) time complexity. Batch size of 500 results with optimal total time on the test system.
            int n = ids.Count();
            var result = new List<TEntity>(n);
            for (int i = 0; i < (n + BufferSize - 1) / BufferSize; i++)
            {
                Guid[] idBuffer = ids.Skip(i * BufferSize).Take(BufferSize).ToArray();
                List<TEntity> itemBuffer;
                if (idBuffer.Length == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
                {
                    Guid id = idBuffer.Single();
                    itemBuffer = Query().Where(item => item.ID == id).GenericToSimple<TEntity>().ToList();
                }
                else if(!idBuffer.Any())
                {
                    itemBuffer = new List<TEntity>();  
                }
                else
                    itemBuffer = Query().WhereContains(idBuffer.ToList(), item => item.ID).GenericToSimple<TEntity>().ToList();
                result.AddRange(itemBuffer);
            }
            return result.ToArray();
        }

        public abstract IQueryable<TQueryableEntity> Query();

        // LINQ to Entity does not support Query() method in subqueries.
        public IQueryable<TQueryableEntity> Subquery { get { return Query(); } }

        public IQueryable<TQueryableEntity> Query(object parameter, Type parameterType)
        {
            var query = _executionContext.GenericRepository(typeof(TEntity).FullName).Query(parameter, parameterType);
            return (IQueryable<TQueryableEntity>)query;
        }
    }

    public abstract class OrmRepositoryBase<TQueryableEntity, TEntity> : QueryableRepositoryBase<TQueryableEntity, TEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        public IQueryable<TQueryableEntity> Filter(IQueryable<TQueryableEntity> query, IEnumerable<Guid> ids)
        {
            if (!(ids is System.Collections.IList))
                ids = ids.ToList();

            if (ids.Count() == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
            {
                Guid id = ids.Single();
                return query.Where(item => item.ID == id);
            }
            else if (!ids.Any())
            {
                return Array.Empty<TQueryableEntity>().AsQueryable();
            }
            else
            {
                // Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
                var idsQuery = _domRepository.Common.FilterId.CreateQueryableFilterIds(ids);

                if (idsQuery is IList<Guid>)
                    return query.WhereContains(idsQuery.ToList(), item => item.ID);
                else
                    return query.Where(item => idsQuery.Contains(item.ID));
            }
        }
    }

    internal class DontTrackHistory<T> : List<T>
    {
    }
    /*CommonNamespaceMembers*/
}

namespace Kadrovska._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Kadrovska*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Djelatnik_Repository _Djelatnik_Repository;
        public Djelatnik_Repository Djelatnik { get { return _Djelatnik_Repository ?? (_Djelatnik_Repository = (Djelatnik_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Kadrovska.Djelatnik")); } }

        private Odjel_Repository _Odjel_Repository;
        public Odjel_Repository Odjel { get { return _Odjel_Repository ?? (_Odjel_Repository = (Odjel_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Kadrovska.Odjel")); } }

        private Sektor_Repository _Sektor_Repository;
        public Sektor_Repository Sektor { get { return _Sektor_Repository ?? (_Sektor_Repository = (Sektor_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Kadrovska.Sektor")); } }

        /*ModuleInfo RepositoryMembers Kadrovska*/
    }

    /*DataStructureInfo RepositoryAttributes Kadrovska.Djelatnik*/
    public class Djelatnik_Repository : /*DataStructureInfo OverrideBaseType Kadrovska.Djelatnik*/ Common.OrmRepositoryBase<Common.Queryable.Kadrovska_Djelatnik, Kadrovska.Djelatnik> // Common.QueryableRepositoryBase<Common.Queryable.Kadrovska_Djelatnik, Kadrovska.Djelatnik> // Common.ReadableRepositoryBase<Kadrovska.Djelatnik> // global::Common.RepositoryBase
        , IWritableRepository<Kadrovska.Djelatnik>, IValidateRepository/*DataStructureInfo RepositoryInterface Kadrovska.Djelatnik*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Kadrovska.Djelatnik*/

        public Djelatnik_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Kadrovska.Djelatnik*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Kadrovska.Djelatnik*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Kadrovska.Djelatnik[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Kadrovska_Djelatnik> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Kadrovska.Djelatnik*/
            return _executionContext.EntityFrameworkContext.Kadrovska_Djelatnik.AsNoTracking();
        }

        public void Save(IEnumerable<Kadrovska.Djelatnik> insertedNew, IEnumerable<Kadrovska.Djelatnik> updatedNew, IEnumerable<Kadrovska.Djelatnik> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Kadrovska.Djelatnik*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.MaticniBroj != null && newItem.MaticniBroj.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Djelatnik.MaticniBroj", "256" },
                        "DataStructure:Kadrovska.Djelatnik,ID:" + invalidItem.ID.ToString() + ",Property:MaticniBroj",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Prezime != null && newItem.Prezime.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Djelatnik.Prezime", "256" },
                        "DataStructure:Kadrovska.Djelatnik,ID:" + invalidItem.ID.ToString() + ",Property:Prezime",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Ime != null && newItem.Ime.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Djelatnik.Ime", "256" },
                        "DataStructure:Kadrovska.Djelatnik,ID:" + invalidItem.ID.ToString() + ",Property:Ime",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Email != null && newItem.Email.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Djelatnik.Email", "256" },
                        "DataStructure:Kadrovska.Djelatnik,ID:" + invalidItem.ID.ToString() + ",Property:Email",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Mobitel != null && newItem.Mobitel.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Djelatnik.Mobitel", "256" },
                        "DataStructure:Kadrovska.Djelatnik,ID:" + invalidItem.ID.ToString() + ",Property:Mobitel",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Tvrtka != null && newItem.Tvrtka.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Djelatnik.Tvrtka", "256" },
                        "DataStructure:Kadrovska.Djelatnik,ID:" + invalidItem.ID.ToString() + ",Property:Tvrtka",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Kadrovska.Djelatnik*/

            /*DataStructureInfo WritableOrm Initialization Kadrovska.Djelatnik*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Kadrovska_Djelatnik> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Kadrovska_Djelatnik>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Kadrovska_Djelatnik>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Kadrovska_Djelatnik> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Kadrovska_Djelatnik>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Kadrovska_Djelatnik>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Kadrovska.Djelatnik*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Prezime == null || string.IsNullOrWhiteSpace(item.Prezime) /*RequiredPropertyInfo OrCondition Kadrovska.Djelatnik.Prezime*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Kadrovska.Djelatnik", "Prezime" },
                        "DataStructure:Kadrovska.Djelatnik,ID:" + invalid.ID.ToString() + ",Property:Prezime", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Ime == null || string.IsNullOrWhiteSpace(item.Ime) /*RequiredPropertyInfo OrCondition Kadrovska.Djelatnik.Ime*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Kadrovska.Djelatnik", "Ime" },
                        "DataStructure:Kadrovska.Djelatnik,ID:" + invalid.ID.ToString() + ",Property:Ime", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Kadrovska.Djelatnik*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Kadrovska_Djelatnik.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Kadrovska.Sektor", @"VoditeljID", @"FK_Sektor_Djelatnik_VoditeljID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Kadrovska.Sektor,Property:VoditeljID,Referenced:Kadrovska.Djelatnik";
                /*DataStructureInfo WritableOrm OnDatabaseError Kadrovska.Djelatnik*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Kadrovska.Djelatnik");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Kadrovska_Djelatnik> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Kadrovska.Djelatnik*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Kadrovska.Djelatnik*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Kadrovska.Djelatnik");

                /*DataStructureInfo WritableOrm AfterSave Kadrovska.Djelatnik*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Kadrovska.Djelatnik*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Kadrovska.Djelatnik*/
    }

    /*DataStructureInfo RepositoryAttributes Kadrovska.Odjel*/
    public class Odjel_Repository : /*DataStructureInfo OverrideBaseType Kadrovska.Odjel*/ Common.OrmRepositoryBase<Common.Queryable.Kadrovska_Odjel, Kadrovska.Odjel> // Common.QueryableRepositoryBase<Common.Queryable.Kadrovska_Odjel, Kadrovska.Odjel> // Common.ReadableRepositoryBase<Kadrovska.Odjel> // global::Common.RepositoryBase
        , IWritableRepository<Kadrovska.Odjel>, IValidateRepository/*DataStructureInfo RepositoryInterface Kadrovska.Odjel*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Kadrovska.Odjel*/

        public Odjel_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Kadrovska.Odjel*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Kadrovska.Odjel*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Kadrovska.Odjel[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Kadrovska_Odjel> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Kadrovska.Odjel*/
            return _executionContext.EntityFrameworkContext.Kadrovska_Odjel.AsNoTracking();
        }

        public void Save(IEnumerable<Kadrovska.Odjel> insertedNew, IEnumerable<Kadrovska.Odjel> updatedNew, IEnumerable<Kadrovska.Odjel> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Kadrovska.Odjel*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Naziv != null && newItem.Naziv.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Odjel.Naziv", "256" },
                        "DataStructure:Kadrovska.Odjel,ID:" + invalidItem.ID.ToString() + ",Property:Naziv",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Kadrovska.Odjel*/

            /*DataStructureInfo WritableOrm Initialization Kadrovska.Odjel*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Kadrovska_Odjel> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Kadrovska_Odjel>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Kadrovska_Odjel>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Kadrovska_Odjel> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Kadrovska_Odjel>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Kadrovska_Odjel>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Kadrovska.Odjel*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Naziv == null || string.IsNullOrWhiteSpace(item.Naziv) /*RequiredPropertyInfo OrCondition Kadrovska.Odjel.Naziv*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Kadrovska.Odjel", "Naziv" },
                        "DataStructure:Kadrovska.Odjel,ID:" + invalid.ID.ToString() + ",Property:Naziv", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Kadrovska.Odjel*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Kadrovska_Odjel.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Kadrovska.Odjel", @"IX_Odjel_Naziv"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Kadrovska.Odjel,Property:Naziv";
                /*DataStructureInfo WritableOrm OnDatabaseError Kadrovska.Odjel*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Kadrovska.Odjel");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Kadrovska_Odjel> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Kadrovska.Odjel*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Kadrovska.Odjel*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Kadrovska.Odjel");

                /*DataStructureInfo WritableOrm AfterSave Kadrovska.Odjel*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Kadrovska.Odjel*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Kadrovska.Odjel*/
    }

    /*DataStructureInfo RepositoryAttributes Kadrovska.Sektor*/
    public class Sektor_Repository : /*DataStructureInfo OverrideBaseType Kadrovska.Sektor*/ Common.OrmRepositoryBase<Common.Queryable.Kadrovska_Sektor, Kadrovska.Sektor> // Common.QueryableRepositoryBase<Common.Queryable.Kadrovska_Sektor, Kadrovska.Sektor> // Common.ReadableRepositoryBase<Kadrovska.Sektor> // global::Common.RepositoryBase
        , IWritableRepository<Kadrovska.Sektor>, IValidateRepository/*DataStructureInfo RepositoryInterface Kadrovska.Sektor*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Kadrovska.Sektor*/

        public Sektor_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Kadrovska.Sektor*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Kadrovska.Sektor*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Kadrovska.Sektor[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Kadrovska_Sektor> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Kadrovska.Sektor*/
            return _executionContext.EntityFrameworkContext.Kadrovska_Sektor.AsNoTracking();
        }

        public void Save(IEnumerable<Kadrovska.Sektor> insertedNew, IEnumerable<Kadrovska.Sektor> updatedNew, IEnumerable<Kadrovska.Sektor> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Kadrovska.Sektor*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Naziv != null && newItem.Naziv.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Sektor.Naziv", "256" },
                        "DataStructure:Kadrovska.Sektor,ID:" + invalidItem.ID.ToString() + ",Property:Naziv",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Kadrovska.Sektor*/

            /*DataStructureInfo WritableOrm Initialization Kadrovska.Sektor*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Kadrovska_Sektor> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Kadrovska_Sektor>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Kadrovska_Sektor>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Kadrovska_Sektor> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Kadrovska_Sektor>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Kadrovska_Sektor>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Kadrovska.Sektor*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Naziv == null || string.IsNullOrWhiteSpace(item.Naziv) /*RequiredPropertyInfo OrCondition Kadrovska.Sektor.Naziv*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Kadrovska.Sektor", "Naziv" },
                        "DataStructure:Kadrovska.Sektor,ID:" + invalid.ID.ToString() + ",Property:Naziv", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.VoditeljID == null /*RequiredPropertyInfo OrCondition Kadrovska.Sektor.Voditelj*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Kadrovska.Sektor", "Voditelj" },
                        "DataStructure:Kadrovska.Sektor,ID:" + invalid.ID.ToString() + ",Property:VoditeljID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Kadrovska.Sektor*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Kadrovska_Sektor.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Kadrovska.Djelatnik", @"ID", @"FK_Sektor_Djelatnik_VoditeljID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Kadrovska.Sektor,Property:VoditeljID,Referenced:Kadrovska.Djelatnik";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Kadrovska.Sektor", @"IX_Sektor_Naziv"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Kadrovska.Sektor,Property:Naziv";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Kadrovska.Sektor", @"IX_Sektor_Voditelj"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Kadrovska.Sektor,Property:Voditelj";
                /*DataStructureInfo WritableOrm OnDatabaseError Kadrovska.Sektor*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Kadrovska.Sektor");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Kadrovska_Sektor> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Kadrovska.Sektor*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Kadrovska.Sektor*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Kadrovska.Sektor");

                /*DataStructureInfo WritableOrm AfterSave Kadrovska.Sektor*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Kadrovska.Sektor*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Kadrovska.Sektor*/
    }

    /*ModuleInfo HelperNamespaceMembers Kadrovska*/
}

namespace Common._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Common*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private AutoCodeCache_Repository _AutoCodeCache_Repository;
        public AutoCodeCache_Repository AutoCodeCache { get { return _AutoCodeCache_Repository ?? (_AutoCodeCache_Repository = (AutoCodeCache_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AutoCodeCache")); } }

        private FilterId_Repository _FilterId_Repository;
        public FilterId_Repository FilterId { get { return _FilterId_Repository ?? (_FilterId_Repository = (FilterId_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.FilterId")); } }

        private KeepSynchronizedMetadata_Repository _KeepSynchronizedMetadata_Repository;
        public KeepSynchronizedMetadata_Repository KeepSynchronizedMetadata { get { return _KeepSynchronizedMetadata_Repository ?? (_KeepSynchronizedMetadata_Repository = (KeepSynchronizedMetadata_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.KeepSynchronizedMetadata")); } }

        private ExclusiveLock_Repository _ExclusiveLock_Repository;
        public ExclusiveLock_Repository ExclusiveLock { get { return _ExclusiveLock_Repository ?? (_ExclusiveLock_Repository = (ExclusiveLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ExclusiveLock")); } }

        private SetLock_Repository _SetLock_Repository;
        public SetLock_Repository SetLock { get { return _SetLock_Repository ?? (_SetLock_Repository = (SetLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.SetLock")); } }

        private ReleaseLock_Repository _ReleaseLock_Repository;
        public ReleaseLock_Repository ReleaseLock { get { return _ReleaseLock_Repository ?? (_ReleaseLock_Repository = (ReleaseLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ReleaseLock")); } }

        private LogReader_Repository _LogReader_Repository;
        public LogReader_Repository LogReader { get { return _LogReader_Repository ?? (_LogReader_Repository = (LogReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogReader")); } }

        private LogRelatedItemReader_Repository _LogRelatedItemReader_Repository;
        public LogRelatedItemReader_Repository LogRelatedItemReader { get { return _LogRelatedItemReader_Repository ?? (_LogRelatedItemReader_Repository = (LogRelatedItemReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItemReader")); } }

        private Log_Repository _Log_Repository;
        public Log_Repository Log { get { return _Log_Repository ?? (_Log_Repository = (Log_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Log")); } }

        private AddToLog_Repository _AddToLog_Repository;
        public AddToLog_Repository AddToLog { get { return _AddToLog_Repository ?? (_AddToLog_Repository = (AddToLog_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AddToLog")); } }

        private LogRelatedItem_Repository _LogRelatedItem_Repository;
        public LogRelatedItem_Repository LogRelatedItem { get { return _LogRelatedItem_Repository ?? (_LogRelatedItem_Repository = (LogRelatedItem_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItem")); } }

        private RelatedEventsSource_Repository _RelatedEventsSource_Repository;
        public RelatedEventsSource_Repository RelatedEventsSource { get { return _RelatedEventsSource_Repository ?? (_RelatedEventsSource_Repository = (RelatedEventsSource_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RelatedEventsSource")); } }

        private Claim_Repository _Claim_Repository;
        public Claim_Repository Claim { get { return _Claim_Repository ?? (_Claim_Repository = (Claim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Claim")); } }

        private MyClaim_Repository _MyClaim_Repository;
        public MyClaim_Repository MyClaim { get { return _MyClaim_Repository ?? (_MyClaim_Repository = (MyClaim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.MyClaim")); } }

        private Principal_Repository _Principal_Repository;
        public Principal_Repository Principal { get { return _Principal_Repository ?? (_Principal_Repository = (Principal_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Principal")); } }

        private PrincipalHasRole_Repository _PrincipalHasRole_Repository;
        public PrincipalHasRole_Repository PrincipalHasRole { get { return _PrincipalHasRole_Repository ?? (_PrincipalHasRole_Repository = (PrincipalHasRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalHasRole")); } }

        private Role_Repository _Role_Repository;
        public Role_Repository Role { get { return _Role_Repository ?? (_Role_Repository = (Role_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Role")); } }

        private RoleInheritsRole_Repository _RoleInheritsRole_Repository;
        public RoleInheritsRole_Repository RoleInheritsRole { get { return _RoleInheritsRole_Repository ?? (_RoleInheritsRole_Repository = (RoleInheritsRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RoleInheritsRole")); } }

        private PrincipalPermission_Repository _PrincipalPermission_Repository;
        public PrincipalPermission_Repository PrincipalPermission { get { return _PrincipalPermission_Repository ?? (_PrincipalPermission_Repository = (PrincipalPermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalPermission")); } }

        private RolePermission_Repository _RolePermission_Repository;
        public RolePermission_Repository RolePermission { get { return _RolePermission_Repository ?? (_RolePermission_Repository = (RolePermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RolePermission")); } }

        /*ModuleInfo RepositoryMembers Common*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AutoCodeCache*/
    public class AutoCodeCache_Repository : /*DataStructureInfo OverrideBaseType Common.AutoCodeCache*/ Common.OrmRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.QueryableRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.ReadableRepositoryBase<Common.AutoCodeCache> // global::Common.RepositoryBase
        , IWritableRepository<Common.AutoCodeCache>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.AutoCodeCache*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.AutoCodeCache*/

        public AutoCodeCache_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.AutoCodeCache*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.AutoCodeCache*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.AutoCodeCache[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_AutoCodeCache> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.AutoCodeCache*/
            return _executionContext.EntityFrameworkContext.Common_AutoCodeCache.AsNoTracking();
        }

        public void Save(IEnumerable<Common.AutoCodeCache> insertedNew, IEnumerable<Common.AutoCodeCache> updatedNew, IEnumerable<Common.AutoCodeCache> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.AutoCodeCache*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Entity != null && newItem.Entity.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Entity", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Entity",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Property != null && newItem.Property.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Property", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Property",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Grouping != null && newItem.Grouping.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Grouping", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Grouping",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Prefix != null && newItem.Prefix.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Prefix", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Prefix",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm Initialization Common.AutoCodeCache*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_AutoCodeCache> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_AutoCodeCache>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_AutoCodeCache>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_AutoCodeCache> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_AutoCodeCache>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_AutoCodeCache>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.AutoCodeCache*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_AutoCodeCache.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.AutoCodeCache", @"IX_AutoCodeCache_Entity_Property_Grouping_Prefix"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.AutoCodeCache,Property:Entity Property Grouping Prefix";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.AutoCodeCache*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.AutoCodeCache");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_AutoCodeCache> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.AutoCodeCache*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.AutoCodeCache*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.AutoCodeCache");

                /*DataStructureInfo WritableOrm AfterSave Common.AutoCodeCache*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.AutoCodeCache*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.AutoCodeCache*/
    }

    /*DataStructureInfo RepositoryAttributes Common.FilterId*/
    public class FilterId_Repository : /*DataStructureInfo OverrideBaseType Common.FilterId*/ Common.OrmRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.QueryableRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.ReadableRepositoryBase<Common.FilterId> // global::Common.RepositoryBase
        , IWritableRepository<Common.FilterId>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.FilterId*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.FilterId*/

        public FilterId_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.FilterId*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.FilterId*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.FilterId[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_FilterId> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.FilterId*/
            return _executionContext.EntityFrameworkContext.Common_FilterId.AsNoTracking();
        }

        /// <summary>
        /// Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
        /// EF 6.1.3 has performance issues on Contains function with large lists. It seems to have O(n^2) time complexity.
        /// </summary>
        public IEnumerable<Guid> CreateQueryableFilterIds(IEnumerable<Guid> ids)
        {
            Rhetos.Utilities.CsUtility.Materialize(ref ids);

            if (ids.Count() < 200)
                return ids;

            var handle = Guid.NewGuid();
            string sqlInsertIdFormat = "INSERT INTO Common.FilterId (Handle, Value) VALUES ('" + SqlUtility.GuidToString(handle) + "', '{0}');";

            const int chunkSize = 1000; // Keeping a moderate SQL script size.
            for (int start = 0; start < ids.Count(); start += chunkSize)
            {
                string sqlInsertIds = string.Join("\r\n", ids.Skip(start).Take(chunkSize)
                        .Select(id => string.Format(sqlInsertIdFormat, SqlUtility.GuidToString(id))));
                _executionContext.SqlExecuter.ExecuteSql(sqlInsertIds);
            }

            // Delete temporary data when closing the connection. The data must remain in the database until the returned query is used.
            string deleteFilterIds = "DELETE FROM Common.FilterId WHERE Handle = " + SqlUtility.QuoteGuid(handle);
            _executionContext.PersistenceTransaction.BeforeClose += () =>
                {
                    try
                    {
                        _executionContext.SqlExecuter.ExecuteSql(deleteFilterIds);
                    }
                    catch
                    {
                        // Cleanup error may be ignored. The temporary data may be deleted on regular maintenance.
                    }
                };

            return Query().Where(filterId => filterId.Handle == handle).Select(filterId => filterId.Value.Value);
        }

        public void Save(IEnumerable<Common.FilterId> insertedNew, IEnumerable<Common.FilterId> updatedNew, IEnumerable<Common.FilterId> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.FilterId*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.FilterId*/

            /*DataStructureInfo WritableOrm Initialization Common.FilterId*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_FilterId> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_FilterId>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_FilterId>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_FilterId> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_FilterId>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_FilterId>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.FilterId*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.FilterId*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_FilterId.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Common.FilterId*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.FilterId");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_FilterId> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.FilterId*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.FilterId*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.FilterId");

                /*DataStructureInfo WritableOrm AfterSave Common.FilterId*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.FilterId*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.FilterId*/
    }

    /*DataStructureInfo RepositoryAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata_Repository : /*DataStructureInfo OverrideBaseType Common.KeepSynchronizedMetadata*/ Common.OrmRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.QueryableRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.ReadableRepositoryBase<Common.KeepSynchronizedMetadata> // global::Common.RepositoryBase
        , IWritableRepository<Common.KeepSynchronizedMetadata>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.KeepSynchronizedMetadata*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.KeepSynchronizedMetadata*/

        public KeepSynchronizedMetadata_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.KeepSynchronizedMetadata*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.KeepSynchronizedMetadata*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.KeepSynchronizedMetadata[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.KeepSynchronizedMetadata*/
            return _executionContext.EntityFrameworkContext.Common_KeepSynchronizedMetadata.AsNoTracking();
        }

        public void Save(IEnumerable<Common.KeepSynchronizedMetadata> insertedNew, IEnumerable<Common.KeepSynchronizedMetadata> updatedNew, IEnumerable<Common.KeepSynchronizedMetadata> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.KeepSynchronizedMetadata*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Target != null && newItem.Target.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "KeepSynchronizedMetadata.Target", "256" },
                        "DataStructure:Common.KeepSynchronizedMetadata,ID:" + invalidItem.ID.ToString() + ",Property:Target",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Source != null && newItem.Source.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "KeepSynchronizedMetadata.Source", "256" },
                        "DataStructure:Common.KeepSynchronizedMetadata,ID:" + invalidItem.ID.ToString() + ",Property:Source",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm Initialization Common.KeepSynchronizedMetadata*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_KeepSynchronizedMetadata>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_KeepSynchronizedMetadata>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_KeepSynchronizedMetadata>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_KeepSynchronizedMetadata>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.KeepSynchronizedMetadata*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_KeepSynchronizedMetadata.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Common.KeepSynchronizedMetadata*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.KeepSynchronizedMetadata");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.KeepSynchronizedMetadata*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.KeepSynchronizedMetadata*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.KeepSynchronizedMetadata");

                /*DataStructureInfo WritableOrm AfterSave Common.KeepSynchronizedMetadata*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.KeepSynchronizedMetadata*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.KeepSynchronizedMetadata*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ExclusiveLock*/
    public class ExclusiveLock_Repository : /*DataStructureInfo OverrideBaseType Common.ExclusiveLock*/ Common.OrmRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.QueryableRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.ReadableRepositoryBase<Common.ExclusiveLock> // global::Common.RepositoryBase
        , IWritableRepository<Common.ExclusiveLock>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.ExclusiveLock*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.ExclusiveLock*/

        public ExclusiveLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.ExclusiveLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.ExclusiveLock*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.ExclusiveLock[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_ExclusiveLock> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.ExclusiveLock*/
            return _executionContext.EntityFrameworkContext.Common_ExclusiveLock.AsNoTracking();
        }

        public void Save(IEnumerable<Common.ExclusiveLock> insertedNew, IEnumerable<Common.ExclusiveLock> updatedNew, IEnumerable<Common.ExclusiveLock> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.ExclusiveLock*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ResourceType != null && newItem.ResourceType.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.ResourceType", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:ResourceType",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.UserName != null && newItem.UserName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.UserName", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:UserName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Workstation != null && newItem.Workstation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.Workstation", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:Workstation",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.ExclusiveLock*/

            /*DataStructureInfo WritableOrm Initialization Common.ExclusiveLock*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_ExclusiveLock> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_ExclusiveLock>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ExclusiveLock>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_ExclusiveLock> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_ExclusiveLock>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ExclusiveLock>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.ExclusiveLock*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceType == null || string.IsNullOrWhiteSpace(item.ResourceType) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceType*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceType" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceType", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceID == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceID*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceID" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "UserName" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "Workstation" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockStart == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockStart*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockStart" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockStart", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockFinish == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockFinish*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockFinish" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockFinish", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.ExclusiveLock*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_ExclusiveLock.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.ExclusiveLock", @"IX_ExclusiveLock_ResourceID_ResourceType"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.ExclusiveLock,Property:ResourceID ResourceType";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.ExclusiveLock*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.ExclusiveLock");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_ExclusiveLock> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.ExclusiveLock*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.ExclusiveLock*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.ExclusiveLock");

                /*DataStructureInfo WritableOrm AfterSave Common.ExclusiveLock*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.ExclusiveLock*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.ExclusiveLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.SetLock*/
    public class SetLock_Repository : /*DataStructureInfo OverrideBaseType Common.SetLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.SetLock*/
    {
        private readonly Rhetos.Utilities.ILocalizer _localizer;
        /*DataStructureInfo RepositoryPrivateMembers Common.SetLock*/

        public SetLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ILocalizer _localizer/*DataStructureInfo RepositoryConstructorArguments Common.SetLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._localizer = _localizer;
            /*DataStructureInfo RepositoryConstructorCode Common.SetLock*/
        }

        public void Execute(Common.SetLock actionParameter)
        {
            Action<Common.SetLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.SetLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

            var oldLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID)
                .FirstOrDefault();
            
            if (oldLock == null)
                repository.Common.ExclusiveLock.Insert(new[] { new Common.ExclusiveLock
                    {
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = now,
                        LockFinish = now.AddMinutes(15)
                    }});
            else if (oldLock.UserName == userInfo.UserName
                && oldLock.Workstation == userInfo.Workstation
                || oldLock.LockFinish < now)
                repository.Common.ExclusiveLock.Update(new[] { new Common.ExclusiveLock
                    {
                        ID = oldLock.ID,
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = now,
                        LockFinish = now.AddMinutes(15)
                    }});
             else
             {
                string lockInfo = _localizer["Locked record {0}, ID {1}.", oldLock.ResourceType, oldLock.ResourceID];

                string errorInfo;
                if (oldLock.UserName.Equals(userInfo.UserName, StringComparison.InvariantCultureIgnoreCase))
                    errorInfo = _localizer["It is not allowed to enter the record at client workstation '{0}' because the data entry is in progress at workstation '{1}'.",
                        userInfo.Workstation, oldLock.Workstation];
                else
                    errorInfo = _localizer["It is not allowed to enter the record because the data entry is in progress by user '{0}'.",
                        oldLock.UserName];
                
                string localizedMessage = errorInfo + "\r\n" + lockInfo;
                throw new Rhetos.UserException(localizedMessage);
             }
        };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.SetLock*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.SetLock*/);
                /*ActionInfo AfterAction Common.SetLock*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.SetLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.SetLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ReleaseLock*/
    public class ReleaseLock_Repository : /*DataStructureInfo OverrideBaseType Common.ReleaseLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.ReleaseLock*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.ReleaseLock*/

        public ReleaseLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.ReleaseLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.ReleaseLock*/
        }

        public void Execute(Common.ReleaseLock actionParameter)
        {
            Action<Common.ReleaseLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.ReleaseLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var myLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID
                    && itemLock.UserName == userInfo.UserName
                    && itemLock.Workstation == userInfo.Workstation)
                .FirstOrDefault();

            if (myLock != null)
                repository.Common.ExclusiveLock.Delete(new[] { myLock });
        };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.ReleaseLock*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.ReleaseLock*/);
                /*ActionInfo AfterAction Common.ReleaseLock*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.ReleaseLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.ReleaseLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogReader*/
    public class LogReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.ReadableRepositoryBase<Common.LogReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogReader*/

        public LogReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogReader*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogReader[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogReader> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogReader*/
            return _executionContext.EntityFrameworkContext.Common_LogReader.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.LogReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItemReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.ReadableRepositoryBase<Common.LogRelatedItemReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogRelatedItemReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItemReader*/

        public LogRelatedItemReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItemReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItemReader*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogRelatedItemReader[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogRelatedItemReader> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogRelatedItemReader*/
            return _executionContext.EntityFrameworkContext.Common_LogRelatedItemReader.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItemReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Log*/
    public class Log_Repository : /*DataStructureInfo OverrideBaseType Common.Log*/ Common.OrmRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.QueryableRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.ReadableRepositoryBase<Common.Log> // global::Common.RepositoryBase
        , IWritableRepository<Common.Log>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Log*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Log*/

        public Log_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Log*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Log*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Log[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Log> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Log*/
            return _executionContext.EntityFrameworkContext.Common_Log.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Log> insertedNew, IEnumerable<Common.Log> updatedNew, IEnumerable<Common.Log> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Log*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.UserName != null && newItem.UserName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.UserName", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:UserName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Workstation != null && newItem.Workstation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.Workstation", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:Workstation",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ContextInfo != null && newItem.ContextInfo.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.ContextInfo", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:ContextInfo",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Action != null && newItem.Action.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.Action", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:Action",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.TableName != null && newItem.TableName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.TableName", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:TableName",
                        null);
            }
            if (checkUserPermissions)
                throw new Rhetos.UserException(
                    "It is not allowed to directly modify {0}.", new[] { "Common.Log" }, null, null);
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Log*/

            /*DataStructureInfo WritableOrm Initialization Common.Log*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_Log> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_Log>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Log>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_Log> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_Log>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Log>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.LogRelatedItem> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.LogRelatedItem.Query()
                        .Where(child => child.LogID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.LogRelatedItem { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.LogRelatedItem.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Log*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Created == null /*RequiredPropertyInfo OrCondition Common.Log.Created*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Created" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Created", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.Log.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "UserName" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.Log.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Workstation" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Action == null || string.IsNullOrWhiteSpace(item.Action) /*RequiredPropertyInfo OrCondition Common.Log.Action*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Action" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Action", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Log*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Log.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.LogRelatedItem", @"LogID", @"FK_LogRelatedItem_Log_LogID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Log*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Log");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Log> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Log*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Log*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Log");

                /*DataStructureInfo WritableOrm AfterSave Common.Log*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Log*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Log*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AddToLog*/
    public class AddToLog_Repository : /*DataStructureInfo OverrideBaseType Common.AddToLog*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.AddToLog*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.AddToLog*/

        public AddToLog_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.AddToLog*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.AddToLog*/
        }

        public void Execute(Common.AddToLog actionParameter)
        {
            Action<Common.AddToLog, Common.DomRepository, IUserInfo, Common.ExecutionContext/*DataStructureInfo AdditionalParametersType Common.AddToLog*/> action_Object = (parameter, repository, userInfo, context) =>
		{
			if (parameter.Action == null)
				throw new Rhetos.UserException("Parameter Action is required.");
			string sql = @"INSERT INTO Common.Log (Action, TableName, ItemId, Description)
                SELECT @p0, @p1, @p2, @p3";
			context.EntityFrameworkContext.Database.ExecuteSqlCommand(sql,
				parameter.Action,
				parameter.TableName,
				parameter.ItemId,
				parameter.Description);
		};

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.AddToLog*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo, _executionContext/*DataStructureInfo AdditionalParametersArgument Common.AddToLog*/);
                /*ActionInfo AfterAction Common.AddToLog*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.AddToLog) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.AddToLog*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItem*/
    public class LogRelatedItem_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItem*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.ReadableRepositoryBase<Common.LogRelatedItem> // global::Common.RepositoryBase
        , IWritableRepository<Common.LogRelatedItem>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.LogRelatedItem*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItem*/

        public LogRelatedItem_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItem*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItem*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogRelatedItem[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogRelatedItem> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogRelatedItem*/
            return _executionContext.EntityFrameworkContext.Common_LogRelatedItem.AsNoTracking();
        }

        public void Save(IEnumerable<Common.LogRelatedItem> insertedNew, IEnumerable<Common.LogRelatedItem> updatedNew, IEnumerable<Common.LogRelatedItem> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.LogRelatedItem*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.TableName != null && newItem.TableName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "LogRelatedItem.TableName", "256" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalidItem.ID.ToString() + ",Property:TableName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Relation != null && newItem.Relation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "LogRelatedItem.Relation", "256" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalidItem.ID.ToString() + ",Property:Relation",
                        null);
            }
            if (checkUserPermissions)
                throw new Rhetos.UserException(
                    "It is not allowed to directly modify {0}.", new[] { "Common.LogRelatedItem" }, null, null);
            /*DataStructureInfo WritableOrm ArgumentValidation Common.LogRelatedItem*/

            /*DataStructureInfo WritableOrm Initialization Common.LogRelatedItem*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_LogRelatedItem> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_LogRelatedItem>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_LogRelatedItem>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_LogRelatedItem> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_LogRelatedItem>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_LogRelatedItem>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.LogRelatedItem*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LogID == null /*RequiredPropertyInfo OrCondition Common.LogRelatedItem.Log*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.LogRelatedItem", "Log" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalid.ID.ToString() + ",Property:LogID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.LogRelatedItem*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_LogRelatedItem.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Log", @"ID", @"FK_LogRelatedItem_Log_LogID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.LogRelatedItem*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.LogRelatedItem");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_LogRelatedItem> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.LogRelatedItem*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.LogRelatedItem*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.LogRelatedItem");

                /*DataStructureInfo WritableOrm AfterSave Common.LogRelatedItem*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredLog()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredLog(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.LogRelatedItem*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredLog(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredLog";
            metadata[@"Property"] = @"Log";
            /*InvalidDataInfo ErrorMetadata Common.LogRelatedItem.SystemRequiredLog*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.LogRelatedItem.Log" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.LogRelatedItem.SystemRequiredLog*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_LogRelatedItem> Filter(IQueryable<Common.Queryable.Common_LogRelatedItem> localSource, Common.SystemRequiredLog localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_LogRelatedItem>, Common.DomRepository, Common.SystemRequiredLog/*ComposableFilterByInfo AdditionalParametersType Common.LogRelatedItem.'Common.SystemRequiredLog'*/, IQueryable<Common.Queryable.Common_LogRelatedItem>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Log == null);

            /*ComposableFilterByInfo BeforeFilter Common.LogRelatedItem.'Common.SystemRequiredLog'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.LogRelatedItem.'Common.SystemRequiredLog'*/);
        }

        public global::Common.LogRelatedItem[] Filter(Common.SystemRequiredLog filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredLog/*FilterByInfo AdditionalParametersType Common.LogRelatedItem.'Common.SystemRequiredLog'*/, Common.LogRelatedItem[]> filter_Function =
                (repository, parameter) => repository.Common.LogRelatedItem.Filter(repository.Common.LogRelatedItem.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.LogRelatedItem.'Common.SystemRequiredLog'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItem*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource_Repository : /*DataStructureInfo OverrideBaseType Common.RelatedEventsSource*/ Common.OrmRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.QueryableRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.ReadableRepositoryBase<Common.RelatedEventsSource> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.RelatedEventsSource*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.RelatedEventsSource*/

        public RelatedEventsSource_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.RelatedEventsSource*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.RelatedEventsSource*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RelatedEventsSource[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RelatedEventsSource> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RelatedEventsSource*/
            return _executionContext.EntityFrameworkContext.Common_RelatedEventsSource.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.RelatedEventsSource*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Claim*/
    public class Claim_Repository : /*DataStructureInfo OverrideBaseType Common.Claim*/ Common.OrmRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.QueryableRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.ReadableRepositoryBase<Common.Claim> // global::Common.RepositoryBase
        , IWritableRepository<Common.Claim>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Claim*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Claim*/

        public Claim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Claim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Claim*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Claim[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Claim> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Claim*/
            return _executionContext.EntityFrameworkContext.Common_Claim.AsNoTracking();
        }

        // Claims in use should be deactivated instead of deleted.
        public IEnumerable<Claim> Filter(IEnumerable<Claim> deleted, Rhetos.Dom.DefaultConcepts.DeactivateInsteadOfDelete parameter)
        {
            var deactivateClaimsId = new List<Guid>();
            var deletedClaimsId = new Lazy<List<Guid>>(() => deleted.Select(c => c.ID).ToList());

            {
                // Don't delete claims that are referenced from RolePermission:

                var permissionsQuery = _domRepository.Common.RolePermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            
            {
                // Don't delete claims that are referenced from PrincipalPermission:

                var permissionsQuery = _domRepository.Common.PrincipalPermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            /*DataStructureInfo DeactivateInsteadOfDelete Common.Claim*/

            var deactivateClaimsIdIndex = new HashSet<Guid>(deactivateClaimsId);
            return deleted.Where(item => deactivateClaimsIdIndex.Contains(item.ID)).ToList();
        }

        public void Save(IEnumerable<Common.Claim> insertedNew, IEnumerable<Common.Claim> updatedNew, IEnumerable<Common.Claim> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Claim*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ClaimResource != null && newItem.ClaimResource.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Claim.ClaimResource", "256" },
                        "DataStructure:Common.Claim,ID:" + invalidItem.ID.ToString() + ",Property:ClaimResource",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ClaimRight != null && newItem.ClaimRight.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Claim.ClaimRight", "256" },
                        "DataStructure:Common.Claim,ID:" + invalidItem.ID.ToString() + ",Property:ClaimRight",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Claim*/

            /*DataStructureInfo WritableOrm Initialization Common.Claim*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_Claim> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_Claim>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Claim>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_Claim> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_Claim>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Claim>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            foreach (var newItem in insertedNew)
                if (newItem.Active == null)
                    newItem.Active = true;

            foreach (var change in updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem }))
                if (change.newItem.Active == null)
                    change.newItem.Active = change.oldItem.Active ?? true;

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Claim*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimResource == null || string.IsNullOrWhiteSpace(item.ClaimResource) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimResource*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimResource" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimResource", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimRight == null || string.IsNullOrWhiteSpace(item.ClaimRight) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimRight*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimRight" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimRight", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Claim*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Claim.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"ClaimID", @"FK_PrincipalPermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"ClaimID", @"FK_RolePermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Claim", @"IX_Claim_ClaimResource_ClaimRight"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Claim,Property:ClaimResource ClaimRight";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Claim*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Claim");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Claim> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Claim*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Claim*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Claim");

                /*DataStructureInfo WritableOrm AfterSave Common.Claim*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredActive()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredActive(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Claim*/
            yield break;
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> localSource, Rhetos.Dom.DefaultConcepts.ActiveItems localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository, Rhetos.Dom.DefaultConcepts.ActiveItems/*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/, IQueryable<Common.Queryable.Common_Claim>> filterFunction =
            (items, repository, parameter) =>
                    {
                        if (parameter != null && parameter.ItemID.HasValue)
                            return items.Where(item => item.Active == null || item.Active.Value || item.ID == parameter.ItemID.Value);
                        else
                            return items.Where(item => item.Active == null || item.Active.Value);
                    };

            /*ComposableFilterByInfo BeforeFilter Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredActive(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredActive";
            metadata[@"Property"] = @"Active";
            /*InvalidDataInfo ErrorMetadata Common.Claim.SystemRequiredActive*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Bool Common.Claim.Active" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.Claim.SystemRequiredActive*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> localSource, Common.SystemRequiredActive localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository, Common.SystemRequiredActive/*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Common.SystemRequiredActive'*/, IQueryable<Common.Queryable.Common_Claim>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Active == null);

            /*ComposableFilterByInfo BeforeFilter Common.Claim.'Common.SystemRequiredActive'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Common.SystemRequiredActive'*/);
        }

        public global::Common.Claim[] Filter(Rhetos.Dom.DefaultConcepts.ActiveItems filter_Parameter)
        {
            Func<Common.DomRepository, Rhetos.Dom.DefaultConcepts.ActiveItems/*FilterByInfo AdditionalParametersType Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/, Common.Claim[]> filter_Function =
                (repository, parameter) => repository.Common.Claim.Filter(repository.Common.Claim.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/);
        }

        public global::Common.Claim[] Filter(Common.SystemRequiredActive filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredActive/*FilterByInfo AdditionalParametersType Common.Claim.'Common.SystemRequiredActive'*/, Common.Claim[]> filter_Function =
                (repository, parameter) => repository.Common.Claim.Filter(repository.Common.Claim.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.Claim.'Common.SystemRequiredActive'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.Claim*/
    }

    /*DataStructureInfo RepositoryAttributes Common.MyClaim*/
    public class MyClaim_Repository : /*DataStructureInfo OverrideBaseType Common.MyClaim*/ Common.QueryableRepositoryBase<Common.Queryable.Common_MyClaim, Common.MyClaim> // Common.ReadableRepositoryBase<Common.MyClaim> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.MyClaim*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.MyClaim*/

        public MyClaim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.MyClaim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.MyClaim*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.MyClaim[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_MyClaim> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.MyClaim*/
            return Compute(_domRepository.Common.Claim.Query(), _domRepository/*DataStructureInfo AdditionalParametersArgument Common.MyClaim*/);
        }

        public readonly Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository/*DataStructureInfo AdditionalParametersType Common.MyClaim*/, IQueryable<Common.Queryable.Common_MyClaim>> Compute =
            (query, repository) =>
		{ throw new Rhetos.UserException("Reading Common.MyClaim without filter is not permitted. Use filter by Common.Claim or Common.Claim[]."); };

        public global::Common.MyClaim[] Filter(Common.Claim filter_Parameter)
        {
            Func<Common.DomRepository, Common.Claim, Common.ExecutionContext/*FilterByInfo AdditionalParametersType Common.MyClaim.'Common.Claim'*/, Common.MyClaim[]> filter_Function =
                (repository, parameter, executionContext) =>
			{
				var claim = repository.Common.Claim.Query().Where(item => item.ClaimResource == parameter.ClaimResource && item.ClaimRight == parameter.ClaimRight).SingleOrDefault();
				if (claim == null)
					throw new Rhetos.UserException("Claim {0}-{1} does not exist.",
						new[] { parameter.ClaimResource, parameter.ClaimRight }, null, null);
				
				return repository.Common.MyClaim.Filter(new[] { claim });
			};

            return filter_Function(_domRepository, filter_Parameter, _executionContext/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'Common.Claim'*/);
        }

        public global::Common.MyClaim[] Filter(IEnumerable<Common.Claim> filter_Parameter)
        {
            Func<Common.DomRepository, IEnumerable<Common.Claim>, Common.ExecutionContext/*FilterByInfo AdditionalParametersType Common.MyClaim.'IEnumerable<Common.Claim>'*/, Common.MyClaim[]> filter_Function =
                (repository, claims, executionContext) =>
			{
                var securityClaims = claims.Select(c => new Rhetos.Security.Claim(c.ClaimResource, c.ClaimRight)).ToList();
                var authorizations = executionContext.AuthorizationManager.GetAuthorizations(securityClaims);
			
                return claims.Zip(authorizations, (claim, authorized) => new Common.MyClaim {
                        ID = claim.ID,
                        Applies = authorized
                    }).ToArray();
             };

            return filter_Function(_domRepository, filter_Parameter, _executionContext/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'IEnumerable<Common.Claim>'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.MyClaim*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Principal*/
    public class Principal_Repository : /*DataStructureInfo OverrideBaseType Common.Principal*/ Common.OrmRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.QueryableRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.ReadableRepositoryBase<Common.Principal> // global::Common.RepositoryBase
        , IWritableRepository<Common.Principal>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Principal*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Principal*/

        public Principal_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Principal*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Principal*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Principal[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Principal> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Principal*/
            return _executionContext.EntityFrameworkContext.Common_Principal.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Principal> insertedNew, IEnumerable<Common.Principal> updatedNew, IEnumerable<Common.Principal> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Principal*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Principal.Name", "256" },
                        "DataStructure:Common.Principal,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Principal*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.Principal*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_Principal> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_Principal>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Principal>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_Principal> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_Principal>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Principal>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<LightDMS.DocumentStatus> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.LightDMS.DocumentStatus.Query()
                        .Where(child => child.CheckedOutToID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new LightDMS.DocumentStatus { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.LightDMS.DocumentStatus.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalHasRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalHasRole.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalHasRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalHasRole.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Principal*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Principal.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Principal", "Name" },
                        "DataStructure:Common.Principal,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Principal*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Principal.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"PrincipalID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"PrincipalID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"LightDMS.Checkout", @"CreatedByID", @"FK_Checkout_Principal_CreatedByID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.Checkout,Property:CreatedByID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"LightDMS.DocumentStatus", @"CheckedOutToID", @"FK_DocumentStatus_Principal_CheckedOutToID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentStatus,Property:CheckedOutToID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"LightDMS.DocumentVersion", @"CreatedByID", @"FK_DocumentVersion_Principal_CreatedByID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentVersion,Property:CreatedByID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"LightDMS.UndoCheckout", @"CreatedByID", @"FK_UndoCheckout_Principal_CreatedByID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.UndoCheckout,Property:CreatedByID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Principal", @"IX_Principal_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Principal,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Principal*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Principal");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Principal> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalInfos = ((IEnumerable<Rhetos.Dom.DefaultConcepts.IPrincipal>)insertedNew).Concat(updatedNew)
                    .Concat(updatedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }))
                    .Concat(deletedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }));
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Principal*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Principal*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Principal");

                /*DataStructureInfo WritableOrm AfterSave Common.Principal*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Principal*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Principal*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalHasRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.ReadableRepositoryBase<Common.PrincipalHasRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalHasRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalHasRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalHasRole*/

        public PrincipalHasRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalHasRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalHasRole*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.PrincipalHasRole[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_PrincipalHasRole> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.PrincipalHasRole*/
            return _executionContext.EntityFrameworkContext.Common_PrincipalHasRole.AsNoTracking();
        }

        public void Save(IEnumerable<Common.PrincipalHasRole> insertedNew, IEnumerable<Common.PrincipalHasRole> updatedNew, IEnumerable<Common.PrincipalHasRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalHasRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalHasRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalHasRole*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_PrincipalHasRole> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_PrincipalHasRole>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalHasRole>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_PrincipalHasRole> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_PrincipalHasRole>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalHasRole>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalHasRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Principal" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Role" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalHasRole*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_PrincipalHasRole.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_PrincipalHasRole_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalHasRole", @"IX_PrincipalHasRole_Principal_Role"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:Principal Role";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalHasRole*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.PrincipalHasRole");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalHasRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalHasRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalHasRole");

                /*DataStructureInfo WritableOrm AfterSave Common.PrincipalHasRole*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalHasRole*/
            yield break;
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Query(Rhetos.Dom.DefaultConcepts.IPrincipal queryParameter)
        {
            /*QueryWithParameterInfo BeforeQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            Func<Rhetos.Dom.DefaultConcepts.IPrincipal, IQueryable<Common.Queryable.Common_PrincipalHasRole>> queryFunction = parameter => Query().Where(item => item.Principal.ID == parameter.ID);
            var queryResult = queryFunction(queryParameter);
            /*QueryWithParameterInfo AfterQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            return queryResult;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalHasRole.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalHasRole.Principal" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalHasRole.SystemRequiredPrincipal*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Filter(IQueryable<Common.Queryable.Common_PrincipalHasRole> localSource, Common.SystemRequiredPrincipal localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalHasRole>, Common.DomRepository, Common.SystemRequiredPrincipal/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/, IQueryable<Common.Queryable.Common_PrincipalHasRole>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Principal == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/);
        }

        public global::Common.PrincipalHasRole[] Filter(Common.SystemRequiredPrincipal filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredPrincipal/*FilterByInfo AdditionalParametersType Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/, Common.PrincipalHasRole[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalHasRole.Filter(repository.Common.PrincipalHasRole.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalHasRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Role*/
    public class Role_Repository : /*DataStructureInfo OverrideBaseType Common.Role*/ Common.OrmRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.QueryableRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.ReadableRepositoryBase<Common.Role> // global::Common.RepositoryBase
        , IWritableRepository<Common.Role>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Role*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Role*/

        public Role_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Role*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Role*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Role[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Role> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Role*/
            return _executionContext.EntityFrameworkContext.Common_Role.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Role> insertedNew, IEnumerable<Common.Role> updatedNew, IEnumerable<Common.Role> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Role*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Role.Name", "256" },
                        "DataStructure:Common.Role,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Role*/

            /*DataStructureInfo WritableOrm Initialization Common.Role*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_Role> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_Role>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Role>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_Role> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_Role>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Role>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.RoleInheritsRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RoleInheritsRole.Query()
                        .Where(child => child.UsersFromID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RoleInheritsRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RoleInheritsRole.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.RoleID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Role*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Role.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Role", "Name" },
                        "DataStructure:Common.Role,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Role*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Role.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"RoleID", @"FK_PrincipalHasRole_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"UsersFromID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"PermissionsFromID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"RoleID", @"FK_RolePermission_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Role", @"IX_Role_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Role,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Role*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Role");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Role> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Concat(deletedIds).Select(r => r.ID);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Role*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Role*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Role");

                /*DataStructureInfo WritableOrm AfterSave Common.Role*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Role*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Role*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole_Repository : /*DataStructureInfo OverrideBaseType Common.RoleInheritsRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.ReadableRepositoryBase<Common.RoleInheritsRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.RoleInheritsRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RoleInheritsRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RoleInheritsRole*/

        public RoleInheritsRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RoleInheritsRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RoleInheritsRole*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RoleInheritsRole[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RoleInheritsRole> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RoleInheritsRole*/
            return _executionContext.EntityFrameworkContext.Common_RoleInheritsRole.AsNoTracking();
        }

        public void Save(IEnumerable<Common.RoleInheritsRole> insertedNew, IEnumerable<Common.RoleInheritsRole> updatedNew, IEnumerable<Common.RoleInheritsRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RoleInheritsRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RoleInheritsRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RoleInheritsRole*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_RoleInheritsRole> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_RoleInheritsRole>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RoleInheritsRole>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_RoleInheritsRole> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_RoleInheritsRole>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RoleInheritsRole>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RoleInheritsRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UsersFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.UsersFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "UsersFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:UsersFromID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PermissionsFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.PermissionsFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "PermissionsFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:PermissionsFromID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RoleInheritsRole*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_RoleInheritsRole.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RoleInheritsRole", @"IX_RoleInheritsRole_UsersFrom_PermissionsFrom"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFrom PermissionsFrom";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.RoleInheritsRole*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.RoleInheritsRole");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.UsersFromID)
                        .Concat(updatedOld.Select(item => item.UsersFromID))
                        .Concat(deletedOld.Select(item => item.UsersFromID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RoleInheritsRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RoleInheritsRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RoleInheritsRole");

                /*DataStructureInfo WritableOrm AfterSave Common.RoleInheritsRole*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredUsersFrom()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredUsersFrom(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RoleInheritsRole*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredUsersFrom(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredUsersFrom";
            metadata[@"Property"] = @"UsersFrom";
            /*InvalidDataInfo ErrorMetadata Common.RoleInheritsRole.SystemRequiredUsersFrom*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RoleInheritsRole.UsersFrom" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RoleInheritsRole.SystemRequiredUsersFrom*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_RoleInheritsRole> Filter(IQueryable<Common.Queryable.Common_RoleInheritsRole> localSource, Common.SystemRequiredUsersFrom localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RoleInheritsRole>, Common.DomRepository, Common.SystemRequiredUsersFrom/*ComposableFilterByInfo AdditionalParametersType Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/, IQueryable<Common.Queryable.Common_RoleInheritsRole>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.UsersFrom == null);

            /*ComposableFilterByInfo BeforeFilter Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/);
        }

        public global::Common.RoleInheritsRole[] Filter(Common.SystemRequiredUsersFrom filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredUsersFrom/*FilterByInfo AdditionalParametersType Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/, Common.RoleInheritsRole[]> filter_Function =
                (repository, parameter) => repository.Common.RoleInheritsRole.Filter(repository.Common.RoleInheritsRole.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.RoleInheritsRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalPermission*/
    public class PrincipalPermission_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalPermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.ReadableRepositoryBase<Common.PrincipalPermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalPermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalPermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalPermission*/

        public PrincipalPermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalPermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalPermission*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.PrincipalPermission[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_PrincipalPermission> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.PrincipalPermission*/
            return _executionContext.EntityFrameworkContext.Common_PrincipalPermission.AsNoTracking();
        }

        public void Save(IEnumerable<Common.PrincipalPermission> insertedNew, IEnumerable<Common.PrincipalPermission> updatedNew, IEnumerable<Common.PrincipalPermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalPermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalPermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalPermission*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_PrincipalPermission> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_PrincipalPermission>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalPermission>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_PrincipalPermission> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_PrincipalPermission>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalPermission>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalPermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Principal" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Claim" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "IsAuthorized" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalPermission*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_PrincipalPermission.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_PrincipalPermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalPermission", @"IX_PrincipalPermission_Principal_Claim"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:Principal Claim";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalPermission*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.PrincipalPermission");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalPermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalPermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalPermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalPermission");

                /*DataStructureInfo WritableOrm AfterSave Common.PrincipalPermission*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalPermission*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Principal" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalPermission.SystemRequiredPrincipal*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Claim" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalPermission.SystemRequiredClaim*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> localSource, Common.SystemRequiredPrincipal localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalPermission>, Common.DomRepository, Common.SystemRequiredPrincipal/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/, IQueryable<Common.Queryable.Common_PrincipalPermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Principal == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/);
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> localSource, Common.SystemRequiredClaim localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalPermission>, Common.DomRepository, Common.SystemRequiredClaim/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredClaim'*/, IQueryable<Common.Queryable.Common_PrincipalPermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Claim == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredClaim'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredClaim'*/);
        }

        public global::Common.PrincipalPermission[] Filter(Common.SystemRequiredPrincipal filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredPrincipal/*FilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/, Common.PrincipalPermission[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalPermission.Filter(repository.Common.PrincipalPermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/);
        }

        public global::Common.PrincipalPermission[] Filter(Common.SystemRequiredClaim filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredClaim/*FilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredClaim'*/, Common.PrincipalPermission[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalPermission.Filter(repository.Common.PrincipalPermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredClaim'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalPermission*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RolePermission*/
    public class RolePermission_Repository : /*DataStructureInfo OverrideBaseType Common.RolePermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.ReadableRepositoryBase<Common.RolePermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.RolePermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RolePermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RolePermission*/

        public RolePermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RolePermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RolePermission*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RolePermission[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RolePermission> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RolePermission*/
            return _executionContext.EntityFrameworkContext.Common_RolePermission.AsNoTracking();
        }

        public void Save(IEnumerable<Common.RolePermission> insertedNew, IEnumerable<Common.RolePermission> updatedNew, IEnumerable<Common.RolePermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RolePermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RolePermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RolePermission*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.Common_RolePermission> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.Common_RolePermission>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RolePermission>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.Common_RolePermission> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.Common_RolePermission>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RolePermission>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RolePermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Role" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Claim" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.RolePermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "IsAuthorized" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RolePermission*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_RolePermission.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RolePermission_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_RolePermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RolePermission", @"IX_RolePermission_Role_Claim"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:Role Claim";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.RolePermission*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.RolePermission");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RolePermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.RoleID)
                        .Concat(updatedOld.Select(item => item.RoleID))
                        .Concat(deletedOld.Select(item => item.RoleID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RolePermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RolePermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RolePermission");

                /*DataStructureInfo WritableOrm AfterSave Common.RolePermission*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredRole()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredRole(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RolePermission*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredRole(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredRole";
            metadata[@"Property"] = @"Role";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredRole*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RolePermission.Role" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RolePermission.SystemRequiredRole*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RolePermission.Claim" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RolePermission.SystemRequiredClaim*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> localSource, Common.SystemRequiredRole localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RolePermission>, Common.DomRepository, Common.SystemRequiredRole/*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredRole'*/, IQueryable<Common.Queryable.Common_RolePermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Role == null);

            /*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredRole'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredRole'*/);
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> localSource, Common.SystemRequiredClaim localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RolePermission>, Common.DomRepository, Common.SystemRequiredClaim/*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredClaim'*/, IQueryable<Common.Queryable.Common_RolePermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Claim == null);

            /*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredClaim'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredClaim'*/);
        }

        public global::Common.RolePermission[] Filter(Common.SystemRequiredRole filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredRole/*FilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredRole'*/, Common.RolePermission[]> filter_Function =
                (repository, parameter) => repository.Common.RolePermission.Filter(repository.Common.RolePermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredRole'*/);
        }

        public global::Common.RolePermission[] Filter(Common.SystemRequiredClaim filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredClaim/*FilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredClaim'*/, Common.RolePermission[]> filter_Function =
                (repository, parameter) => repository.Common.RolePermission.Filter(repository.Common.RolePermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredClaim'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.RolePermission*/
    }

    /*ModuleInfo HelperNamespaceMembers Common*/
}

namespace LightDMS._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using LightDMS*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Checkout_Repository _Checkout_Repository;
        public Checkout_Repository Checkout { get { return _Checkout_Repository ?? (_Checkout_Repository = (Checkout_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.Checkout")); } }

        private DocumentEvent_Repository _DocumentEvent_Repository;
        public DocumentEvent_Repository DocumentEvent { get { return _DocumentEvent_Repository ?? (_DocumentEvent_Repository = (DocumentEvent_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.DocumentEvent")); } }

        private DocumentStatusBeforeEvent_Repository _DocumentStatusBeforeEvent_Repository;
        public DocumentStatusBeforeEvent_Repository DocumentStatusBeforeEvent { get { return _DocumentStatusBeforeEvent_Repository ?? (_DocumentStatusBeforeEvent_Repository = (DocumentStatusBeforeEvent_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.DocumentStatusBeforeEvent")); } }

        private ComputeDocumentStatus_Repository _ComputeDocumentStatus_Repository;
        public ComputeDocumentStatus_Repository ComputeDocumentStatus { get { return _ComputeDocumentStatus_Repository ?? (_ComputeDocumentStatus_Repository = (ComputeDocumentStatus_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.ComputeDocumentStatus")); } }

        private DocumentStatus_Repository _DocumentStatus_Repository;
        public DocumentStatus_Repository DocumentStatus { get { return _DocumentStatus_Repository ?? (_DocumentStatus_Repository = (DocumentStatus_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.DocumentStatus")); } }

        private DocumentVersion_Repository _DocumentVersion_Repository;
        public DocumentVersion_Repository DocumentVersion { get { return _DocumentVersion_Repository ?? (_DocumentVersion_Repository = (DocumentVersion_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.DocumentVersion")); } }

        private DocumentVersionExt_Repository _DocumentVersionExt_Repository;
        public DocumentVersionExt_Repository DocumentVersionExt { get { return _DocumentVersionExt_Repository ?? (_DocumentVersionExt_Repository = (DocumentVersionExt_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.DocumentVersionExt")); } }

        private FileContent_Repository _FileContent_Repository;
        public FileContent_Repository FileContent { get { return _FileContent_Repository ?? (_FileContent_Repository = (FileContent_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.FileContent")); } }

        private DocumentRepository_Repository _DocumentRepository_Repository;
        public DocumentRepository_Repository DocumentRepository { get { return _DocumentRepository_Repository ?? (_DocumentRepository_Repository = (DocumentRepository_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.DocumentRepository")); } }

        private UndoCheckout_Repository _UndoCheckout_Repository;
        public UndoCheckout_Repository UndoCheckout { get { return _UndoCheckout_Repository ?? (_UndoCheckout_Repository = (UndoCheckout_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"LightDMS.UndoCheckout")); } }

        /*ModuleInfo RepositoryMembers LightDMS*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.Checkout*/
    public class Checkout_Repository : /*DataStructureInfo OverrideBaseType LightDMS.Checkout*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_Checkout, LightDMS.Checkout> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_Checkout, LightDMS.Checkout> // Common.ReadableRepositoryBase<LightDMS.Checkout> // global::Common.RepositoryBase
        , IWritableRepository<LightDMS.Checkout>, IValidateRepository/*DataStructureInfo RepositoryInterface LightDMS.Checkout*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.Checkout*/

        public Checkout_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments LightDMS.Checkout*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.Checkout*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.Checkout[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_Checkout> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.Checkout*/
            return _executionContext.EntityFrameworkContext.LightDMS_Checkout.AsNoTracking();
        }

        public void Save(IEnumerable<LightDMS.Checkout> insertedNew, IEnumerable<LightDMS.Checkout> updatedNew, IEnumerable<LightDMS.Checkout> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext LightDMS.Checkout*/

            if (checkUserPermissions)
            {
                var invalidItem = insertedNew.Where(newItem => newItem.CreatedDate != null).FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "CreatedDate", "LightDMS.Checkout" },
                        "DataStructure:LightDMS.Checkout,ID:" + invalidItem.ID + ",Property:CreatedDate",
                        null);
            
            }

            /*DataStructureInfo WritableOrm ArgumentValidation LightDMS.Checkout*/

            {
                var userName = _executionContext.UserInfo.UserName;
                var userIds = _domRepository.Common.Principal.Query(p => p.Name == userName).Select(p => p.ID).ToList();

                if (userIds.Count > 1)
                    throw new Rhetos.UserException("The system is not configured properly: There are multiple principals with the same username '{0}'. Please contact your system administrator.", new[] { userName }, null, null);
                if (userIds.Count == 0)
                    throw new Rhetos.UserException("The system is not configured properly: There are no principals with username '{0}'. Please contact your system administrator.", new[] { userName }, null, null);
                Guid userId = userIds.Single();

                foreach (var newItem in insertedNew)
                    if(newItem.CreatedByID == null)
                        newItem.CreatedByID = userId;
            }
            { 
                var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

                foreach (var newItem in insertedNew)
                    if(newItem.CreatedDate == null)
                        newItem.CreatedDate = now;
            }
                            { // DeadlockPrevention
                    /*
    Copyright (C) 2014 Omega software d.o.o.

    This file is part of Rhetos.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

string lockDocument =
	string.Join("\r\n",
		insertedNew.Concat(updatedNew).Concat(deletedIds)
		.Where(item => item.DocumentID.HasValue)
		.Select(item => item.DocumentID)
		.Distinct()
		.Select(documentId => "exec sp_getapplock 'LightDms.Document_" + documentId + "', 'Exclusive';"));

_executionContext.SqlExecuter.ExecuteSql(lockDocument);
                }

/*DataStructureInfo WritableOrm Initialization LightDMS.Checkout*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.LightDMS_Checkout> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.LightDMS_Checkout>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_Checkout>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.LightDMS_Checkout> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.LightDMS_Checkout>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_Checkout>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (checkUserPermissions)
            {
                var changes = updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem });
                foreach (var change in changes)
                    if (change.newItem.CreatedDate == null && change.oldItem.CreatedDate != null)
                        change.newItem.CreatedDate = change.oldItem.CreatedDate;
                var invalidItem = changes
                    .Where(change => change.newItem.CreatedDate != null && !change.newItem.CreatedDate.Equals(change.oldItem.CreatedDate) || change.newItem.CreatedDate == null && change.oldItem.CreatedDate != null)
                    .Select(change => change.newItem)
                    .FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "CreatedDate", "LightDMS.Checkout" },
                        "DataStructure:LightDMS.Checkout,ID:" + invalidItem.ID + ",Property:CreatedDate",
                        null);
            
            }

            Func<IEnumerable<Common.Queryable.LightDMS_Checkout>, Guid[]> filterLoadKeepSynchronizedOnChangedItems1 =
                /*
    Copyright (C) 2014 Omega software d.o.o.

    This file is part of Rhetos.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

changedItems => changedItems.Where(item => item.DocumentID.HasValue).Select(item => item.DocumentID.Value).Distinct().ToArray();
            Guid[] filterKeepSynchronizedOnChangedItems1Old = filterLoadKeepSynchronizedOnChangedItems1(updated.Concat(deleted));

            /*DataStructureInfo WritableOrm OldDataLoaded LightDMS.Checkout*/

            /*DataStructureInfo WritableOrm ProcessedOldData LightDMS.Checkout*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.LightDMS_Checkout.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_Checkout_Principal_CreatedByID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.Checkout,Property:CreatedByID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"LightDMS.DocumentRepository", @"ID", @"FK_Checkout_DocumentRepository_RepositoryID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.Checkout,Property:RepositoryID,Referenced:LightDMS.DocumentRepository";
                /*DataStructureInfo WritableOrm OnDatabaseError LightDMS.Checkout*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "LightDMS.Checkout");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.LightDMS_Checkout> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*OverrideRecompute KeepSynchronizedInfo LightDMS.DocumentStatus.LightDMS.ComputeDocumentStatus.1*/
                {
                    var filteredNew = filterLoadKeepSynchronizedOnChangedItems1(inserted.Concat(updated));
                    Guid[] optimizedFilter;
                    if (KeepSynchronizedHelper.OptimizeFiltersUnion(filteredNew, filterKeepSynchronizedOnChangedItems1Old, out optimizedFilter))
                        _domRepository.LightDMS.DocumentStatus.RecomputeFromComputeDocumentStatus(optimizedFilter);
                    else
                    {
                        _domRepository.LightDMS.DocumentStatus.RecomputeFromComputeDocumentStatus(filterKeepSynchronizedOnChangedItems1Old);
                        _domRepository.LightDMS.DocumentStatus.RecomputeFromComputeDocumentStatus(filteredNew);
                    }
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 LightDMS.Checkout*/

                /*DataStructureInfo WritableOrm OnSaveTag2 LightDMS.Checkout*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "LightDMS.Checkout");

                /*DataStructureInfo WritableOrm AfterSave LightDMS.Checkout*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new MultipleDocumentCheckout()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_MultipleDocumentCheckout(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new NullDocumentCheckout()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_NullDocumentCheckout(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredCreatedBy()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredCreatedBy(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredCreatedDate()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredCreatedDate(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate LightDMS.Checkout*/
            yield break;
        }

        public IQueryable<Common.Queryable.LightDMS_Checkout> Filter(IQueryable<Common.Queryable.LightDMS_Checkout> localSource, MultipleDocumentCheckout localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_Checkout>, Common.DomRepository, MultipleDocumentCheckout/*ComposableFilterByInfo AdditionalParametersType LightDMS.Checkout.MultipleDocumentCheckout*/, IQueryable<Common.Queryable.LightDMS_Checkout>> filterFunction =
            (items, repository, filterParameter) =>
		{
            var itemsToCheck = items.Select(i => i.ID).ToList();
    		var invalidItems = repository.LightDMS.DocumentStatusBeforeEvent.Query(i => itemsToCheck.Contains(i.ID) && i.CheckoutID != null).Select(i => i.ID).ToList();
    		return items.Where(i => invalidItems.Contains(i.ID));
	  	};

            /*ComposableFilterByInfo BeforeFilter LightDMS.Checkout.MultipleDocumentCheckout*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.Checkout.MultipleDocumentCheckout*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_MultipleDocumentCheckout(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Akcija nije moguća jer je sadržaj već rezerviran za uređivanje.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"MultipleDocumentCheckout";
            /*InvalidDataInfo ErrorMetadata LightDMS.Checkout.MultipleDocumentCheckout*/
            /*InvalidDataInfo OverrideUserMessages LightDMS.Checkout.MultipleDocumentCheckout*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.LightDMS_Checkout> Filter(IQueryable<Common.Queryable.LightDMS_Checkout> localSource, NullDocumentCheckout localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_Checkout>, Common.DomRepository, NullDocumentCheckout/*ComposableFilterByInfo AdditionalParametersType LightDMS.Checkout.NullDocumentCheckout*/, IQueryable<Common.Queryable.LightDMS_Checkout>> filterFunction =
            (items, repository, filterParameter) =>
		{
			var itemsToCheck = items.Select(a => a.DocumentID).ToList();
            var validItems = repository.LightDMS.DocumentVersion.Query(i => itemsToCheck.Contains(i.DocumentID)).Select(i => i.DocumentID).ToList();
            return items.Where(i => !validItems.Contains(i.DocumentID));
	  	};

            /*ComposableFilterByInfo BeforeFilter LightDMS.Checkout.NullDocumentCheckout*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.Checkout.NullDocumentCheckout*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_NullDocumentCheckout(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Akcija nije moguća jer ne postoji sadržaj za preuzimanje.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"NullDocumentCheckout";
            /*InvalidDataInfo ErrorMetadata LightDMS.Checkout.NullDocumentCheckout*/
            /*InvalidDataInfo OverrideUserMessages LightDMS.Checkout.NullDocumentCheckout*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredCreatedBy(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredCreatedBy";
            metadata[@"Property"] = @"CreatedBy";
            /*InvalidDataInfo ErrorMetadata LightDMS.Checkout.SystemRequiredCreatedBy*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference LightDMS.Checkout.CreatedBy" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages LightDMS.Checkout.SystemRequiredCreatedBy*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredCreatedDate(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredCreatedDate";
            metadata[@"Property"] = @"CreatedDate";
            /*InvalidDataInfo ErrorMetadata LightDMS.Checkout.SystemRequiredCreatedDate*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"DateTime LightDMS.Checkout.CreatedDate" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages LightDMS.Checkout.SystemRequiredCreatedDate*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.LightDMS_Checkout> Filter(IQueryable<Common.Queryable.LightDMS_Checkout> localSource, LightDMS.SystemRequiredCreatedBy localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_Checkout>, Common.DomRepository, LightDMS.SystemRequiredCreatedBy/*ComposableFilterByInfo AdditionalParametersType LightDMS.Checkout.'LightDMS.SystemRequiredCreatedBy'*/, IQueryable<Common.Queryable.LightDMS_Checkout>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.CreatedBy == null);

            /*ComposableFilterByInfo BeforeFilter LightDMS.Checkout.'LightDMS.SystemRequiredCreatedBy'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.Checkout.'LightDMS.SystemRequiredCreatedBy'*/);
        }

        public IQueryable<Common.Queryable.LightDMS_Checkout> Filter(IQueryable<Common.Queryable.LightDMS_Checkout> localSource, LightDMS.SystemRequiredCreatedDate localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_Checkout>, Common.DomRepository, LightDMS.SystemRequiredCreatedDate/*ComposableFilterByInfo AdditionalParametersType LightDMS.Checkout.'LightDMS.SystemRequiredCreatedDate'*/, IQueryable<Common.Queryable.LightDMS_Checkout>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.CreatedDate == null);

            /*ComposableFilterByInfo BeforeFilter LightDMS.Checkout.'LightDMS.SystemRequiredCreatedDate'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.Checkout.'LightDMS.SystemRequiredCreatedDate'*/);
        }

        public global::LightDMS.Checkout[] Filter(MultipleDocumentCheckout filter_Parameter)
        {
            Func<Common.DomRepository, MultipleDocumentCheckout/*FilterByInfo AdditionalParametersType LightDMS.Checkout.MultipleDocumentCheckout*/, LightDMS.Checkout[]> filter_Function =
                (repository, parameter) => repository.LightDMS.Checkout.Filter(repository.LightDMS.Checkout.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.Checkout.MultipleDocumentCheckout*/);
        }

        public global::LightDMS.Checkout[] Filter(NullDocumentCheckout filter_Parameter)
        {
            Func<Common.DomRepository, NullDocumentCheckout/*FilterByInfo AdditionalParametersType LightDMS.Checkout.NullDocumentCheckout*/, LightDMS.Checkout[]> filter_Function =
                (repository, parameter) => repository.LightDMS.Checkout.Filter(repository.LightDMS.Checkout.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.Checkout.NullDocumentCheckout*/);
        }

        public global::LightDMS.Checkout[] Filter(LightDMS.SystemRequiredCreatedBy filter_Parameter)
        {
            Func<Common.DomRepository, LightDMS.SystemRequiredCreatedBy/*FilterByInfo AdditionalParametersType LightDMS.Checkout.'LightDMS.SystemRequiredCreatedBy'*/, LightDMS.Checkout[]> filter_Function =
                (repository, parameter) => repository.LightDMS.Checkout.Filter(repository.LightDMS.Checkout.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.Checkout.'LightDMS.SystemRequiredCreatedBy'*/);
        }

        public global::LightDMS.Checkout[] Filter(LightDMS.SystemRequiredCreatedDate filter_Parameter)
        {
            Func<Common.DomRepository, LightDMS.SystemRequiredCreatedDate/*FilterByInfo AdditionalParametersType LightDMS.Checkout.'LightDMS.SystemRequiredCreatedDate'*/, LightDMS.Checkout[]> filter_Function =
                (repository, parameter) => repository.LightDMS.Checkout.Filter(repository.LightDMS.Checkout.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.Checkout.'LightDMS.SystemRequiredCreatedDate'*/);
        }

        /*DataStructureInfo RepositoryMembers LightDMS.Checkout*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.DocumentEvent*/
    public class DocumentEvent_Repository : /*DataStructureInfo OverrideBaseType LightDMS.DocumentEvent*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_DocumentEvent, LightDMS.DocumentEvent> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_DocumentEvent, LightDMS.DocumentEvent> // Common.ReadableRepositoryBase<LightDMS.DocumentEvent> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface LightDMS.DocumentEvent*/
    {
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.DocumentEvent*/

        public DocumentEvent_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments LightDMS.DocumentEvent*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.DocumentEvent*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.DocumentEvent[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_DocumentEvent> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.DocumentEvent*/
            return _executionContext.EntityFrameworkContext.LightDMS_DocumentEvent.AsNoTracking();
        }

        public global::LightDMS.DocumentEvent[] Filter(Rhetos.Dom.DefaultConcepts.FilterSubtype filter_Parameter)
        {
            Func<Common.DomRepository, Rhetos.Dom.DefaultConcepts.FilterSubtype/*FilterByInfo AdditionalParametersType LightDMS.DocumentEvent.'Rhetos.Dom.DefaultConcepts.FilterSubtype'*/, LightDMS.DocumentEvent[]> filter_Function =
                (repository, parameter) =>
                {{
                    Expression<Func<Common.Queryable.LightDMS_DocumentEvent, bool>> filterExpression = null;
                    parameter.ImplementationName = parameter.ImplementationName ?? "";
                    if (parameter.Subtype == @"LightDMS.Checkout" && parameter.ImplementationName == @"")
                        filterExpression = item => item.CheckoutID != null;
                    if (parameter.Subtype == @"LightDMS.DocumentVersion" && parameter.ImplementationName == @"")
                        filterExpression = item => item.DocumentVersionID != null;
                    if (parameter.Subtype == @"LightDMS.UndoCheckout" && parameter.ImplementationName == @"")
                        filterExpression = item => item.UndoCheckoutID != null;
                    /*PolymorphicInfo SetFilterExpression LightDMS.DocumentEvent*/
                    if (filterExpression == null)
                        throw new Rhetos.ClientException(string.Format("Invalid subtype name or implementation name provided: '{0}', '{1}'.",
                            parameter.Subtype, parameter.ImplementationName));
                    return Filter(Query().Where(filterExpression), parameter.Ids).ToSimple().ToArray();
                }};

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.DocumentEvent.'Rhetos.Dom.DefaultConcepts.FilterSubtype'*/);
        }

        /*DataStructureInfo RepositoryMembers LightDMS.DocumentEvent*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.DocumentStatusBeforeEvent*/
    public class DocumentStatusBeforeEvent_Repository : /*DataStructureInfo OverrideBaseType LightDMS.DocumentStatusBeforeEvent*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_DocumentStatusBeforeEvent, LightDMS.DocumentStatusBeforeEvent> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_DocumentStatusBeforeEvent, LightDMS.DocumentStatusBeforeEvent> // Common.ReadableRepositoryBase<LightDMS.DocumentStatusBeforeEvent> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface LightDMS.DocumentStatusBeforeEvent*/
    {
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.DocumentStatusBeforeEvent*/

        public DocumentStatusBeforeEvent_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments LightDMS.DocumentStatusBeforeEvent*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.DocumentStatusBeforeEvent*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.DocumentStatusBeforeEvent[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_DocumentStatusBeforeEvent> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.DocumentStatusBeforeEvent*/
            return _executionContext.EntityFrameworkContext.LightDMS_DocumentStatusBeforeEvent.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers LightDMS.DocumentStatusBeforeEvent*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.ComputeDocumentStatus*/
    public class ComputeDocumentStatus_Repository : /*DataStructureInfo OverrideBaseType LightDMS.ComputeDocumentStatus*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_ComputeDocumentStatus, LightDMS.ComputeDocumentStatus> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_ComputeDocumentStatus, LightDMS.ComputeDocumentStatus> // Common.ReadableRepositoryBase<LightDMS.ComputeDocumentStatus> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface LightDMS.ComputeDocumentStatus*/
    {
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.ComputeDocumentStatus*/

        public ComputeDocumentStatus_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments LightDMS.ComputeDocumentStatus*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.ComputeDocumentStatus*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.ComputeDocumentStatus[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_ComputeDocumentStatus> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.ComputeDocumentStatus*/
            return _executionContext.EntityFrameworkContext.LightDMS_ComputeDocumentStatus.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers LightDMS.ComputeDocumentStatus*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.DocumentStatus*/
    public class DocumentStatus_Repository : /*DataStructureInfo OverrideBaseType LightDMS.DocumentStatus*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_DocumentStatus, LightDMS.DocumentStatus> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_DocumentStatus, LightDMS.DocumentStatus> // Common.ReadableRepositoryBase<LightDMS.DocumentStatus> // global::Common.RepositoryBase
        , IWritableRepository<LightDMS.DocumentStatus>, IValidateRepository/*DataStructureInfo RepositoryInterface LightDMS.DocumentStatus*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.DocumentStatus*/

        public DocumentStatus_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments LightDMS.DocumentStatus*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.DocumentStatus*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.DocumentStatus[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_DocumentStatus> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.DocumentStatus*/
            return _executionContext.EntityFrameworkContext.LightDMS_DocumentStatus.AsNoTracking();
        }

        public void Save(IEnumerable<LightDMS.DocumentStatus> insertedNew, IEnumerable<LightDMS.DocumentStatus> updatedNew, IEnumerable<LightDMS.DocumentStatus> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext LightDMS.DocumentStatus*/

            /*DataStructureInfo WritableOrm ArgumentValidation LightDMS.DocumentStatus*/

            /*DataStructureInfo WritableOrm Initialization LightDMS.DocumentStatus*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.LightDMS_DocumentStatus> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.LightDMS_DocumentStatus>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_DocumentStatus>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.LightDMS_DocumentStatus> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.LightDMS_DocumentStatus>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_DocumentStatus>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded LightDMS.DocumentStatus*/

            /*DataStructureInfo WritableOrm ProcessedOldData LightDMS.DocumentStatus*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.LightDMS_DocumentStatus.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_DocumentStatus_Principal_CheckedOutToID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentStatus,Property:CheckedOutToID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"LightDMS.DocumentVersion", @"ID", @"FK_DocumentStatus_DocumentVersion_LastVersionID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentStatus,Property:LastVersionID,Referenced:LightDMS.DocumentVersion";
                /*DataStructureInfo WritableOrm OnDatabaseError LightDMS.DocumentStatus*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "LightDMS.DocumentStatus");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.LightDMS_DocumentStatus> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 LightDMS.DocumentStatus*/

                /*DataStructureInfo WritableOrm OnSaveTag2 LightDMS.DocumentStatus*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "LightDMS.DocumentStatus");

                /*DataStructureInfo WritableOrm AfterSave LightDMS.DocumentStatus*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate LightDMS.DocumentStatus*/
            yield break;
        }

        public IEnumerable<LightDMS.DocumentStatus> RecomputeFromComputeDocumentStatus(object filterLoad = null, Func<IEnumerable<LightDMS.DocumentStatus>, IEnumerable<LightDMS.DocumentStatus>> filterSave = null)
        {
            /*EntityComputedFromInfo OverrideDefaultFilters LightDMS.DocumentStatus.LightDMS.ComputeDocumentStatus*/
            filterSave = filterSave ?? FilterSaveKeepSynchronizedOnChangedItems_LightDMS_ComputeDocumentStatus;
            filterLoad = filterLoad ?? new FilterAll();
            filterSave = filterSave ?? (x => x);

            var sourceRepository = _executionContext.GenericRepositories.GetGenericRepository<LightDMS.ComputeDocumentStatus>();
            var sourceItems = sourceRepository.Load(filterLoad);
            var newItems = sourceItems.Select(sourceItem => new LightDMS.DocumentStatus {
                ID = sourceItem.ID,
                LastEventID = sourceItem.LastEventID,
                CheckedOutToID = sourceItem.CheckedOutToID,
                IsCheckout = sourceItem.IsCheckout,
                LastVersionID = sourceItem.LastVersionID,
                /*EntityComputedFromInfo CloneProperty LightDMS.DocumentStatus.LightDMS.ComputeDocumentStatus*/ }).ToList();

            var destinationRepository = _executionContext.GenericRepositories.GetGenericRepository<LightDMS.DocumentStatus>();
            destinationRepository.InsertOrUpdateOrDelete(
                newItems,
                sameRecord: /*EntityComputedFromInfo OverrideKeyComparer LightDMS.DocumentStatus.LightDMS.ComputeDocumentStatus*/ null, // Default is comparison by ID.
                sameValue: (x, y) =>
                {
                    if (x.LastEventID == null && y.LastEventID != null || x.LastEventID != null && !x.LastEventID.Equals(y.LastEventID)) return false;
                    if (x.CheckedOutToID == null && y.CheckedOutToID != null || x.CheckedOutToID != null && !x.CheckedOutToID.Equals(y.CheckedOutToID)) return false;
                    if (x.IsCheckout == null && y.IsCheckout != null || x.IsCheckout != null && !x.IsCheckout.Equals(y.IsCheckout)) return false;
                    if (x.LastVersionID == null && y.LastVersionID != null || x.LastVersionID != null && !x.LastVersionID.Equals(y.LastVersionID)) return false;
                    /*EntityComputedFromInfo CompareValueProperty LightDMS.DocumentStatus.LightDMS.ComputeDocumentStatus*/
                    return true;
                },
                filterLoad: filterLoad,
                assign: (destination, source) =>
                {
                    destination.LastEventID = source.LastEventID;
                    destination.CheckedOutToID = source.CheckedOutToID;
                    destination.IsCheckout = source.IsCheckout;
                    destination.LastVersionID = source.LastVersionID;
                    /*EntityComputedFromInfo AssignProperty LightDMS.DocumentStatus.LightDMS.ComputeDocumentStatus*/
                },
                beforeSave: (ref IEnumerable<LightDMS.DocumentStatus> toInsert, ref IEnumerable<LightDMS.DocumentStatus> toUpdate, ref IEnumerable<LightDMS.DocumentStatus> toDelete) =>
                {
                    toInsert = filterSave(toInsert);
                    toUpdate = filterSave(toUpdate);
                    toDelete = filterSave(toDelete);
                });
            return newItems;
        }
        
        public IEnumerable<LightDMS.DocumentStatus> FilterSaveKeepSynchronizedOnChangedItems_LightDMS_ComputeDocumentStatus(IEnumerable<LightDMS.DocumentStatus> items)
        {
            return items;
        }

        /*DataStructureInfo RepositoryMembers LightDMS.DocumentStatus*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.DocumentVersion*/
    public class DocumentVersion_Repository : /*DataStructureInfo OverrideBaseType LightDMS.DocumentVersion*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_DocumentVersion, LightDMS.DocumentVersion> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_DocumentVersion, LightDMS.DocumentVersion> // Common.ReadableRepositoryBase<LightDMS.DocumentVersion> // global::Common.RepositoryBase
        , IWritableRepository<LightDMS.DocumentVersion>, IValidateRepository/*DataStructureInfo RepositoryInterface LightDMS.DocumentVersion*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.DocumentVersion*/

        public DocumentVersion_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments LightDMS.DocumentVersion*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.DocumentVersion*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.DocumentVersion[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_DocumentVersion> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.DocumentVersion*/
            return _executionContext.EntityFrameworkContext.LightDMS_DocumentVersion.AsNoTracking();
        }

        public void Save(IEnumerable<LightDMS.DocumentVersion> insertedNew, IEnumerable<LightDMS.DocumentVersion> updatedNew, IEnumerable<LightDMS.DocumentVersion> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext LightDMS.DocumentVersion*/

            if (checkUserPermissions)
            {
                var invalidItem = insertedNew.Where(newItem => newItem.CreatedDate != null).FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "CreatedDate", "LightDMS.DocumentVersion" },
                        "DataStructure:LightDMS.DocumentVersion,ID:" + invalidItem.ID + ",Property:CreatedDate",
                        null);
            
            }

            /*DataStructureInfo WritableOrm ArgumentValidation LightDMS.DocumentVersion*/

            {
                var userName = _executionContext.UserInfo.UserName;
                var userIds = _domRepository.Common.Principal.Query(p => p.Name == userName).Select(p => p.ID).ToList();

                if (userIds.Count > 1)
                    throw new Rhetos.UserException("The system is not configured properly: There are multiple principals with the same username '{0}'. Please contact your system administrator.", new[] { userName }, null, null);
                if (userIds.Count == 0)
                    throw new Rhetos.UserException("The system is not configured properly: There are no principals with username '{0}'. Please contact your system administrator.", new[] { userName }, null, null);
                Guid userId = userIds.Single();

                foreach (var newItem in insertedNew)
                    if(newItem.CreatedByID == null)
                        newItem.CreatedByID = userId;
            }
            { 
                var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

                foreach (var newItem in insertedNew)
                    if(newItem.CreatedDate == null)
                        newItem.CreatedDate = now;
            }
                            { // DeadlockPrevention
                    /*
    Copyright (C) 2014 Omega software d.o.o.

    This file is part of Rhetos.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

string lockDocument =
	string.Join("\r\n",
		insertedNew.Concat(updatedNew).Concat(deletedIds)
		.Where(item => item.DocumentID.HasValue)
		.Select(item => item.DocumentID)
		.Distinct()
		.Select(documentId => "exec sp_getapplock 'LightDms.Document_" + documentId + "', 'Exclusive';"));

_executionContext.SqlExecuter.ExecuteSql(lockDocument);
                }

/*DataStructureInfo WritableOrm Initialization LightDMS.DocumentVersion*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.LightDMS_DocumentVersion> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.LightDMS_DocumentVersion>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_DocumentVersion>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.LightDMS_DocumentVersion> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.LightDMS_DocumentVersion>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_DocumentVersion>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<LightDMS.DocumentStatus> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.LightDMS.DocumentStatus.Query()
                        .Where(child => child.LastVersionID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new LightDMS.DocumentStatus { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.LightDMS.DocumentStatus.Delete(childItems);
            }

            if (checkUserPermissions)
            {
                var changes = updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem });
                foreach (var change in changes)
                    if (change.newItem.CreatedDate == null && change.oldItem.CreatedDate != null)
                        change.newItem.CreatedDate = change.oldItem.CreatedDate;
                var invalidItem = changes
                    .Where(change => change.newItem.CreatedDate != null && !change.newItem.CreatedDate.Equals(change.oldItem.CreatedDate) || change.newItem.CreatedDate == null && change.oldItem.CreatedDate != null)
                    .Select(change => change.newItem)
                    .FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "CreatedDate", "LightDMS.DocumentVersion" },
                        "DataStructure:LightDMS.DocumentVersion,ID:" + invalidItem.ID + ",Property:CreatedDate",
                        null);
            
            }

            AutoCodeHelper.UpdateCodesWithoutCache(
                _executionContext.SqlExecuter, "LightDMS.DocumentVersion", "VersionNumber",
                insertedNew.Select(item => AutoCodeItem.Create(item, item.VersionNumber, Rhetos.Utilities.SqlUtility.GuidToString(item.DocumentID)/*AutoCodePropertyInfo Grouping LightDMS.DocumentVersion.VersionNumber*/)).ToList(),
                (item, newCode) => item.VersionNumber = newCode,
                @"DocumentID", true/*AutoCodePropertyInfo GroupColumnMetadata LightDMS.DocumentVersion.VersionNumber*/);

            Func<IEnumerable<Common.Queryable.LightDMS_DocumentVersion>, Guid[]> filterLoadKeepSynchronizedOnChangedItems2 =
                /*
    Copyright (C) 2014 Omega software d.o.o.

    This file is part of Rhetos.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

changedItems => changedItems.Where(item => item.DocumentID.HasValue).Select(item => item.DocumentID.Value).Distinct().ToArray();
            Guid[] filterKeepSynchronizedOnChangedItems2Old = filterLoadKeepSynchronizedOnChangedItems2(updated.Concat(deleted));

            /*DataStructureInfo WritableOrm OldDataLoaded LightDMS.DocumentVersion*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.FileName == null || string.IsNullOrWhiteSpace(item.FileName) /*RequiredPropertyInfo OrCondition LightDMS.DocumentVersion.FileName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "LightDMS.DocumentVersion", "FileName" },
                        "DataStructure:LightDMS.DocumentVersion,ID:" + invalid.ID.ToString() + ",Property:FileName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.FileContentID == null /*RequiredPropertyInfo OrCondition LightDMS.DocumentVersion.FileContent*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "LightDMS.DocumentVersion", "FileContent" },
                        "DataStructure:LightDMS.DocumentVersion,ID:" + invalid.ID.ToString() + ",Property:FileContentID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData LightDMS.DocumentVersion*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.LightDMS_DocumentVersion.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"LightDMS.DocumentStatus", @"LastVersionID", @"FK_DocumentStatus_DocumentVersion_LastVersionID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentStatus,Property:LastVersionID,Referenced:LightDMS.DocumentVersion";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_DocumentVersion_Principal_CreatedByID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentVersion,Property:CreatedByID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"LightDMS.FileContent", @"ID", @"FK_DocumentVersion_FileContent_FileContentID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentVersion,Property:FileContentID,Referenced:LightDMS.FileContent";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"LightDMS.DocumentRepository", @"ID", @"FK_DocumentVersion_DocumentRepository_RepositoryID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentVersion,Property:RepositoryID,Referenced:LightDMS.DocumentRepository";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"LightDMS.DocumentVersion", @"IX_DocumentVersion_DocumentID_VersionNumber"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentVersion,Property:DocumentID VersionNumber";
                /*DataStructureInfo WritableOrm OnDatabaseError LightDMS.DocumentVersion*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "LightDMS.DocumentVersion");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.LightDMS_DocumentVersion> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*OverrideRecompute KeepSynchronizedInfo LightDMS.DocumentStatus.LightDMS.ComputeDocumentStatus.2*/
                {
                    var filteredNew = filterLoadKeepSynchronizedOnChangedItems2(inserted.Concat(updated));
                    Guid[] optimizedFilter;
                    if (KeepSynchronizedHelper.OptimizeFiltersUnion(filteredNew, filterKeepSynchronizedOnChangedItems2Old, out optimizedFilter))
                        _domRepository.LightDMS.DocumentStatus.RecomputeFromComputeDocumentStatus(optimizedFilter);
                    else
                    {
                        _domRepository.LightDMS.DocumentStatus.RecomputeFromComputeDocumentStatus(filterKeepSynchronizedOnChangedItems2Old);
                        _domRepository.LightDMS.DocumentStatus.RecomputeFromComputeDocumentStatus(filteredNew);
                    }
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 LightDMS.DocumentVersion*/

                /*DataStructureInfo WritableOrm OnSaveTag2 LightDMS.DocumentVersion*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "LightDMS.DocumentVersion");

                /*DataStructureInfo WritableOrm AfterSave LightDMS.DocumentVersion*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new OtherUserDocumentCheckIn()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_OtherUserDocumentCheckIn(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredCreatedBy()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredCreatedBy(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredCreatedDate()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredCreatedDate(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredVersionNumber()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredVersionNumber(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate LightDMS.DocumentVersion*/
            yield break;
        }

        public IQueryable<Common.Queryable.LightDMS_DocumentVersion> Filter(IQueryable<Common.Queryable.LightDMS_DocumentVersion> localSource, OtherUserDocumentCheckIn localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_DocumentVersion>, Common.DomRepository, OtherUserDocumentCheckIn/*ComposableFilterByInfo AdditionalParametersType LightDMS.DocumentVersion.OtherUserDocumentCheckIn*/, IQueryable<Common.Queryable.LightDMS_DocumentVersion>> filterFunction =
            (items, repository, filterParameter) =>
		{
			var itemList = items.Select(x => new { ID = (Guid?)x.ID, DocumentID = x.DocumentID }).ToList();
			var itemListIds = itemList.Select(x => x.ID);
			var itemListDocumentIds = itemList.Select(x => x.DocumentID).Distinct();

			return repository.LightDMS.DocumentEvent.Query()
				.Where(de =>
					itemListIds.Contains(de.DocumentVersionID) &&
					itemListDocumentIds.Contains(de.DocumentID) && // Ne micati. Dodatan uvjet za sprječavanje lockova 
					de.Extension_DocumentStatusBeforeEvent.CheckoutID != null &&
					de.Extension_DocumentStatusBeforeEvent.CheckedOutToID != de.DocumentVersion.CreatedByID)
				.Select(de => de.DocumentVersion);
		}
		;

            /*ComposableFilterByInfo BeforeFilter LightDMS.DocumentVersion.OtherUserDocumentCheckIn*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.DocumentVersion.OtherUserDocumentCheckIn*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_OtherUserDocumentCheckIn(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Akcija nije moguća jer je sadržaj rezerviran za uređivanje od strane drugog korisnika.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"OtherUserDocumentCheckIn";
            /*InvalidDataInfo ErrorMetadata LightDMS.DocumentVersion.OtherUserDocumentCheckIn*/
            /*InvalidDataInfo OverrideUserMessages LightDMS.DocumentVersion.OtherUserDocumentCheckIn*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredCreatedBy(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredCreatedBy";
            metadata[@"Property"] = @"CreatedBy";
            /*InvalidDataInfo ErrorMetadata LightDMS.DocumentVersion.SystemRequiredCreatedBy*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference LightDMS.DocumentVersion.CreatedBy" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages LightDMS.DocumentVersion.SystemRequiredCreatedBy*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredCreatedDate(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredCreatedDate";
            metadata[@"Property"] = @"CreatedDate";
            /*InvalidDataInfo ErrorMetadata LightDMS.DocumentVersion.SystemRequiredCreatedDate*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"DateTime LightDMS.DocumentVersion.CreatedDate" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages LightDMS.DocumentVersion.SystemRequiredCreatedDate*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredVersionNumber(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredVersionNumber";
            metadata[@"Property"] = @"VersionNumber";
            /*InvalidDataInfo ErrorMetadata LightDMS.DocumentVersion.SystemRequiredVersionNumber*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Integer LightDMS.DocumentVersion.VersionNumber" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages LightDMS.DocumentVersion.SystemRequiredVersionNumber*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.LightDMS_DocumentVersion> Filter(IQueryable<Common.Queryable.LightDMS_DocumentVersion> localSource, LightDMS.SystemRequiredCreatedBy localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_DocumentVersion>, Common.DomRepository, LightDMS.SystemRequiredCreatedBy/*ComposableFilterByInfo AdditionalParametersType LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedBy'*/, IQueryable<Common.Queryable.LightDMS_DocumentVersion>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.CreatedBy == null);

            /*ComposableFilterByInfo BeforeFilter LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedBy'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedBy'*/);
        }

        public IQueryable<Common.Queryable.LightDMS_DocumentVersion> Filter(IQueryable<Common.Queryable.LightDMS_DocumentVersion> localSource, LightDMS.SystemRequiredCreatedDate localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_DocumentVersion>, Common.DomRepository, LightDMS.SystemRequiredCreatedDate/*ComposableFilterByInfo AdditionalParametersType LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedDate'*/, IQueryable<Common.Queryable.LightDMS_DocumentVersion>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.CreatedDate == null);

            /*ComposableFilterByInfo BeforeFilter LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedDate'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedDate'*/);
        }

        public IQueryable<Common.Queryable.LightDMS_DocumentVersion> Filter(IQueryable<Common.Queryable.LightDMS_DocumentVersion> localSource, LightDMS.SystemRequiredVersionNumber localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_DocumentVersion>, Common.DomRepository, LightDMS.SystemRequiredVersionNumber/*ComposableFilterByInfo AdditionalParametersType LightDMS.DocumentVersion.'LightDMS.SystemRequiredVersionNumber'*/, IQueryable<Common.Queryable.LightDMS_DocumentVersion>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.VersionNumber == null);

            /*ComposableFilterByInfo BeforeFilter LightDMS.DocumentVersion.'LightDMS.SystemRequiredVersionNumber'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.DocumentVersion.'LightDMS.SystemRequiredVersionNumber'*/);
        }

        public global::LightDMS.DocumentVersion[] Filter(OtherUserDocumentCheckIn filter_Parameter)
        {
            Func<Common.DomRepository, OtherUserDocumentCheckIn/*FilterByInfo AdditionalParametersType LightDMS.DocumentVersion.OtherUserDocumentCheckIn*/, LightDMS.DocumentVersion[]> filter_Function =
                (repository, parameter) => repository.LightDMS.DocumentVersion.Filter(repository.LightDMS.DocumentVersion.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.DocumentVersion.OtherUserDocumentCheckIn*/);
        }

        public global::LightDMS.DocumentVersion[] Filter(LightDMS.SystemRequiredCreatedBy filter_Parameter)
        {
            Func<Common.DomRepository, LightDMS.SystemRequiredCreatedBy/*FilterByInfo AdditionalParametersType LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedBy'*/, LightDMS.DocumentVersion[]> filter_Function =
                (repository, parameter) => repository.LightDMS.DocumentVersion.Filter(repository.LightDMS.DocumentVersion.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedBy'*/);
        }

        public global::LightDMS.DocumentVersion[] Filter(LightDMS.SystemRequiredCreatedDate filter_Parameter)
        {
            Func<Common.DomRepository, LightDMS.SystemRequiredCreatedDate/*FilterByInfo AdditionalParametersType LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedDate'*/, LightDMS.DocumentVersion[]> filter_Function =
                (repository, parameter) => repository.LightDMS.DocumentVersion.Filter(repository.LightDMS.DocumentVersion.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.DocumentVersion.'LightDMS.SystemRequiredCreatedDate'*/);
        }

        public global::LightDMS.DocumentVersion[] Filter(LightDMS.SystemRequiredVersionNumber filter_Parameter)
        {
            Func<Common.DomRepository, LightDMS.SystemRequiredVersionNumber/*FilterByInfo AdditionalParametersType LightDMS.DocumentVersion.'LightDMS.SystemRequiredVersionNumber'*/, LightDMS.DocumentVersion[]> filter_Function =
                (repository, parameter) => repository.LightDMS.DocumentVersion.Filter(repository.LightDMS.DocumentVersion.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.DocumentVersion.'LightDMS.SystemRequiredVersionNumber'*/);
        }

        /*DataStructureInfo RepositoryMembers LightDMS.DocumentVersion*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.DocumentVersionExt*/
    public class DocumentVersionExt_Repository : /*DataStructureInfo OverrideBaseType LightDMS.DocumentVersionExt*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_DocumentVersionExt, LightDMS.DocumentVersionExt> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_DocumentVersionExt, LightDMS.DocumentVersionExt> // Common.ReadableRepositoryBase<LightDMS.DocumentVersionExt> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface LightDMS.DocumentVersionExt*/
    {
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.DocumentVersionExt*/

        public DocumentVersionExt_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments LightDMS.DocumentVersionExt*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.DocumentVersionExt*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.DocumentVersionExt[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_DocumentVersionExt> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.DocumentVersionExt*/
            return _executionContext.EntityFrameworkContext.LightDMS_DocumentVersionExt.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers LightDMS.DocumentVersionExt*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.FileContent*/
    public class FileContent_Repository : /*DataStructureInfo OverrideBaseType LightDMS.FileContent*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_FileContent, LightDMS.FileContent> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_FileContent, LightDMS.FileContent> // Common.ReadableRepositoryBase<LightDMS.FileContent> // global::Common.RepositoryBase
        , IWritableRepository<LightDMS.FileContent>, IValidateRepository/*DataStructureInfo RepositoryInterface LightDMS.FileContent*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.FileContent*/

        public FileContent_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments LightDMS.FileContent*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.FileContent*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.FileContent[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_FileContent> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.FileContent*/
            return _executionContext.EntityFrameworkContext.LightDMS_FileContent.AsNoTracking();
        }

        public void Save(IEnumerable<LightDMS.FileContent> insertedNew, IEnumerable<LightDMS.FileContent> updatedNew, IEnumerable<LightDMS.FileContent> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext LightDMS.FileContent*/

            if (checkUserPermissions)
            {
                var invalidItem = insertedNew.Where(newItem => newItem.CreatedDate != null).FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "CreatedDate", "LightDMS.FileContent" },
                        "DataStructure:LightDMS.FileContent,ID:" + invalidItem.ID + ",Property:CreatedDate",
                        null);
            
            }

            /*DataStructureInfo WritableOrm ArgumentValidation LightDMS.FileContent*/

            { 
                var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

                foreach (var newItem in insertedNew)
                    if(newItem.CreatedDate == null)
                        newItem.CreatedDate = now;
            }
            /*DataStructureInfo WritableOrm Initialization LightDMS.FileContent*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.LightDMS_FileContent> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.LightDMS_FileContent>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_FileContent>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.LightDMS_FileContent> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.LightDMS_FileContent>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_FileContent>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (checkUserPermissions)
            {
                var changes = updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem });
                foreach (var change in changes)
                    if (change.newItem.CreatedDate == null && change.oldItem.CreatedDate != null)
                        change.newItem.CreatedDate = change.oldItem.CreatedDate;
                var invalidItem = changes
                    .Where(change => change.newItem.CreatedDate != null && !change.newItem.CreatedDate.Equals(change.oldItem.CreatedDate) || change.newItem.CreatedDate == null && change.oldItem.CreatedDate != null)
                    .Select(change => change.newItem)
                    .FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "CreatedDate", "LightDMS.FileContent" },
                        "DataStructure:LightDMS.FileContent,ID:" + invalidItem.ID + ",Property:CreatedDate",
                        null);
            
            }

            /*DataStructureInfo WritableOrm OldDataLoaded LightDMS.FileContent*/

            /*DataStructureInfo WritableOrm ProcessedOldData LightDMS.FileContent*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.LightDMS_FileContent.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"LightDMS.DocumentVersion", @"FileContentID", @"FK_DocumentVersion_FileContent_FileContentID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentVersion,Property:FileContentID,Referenced:LightDMS.FileContent";
                /*DataStructureInfo WritableOrm OnDatabaseError LightDMS.FileContent*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "LightDMS.FileContent");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.LightDMS_FileContent> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 LightDMS.FileContent*/

                /*DataStructureInfo WritableOrm OnSaveTag2 LightDMS.FileContent*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "LightDMS.FileContent");

                /*DataStructureInfo WritableOrm AfterSave LightDMS.FileContent*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new ContentIliAzureStorage()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_ContentIliAzureStorage(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredCreatedDate()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredCreatedDate(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate LightDMS.FileContent*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_ContentIliAzureStorage(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Ako Content nije postavljen, AzureStorage mora biti true.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"ContentIliAzureStorage";
            /*InvalidDataInfo ErrorMetadata LightDMS.FileContent.ContentIliAzureStorage*/
            /*InvalidDataInfo OverrideUserMessages LightDMS.FileContent.ContentIliAzureStorage*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredCreatedDate(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredCreatedDate";
            metadata[@"Property"] = @"CreatedDate";
            /*InvalidDataInfo ErrorMetadata LightDMS.FileContent.SystemRequiredCreatedDate*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"DateTime LightDMS.FileContent.CreatedDate" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages LightDMS.FileContent.SystemRequiredCreatedDate*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.LightDMS_FileContent> Filter(IQueryable<Common.Queryable.LightDMS_FileContent> localSource, LightDMS.ContentIliAzureStorage localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_FileContent>, Common.DomRepository, LightDMS.ContentIliAzureStorage/*ComposableFilterByInfo AdditionalParametersType LightDMS.FileContent.'LightDMS.ContentIliAzureStorage'*/, IQueryable<Common.Queryable.LightDMS_FileContent>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Content == null && item.AzureStorage != true);

            /*ComposableFilterByInfo BeforeFilter LightDMS.FileContent.'LightDMS.ContentIliAzureStorage'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.FileContent.'LightDMS.ContentIliAzureStorage'*/);
        }

        public IQueryable<Common.Queryable.LightDMS_FileContent> Filter(IQueryable<Common.Queryable.LightDMS_FileContent> localSource, LightDMS.SystemRequiredCreatedDate localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_FileContent>, Common.DomRepository, LightDMS.SystemRequiredCreatedDate/*ComposableFilterByInfo AdditionalParametersType LightDMS.FileContent.'LightDMS.SystemRequiredCreatedDate'*/, IQueryable<Common.Queryable.LightDMS_FileContent>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.CreatedDate == null);

            /*ComposableFilterByInfo BeforeFilter LightDMS.FileContent.'LightDMS.SystemRequiredCreatedDate'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.FileContent.'LightDMS.SystemRequiredCreatedDate'*/);
        }

        public global::LightDMS.FileContent[] Filter(LightDMS.ContentIliAzureStorage filter_Parameter)
        {
            Func<Common.DomRepository, LightDMS.ContentIliAzureStorage/*FilterByInfo AdditionalParametersType LightDMS.FileContent.'LightDMS.ContentIliAzureStorage'*/, LightDMS.FileContent[]> filter_Function =
                (repository, parameter) => repository.LightDMS.FileContent.Filter(repository.LightDMS.FileContent.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.FileContent.'LightDMS.ContentIliAzureStorage'*/);
        }

        public global::LightDMS.FileContent[] Filter(LightDMS.SystemRequiredCreatedDate filter_Parameter)
        {
            Func<Common.DomRepository, LightDMS.SystemRequiredCreatedDate/*FilterByInfo AdditionalParametersType LightDMS.FileContent.'LightDMS.SystemRequiredCreatedDate'*/, LightDMS.FileContent[]> filter_Function =
                (repository, parameter) => repository.LightDMS.FileContent.Filter(repository.LightDMS.FileContent.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.FileContent.'LightDMS.SystemRequiredCreatedDate'*/);
        }

        /*DataStructureInfo RepositoryMembers LightDMS.FileContent*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.DocumentRepository*/
    public class DocumentRepository_Repository : /*DataStructureInfo OverrideBaseType LightDMS.DocumentRepository*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_DocumentRepository, LightDMS.DocumentRepository> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_DocumentRepository, LightDMS.DocumentRepository> // Common.ReadableRepositoryBase<LightDMS.DocumentRepository> // global::Common.RepositoryBase
        , IWritableRepository<LightDMS.DocumentRepository>, IValidateRepository/*DataStructureInfo RepositoryInterface LightDMS.DocumentRepository*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.DocumentRepository*/

        public DocumentRepository_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments LightDMS.DocumentRepository*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.DocumentRepository*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.DocumentRepository[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_DocumentRepository> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.DocumentRepository*/
            return _executionContext.EntityFrameworkContext.LightDMS_DocumentRepository.AsNoTracking();
        }

        public void Save(IEnumerable<LightDMS.DocumentRepository> insertedNew, IEnumerable<LightDMS.DocumentRepository> updatedNew, IEnumerable<LightDMS.DocumentRepository> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext LightDMS.DocumentRepository*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "DocumentRepository.Name", "256" },
                        "DataStructure:LightDMS.DocumentRepository,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation LightDMS.DocumentRepository*/

            /*DataStructureInfo WritableOrm Initialization LightDMS.DocumentRepository*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.LightDMS_DocumentRepository> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.LightDMS_DocumentRepository>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_DocumentRepository>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.LightDMS_DocumentRepository> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.LightDMS_DocumentRepository>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_DocumentRepository>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded LightDMS.DocumentRepository*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition LightDMS.DocumentRepository.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "LightDMS.DocumentRepository", "Name" },
                        "DataStructure:LightDMS.DocumentRepository,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData LightDMS.DocumentRepository*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.LightDMS_DocumentRepository.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"LightDMS.Checkout", @"RepositoryID", @"FK_Checkout_DocumentRepository_RepositoryID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.Checkout,Property:RepositoryID,Referenced:LightDMS.DocumentRepository";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"LightDMS.DocumentVersion", @"RepositoryID", @"FK_DocumentVersion_DocumentRepository_RepositoryID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.DocumentVersion,Property:RepositoryID,Referenced:LightDMS.DocumentRepository";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"LightDMS.UndoCheckout", @"RepositoryID", @"FK_UndoCheckout_DocumentRepository_RepositoryID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.UndoCheckout,Property:RepositoryID,Referenced:LightDMS.DocumentRepository";
                /*DataStructureInfo WritableOrm OnDatabaseError LightDMS.DocumentRepository*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "LightDMS.DocumentRepository");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.LightDMS_DocumentRepository> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 LightDMS.DocumentRepository*/

                /*DataStructureInfo WritableOrm OnSaveTag2 LightDMS.DocumentRepository*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "LightDMS.DocumentRepository");

                /*DataStructureInfo WritableOrm AfterSave LightDMS.DocumentRepository*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate LightDMS.DocumentRepository*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers LightDMS.DocumentRepository*/
    }

    /*DataStructureInfo RepositoryAttributes LightDMS.UndoCheckout*/
    public class UndoCheckout_Repository : /*DataStructureInfo OverrideBaseType LightDMS.UndoCheckout*/ Common.OrmRepositoryBase<Common.Queryable.LightDMS_UndoCheckout, LightDMS.UndoCheckout> // Common.QueryableRepositoryBase<Common.Queryable.LightDMS_UndoCheckout, LightDMS.UndoCheckout> // Common.ReadableRepositoryBase<LightDMS.UndoCheckout> // global::Common.RepositoryBase
        , IWritableRepository<LightDMS.UndoCheckout>, IValidateRepository/*DataStructureInfo RepositoryInterface LightDMS.UndoCheckout*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers LightDMS.UndoCheckout*/

        public UndoCheckout_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments LightDMS.UndoCheckout*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode LightDMS.UndoCheckout*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::LightDMS.UndoCheckout[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.LightDMS_UndoCheckout> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery LightDMS.UndoCheckout*/
            return _executionContext.EntityFrameworkContext.LightDMS_UndoCheckout.AsNoTracking();
        }

        public void Save(IEnumerable<LightDMS.UndoCheckout> insertedNew, IEnumerable<LightDMS.UndoCheckout> updatedNew, IEnumerable<LightDMS.UndoCheckout> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext LightDMS.UndoCheckout*/

            if (checkUserPermissions)
            {
                var invalidItem = insertedNew.Where(newItem => newItem.CreatedDate != null).FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "CreatedDate", "LightDMS.UndoCheckout" },
                        "DataStructure:LightDMS.UndoCheckout,ID:" + invalidItem.ID + ",Property:CreatedDate",
                        null);
            
            }

            /*DataStructureInfo WritableOrm ArgumentValidation LightDMS.UndoCheckout*/

            {
                var userName = _executionContext.UserInfo.UserName;
                var userIds = _domRepository.Common.Principal.Query(p => p.Name == userName).Select(p => p.ID).ToList();

                if (userIds.Count > 1)
                    throw new Rhetos.UserException("The system is not configured properly: There are multiple principals with the same username '{0}'. Please contact your system administrator.", new[] { userName }, null, null);
                if (userIds.Count == 0)
                    throw new Rhetos.UserException("The system is not configured properly: There are no principals with username '{0}'. Please contact your system administrator.", new[] { userName }, null, null);
                Guid userId = userIds.Single();

                foreach (var newItem in insertedNew)
                    if(newItem.CreatedByID == null)
                        newItem.CreatedByID = userId;
            }
            { 
                var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

                foreach (var newItem in insertedNew)
                    if(newItem.CreatedDate == null)
                        newItem.CreatedDate = now;
            }
                            { // DeadlockPrevention
                    /*
    Copyright (C) 2014 Omega software d.o.o.

    This file is part of Rhetos.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

string lockDocument =
	string.Join("\r\n",
		insertedNew.Concat(updatedNew).Concat(deletedIds)
		.Where(item => item.DocumentID.HasValue)
		.Select(item => item.DocumentID)
		.Distinct()
		.Select(documentId => "exec sp_getapplock 'LightDms.Document_" + documentId + "', 'Exclusive';"));

_executionContext.SqlExecuter.ExecuteSql(lockDocument);
                }

/*DataStructureInfo WritableOrm Initialization LightDMS.UndoCheckout*/

            // Using old data, including lazy loading of navigation properties:
		    IEnumerable<Common.Queryable.LightDMS_UndoCheckout> deleted;
		    if(deletedIds.Any())
                deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            else
                deleted = new List<Common.Queryable.LightDMS_UndoCheckout>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_UndoCheckout>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
		    IEnumerable<Common.Queryable.LightDMS_UndoCheckout> updated;
		    if(updatedNew.Any())
                updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            else
                updated = new List<Common.Queryable.LightDMS_UndoCheckout>();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.LightDMS_UndoCheckout>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (checkUserPermissions)
            {
                var changes = updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem });
                foreach (var change in changes)
                    if (change.newItem.CreatedDate == null && change.oldItem.CreatedDate != null)
                        change.newItem.CreatedDate = change.oldItem.CreatedDate;
                var invalidItem = changes
                    .Where(change => change.newItem.CreatedDate != null && !change.newItem.CreatedDate.Equals(change.oldItem.CreatedDate) || change.newItem.CreatedDate == null && change.oldItem.CreatedDate != null)
                    .Select(change => change.newItem)
                    .FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "CreatedDate", "LightDMS.UndoCheckout" },
                        "DataStructure:LightDMS.UndoCheckout,ID:" + invalidItem.ID + ",Property:CreatedDate",
                        null);
            
            }

            Func<IEnumerable<Common.Queryable.LightDMS_UndoCheckout>, Guid[]> filterLoadKeepSynchronizedOnChangedItems3 =
                /*
    Copyright (C) 2014 Omega software d.o.o.

    This file is part of Rhetos.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

changedItems => changedItems.Where(item => item.DocumentID.HasValue).Select(item => item.DocumentID.Value).Distinct().ToArray();
            Guid[] filterKeepSynchronizedOnChangedItems3Old = filterLoadKeepSynchronizedOnChangedItems3(updated.Concat(deleted));

            /*DataStructureInfo WritableOrm OldDataLoaded LightDMS.UndoCheckout*/

            /*DataStructureInfo WritableOrm ProcessedOldData LightDMS.UndoCheckout*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.LightDMS_UndoCheckout.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"LightDMS.DocumentRepository", @"ID", @"FK_UndoCheckout_DocumentRepository_RepositoryID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.UndoCheckout,Property:RepositoryID,Referenced:LightDMS.DocumentRepository";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_UndoCheckout_Principal_CreatedByID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:LightDMS.UndoCheckout,Property:CreatedByID,Referenced:Common.Principal";
                /*DataStructureInfo WritableOrm OnDatabaseError LightDMS.UndoCheckout*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "LightDMS.UndoCheckout");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.LightDMS_UndoCheckout> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*OverrideRecompute KeepSynchronizedInfo LightDMS.DocumentStatus.LightDMS.ComputeDocumentStatus.3*/
                {
                    var filteredNew = filterLoadKeepSynchronizedOnChangedItems3(inserted.Concat(updated));
                    Guid[] optimizedFilter;
                    if (KeepSynchronizedHelper.OptimizeFiltersUnion(filteredNew, filterKeepSynchronizedOnChangedItems3Old, out optimizedFilter))
                        _domRepository.LightDMS.DocumentStatus.RecomputeFromComputeDocumentStatus(optimizedFilter);
                    else
                    {
                        _domRepository.LightDMS.DocumentStatus.RecomputeFromComputeDocumentStatus(filterKeepSynchronizedOnChangedItems3Old);
                        _domRepository.LightDMS.DocumentStatus.RecomputeFromComputeDocumentStatus(filteredNew);
                    }
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 LightDMS.UndoCheckout*/

                /*DataStructureInfo WritableOrm OnSaveTag2 LightDMS.UndoCheckout*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "LightDMS.UndoCheckout");

                /*DataStructureInfo WritableOrm AfterSave LightDMS.UndoCheckout*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new DocumentNotCheckouted()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_DocumentNotCheckouted(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new OtherUserDocumentUndoCheckout()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_OtherUserDocumentUndoCheckout(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredCreatedBy()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredCreatedBy(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredCreatedDate()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredCreatedDate(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate LightDMS.UndoCheckout*/
            yield break;
        }

        public IQueryable<Common.Queryable.LightDMS_UndoCheckout> Filter(IQueryable<Common.Queryable.LightDMS_UndoCheckout> localSource, DocumentNotCheckouted localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_UndoCheckout>, Common.DomRepository, DocumentNotCheckouted/*ComposableFilterByInfo AdditionalParametersType LightDMS.UndoCheckout.DocumentNotCheckouted*/, IQueryable<Common.Queryable.LightDMS_UndoCheckout>> filterFunction =
            (items, repository, filterParameter) =>
		{
            var itemsToCheck = items.Select(i => i.ID).ToList();
    		var invalidItems = repository.LightDMS.DocumentStatusBeforeEvent.Query(i => itemsToCheck.Contains(i.ID) && i.CheckoutID == null).Select(i => i.ID).ToList();
    		return items.Where(i => invalidItems.Contains(i.ID));
	  	};

            /*ComposableFilterByInfo BeforeFilter LightDMS.UndoCheckout.DocumentNotCheckouted*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.UndoCheckout.DocumentNotCheckouted*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_DocumentNotCheckouted(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Akcija nije moguća jer sadržaj niste rezervirali za uređivanje.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"DocumentNotCheckouted";
            /*InvalidDataInfo ErrorMetadata LightDMS.UndoCheckout.DocumentNotCheckouted*/
            /*InvalidDataInfo OverrideUserMessages LightDMS.UndoCheckout.DocumentNotCheckouted*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.LightDMS_UndoCheckout> Filter(IQueryable<Common.Queryable.LightDMS_UndoCheckout> localSource, OtherUserDocumentUndoCheckout localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_UndoCheckout>, Common.DomRepository, OtherUserDocumentUndoCheckout, Common.ExecutionContext/*ComposableFilterByInfo AdditionalParametersType LightDMS.UndoCheckout.OtherUserDocumentUndoCheckout*/, IQueryable<Common.Queryable.LightDMS_UndoCheckout>> filterFunction =
            (items, repository, parameter, context) =>
		{							
			var claimCanUndoCheckoutForOtherUser = new List<Rhetos.Security.Claim>() { new Rhetos.Security.Claim("LightDMS.UndoCheckout", "CanUndoCheckoutForOtherUser") };
			var canUndoCheckoutForOtherUser = context.AuthorizationManager.GetAuthorizations(claimCanUndoCheckoutForOtherUser).FirstOrDefault();
			if(canUndoCheckoutForOtherUser)
			{
				return items.Where(i => false);
			}
			else
			{
				var itemList = items.Select(x => (Guid?)x.ID).ToList();
				return repository.LightDMS.DocumentEvent.Query()
					.Where(de =>
						itemList.Contains(de.UndoCheckoutID) &&
						de.Extension_DocumentStatusBeforeEvent.CheckoutID != null &&
						(de.Extension_DocumentStatusBeforeEvent.CheckedOutToID != de.UndoCheckout.CreatedByID)
					)
					.Select(de => de.UndoCheckout);
			}
		}
		;

            /*ComposableFilterByInfo BeforeFilter LightDMS.UndoCheckout.OtherUserDocumentUndoCheckout*/
            return filterFunction(localSource, _domRepository, localParameter, _executionContext/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.UndoCheckout.OtherUserDocumentUndoCheckout*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_OtherUserDocumentUndoCheckout(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Akcija nije moguća jer je sadržaj rezerviran za uređivanje od strane drugog korisnika.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"OtherUserDocumentUndoCheckout";
            /*InvalidDataInfo ErrorMetadata LightDMS.UndoCheckout.OtherUserDocumentUndoCheckout*/
            /*InvalidDataInfo OverrideUserMessages LightDMS.UndoCheckout.OtherUserDocumentUndoCheckout*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredCreatedBy(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredCreatedBy";
            metadata[@"Property"] = @"CreatedBy";
            /*InvalidDataInfo ErrorMetadata LightDMS.UndoCheckout.SystemRequiredCreatedBy*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference LightDMS.UndoCheckout.CreatedBy" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages LightDMS.UndoCheckout.SystemRequiredCreatedBy*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredCreatedDate(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredCreatedDate";
            metadata[@"Property"] = @"CreatedDate";
            /*InvalidDataInfo ErrorMetadata LightDMS.UndoCheckout.SystemRequiredCreatedDate*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"DateTime LightDMS.UndoCheckout.CreatedDate" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages LightDMS.UndoCheckout.SystemRequiredCreatedDate*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.LightDMS_UndoCheckout> Filter(IQueryable<Common.Queryable.LightDMS_UndoCheckout> localSource, LightDMS.SystemRequiredCreatedBy localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_UndoCheckout>, Common.DomRepository, LightDMS.SystemRequiredCreatedBy/*ComposableFilterByInfo AdditionalParametersType LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedBy'*/, IQueryable<Common.Queryable.LightDMS_UndoCheckout>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.CreatedBy == null);

            /*ComposableFilterByInfo BeforeFilter LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedBy'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedBy'*/);
        }

        public IQueryable<Common.Queryable.LightDMS_UndoCheckout> Filter(IQueryable<Common.Queryable.LightDMS_UndoCheckout> localSource, LightDMS.SystemRequiredCreatedDate localParameter)
        {
            Func<IQueryable<Common.Queryable.LightDMS_UndoCheckout>, Common.DomRepository, LightDMS.SystemRequiredCreatedDate/*ComposableFilterByInfo AdditionalParametersType LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedDate'*/, IQueryable<Common.Queryable.LightDMS_UndoCheckout>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.CreatedDate == null);

            /*ComposableFilterByInfo BeforeFilter LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedDate'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedDate'*/);
        }

        public global::LightDMS.UndoCheckout[] Filter(DocumentNotCheckouted filter_Parameter)
        {
            Func<Common.DomRepository, DocumentNotCheckouted/*FilterByInfo AdditionalParametersType LightDMS.UndoCheckout.DocumentNotCheckouted*/, LightDMS.UndoCheckout[]> filter_Function =
                (repository, parameter) => repository.LightDMS.UndoCheckout.Filter(repository.LightDMS.UndoCheckout.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.UndoCheckout.DocumentNotCheckouted*/);
        }

        public global::LightDMS.UndoCheckout[] Filter(OtherUserDocumentUndoCheckout filter_Parameter)
        {
            Func<Common.DomRepository, OtherUserDocumentUndoCheckout/*FilterByInfo AdditionalParametersType LightDMS.UndoCheckout.OtherUserDocumentUndoCheckout*/, LightDMS.UndoCheckout[]> filter_Function =
                (repository, parameter) => repository.LightDMS.UndoCheckout.Filter(repository.LightDMS.UndoCheckout.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.UndoCheckout.OtherUserDocumentUndoCheckout*/);
        }

        public global::LightDMS.UndoCheckout[] Filter(LightDMS.SystemRequiredCreatedBy filter_Parameter)
        {
            Func<Common.DomRepository, LightDMS.SystemRequiredCreatedBy/*FilterByInfo AdditionalParametersType LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedBy'*/, LightDMS.UndoCheckout[]> filter_Function =
                (repository, parameter) => repository.LightDMS.UndoCheckout.Filter(repository.LightDMS.UndoCheckout.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedBy'*/);
        }

        public global::LightDMS.UndoCheckout[] Filter(LightDMS.SystemRequiredCreatedDate filter_Parameter)
        {
            Func<Common.DomRepository, LightDMS.SystemRequiredCreatedDate/*FilterByInfo AdditionalParametersType LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedDate'*/, LightDMS.UndoCheckout[]> filter_Function =
                (repository, parameter) => repository.LightDMS.UndoCheckout.Filter(repository.LightDMS.UndoCheckout.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument LightDMS.UndoCheckout.'LightDMS.SystemRequiredCreatedDate'*/);
        }

        /*DataStructureInfo RepositoryMembers LightDMS.UndoCheckout*/
    }

    /*ModuleInfo HelperNamespaceMembers LightDMS*/
}

/*RepositoryClasses*/