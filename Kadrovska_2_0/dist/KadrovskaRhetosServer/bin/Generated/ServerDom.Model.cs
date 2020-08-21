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
// DomGeneratorOptions.Debug = "False"

namespace Kadrovska
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

    [DataContract]/*DataStructureInfo ClassAttributes Kadrovska.Djelatnik*/
    public class Djelatnik : EntityBase<Kadrovska.Djelatnik>/*Next DataStructureInfo ClassInterace Kadrovska.Djelatnik*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Kadrovska_Djelatnik ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Kadrovska_Djelatnik
            {
                ID = item.ID,
                MaticniBroj = item.MaticniBroj,
                Prezime = item.Prezime,
                Ime = item.Ime,
                Email = item.Email,
                Mobitel = item.Mobitel,
                Tvrtka = item.Tvrtka,
                OdjelID = item.OdjelID,
                SektorID = item.SektorID,
                TimID = item.TimID/*DataStructureInfo AssignSimpleProperty Kadrovska.Djelatnik*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Kadrovska.Djelatnik.MaticniBroj*/
        public string MaticniBroj { get; set; }
        [DataMember]/*PropertyInfo Attribute Kadrovska.Djelatnik.Prezime*/
        public string Prezime { get; set; }
        [DataMember]/*PropertyInfo Attribute Kadrovska.Djelatnik.Ime*/
        public string Ime { get; set; }
        [DataMember]/*PropertyInfo Attribute Kadrovska.Djelatnik.Email*/
        public string Email { get; set; }
        [DataMember]/*PropertyInfo Attribute Kadrovska.Djelatnik.Mobitel*/
        public string Mobitel { get; set; }
        [DataMember]/*PropertyInfo Attribute Kadrovska.Djelatnik.Tvrtka*/
        public string Tvrtka { get; set; }
        [DataMember]/*PropertyInfo Attribute Kadrovska.Djelatnik.OdjelID*/
        public Guid? OdjelID { get; set; }
        [DataMember]/*PropertyInfo Attribute Kadrovska.Djelatnik.SektorID*/
        public Guid? SektorID { get; set; }
        [DataMember]/*PropertyInfo Attribute Kadrovska.Djelatnik.TimID*/
        public Guid? TimID { get; set; }
        /*DataStructureInfo ClassBody Kadrovska.Djelatnik*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Kadrovska.Odjel*/
    public class Odjel : EntityBase<Kadrovska.Odjel>/*Next DataStructureInfo ClassInterace Kadrovska.Odjel*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Kadrovska_Odjel ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Kadrovska_Odjel
            {
                ID = item.ID,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Kadrovska.Odjel*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Kadrovska.Odjel.Naziv*/
        public string Naziv { get; set; }
        /*DataStructureInfo ClassBody Kadrovska.Odjel*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Kadrovska.Sektor*/
    public class Sektor : EntityBase<Kadrovska.Sektor>/*Next DataStructureInfo ClassInterace Kadrovska.Sektor*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Kadrovska_Sektor ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Kadrovska_Sektor
            {
                ID = item.ID,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Kadrovska.Sektor*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Kadrovska.Sektor.Naziv*/
        public string Naziv { get; set; }
        /*DataStructureInfo ClassBody Kadrovska.Sektor*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Kadrovska.Tim*/
    public class Tim : EntityBase<Kadrovska.Tim>/*Next DataStructureInfo ClassInterace Kadrovska.Tim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Kadrovska_Tim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Kadrovska_Tim
            {
                ID = item.ID,
                Naziv = item.Naziv,
                VoditeljID = item.VoditeljID/*DataStructureInfo AssignSimpleProperty Kadrovska.Tim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Kadrovska.Tim.Naziv*/
        public string Naziv { get; set; }
        [DataMember]/*PropertyInfo Attribute Kadrovska.Tim.VoditeljID*/
        public Guid? VoditeljID { get; set; }
        /*DataStructureInfo ClassBody Kadrovska.Tim*/
    }

    /*ModuleInfo Body Kadrovska*/
}

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

    /*ModuleInfo Using Common*/

    [DataContract]/*DataStructureInfo ClassAttributes Common.AutoCodeCache*/
    public class AutoCodeCache : EntityBase<Common.AutoCodeCache>/*Next DataStructureInfo ClassInterace Common.AutoCodeCache*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_AutoCodeCache ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Entity*/
        public string Entity { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Property*/
        public string Property { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Grouping*/
        public string Grouping { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Prefix*/
        public string Prefix { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.MinDigits*/
        public int? MinDigits { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.LastCode*/
        public int? LastCode { get; set; }
        /*DataStructureInfo ClassBody Common.AutoCodeCache*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.FilterId*/
    public class FilterId : EntityBase<Common.FilterId>, Rhetos.Dom.DefaultConcepts.ICommonFilterId/*Next DataStructureInfo ClassInterace Common.FilterId*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_FilterId ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.FilterId.Handle*/
        public Guid? Handle { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.FilterId.Value*/
        public Guid? Value { get; set; }
        /*DataStructureInfo ClassBody Common.FilterId*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata : EntityBase<Common.KeepSynchronizedMetadata>, Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata/*Next DataStructureInfo ClassInterace Common.KeepSynchronizedMetadata*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_KeepSynchronizedMetadata ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Target*/
        public string Target { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Source*/
        public string Source { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Context*/
        public string Context { get; set; }
        /*DataStructureInfo ClassBody Common.KeepSynchronizedMetadata*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ExclusiveLock*/
    public class ExclusiveLock : EntityBase<Common.ExclusiveLock>/*Next DataStructureInfo ClassInterace Common.ExclusiveLock*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_ExclusiveLock ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockStart*/
        public DateTime? LockStart { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockFinish*/
        public DateTime? LockFinish { get; set; }
        /*DataStructureInfo ClassBody Common.ExclusiveLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SetLock*/
    public class SetLock/*DataStructureInfo ClassInterace Common.SetLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.SetLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ReleaseLock*/
    public class ReleaseLock/*DataStructureInfo ClassInterace Common.ReleaseLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.ReleaseLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogReader*/
    public class LogReader : EntityBase<Common.LogReader>/*Next DataStructureInfo ClassInterace Common.LogReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogReader.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Created*/
        public DateTime? Created { get; set; }
        /*DataStructureInfo ClassBody Common.LogReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader : EntityBase<Common.LogRelatedItemReader>/*Next DataStructureInfo ClassInterace Common.LogRelatedItemReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItemReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.LogID*/
        public Guid? LogID { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItemReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Log*/
    public class Log : EntityBase<Common.Log>/*Next DataStructureInfo ClassInterace Common.Log*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Log ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Log.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.Log*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.AddToLog*/
    public class AddToLog/*DataStructureInfo ClassInterace Common.AddToLog*/
    {
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.AddToLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItem*/
    public class LogRelatedItem : EntityBase<Common.LogRelatedItem>/*Next DataStructureInfo ClassInterace Common.LogRelatedItem*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItem ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.Relation*/
        public string Relation { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItem*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource : EntityBase<Common.RelatedEventsSource>/*Next DataStructureInfo ClassInterace Common.RelatedEventsSource*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RelatedEventsSource ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToTable*/
        public string RelatedToTable { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToItem*/
        public Guid? RelatedToItem { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Created*/
        public DateTime? Created { get; set; }
        /*DataStructureInfo ClassBody Common.RelatedEventsSource*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Claim*/
    public class Claim : EntityBase<Common.Claim>, Rhetos.Dom.DefaultConcepts.IDeactivatable, Rhetos.Dom.DefaultConcepts.ICommonClaim/*Next DataStructureInfo ClassInterace Common.Claim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Claim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimResource*/
        public string ClaimResource { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimRight*/
        public string ClaimRight { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.Active*/
        public bool? Active { get; set; }
        /*DataStructureInfo ClassBody Common.Claim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.MyClaim*/
    public class MyClaim : EntityBase<Common.MyClaim>/*Next DataStructureInfo ClassInterace Common.MyClaim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_MyClaim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.MyClaim.Applies*/
        public bool? Applies { get; set; }
        /*DataStructureInfo ClassBody Common.MyClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Principal*/
    public class Principal : EntityBase<Common.Principal>, Rhetos.Dom.DefaultConcepts.IPrincipal/*Next DataStructureInfo ClassInterace Common.Principal*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Principal ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Principal.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Principal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole : EntityBase<Common.PrincipalHasRole>, Rhetos.Dom.DefaultConcepts.IPrincipalHasRole/*Next DataStructureInfo ClassInterace Common.PrincipalHasRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalHasRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.RoleID*/
        public Guid? RoleID { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalHasRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Role*/
    public class Role : EntityBase<Common.Role>, Rhetos.Dom.DefaultConcepts.IRole/*Next DataStructureInfo ClassInterace Common.Role*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Role ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Role.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Role*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole : EntityBase<Common.RoleInheritsRole>, Rhetos.Dom.DefaultConcepts.IRoleInheritsRole/*Next DataStructureInfo ClassInterace Common.RoleInheritsRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RoleInheritsRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.UsersFromID*/
        public Guid? UsersFromID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.PermissionsFromID*/
        public Guid? PermissionsFromID { get; set; }
        /*DataStructureInfo ClassBody Common.RoleInheritsRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalPermission*/
    public class PrincipalPermission : EntityBase<Common.PrincipalPermission>, Rhetos.Dom.DefaultConcepts.IPrincipalPermission/*Next DataStructureInfo ClassInterace Common.PrincipalPermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalPermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalPermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RolePermission*/
    public class RolePermission : EntityBase<Common.RolePermission>, Rhetos.Dom.DefaultConcepts.IRolePermission/*Next DataStructureInfo ClassInterace Common.RolePermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RolePermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RolePermission.RoleID*/
        public Guid? RoleID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.RolePermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsReadItems*/
    public class RowPermissionsReadItems/*DataStructureInfo ClassInterace Common.RowPermissionsReadItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsReadItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsWriteItems*/
    public class RowPermissionsWriteItems/*DataStructureInfo ClassInterace Common.RowPermissionsWriteItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsWriteItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredActive*/
    public class SystemRequiredActive/*DataStructureInfo ClassInterace Common.SystemRequiredActive*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredActive*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredLog*/
    public class SystemRequiredLog/*DataStructureInfo ClassInterace Common.SystemRequiredLog*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredPrincipal*/
    public class SystemRequiredPrincipal/*DataStructureInfo ClassInterace Common.SystemRequiredPrincipal*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredPrincipal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredUsersFrom*/
    public class SystemRequiredUsersFrom/*DataStructureInfo ClassInterace Common.SystemRequiredUsersFrom*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredUsersFrom*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredClaim*/
    public class SystemRequiredClaim/*DataStructureInfo ClassInterace Common.SystemRequiredClaim*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredRole*/
    public class SystemRequiredRole/*DataStructureInfo ClassInterace Common.SystemRequiredRole*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredRole*/
    }

    /*ModuleInfo Body Common*/
}

namespace LightDMS
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

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.Checkout*/
    public class Checkout : EntityBase<LightDMS.Checkout>/*Next DataStructureInfo ClassInterace LightDMS.Checkout*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_Checkout ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_Checkout
            {
                ID = item.ID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment,
                RepositoryID = item.RepositoryID/*DataStructureInfo AssignSimpleProperty LightDMS.Checkout*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.Checkout.DocumentID*/
        public Guid? DocumentID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.Checkout.CreatedByID*/
        public Guid? CreatedByID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.Checkout.CreatedDate*/
        public DateTime? CreatedDate { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.Checkout.Comment*/
        public string Comment { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.Checkout.RepositoryID*/
        public Guid? RepositoryID { get; set; }
        /*DataStructureInfo ClassBody LightDMS.Checkout*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.MultipleDocumentCheckout*/
    public class MultipleDocumentCheckout/*DataStructureInfo ClassInterace LightDMS.MultipleDocumentCheckout*/
    {
        /*DataStructureInfo ClassBody LightDMS.MultipleDocumentCheckout*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.NullDocumentCheckout*/
    public class NullDocumentCheckout/*DataStructureInfo ClassInterace LightDMS.NullDocumentCheckout*/
    {
        /*DataStructureInfo ClassBody LightDMS.NullDocumentCheckout*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.DocumentEvent*/
    public class DocumentEvent : EntityBase<LightDMS.DocumentEvent>/*Next DataStructureInfo ClassInterace LightDMS.DocumentEvent*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_DocumentEvent ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_DocumentEvent
            {
                ID = item.ID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment,
                RepositoryID = item.RepositoryID,
                CheckoutID = item.CheckoutID,
                DocumentVersionID = item.DocumentVersionID,
                UndoCheckoutID = item.UndoCheckoutID,
                Subtype = item.Subtype/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentEvent*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentEvent.DocumentID*/
        public Guid? DocumentID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentEvent.CreatedByID*/
        public Guid? CreatedByID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentEvent.CreatedDate*/
        public DateTime? CreatedDate { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentEvent.Comment*/
        public string Comment { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentEvent.RepositoryID*/
        public Guid? RepositoryID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentEvent.CheckoutID*/
        public Guid? CheckoutID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentEvent.DocumentVersionID*/
        public Guid? DocumentVersionID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentEvent.UndoCheckoutID*/
        public Guid? UndoCheckoutID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentEvent.Subtype*/
        public string Subtype { get; set; }
        /*DataStructureInfo ClassBody LightDMS.DocumentEvent*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.DocumentStatusBeforeEvent*/
    public class DocumentStatusBeforeEvent : EntityBase<LightDMS.DocumentStatusBeforeEvent>/*Next DataStructureInfo ClassInterace LightDMS.DocumentStatusBeforeEvent*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_DocumentStatusBeforeEvent ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_DocumentStatusBeforeEvent
            {
                ID = item.ID,
                PreviousEventID = item.PreviousEventID,
                DocumentID = item.DocumentID,
                CheckoutID = item.CheckoutID,
                CheckedOutToID = item.CheckedOutToID,
                DocumentVersionID = item.DocumentVersionID/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentStatusBeforeEvent*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentStatusBeforeEvent.PreviousEventID*/
        public Guid? PreviousEventID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentStatusBeforeEvent.DocumentID*/
        public Guid? DocumentID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentStatusBeforeEvent.CheckoutID*/
        public Guid? CheckoutID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentStatusBeforeEvent.CheckedOutToID*/
        public Guid? CheckedOutToID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentStatusBeforeEvent.DocumentVersionID*/
        public Guid? DocumentVersionID { get; set; }
        /*DataStructureInfo ClassBody LightDMS.DocumentStatusBeforeEvent*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.ComputeDocumentStatus*/
    public class ComputeDocumentStatus : EntityBase<LightDMS.ComputeDocumentStatus>/*Next DataStructureInfo ClassInterace LightDMS.ComputeDocumentStatus*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_ComputeDocumentStatus ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_ComputeDocumentStatus
            {
                ID = item.ID,
                LastEventID = item.LastEventID,
                CheckedOutToID = item.CheckedOutToID,
                IsCheckout = item.IsCheckout,
                LastVersionID = item.LastVersionID/*DataStructureInfo AssignSimpleProperty LightDMS.ComputeDocumentStatus*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.ComputeDocumentStatus.LastEventID*/
        public Guid? LastEventID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.ComputeDocumentStatus.CheckedOutToID*/
        public Guid? CheckedOutToID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.ComputeDocumentStatus.IsCheckout*/
        public bool? IsCheckout { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.ComputeDocumentStatus.LastVersionID*/
        public Guid? LastVersionID { get; set; }
        /*DataStructureInfo ClassBody LightDMS.ComputeDocumentStatus*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.DocumentStatus*/
    public class DocumentStatus : EntityBase<LightDMS.DocumentStatus>/*Next DataStructureInfo ClassInterace LightDMS.DocumentStatus*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_DocumentStatus ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_DocumentStatus
            {
                ID = item.ID,
                LastEventID = item.LastEventID,
                CheckedOutToID = item.CheckedOutToID,
                IsCheckout = item.IsCheckout,
                LastVersionID = item.LastVersionID/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentStatus*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentStatus.LastEventID*/
        public Guid? LastEventID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentStatus.CheckedOutToID*/
        public Guid? CheckedOutToID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentStatus.IsCheckout*/
        public bool? IsCheckout { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentStatus.LastVersionID*/
        public Guid? LastVersionID { get; set; }
        /*DataStructureInfo ClassBody LightDMS.DocumentStatus*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.DocumentVersion*/
    public class DocumentVersion : EntityBase<LightDMS.DocumentVersion>/*Next DataStructureInfo ClassInterace LightDMS.DocumentVersion*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_DocumentVersion ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_DocumentVersion
            {
                ID = item.ID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment,
                VersionNumber = item.VersionNumber,
                FileName = item.FileName,
                FileContentID = item.FileContentID,
                RepositoryID = item.RepositoryID/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentVersion*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentVersion.DocumentID*/
        public Guid? DocumentID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentVersion.CreatedByID*/
        public Guid? CreatedByID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentVersion.CreatedDate*/
        public DateTime? CreatedDate { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentVersion.Comment*/
        public string Comment { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentVersion.VersionNumber*/
        public int? VersionNumber { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentVersion.FileName*/
        public string FileName { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentVersion.FileContentID*/
        public Guid? FileContentID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentVersion.RepositoryID*/
        public Guid? RepositoryID { get; set; }
        /*DataStructureInfo ClassBody LightDMS.DocumentVersion*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.OtherUserDocumentCheckIn*/
    public class OtherUserDocumentCheckIn/*DataStructureInfo ClassInterace LightDMS.OtherUserDocumentCheckIn*/
    {
        /*DataStructureInfo ClassBody LightDMS.OtherUserDocumentCheckIn*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.DocumentVersionExt*/
    public class DocumentVersionExt : EntityBase<LightDMS.DocumentVersionExt>/*Next DataStructureInfo ClassInterace LightDMS.DocumentVersionExt*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_DocumentVersionExt ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_DocumentVersionExt
            {
                ID = item.ID,
                SizeInKBytes = item.SizeInKBytes/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentVersionExt*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentVersionExt.SizeInKBytes*/
        public decimal? SizeInKBytes { get; set; }
        /*DataStructureInfo ClassBody LightDMS.DocumentVersionExt*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.FileContent*/
    public class FileContent : EntityBase<LightDMS.FileContent>/*Next DataStructureInfo ClassInterace LightDMS.FileContent*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_FileContent ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_FileContent
            {
                ID = item.ID,
                Content = item.Content,
                CreatedDate = item.CreatedDate,
                AzureStorage = item.AzureStorage/*DataStructureInfo AssignSimpleProperty LightDMS.FileContent*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.FileContent.Content*/
        public byte[] Content { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.FileContent.CreatedDate*/
        public DateTime? CreatedDate { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.FileContent.AzureStorage*/
        public bool? AzureStorage { get; set; }
        /*DataStructureInfo ClassBody LightDMS.FileContent*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.DocumentRepository*/
    public class DocumentRepository : EntityBase<LightDMS.DocumentRepository>/*Next DataStructureInfo ClassInterace LightDMS.DocumentRepository*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_DocumentRepository ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_DocumentRepository
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentRepository*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.DocumentRepository.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody LightDMS.DocumentRepository*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.UndoCheckout*/
    public class UndoCheckout : EntityBase<LightDMS.UndoCheckout>/*Next DataStructureInfo ClassInterace LightDMS.UndoCheckout*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.LightDMS_UndoCheckout ToNavigation()
        {
            var item = this;
            return new Common.Queryable.LightDMS_UndoCheckout
            {
                ID = item.ID,
                RepositoryID = item.RepositoryID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment/*DataStructureInfo AssignSimpleProperty LightDMS.UndoCheckout*/
            };
        }

        [DataMember]/*PropertyInfo Attribute LightDMS.UndoCheckout.RepositoryID*/
        public Guid? RepositoryID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.UndoCheckout.DocumentID*/
        public Guid? DocumentID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.UndoCheckout.CreatedByID*/
        public Guid? CreatedByID { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.UndoCheckout.CreatedDate*/
        public DateTime? CreatedDate { get; set; }
        [DataMember]/*PropertyInfo Attribute LightDMS.UndoCheckout.Comment*/
        public string Comment { get; set; }
        /*DataStructureInfo ClassBody LightDMS.UndoCheckout*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.OtherUserDocumentUndoCheckout*/
    public class OtherUserDocumentUndoCheckout/*DataStructureInfo ClassInterace LightDMS.OtherUserDocumentUndoCheckout*/
    {
        /*DataStructureInfo ClassBody LightDMS.OtherUserDocumentUndoCheckout*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.DocumentNotCheckouted*/
    public class DocumentNotCheckouted/*DataStructureInfo ClassInterace LightDMS.DocumentNotCheckouted*/
    {
        /*DataStructureInfo ClassBody LightDMS.DocumentNotCheckouted*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.ContentIliAzureStorage*/
    public class ContentIliAzureStorage/*DataStructureInfo ClassInterace LightDMS.ContentIliAzureStorage*/
    {
        /*DataStructureInfo ClassBody LightDMS.ContentIliAzureStorage*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.SystemRequiredCreatedBy*/
    public class SystemRequiredCreatedBy/*DataStructureInfo ClassInterace LightDMS.SystemRequiredCreatedBy*/
    {
        /*DataStructureInfo ClassBody LightDMS.SystemRequiredCreatedBy*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.SystemRequiredCreatedDate*/
    public class SystemRequiredCreatedDate/*DataStructureInfo ClassInterace LightDMS.SystemRequiredCreatedDate*/
    {
        /*DataStructureInfo ClassBody LightDMS.SystemRequiredCreatedDate*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes LightDMS.SystemRequiredVersionNumber*/
    public class SystemRequiredVersionNumber/*DataStructureInfo ClassInterace LightDMS.SystemRequiredVersionNumber*/
    {
        /*DataStructureInfo ClassBody LightDMS.SystemRequiredVersionNumber*/
    }

    /*ModuleInfo Body LightDMS*/
}

/*SimpleClasses*/

namespace Common.Queryable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*DataStructureInfo QueryableClassAttributes Kadrovska.Djelatnik*/
    public class Kadrovska_Djelatnik : global::Kadrovska.Djelatnik, IQueryableEntity<Kadrovska.Djelatnik>, System.IEquatable<Kadrovska_Djelatnik>, IDetachOverride/*DataStructureInfo QueryableClassInterace Kadrovska.Djelatnik*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Kadrovska.Djelatnik ToSimple()
        {
            var item = this;
            return new Kadrovska.Djelatnik
            {
                ID = item.ID,
                MaticniBroj = item.MaticniBroj,
                Prezime = item.Prezime,
                Ime = item.Ime,
                Email = item.Email,
                Mobitel = item.Mobitel,
                Tvrtka = item.Tvrtka,
                OdjelID = item.OdjelID,
                SektorID = item.SektorID,
                TimID = item.TimID/*DataStructureInfo AssignSimpleProperty Kadrovska.Djelatnik*/
            };
        }

        private Common.Queryable.Kadrovska_Odjel _odjel;

        /*DataStructureQueryable PropertyAttribute Kadrovska.Djelatnik.Odjel*/
        public virtual Common.Queryable.Kadrovska_Odjel Odjel
        {
            get
            {
                /*DataStructureQueryable Getter Kadrovska.Djelatnik.Odjel*/
                return _odjel;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Kadrovska.Djelatnik.Odjel*/
                _odjel = value;
                OdjelID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Kadrovska_Sektor _sektor;

        /*DataStructureQueryable PropertyAttribute Kadrovska.Djelatnik.Sektor*/
        public virtual Common.Queryable.Kadrovska_Sektor Sektor
        {
            get
            {
                /*DataStructureQueryable Getter Kadrovska.Djelatnik.Sektor*/
                return _sektor;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Kadrovska.Djelatnik.Sektor*/
                _sektor = value;
                SektorID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Kadrovska_Tim _tim;

        /*DataStructureQueryable PropertyAttribute Kadrovska.Djelatnik.Tim*/
        public virtual Common.Queryable.Kadrovska_Tim Tim
        {
            get
            {
                /*DataStructureQueryable Getter Kadrovska.Djelatnik.Tim*/
                return _tim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Kadrovska.Djelatnik.Tim*/
                _tim = value;
                TimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Kadrovska.Djelatnik*/

        public bool Equals(Kadrovska_Djelatnik other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Kadrovska.Odjel*/
    public class Kadrovska_Odjel : global::Kadrovska.Odjel, IQueryableEntity<Kadrovska.Odjel>, System.IEquatable<Kadrovska_Odjel>, IDetachOverride/*DataStructureInfo QueryableClassInterace Kadrovska.Odjel*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Kadrovska.Odjel ToSimple()
        {
            var item = this;
            return new Kadrovska.Odjel
            {
                ID = item.ID,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Kadrovska.Odjel*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Kadrovska.Odjel*/

        public bool Equals(Kadrovska_Odjel other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Kadrovska.Sektor*/
    public class Kadrovska_Sektor : global::Kadrovska.Sektor, IQueryableEntity<Kadrovska.Sektor>, System.IEquatable<Kadrovska_Sektor>, IDetachOverride/*DataStructureInfo QueryableClassInterace Kadrovska.Sektor*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Kadrovska.Sektor ToSimple()
        {
            var item = this;
            return new Kadrovska.Sektor
            {
                ID = item.ID,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Kadrovska.Sektor*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Kadrovska.Sektor*/

        public bool Equals(Kadrovska_Sektor other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Kadrovska.Tim*/
    public class Kadrovska_Tim : global::Kadrovska.Tim, IQueryableEntity<Kadrovska.Tim>, System.IEquatable<Kadrovska_Tim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Kadrovska.Tim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Kadrovska.Tim ToSimple()
        {
            var item = this;
            return new Kadrovska.Tim
            {
                ID = item.ID,
                Naziv = item.Naziv,
                VoditeljID = item.VoditeljID/*DataStructureInfo AssignSimpleProperty Kadrovska.Tim*/
            };
        }

        private Common.Queryable.Kadrovska_Djelatnik _voditelj;

        /*DataStructureQueryable PropertyAttribute Kadrovska.Tim.Voditelj*/
        public virtual Common.Queryable.Kadrovska_Djelatnik Voditelj
        {
            get
            {
                /*DataStructureQueryable Getter Kadrovska.Tim.Voditelj*/
                return _voditelj;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Kadrovska.Tim.Voditelj*/
                _voditelj = value;
                VoditeljID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Kadrovska.Tim*/

        public bool Equals(Kadrovska_Tim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.AutoCodeCache*/
    public class Common_AutoCodeCache : global::Common.AutoCodeCache, IQueryableEntity<Common.AutoCodeCache>, System.IEquatable<Common_AutoCodeCache>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.AutoCodeCache*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.AutoCodeCache ToSimple()
        {
            var item = this;
            return new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.AutoCodeCache*/

        public bool Equals(Common_AutoCodeCache other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.FilterId*/
    public class Common_FilterId : global::Common.FilterId, IQueryableEntity<Common.FilterId>, System.IEquatable<Common_FilterId>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.FilterId*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.FilterId ToSimple()
        {
            var item = this;
            return new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.FilterId*/

        public bool Equals(Common_FilterId other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.KeepSynchronizedMetadata*/
    public class Common_KeepSynchronizedMetadata : global::Common.KeepSynchronizedMetadata, IQueryableEntity<Common.KeepSynchronizedMetadata>, System.IEquatable<Common_KeepSynchronizedMetadata>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.KeepSynchronizedMetadata*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.KeepSynchronizedMetadata ToSimple()
        {
            var item = this;
            return new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.KeepSynchronizedMetadata*/

        public bool Equals(Common_KeepSynchronizedMetadata other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.ExclusiveLock*/
    public class Common_ExclusiveLock : global::Common.ExclusiveLock, IQueryableEntity<Common.ExclusiveLock>, System.IEquatable<Common_ExclusiveLock>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.ExclusiveLock*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.ExclusiveLock ToSimple()
        {
            var item = this;
            return new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.ExclusiveLock*/

        public bool Equals(Common_ExclusiveLock other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogReader*/
    public class Common_LogReader : global::Common.LogReader, IQueryableEntity<Common.LogReader>, System.IEquatable<Common_LogReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogReader ToSimple()
        {
            var item = this;
            return new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.LogReader*/

        public bool Equals(Common_LogReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItemReader*/
    public class Common_LogRelatedItemReader : global::Common.LogRelatedItemReader, IQueryableEntity<Common.LogRelatedItemReader>, System.IEquatable<Common_LogRelatedItemReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItemReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItemReader ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItemReader.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItemReader.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItemReader.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItemReader*/

        public bool Equals(Common_LogRelatedItemReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Log*/
    public class Common_Log : global::Common.Log, IQueryableEntity<Common.Log>, System.IEquatable<Common_Log>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Log*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Log ToSimple()
        {
            var item = this;
            return new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Log*/

        public bool Equals(Common_Log other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItem*/
    public class Common_LogRelatedItem : global::Common.LogRelatedItem, IQueryableEntity<Common.LogRelatedItem>, System.IEquatable<Common_LogRelatedItem>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItem*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItem ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItem.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItem.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItem.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItem*/

        public bool Equals(Common_LogRelatedItem other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RelatedEventsSource*/
    public class Common_RelatedEventsSource : global::Common.RelatedEventsSource, IQueryableEntity<Common.RelatedEventsSource>, System.IEquatable<Common_RelatedEventsSource>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RelatedEventsSource*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RelatedEventsSource ToSimple()
        {
            var item = this;
            return new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        private Common.Queryable.Common_LogReader _log;

        /*DataStructureQueryable PropertyAttribute Common.RelatedEventsSource.Log*/
        public virtual Common.Queryable.Common_LogReader Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.RelatedEventsSource.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RelatedEventsSource.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RelatedEventsSource*/

        public bool Equals(Common_RelatedEventsSource other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Claim*/
    public class Common_Claim : global::Common.Claim, IQueryableEntity<Common.Claim>, System.IEquatable<Common_Claim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Claim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Claim ToSimple()
        {
            var item = this;
            return new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        private Common.Queryable.Common_MyClaim _extension_MyClaim;

        /*DataStructureQueryable PropertyAttribute Common.Claim.Extension_MyClaim*/
        public virtual Common.Queryable.Common_MyClaim Extension_MyClaim
        {
            get
            {
                /*DataStructureQueryable Getter Common.Claim.Extension_MyClaim*/
                return _extension_MyClaim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.Claim.Extension_MyClaim*/
                _extension_MyClaim = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.Claim*/

        public bool Equals(Common_Claim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.MyClaim*/
    public class Common_MyClaim : global::Common.MyClaim, IQueryableEntity<Common.MyClaim>, System.IEquatable<Common_MyClaim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.MyClaim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.MyClaim ToSimple()
        {
            var item = this;
            return new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        private Common.Queryable.Common_Claim _base;

        /*DataStructureQueryable PropertyAttribute Common.MyClaim.Base*/
        public virtual Common.Queryable.Common_Claim Base
        {
            get
            {
                /*DataStructureQueryable Getter Common.MyClaim.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.MyClaim.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.MyClaim*/

        public bool Equals(Common_MyClaim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Principal*/
    public class Common_Principal : global::Common.Principal, IQueryableEntity<Common.Principal>, System.IEquatable<Common_Principal>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Principal*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Principal ToSimple()
        {
            var item = this;
            return new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Principal*/

        public bool Equals(Common_Principal other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalHasRole*/
    public class Common_PrincipalHasRole : global::Common.PrincipalHasRole, IQueryableEntity<Common.PrincipalHasRole>, System.IEquatable<Common_PrincipalHasRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalHasRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalHasRole ToSimple()
        {
            var item = this;
            return new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalHasRole*/

        public bool Equals(Common_PrincipalHasRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Role*/
    public class Common_Role : global::Common.Role, IQueryableEntity<Common.Role>, System.IEquatable<Common_Role>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Role*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Role ToSimple()
        {
            var item = this;
            return new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Role*/

        public bool Equals(Common_Role other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RoleInheritsRole*/
    public class Common_RoleInheritsRole : global::Common.RoleInheritsRole, IQueryableEntity<Common.RoleInheritsRole>, System.IEquatable<Common_RoleInheritsRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RoleInheritsRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RoleInheritsRole ToSimple()
        {
            var item = this;
            return new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        private Common.Queryable.Common_Role _usersFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.UsersFrom*/
        public virtual Common.Queryable.Common_Role UsersFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.UsersFrom*/
                return _usersFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.UsersFrom*/
                _usersFrom = value;
                UsersFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _permissionsFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.PermissionsFrom*/
        public virtual Common.Queryable.Common_Role PermissionsFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.PermissionsFrom*/
                return _permissionsFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.PermissionsFrom*/
                _permissionsFrom = value;
                PermissionsFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RoleInheritsRole*/

        public bool Equals(Common_RoleInheritsRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalPermission*/
    public class Common_PrincipalPermission : global::Common.PrincipalPermission, IQueryableEntity<Common.PrincipalPermission>, System.IEquatable<Common_PrincipalPermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalPermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalPermission ToSimple()
        {
            var item = this;
            return new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalPermission*/

        public bool Equals(Common_PrincipalPermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RolePermission*/
    public class Common_RolePermission : global::Common.RolePermission, IQueryableEntity<Common.RolePermission>, System.IEquatable<Common_RolePermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RolePermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RolePermission ToSimple()
        {
            var item = this;
            return new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RolePermission*/

        public bool Equals(Common_RolePermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.Checkout*/
    public class LightDMS_Checkout : global::LightDMS.Checkout, IQueryableEntity<LightDMS.Checkout>, System.IEquatable<LightDMS_Checkout>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.Checkout*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.Checkout ToSimple()
        {
            var item = this;
            return new LightDMS.Checkout
            {
                ID = item.ID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment,
                RepositoryID = item.RepositoryID/*DataStructureInfo AssignSimpleProperty LightDMS.Checkout*/
            };
        }

        private Common.Queryable.Common_Principal _createdBy;

        /*DataStructureQueryable PropertyAttribute LightDMS.Checkout.CreatedBy*/
        public virtual Common.Queryable.Common_Principal CreatedBy
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.Checkout.CreatedBy*/
                return _createdBy;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.Checkout.CreatedBy*/
                _createdBy = value;
                CreatedByID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_DocumentRepository _repository;

        /*DataStructureQueryable PropertyAttribute LightDMS.Checkout.Repository*/
        public virtual Common.Queryable.LightDMS_DocumentRepository Repository
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.Checkout.Repository*/
                return _repository;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.Checkout.Repository*/
                _repository = value;
                RepositoryID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.Checkout*/

        public bool Equals(LightDMS_Checkout other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.DocumentEvent*/
    public class LightDMS_DocumentEvent : global::LightDMS.DocumentEvent, IQueryableEntity<LightDMS.DocumentEvent>, System.IEquatable<LightDMS_DocumentEvent>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.DocumentEvent*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.DocumentEvent ToSimple()
        {
            var item = this;
            return new LightDMS.DocumentEvent
            {
                ID = item.ID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment,
                RepositoryID = item.RepositoryID,
                CheckoutID = item.CheckoutID,
                DocumentVersionID = item.DocumentVersionID,
                UndoCheckoutID = item.UndoCheckoutID,
                Subtype = item.Subtype/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentEvent*/
            };
        }

        private Common.Queryable.Common_Principal _createdBy;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentEvent.CreatedBy*/
        public virtual Common.Queryable.Common_Principal CreatedBy
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentEvent.CreatedBy*/
                return _createdBy;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentEvent.CreatedBy*/
                _createdBy = value;
                CreatedByID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_DocumentStatusBeforeEvent _extension_DocumentStatusBeforeEvent;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentEvent.Extension_DocumentStatusBeforeEvent*/
        public virtual Common.Queryable.LightDMS_DocumentStatusBeforeEvent Extension_DocumentStatusBeforeEvent
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentEvent.Extension_DocumentStatusBeforeEvent*/
                return _extension_DocumentStatusBeforeEvent;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentEvent.Extension_DocumentStatusBeforeEvent*/
                _extension_DocumentStatusBeforeEvent = value;
            }
        }

        private Common.Queryable.LightDMS_DocumentRepository _repository;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentEvent.Repository*/
        public virtual Common.Queryable.LightDMS_DocumentRepository Repository
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentEvent.Repository*/
                return _repository;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentEvent.Repository*/
                _repository = value;
                RepositoryID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_Checkout _checkout;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentEvent.Checkout*/
        public virtual Common.Queryable.LightDMS_Checkout Checkout
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentEvent.Checkout*/
                return _checkout;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentEvent.Checkout*/
                _checkout = value;
                CheckoutID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_DocumentVersion _documentVersion;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentEvent.DocumentVersion*/
        public virtual Common.Queryable.LightDMS_DocumentVersion DocumentVersion
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentEvent.DocumentVersion*/
                return _documentVersion;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentEvent.DocumentVersion*/
                _documentVersion = value;
                DocumentVersionID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_UndoCheckout _undoCheckout;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentEvent.UndoCheckout*/
        public virtual Common.Queryable.LightDMS_UndoCheckout UndoCheckout
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentEvent.UndoCheckout*/
                return _undoCheckout;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentEvent.UndoCheckout*/
                _undoCheckout = value;
                UndoCheckoutID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.DocumentEvent*/

        public bool Equals(LightDMS_DocumentEvent other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.DocumentStatusBeforeEvent*/
    public class LightDMS_DocumentStatusBeforeEvent : global::LightDMS.DocumentStatusBeforeEvent, IQueryableEntity<LightDMS.DocumentStatusBeforeEvent>, System.IEquatable<LightDMS_DocumentStatusBeforeEvent>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.DocumentStatusBeforeEvent*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.DocumentStatusBeforeEvent ToSimple()
        {
            var item = this;
            return new LightDMS.DocumentStatusBeforeEvent
            {
                ID = item.ID,
                PreviousEventID = item.PreviousEventID,
                DocumentID = item.DocumentID,
                CheckoutID = item.CheckoutID,
                CheckedOutToID = item.CheckedOutToID,
                DocumentVersionID = item.DocumentVersionID/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentStatusBeforeEvent*/
            };
        }

        private Common.Queryable.LightDMS_DocumentEvent _base;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentStatusBeforeEvent.Base*/
        public virtual Common.Queryable.LightDMS_DocumentEvent Base
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentStatusBeforeEvent.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentStatusBeforeEvent.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        private Common.Queryable.LightDMS_DocumentEvent _previousEvent;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentStatusBeforeEvent.PreviousEvent*/
        public virtual Common.Queryable.LightDMS_DocumentEvent PreviousEvent
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentStatusBeforeEvent.PreviousEvent*/
                return _previousEvent;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentStatusBeforeEvent.PreviousEvent*/
                _previousEvent = value;
                PreviousEventID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_Checkout _checkout;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentStatusBeforeEvent.Checkout*/
        public virtual Common.Queryable.LightDMS_Checkout Checkout
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentStatusBeforeEvent.Checkout*/
                return _checkout;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentStatusBeforeEvent.Checkout*/
                _checkout = value;
                CheckoutID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Principal _checkedOutTo;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentStatusBeforeEvent.CheckedOutTo*/
        public virtual Common.Queryable.Common_Principal CheckedOutTo
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentStatusBeforeEvent.CheckedOutTo*/
                return _checkedOutTo;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentStatusBeforeEvent.CheckedOutTo*/
                _checkedOutTo = value;
                CheckedOutToID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_DocumentVersion _documentVersion;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentStatusBeforeEvent.DocumentVersion*/
        public virtual Common.Queryable.LightDMS_DocumentVersion DocumentVersion
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentStatusBeforeEvent.DocumentVersion*/
                return _documentVersion;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentStatusBeforeEvent.DocumentVersion*/
                _documentVersion = value;
                DocumentVersionID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.DocumentStatusBeforeEvent*/

        public bool Equals(LightDMS_DocumentStatusBeforeEvent other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.ComputeDocumentStatus*/
    public class LightDMS_ComputeDocumentStatus : global::LightDMS.ComputeDocumentStatus, IQueryableEntity<LightDMS.ComputeDocumentStatus>, System.IEquatable<LightDMS_ComputeDocumentStatus>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.ComputeDocumentStatus*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.ComputeDocumentStatus ToSimple()
        {
            var item = this;
            return new LightDMS.ComputeDocumentStatus
            {
                ID = item.ID,
                LastEventID = item.LastEventID,
                CheckedOutToID = item.CheckedOutToID,
                IsCheckout = item.IsCheckout,
                LastVersionID = item.LastVersionID/*DataStructureInfo AssignSimpleProperty LightDMS.ComputeDocumentStatus*/
            };
        }

        private Common.Queryable.Common_Principal _checkedOutTo;

        /*DataStructureQueryable PropertyAttribute LightDMS.ComputeDocumentStatus.CheckedOutTo*/
        public virtual Common.Queryable.Common_Principal CheckedOutTo
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.ComputeDocumentStatus.CheckedOutTo*/
                return _checkedOutTo;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.ComputeDocumentStatus.CheckedOutTo*/
                _checkedOutTo = value;
                CheckedOutToID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_DocumentVersion _lastVersion;

        /*DataStructureQueryable PropertyAttribute LightDMS.ComputeDocumentStatus.LastVersion*/
        public virtual Common.Queryable.LightDMS_DocumentVersion LastVersion
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.ComputeDocumentStatus.LastVersion*/
                return _lastVersion;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.ComputeDocumentStatus.LastVersion*/
                _lastVersion = value;
                LastVersionID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.ComputeDocumentStatus*/

        public bool Equals(LightDMS_ComputeDocumentStatus other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.DocumentStatus*/
    public class LightDMS_DocumentStatus : global::LightDMS.DocumentStatus, IQueryableEntity<LightDMS.DocumentStatus>, System.IEquatable<LightDMS_DocumentStatus>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.DocumentStatus*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.DocumentStatus ToSimple()
        {
            var item = this;
            return new LightDMS.DocumentStatus
            {
                ID = item.ID,
                LastEventID = item.LastEventID,
                CheckedOutToID = item.CheckedOutToID,
                IsCheckout = item.IsCheckout,
                LastVersionID = item.LastVersionID/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentStatus*/
            };
        }

        private Common.Queryable.Common_Principal _checkedOutTo;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentStatus.CheckedOutTo*/
        public virtual Common.Queryable.Common_Principal CheckedOutTo
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentStatus.CheckedOutTo*/
                return _checkedOutTo;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentStatus.CheckedOutTo*/
                _checkedOutTo = value;
                CheckedOutToID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_DocumentVersion _lastVersion;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentStatus.LastVersion*/
        public virtual Common.Queryable.LightDMS_DocumentVersion LastVersion
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentStatus.LastVersion*/
                return _lastVersion;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentStatus.LastVersion*/
                _lastVersion = value;
                LastVersionID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.DocumentStatus*/

        public bool Equals(LightDMS_DocumentStatus other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.DocumentVersion*/
    public class LightDMS_DocumentVersion : global::LightDMS.DocumentVersion, IQueryableEntity<LightDMS.DocumentVersion>, System.IEquatable<LightDMS_DocumentVersion>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.DocumentVersion*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.DocumentVersion ToSimple()
        {
            var item = this;
            return new LightDMS.DocumentVersion
            {
                ID = item.ID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment,
                VersionNumber = item.VersionNumber,
                FileName = item.FileName,
                FileContentID = item.FileContentID,
                RepositoryID = item.RepositoryID/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentVersion*/
            };
        }

        private Common.Queryable.Common_Principal _createdBy;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentVersion.CreatedBy*/
        public virtual Common.Queryable.Common_Principal CreatedBy
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentVersion.CreatedBy*/
                return _createdBy;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentVersion.CreatedBy*/
                _createdBy = value;
                CreatedByID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_DocumentVersionExt _extension_DocumentVersionExt;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentVersion.Extension_DocumentVersionExt*/
        public virtual Common.Queryable.LightDMS_DocumentVersionExt Extension_DocumentVersionExt
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentVersion.Extension_DocumentVersionExt*/
                return _extension_DocumentVersionExt;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentVersion.Extension_DocumentVersionExt*/
                _extension_DocumentVersionExt = value;
            }
        }

        private Common.Queryable.LightDMS_FileContent _fileContent;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentVersion.FileContent*/
        public virtual Common.Queryable.LightDMS_FileContent FileContent
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentVersion.FileContent*/
                return _fileContent;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentVersion.FileContent*/
                _fileContent = value;
                FileContentID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.LightDMS_DocumentRepository _repository;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentVersion.Repository*/
        public virtual Common.Queryable.LightDMS_DocumentRepository Repository
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentVersion.Repository*/
                return _repository;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentVersion.Repository*/
                _repository = value;
                RepositoryID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.DocumentVersion*/

        public bool Equals(LightDMS_DocumentVersion other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.DocumentVersionExt*/
    public class LightDMS_DocumentVersionExt : global::LightDMS.DocumentVersionExt, IQueryableEntity<LightDMS.DocumentVersionExt>, System.IEquatable<LightDMS_DocumentVersionExt>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.DocumentVersionExt*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.DocumentVersionExt ToSimple()
        {
            var item = this;
            return new LightDMS.DocumentVersionExt
            {
                ID = item.ID,
                SizeInKBytes = item.SizeInKBytes/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentVersionExt*/
            };
        }

        private Common.Queryable.LightDMS_DocumentVersion _base;

        /*DataStructureQueryable PropertyAttribute LightDMS.DocumentVersionExt.Base*/
        public virtual Common.Queryable.LightDMS_DocumentVersion Base
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.DocumentVersionExt.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.DocumentVersionExt.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.DocumentVersionExt*/

        public bool Equals(LightDMS_DocumentVersionExt other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.FileContent*/
    public class LightDMS_FileContent : global::LightDMS.FileContent, IQueryableEntity<LightDMS.FileContent>, System.IEquatable<LightDMS_FileContent>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.FileContent*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.FileContent ToSimple()
        {
            var item = this;
            return new LightDMS.FileContent
            {
                ID = item.ID,
                Content = item.Content,
                CreatedDate = item.CreatedDate,
                AzureStorage = item.AzureStorage/*DataStructureInfo AssignSimpleProperty LightDMS.FileContent*/
            };
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.FileContent*/

        public bool Equals(LightDMS_FileContent other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.DocumentRepository*/
    public class LightDMS_DocumentRepository : global::LightDMS.DocumentRepository, IQueryableEntity<LightDMS.DocumentRepository>, System.IEquatable<LightDMS_DocumentRepository>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.DocumentRepository*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.DocumentRepository ToSimple()
        {
            var item = this;
            return new LightDMS.DocumentRepository
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentRepository*/
            };
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.DocumentRepository*/

        public bool Equals(LightDMS_DocumentRepository other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes LightDMS.UndoCheckout*/
    public class LightDMS_UndoCheckout : global::LightDMS.UndoCheckout, IQueryableEntity<LightDMS.UndoCheckout>, System.IEquatable<LightDMS_UndoCheckout>, IDetachOverride/*DataStructureInfo QueryableClassInterace LightDMS.UndoCheckout*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public LightDMS.UndoCheckout ToSimple()
        {
            var item = this;
            return new LightDMS.UndoCheckout
            {
                ID = item.ID,
                RepositoryID = item.RepositoryID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment/*DataStructureInfo AssignSimpleProperty LightDMS.UndoCheckout*/
            };
        }

        private Common.Queryable.LightDMS_DocumentRepository _repository;

        /*DataStructureQueryable PropertyAttribute LightDMS.UndoCheckout.Repository*/
        public virtual Common.Queryable.LightDMS_DocumentRepository Repository
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.UndoCheckout.Repository*/
                return _repository;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.UndoCheckout.Repository*/
                _repository = value;
                RepositoryID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Principal _createdBy;

        /*DataStructureQueryable PropertyAttribute LightDMS.UndoCheckout.CreatedBy*/
        public virtual Common.Queryable.Common_Principal CreatedBy
        {
            get
            {
                /*DataStructureQueryable Getter LightDMS.UndoCheckout.CreatedBy*/
                return _createdBy;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter LightDMS.UndoCheckout.CreatedBy*/
                _createdBy = value;
                CreatedByID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers LightDMS.UndoCheckout*/

        public bool Equals(LightDMS_UndoCheckout other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*CommonQueryableMemebers*/
}

namespace Rhetos.Dom.DefaultConcepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    public static class QueryExtensions
    {
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Kadrovska.Djelatnik> ToSimple(this IQueryable<Common.Queryable.Kadrovska_Djelatnik> query)
        {
            return query.Select(item => new Kadrovska.Djelatnik
            {
                ID = item.ID,
                MaticniBroj = item.MaticniBroj,
                Prezime = item.Prezime,
                Ime = item.Ime,
                Email = item.Email,
                Mobitel = item.Mobitel,
                Tvrtka = item.Tvrtka,
                OdjelID = item.OdjelID,
                SektorID = item.SektorID,
                TimID = item.TimID/*DataStructureInfo AssignSimpleProperty Kadrovska.Djelatnik*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Kadrovska.Odjel> ToSimple(this IQueryable<Common.Queryable.Kadrovska_Odjel> query)
        {
            return query.Select(item => new Kadrovska.Odjel
            {
                ID = item.ID,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Kadrovska.Odjel*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Kadrovska.Sektor> ToSimple(this IQueryable<Common.Queryable.Kadrovska_Sektor> query)
        {
            return query.Select(item => new Kadrovska.Sektor
            {
                ID = item.ID,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Kadrovska.Sektor*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Kadrovska.Tim> ToSimple(this IQueryable<Common.Queryable.Kadrovska_Tim> query)
        {
            return query.Select(item => new Kadrovska.Tim
            {
                ID = item.ID,
                Naziv = item.Naziv,
                VoditeljID = item.VoditeljID/*DataStructureInfo AssignSimpleProperty Kadrovska.Tim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.AutoCodeCache> ToSimple(this IQueryable<Common.Queryable.Common_AutoCodeCache> query)
        {
            return query.Select(item => new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.FilterId> ToSimple(this IQueryable<Common.Queryable.Common_FilterId> query)
        {
            return query.Select(item => new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.KeepSynchronizedMetadata> ToSimple(this IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> query)
        {
            return query.Select(item => new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.ExclusiveLock> ToSimple(this IQueryable<Common.Queryable.Common_ExclusiveLock> query)
        {
            return query.Select(item => new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogReader> ToSimple(this IQueryable<Common.Queryable.Common_LogReader> query)
        {
            return query.Select(item => new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItemReader> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItemReader> query)
        {
            return query.Select(item => new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Log> ToSimple(this IQueryable<Common.Queryable.Common_Log> query)
        {
            return query.Select(item => new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItem> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItem> query)
        {
            return query.Select(item => new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RelatedEventsSource> ToSimple(this IQueryable<Common.Queryable.Common_RelatedEventsSource> query)
        {
            return query.Select(item => new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Claim> ToSimple(this IQueryable<Common.Queryable.Common_Claim> query)
        {
            return query.Select(item => new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.MyClaim> ToSimple(this IQueryable<Common.Queryable.Common_MyClaim> query)
        {
            return query.Select(item => new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Principal> ToSimple(this IQueryable<Common.Queryable.Common_Principal> query)
        {
            return query.Select(item => new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalHasRole> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalHasRole> query)
        {
            return query.Select(item => new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Role> ToSimple(this IQueryable<Common.Queryable.Common_Role> query)
        {
            return query.Select(item => new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RoleInheritsRole> ToSimple(this IQueryable<Common.Queryable.Common_RoleInheritsRole> query)
        {
            return query.Select(item => new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalPermission> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalPermission> query)
        {
            return query.Select(item => new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RolePermission> ToSimple(this IQueryable<Common.Queryable.Common_RolePermission> query)
        {
            return query.Select(item => new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.Checkout> ToSimple(this IQueryable<Common.Queryable.LightDMS_Checkout> query)
        {
            return query.Select(item => new LightDMS.Checkout
            {
                ID = item.ID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment,
                RepositoryID = item.RepositoryID/*DataStructureInfo AssignSimpleProperty LightDMS.Checkout*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.DocumentEvent> ToSimple(this IQueryable<Common.Queryable.LightDMS_DocumentEvent> query)
        {
            return query.Select(item => new LightDMS.DocumentEvent
            {
                ID = item.ID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment,
                RepositoryID = item.RepositoryID,
                CheckoutID = item.CheckoutID,
                DocumentVersionID = item.DocumentVersionID,
                UndoCheckoutID = item.UndoCheckoutID,
                Subtype = item.Subtype/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentEvent*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.DocumentStatusBeforeEvent> ToSimple(this IQueryable<Common.Queryable.LightDMS_DocumentStatusBeforeEvent> query)
        {
            return query.Select(item => new LightDMS.DocumentStatusBeforeEvent
            {
                ID = item.ID,
                PreviousEventID = item.PreviousEventID,
                DocumentID = item.DocumentID,
                CheckoutID = item.CheckoutID,
                CheckedOutToID = item.CheckedOutToID,
                DocumentVersionID = item.DocumentVersionID/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentStatusBeforeEvent*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.ComputeDocumentStatus> ToSimple(this IQueryable<Common.Queryable.LightDMS_ComputeDocumentStatus> query)
        {
            return query.Select(item => new LightDMS.ComputeDocumentStatus
            {
                ID = item.ID,
                LastEventID = item.LastEventID,
                CheckedOutToID = item.CheckedOutToID,
                IsCheckout = item.IsCheckout,
                LastVersionID = item.LastVersionID/*DataStructureInfo AssignSimpleProperty LightDMS.ComputeDocumentStatus*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.DocumentStatus> ToSimple(this IQueryable<Common.Queryable.LightDMS_DocumentStatus> query)
        {
            return query.Select(item => new LightDMS.DocumentStatus
            {
                ID = item.ID,
                LastEventID = item.LastEventID,
                CheckedOutToID = item.CheckedOutToID,
                IsCheckout = item.IsCheckout,
                LastVersionID = item.LastVersionID/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentStatus*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.DocumentVersion> ToSimple(this IQueryable<Common.Queryable.LightDMS_DocumentVersion> query)
        {
            return query.Select(item => new LightDMS.DocumentVersion
            {
                ID = item.ID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment,
                VersionNumber = item.VersionNumber,
                FileName = item.FileName,
                FileContentID = item.FileContentID,
                RepositoryID = item.RepositoryID/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentVersion*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.DocumentVersionExt> ToSimple(this IQueryable<Common.Queryable.LightDMS_DocumentVersionExt> query)
        {
            return query.Select(item => new LightDMS.DocumentVersionExt
            {
                ID = item.ID,
                SizeInKBytes = item.SizeInKBytes/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentVersionExt*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.FileContent> ToSimple(this IQueryable<Common.Queryable.LightDMS_FileContent> query)
        {
            return query.Select(item => new LightDMS.FileContent
            {
                ID = item.ID,
                Content = item.Content,
                CreatedDate = item.CreatedDate,
                AzureStorage = item.AzureStorage/*DataStructureInfo AssignSimpleProperty LightDMS.FileContent*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.DocumentRepository> ToSimple(this IQueryable<Common.Queryable.LightDMS_DocumentRepository> query)
        {
            return query.Select(item => new LightDMS.DocumentRepository
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty LightDMS.DocumentRepository*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<LightDMS.UndoCheckout> ToSimple(this IQueryable<Common.Queryable.LightDMS_UndoCheckout> query)
        {
            return query.Select(item => new LightDMS.UndoCheckout
            {
                ID = item.ID,
                RepositoryID = item.RepositoryID,
                DocumentID = item.DocumentID,
                CreatedByID = item.CreatedByID,
                CreatedDate = item.CreatedDate,
                Comment = item.Comment/*DataStructureInfo AssignSimpleProperty LightDMS.UndoCheckout*/
            });
        }
        /*QueryExtensionsMembers*/

        /// <summary>
        /// A specific overload of the 'ToSimple' method cannot be targeted from a generic method using generic type.
        /// This method uses reflection instead to find the specific 'ToSimple' method.
        /// </summary>
        public static IQueryable<TEntity> GenericToSimple<TEntity>(this IQueryable<IEntity> i)
            where TEntity : class, IEntity
	    {
            var method = typeof(QueryExtensions).GetMethod("ToSimple", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public, null, new Type[] { i.GetType() }, null);
            if (method == null)
                throw new Rhetos.FrameworkException("Cannot find 'ToSimple' method for argument type '" + i.GetType().ToString() + "'.");
            return (IQueryable<TEntity>)Rhetos.Utilities.ExceptionsUtility.InvokeEx(method, null, new object[] { i });
        }

        /// <summary>Converts the objects to simple object and the IEnumerable to List or Array, if not already.</summary>
        public static void LoadSimpleObjects<TEntity>(ref IEnumerable<TEntity> items)
            where TEntity: class, IEntity
        {
            var query = items as IQueryable<IQueryableEntity<TEntity>>;
            var navigationItems = items as IEnumerable<IQueryableEntity<TEntity>>;

            if (query != null)
                items = query.GenericToSimple<TEntity>().ToList(); // The IQueryable function allows ORM optimizations.
            else if (navigationItems != null)
                items = navigationItems.Select(item => item.ToSimple()).ToList();
            else
            {
                Rhetos.Utilities.CsUtility.Materialize(ref items);
                var itemsList = (IList<TEntity>)items;
                for (int i = 0; i < itemsList.Count(); i++)
                {
                    var navigationItem = itemsList[i] as IQueryableEntity<TEntity>;
                    if (navigationItem != null)
                        itemsList[i] = navigationItem.ToSimple();
                }
            }
        }
    }
}