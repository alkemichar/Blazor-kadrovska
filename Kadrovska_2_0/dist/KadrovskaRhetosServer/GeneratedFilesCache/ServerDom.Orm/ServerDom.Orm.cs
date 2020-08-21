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

    public class EntityFrameworkContext : System.Data.Entity.DbContext, Rhetos.Persistence.IPersistenceCache
    {
        private readonly Rhetos.Utilities.IConfiguration _configuration;

        public EntityFrameworkContext(
            Rhetos.Persistence.IPersistenceTransaction persistenceTransaction,
            Rhetos.Dom.DefaultConcepts.Persistence.EntityFrameworkMetadata metadata,
            EntityFrameworkConfiguration entityFrameworkConfiguration, // EntityFrameworkConfiguration is provided as an IoC dependency for EntityFrameworkContext in order to initialize the global DbConfiguration before using DbContext.
            Rhetos.Utilities.IConfiguration configuration)
            : base(new System.Data.Entity.Core.EntityClient.EntityConnection(metadata.MetadataWorkspace, persistenceTransaction.Connection), false)
        {
            _configuration = configuration;
            Initialize();
            Database.UseTransaction(persistenceTransaction.Transaction);
        }

        private void Initialize()
        {
            System.Data.Entity.Database.SetInitializer<EntityFrameworkContext>(null); // Prevent EF from creating database objects.

            this.Configuration.UseDatabaseNullSemantics = _configuration.GetBool("EntityFramework.UseDatabaseNullSemantics", false).Value;
            /*EntityFrameworkContextInitialize*/

            this.Database.CommandTimeout = Rhetos.Utilities.SqlUtility.SqlCommandTimeout;
        }

        public void ClearCache()
        {
            SetDetaching(true);
            try
            {
                Configuration.AutoDetectChangesEnabled = false;
                var trackedItems = ChangeTracker.Entries().ToList();
                foreach (var item in trackedItems)
                    Entry(item.Entity).State = System.Data.Entity.EntityState.Detached;
                Configuration.AutoDetectChangesEnabled = true;
            }
            finally
            {
                SetDetaching(false);
            }
        }

        private void SetDetaching(bool detaching)
        {
            foreach (var item in ChangeTracker.Entries().Select(entry => entry.Entity).OfType<IDetachOverride>())
                item.Detaching = detaching;
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<global::Kadrovska.Djelatnik>();
            modelBuilder.Entity<Common.Queryable.Kadrovska_Djelatnik>().Map(m => { m.MapInheritedProperties(); m.ToTable("Djelatnik", "Kadrovska"); });
            modelBuilder.Ignore<global::Kadrovska.Odjel>();
            modelBuilder.Entity<Common.Queryable.Kadrovska_Odjel>().Map(m => { m.MapInheritedProperties(); m.ToTable("Odjel", "Kadrovska"); });
            modelBuilder.Ignore<global::Kadrovska.Sektor>();
            modelBuilder.Entity<Common.Queryable.Kadrovska_Sektor>().Map(m => { m.MapInheritedProperties(); m.ToTable("Sektor", "Kadrovska"); });
            modelBuilder.Entity<Common.Queryable.Kadrovska_Sektor>()
                .HasOptional(t => t.Voditelj).WithMany()
                .HasForeignKey(t => t.VoditeljID);
            modelBuilder.Ignore<global::Common.AutoCodeCache>();
            modelBuilder.Entity<Common.Queryable.Common_AutoCodeCache>().Map(m => { m.MapInheritedProperties(); m.ToTable("AutoCodeCache", "Common"); });
            modelBuilder.Ignore<global::Common.FilterId>();
            modelBuilder.Entity<Common.Queryable.Common_FilterId>().Map(m => { m.MapInheritedProperties(); m.ToTable("FilterId", "Common"); });
            modelBuilder.Ignore<global::Common.KeepSynchronizedMetadata>();
            modelBuilder.Entity<Common.Queryable.Common_KeepSynchronizedMetadata>().Map(m => { m.MapInheritedProperties(); m.ToTable("KeepSynchronizedMetadata", "Common"); });
            modelBuilder.Ignore<global::Common.ExclusiveLock>();
            modelBuilder.Entity<Common.Queryable.Common_ExclusiveLock>().Map(m => { m.MapInheritedProperties(); m.ToTable("ExclusiveLock", "Common"); });
            modelBuilder.Ignore<global::Common.LogReader>();
            modelBuilder.Entity<Common.Queryable.Common_LogReader>().Map(m => { m.MapInheritedProperties(); m.ToTable("LogReader", "Common"); });
            modelBuilder.Ignore<global::Common.LogRelatedItemReader>();
            modelBuilder.Entity<Common.Queryable.Common_LogRelatedItemReader>().Map(m => { m.MapInheritedProperties(); m.ToTable("LogRelatedItemReader", "Common"); });
            modelBuilder.Ignore<global::Common.Log>();
            modelBuilder.Entity<Common.Queryable.Common_Log>().Map(m => { m.MapInheritedProperties(); m.ToTable("Log", "Common"); });
            modelBuilder.Ignore<global::Common.LogRelatedItem>();
            modelBuilder.Entity<Common.Queryable.Common_LogRelatedItem>().Map(m => { m.MapInheritedProperties(); m.ToTable("LogRelatedItem", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_LogRelatedItem>()
                .HasOptional(t => t.Log).WithMany()
                .HasForeignKey(t => t.LogID);
            modelBuilder.Ignore<global::Common.RelatedEventsSource>();
            modelBuilder.Entity<Common.Queryable.Common_RelatedEventsSource>().Map(m => { m.MapInheritedProperties(); m.ToTable("RelatedEventsSource", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_RelatedEventsSource>()
                .HasOptional(t => t.Log).WithMany()
                .HasForeignKey(t => t.LogID);
            modelBuilder.Ignore<global::Common.Claim>();
            modelBuilder.Entity<Common.Queryable.Common_Claim>().Map(m => { m.MapInheritedProperties(); m.ToTable("Claim", "Common"); });
            modelBuilder.Ignore<global::Common.Principal>();
            modelBuilder.Entity<Common.Queryable.Common_Principal>().Map(m => { m.MapInheritedProperties(); m.ToTable("Principal", "Common"); });
            modelBuilder.Ignore<global::Common.PrincipalHasRole>();
            modelBuilder.Entity<Common.Queryable.Common_PrincipalHasRole>().Map(m => { m.MapInheritedProperties(); m.ToTable("PrincipalHasRole", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_PrincipalHasRole>()
                .HasOptional(t => t.Principal).WithMany()
                .HasForeignKey(t => t.PrincipalID);
            modelBuilder.Ignore<global::Common.Role>();
            modelBuilder.Entity<Common.Queryable.Common_Role>().Map(m => { m.MapInheritedProperties(); m.ToTable("Role", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_PrincipalHasRole>()
                .HasOptional(t => t.Role).WithMany()
                .HasForeignKey(t => t.RoleID);
            modelBuilder.Ignore<global::Common.RoleInheritsRole>();
            modelBuilder.Entity<Common.Queryable.Common_RoleInheritsRole>().Map(m => { m.MapInheritedProperties(); m.ToTable("RoleInheritsRole", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_RoleInheritsRole>()
                .HasOptional(t => t.UsersFrom).WithMany()
                .HasForeignKey(t => t.UsersFromID);
            modelBuilder.Entity<Common.Queryable.Common_RoleInheritsRole>()
                .HasOptional(t => t.PermissionsFrom).WithMany()
                .HasForeignKey(t => t.PermissionsFromID);
            modelBuilder.Ignore<global::Common.PrincipalPermission>();
            modelBuilder.Entity<Common.Queryable.Common_PrincipalPermission>().Map(m => { m.MapInheritedProperties(); m.ToTable("PrincipalPermission", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_PrincipalPermission>()
                .HasOptional(t => t.Principal).WithMany()
                .HasForeignKey(t => t.PrincipalID);
            modelBuilder.Entity<Common.Queryable.Common_PrincipalPermission>()
                .HasOptional(t => t.Claim).WithMany()
                .HasForeignKey(t => t.ClaimID);
            modelBuilder.Ignore<global::Common.RolePermission>();
            modelBuilder.Entity<Common.Queryable.Common_RolePermission>().Map(m => { m.MapInheritedProperties(); m.ToTable("RolePermission", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_RolePermission>()
                .HasOptional(t => t.Role).WithMany()
                .HasForeignKey(t => t.RoleID);
            modelBuilder.Entity<Common.Queryable.Common_RolePermission>()
                .HasOptional(t => t.Claim).WithMany()
                .HasForeignKey(t => t.ClaimID);
            modelBuilder.Ignore<global::LightDMS.Checkout>();
            modelBuilder.Entity<Common.Queryable.LightDMS_Checkout>().Map(m => { m.MapInheritedProperties(); m.ToTable("Checkout", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_Checkout>()
                .HasOptional(t => t.CreatedBy).WithMany()
                .HasForeignKey(t => t.CreatedByID);
            modelBuilder.Ignore<global::LightDMS.DocumentEvent>();
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentEvent>().Map(m => { m.MapInheritedProperties(); m.ToTable("DocumentEvent", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentEvent>()
                .HasOptional(t => t.CreatedBy).WithMany()
                .HasForeignKey(t => t.CreatedByID);
            modelBuilder.Ignore<global::LightDMS.DocumentStatusBeforeEvent>();
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentStatusBeforeEvent>().Map(m => { m.MapInheritedProperties(); m.ToTable("DocumentStatusBeforeEvent", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentStatusBeforeEvent>().HasRequired(t => t.Base).WithOptional(t => t.Extension_DocumentStatusBeforeEvent);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentStatusBeforeEvent>()
                .HasOptional(t => t.PreviousEvent).WithMany()
                .HasForeignKey(t => t.PreviousEventID);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentStatusBeforeEvent>()
                .HasOptional(t => t.Checkout).WithMany()
                .HasForeignKey(t => t.CheckoutID);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentStatusBeforeEvent>()
                .HasOptional(t => t.CheckedOutTo).WithMany()
                .HasForeignKey(t => t.CheckedOutToID);
            modelBuilder.Ignore<global::LightDMS.ComputeDocumentStatus>();
            modelBuilder.Entity<Common.Queryable.LightDMS_ComputeDocumentStatus>().Map(m => { m.MapInheritedProperties(); m.ToTable("ComputeDocumentStatus", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_ComputeDocumentStatus>()
                .HasOptional(t => t.CheckedOutTo).WithMany()
                .HasForeignKey(t => t.CheckedOutToID);
            modelBuilder.Ignore<global::LightDMS.DocumentStatus>();
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentStatus>().Map(m => { m.MapInheritedProperties(); m.ToTable("DocumentStatus", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentStatus>()
                .HasOptional(t => t.CheckedOutTo).WithMany()
                .HasForeignKey(t => t.CheckedOutToID);
            modelBuilder.Ignore<global::LightDMS.DocumentVersion>();
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentVersion>().Map(m => { m.MapInheritedProperties(); m.ToTable("DocumentVersion", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentStatusBeforeEvent>()
                .HasOptional(t => t.DocumentVersion).WithMany()
                .HasForeignKey(t => t.DocumentVersionID);
            modelBuilder.Entity<Common.Queryable.LightDMS_ComputeDocumentStatus>()
                .HasOptional(t => t.LastVersion).WithMany()
                .HasForeignKey(t => t.LastVersionID);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentStatus>()
                .HasOptional(t => t.LastVersion).WithMany()
                .HasForeignKey(t => t.LastVersionID);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentVersion>()
                .HasOptional(t => t.CreatedBy).WithMany()
                .HasForeignKey(t => t.CreatedByID);
            modelBuilder.Ignore<global::LightDMS.DocumentVersionExt>();
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentVersionExt>().Map(m => { m.MapInheritedProperties(); m.ToTable("DocumentVersionExt", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentVersionExt>().HasRequired(t => t.Base).WithOptional(t => t.Extension_DocumentVersionExt);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentVersionExt>().Property(t => t.SizeInKBytes).HasPrecision(28, 10);
            modelBuilder.Ignore<global::LightDMS.FileContent>();
            modelBuilder.Entity<Common.Queryable.LightDMS_FileContent>().Map(m => { m.MapInheritedProperties(); m.ToTable("FileContent", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentVersion>()
                .HasOptional(t => t.FileContent).WithMany()
                .HasForeignKey(t => t.FileContentID);
            modelBuilder.Ignore<global::LightDMS.DocumentRepository>();
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentRepository>().Map(m => { m.MapInheritedProperties(); m.ToTable("DocumentRepository", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_Checkout>()
                .HasOptional(t => t.Repository).WithMany()
                .HasForeignKey(t => t.RepositoryID);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentEvent>()
                .HasOptional(t => t.Repository).WithMany()
                .HasForeignKey(t => t.RepositoryID);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentVersion>()
                .HasOptional(t => t.Repository).WithMany()
                .HasForeignKey(t => t.RepositoryID);
            modelBuilder.Ignore<global::LightDMS.UndoCheckout>();
            modelBuilder.Entity<Common.Queryable.LightDMS_UndoCheckout>().Map(m => { m.MapInheritedProperties(); m.ToTable("UndoCheckout", "LightDMS"); });
            modelBuilder.Entity<Common.Queryable.LightDMS_UndoCheckout>()
                .HasOptional(t => t.Repository).WithMany()
                .HasForeignKey(t => t.RepositoryID);
            modelBuilder.Entity<Common.Queryable.LightDMS_UndoCheckout>()
                .HasOptional(t => t.CreatedBy).WithMany()
                .HasForeignKey(t => t.CreatedByID);
            modelBuilder.Entity<Common.Queryable.Common_LogRelatedItemReader>()
                .HasOptional(t => t.Log).WithMany()
                .HasForeignKey(t => t.LogID);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentEvent>()
                .HasOptional(t => t.Checkout).WithMany()
                .HasForeignKey(t => t.CheckoutID);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentEvent>()
                .HasOptional(t => t.DocumentVersion).WithMany()
                .HasForeignKey(t => t.DocumentVersionID);
            modelBuilder.Entity<Common.Queryable.LightDMS_DocumentEvent>()
                .HasOptional(t => t.UndoCheckout).WithMany()
                .HasForeignKey(t => t.UndoCheckoutID);
            modelBuilder.Entity<Common.Queryable.Common_Claim>().Ignore(t => t.Extension_MyClaim);
            /*EntityFrameworkOnModelCreating*/
        }

        public System.Data.Entity.DbSet<Common.Queryable.Kadrovska_Djelatnik> Kadrovska_Djelatnik { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Kadrovska_Odjel> Kadrovska_Odjel { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Kadrovska_Sektor> Kadrovska_Sektor { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_AutoCodeCache> Common_AutoCodeCache { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_FilterId> Common_FilterId { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_KeepSynchronizedMetadata> Common_KeepSynchronizedMetadata { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_ExclusiveLock> Common_ExclusiveLock { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_LogReader> Common_LogReader { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_LogRelatedItemReader> Common_LogRelatedItemReader { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Log> Common_Log { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_LogRelatedItem> Common_LogRelatedItem { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_RelatedEventsSource> Common_RelatedEventsSource { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Claim> Common_Claim { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Principal> Common_Principal { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_PrincipalHasRole> Common_PrincipalHasRole { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Role> Common_Role { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_RoleInheritsRole> Common_RoleInheritsRole { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_PrincipalPermission> Common_PrincipalPermission { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_RolePermission> Common_RolePermission { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_Checkout> LightDMS_Checkout { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_DocumentEvent> LightDMS_DocumentEvent { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_DocumentStatusBeforeEvent> LightDMS_DocumentStatusBeforeEvent { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_ComputeDocumentStatus> LightDMS_ComputeDocumentStatus { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_DocumentStatus> LightDMS_DocumentStatus { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_DocumentVersion> LightDMS_DocumentVersion { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_DocumentVersionExt> LightDMS_DocumentVersionExt { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_FileContent> LightDMS_FileContent { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_DocumentRepository> LightDMS_DocumentRepository { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.LightDMS_UndoCheckout> LightDMS_UndoCheckout { get; set; }
        /*EntityFrameworkContextMembers*/
    }

    public class EntityFrameworkConfiguration : System.Data.Entity.DbConfiguration
    {
        public EntityFrameworkConfiguration()
        {
            SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);

            AddInterceptor(new Rhetos.Dom.DefaultConcepts.ContainsIdsInterceptor());
            AddInterceptor(new Rhetos.Dom.DefaultConcepts.Persistence.FullTextSearchInterceptor());
            /*EntityFrameworkConfiguration*/

            System.Data.Entity.DbConfiguration.SetConfiguration(this);
        }
    }
}