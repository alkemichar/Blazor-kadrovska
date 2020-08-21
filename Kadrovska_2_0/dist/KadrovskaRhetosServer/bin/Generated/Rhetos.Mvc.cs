// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Generated\Captions.dll, 2020-05-05T20:02:06.1296620+02:00
// Reference: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll, 2019-08-06T08:44:51.3843847+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll, 2019-12-04T00:18:52.0000000+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll, 2019-07-24T05:27:10.0000000+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.DataAnnotations\v4.0_4.0.0.0__31bf3856ad364e35\System.ComponentModel.DataAnnotations.dll, 2018-09-15T09:29:51.9354571+02:00
// Reference: C:\aplikacije\Kadrovska_2_0\dist\KadrovskaRhetosServer\bin\Plugins\Rhetos.Mvc.Client.dll, 2020-05-02T19:52:47.9481985+02:00
// DomGeneratorOptions.Debug = "False"


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CaptionsResourceClass =  Rhetos.Mvc.Captions;
/*
    If you need to use additional DataAnnotation attributes, or override existing attributes in the generated MvcModel,
    create the following class in your project:

    [MetadataTypeAttribute(typeof(MyModel.AdditionalAttributes))]
    public partial class MyModel
    {
        internal sealed class AdditionalAttributes
        {
            private AdditionalAttributes() { }

            [Display(Name = "Last Name", Order = 1, Prompt = "Enter Last Name")]
            public string LastName { get; set; }

            // Add other properties ...
        }
    }
*/


namespace Rhetos.Mvc.Kadrovska
{
    [Rhetos.Mvc.LocalizedDisplayName("Kadrovska_Djelatnik", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class Djelatnik  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityDjelatnik = "Djelatnik";

        [Display(Name = "Kadrovska_Djelatnik_MaticniBroj", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string MaticniBroj { get; set; }
        public const string PropertyMaticniBroj = "MaticniBroj";
        
        [Display(Name = "Kadrovska_Djelatnik_Prezime", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Prezime { get; set; }
        public const string PropertyPrezime = "Prezime";
        
        [Display(Name = "Kadrovska_Djelatnik_Ime", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Ime { get; set; }
        public const string PropertyIme = "Ime";
        
        [Display(Name = "Kadrovska_Djelatnik_Email", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Email { get; set; }
        public const string PropertyEmail = "Email";
        
        [Display(Name = "Kadrovska_Djelatnik_Mobitel", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Mobitel { get; set; }
        public const string PropertyMobitel = "Mobitel";
        
        [Display(Name = "Kadrovska_Djelatnik_Tvrtka", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Tvrtka { get; set; }
        public const string PropertyTvrtka = "Tvrtka";
        
        [Display(Name = "Kadrovska_Djelatnik_Odjel", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? OdjelID { get; set; }
        public const string PropertyOdjelID = "OdjelID";
        
        [Display(Name = "Kadrovska_Djelatnik_Sektor", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? SektorID { get; set; }
        public const string PropertySektorID = "SektorID";
        
        [Display(Name = "Kadrovska_Djelatnik_Tim", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? TimID { get; set; }
        public const string PropertyTimID = "TimID";
    }
}

namespace Rhetos.Mvc.Kadrovska
{
    [Rhetos.Mvc.LocalizedDisplayName("Kadrovska_Odjel", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class Odjel  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityOdjel = "Odjel";

        [Display(Name = "Kadrovska_Odjel_Naziv", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Naziv { get; set; }
        public const string PropertyNaziv = "Naziv";
    }
}

namespace Rhetos.Mvc.Kadrovska
{
    [Rhetos.Mvc.LocalizedDisplayName("Kadrovska_Sektor", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class Sektor  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntitySektor = "Sektor";

        [Display(Name = "Kadrovska_Sektor_Naziv", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Naziv { get; set; }
        public const string PropertyNaziv = "Naziv";
    }
}

namespace Rhetos.Mvc.Kadrovska
{
    [Rhetos.Mvc.LocalizedDisplayName("Kadrovska_Tim", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class Tim  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityTim = "Tim";

        [Display(Name = "Kadrovska_Tim_Naziv", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Naziv { get; set; }
        public const string PropertyNaziv = "Naziv";
        
        [Display(Name = "Kadrovska_Tim_Voditelj", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual Guid? VoditeljID { get; set; }
        public const string PropertyVoditeljID = "VoditeljID";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_AutoCodeCache", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class AutoCodeCache  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityAutoCodeCache = "AutoCodeCache";

        [Display(Name = "Common_AutoCodeCache_Entity", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Entity { get; set; }
        public const string PropertyEntity = "Entity";
        
        [Display(Name = "Common_AutoCodeCache_Property", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Property { get; set; }
        public const string PropertyProperty = "Property";
        
        [Display(Name = "Common_AutoCodeCache_Grouping", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Grouping { get; set; }
        public const string PropertyGrouping = "Grouping";
        
        [Display(Name = "Common_AutoCodeCache_Prefix", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Prefix { get; set; }
        public const string PropertyPrefix = "Prefix";
        
        [Display(Name = "Common_AutoCodeCache_MinDigits", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual int? MinDigits { get; set; }
        public const string PropertyMinDigits = "MinDigits";
        
        [Display(Name = "Common_AutoCodeCache_LastCode", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual int? LastCode { get; set; }
        public const string PropertyLastCode = "LastCode";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_FilterId", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class FilterId  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityFilterId = "FilterId";

        [Display(Name = "Common_FilterId_Handle", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? Handle { get; set; }
        public const string PropertyHandle = "Handle";
        
        [Display(Name = "Common_FilterId_Value", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? Value { get; set; }
        public const string PropertyValue = "Value";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_KeepSynchronizedMetadata", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class KeepSynchronizedMetadata  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityKeepSynchronizedMetadata = "KeepSynchronizedMetadata";

        [Display(Name = "Common_KeepSynchronizedMetadata_Target", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Target { get; set; }
        public const string PropertyTarget = "Target";
        
        [Display(Name = "Common_KeepSynchronizedMetadata_Source", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Source { get; set; }
        public const string PropertySource = "Source";
        
        [Display(Name = "Common_KeepSynchronizedMetadata_Context", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Context { get; set; }
        public const string PropertyContext = "Context";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_ExclusiveLock", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class ExclusiveLock  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityExclusiveLock = "ExclusiveLock";

        [Display(Name = "Common_ExclusiveLock_ResourceType", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string ResourceType { get; set; }
        public const string PropertyResourceType = "ResourceType";
        
        [Display(Name = "Common_ExclusiveLock_ResourceID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        [Required()]
        public virtual Guid? ResourceID { get; set; }
        public const string PropertyResourceID = "ResourceID";
        
        [Display(Name = "Common_ExclusiveLock_UserName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string UserName { get; set; }
        public const string PropertyUserName = "UserName";
        
        [Display(Name = "Common_ExclusiveLock_Workstation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Workstation { get; set; }
        public const string PropertyWorkstation = "Workstation";
        
        [Display(Name = "Common_ExclusiveLock_LockStart", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? LockStart { get; set; }
        public const string PropertyLockStart = "LockStart";
        
        [Display(Name = "Common_ExclusiveLock_LockFinish", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? LockFinish { get; set; }
        public const string PropertyLockFinish = "LockFinish";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SetLock", typeof(CaptionsResourceClass))]
    public partial class SetLock  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntitySetLock = "SetLock";

        [Display(Name = "Common_SetLock_ResourceType", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ResourceType { get; set; }
        public const string PropertyResourceType = "ResourceType";
        
        [Display(Name = "Common_SetLock_ResourceID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? ResourceID { get; set; }
        public const string PropertyResourceID = "ResourceID";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_ReleaseLock", typeof(CaptionsResourceClass))]
    public partial class ReleaseLock  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityReleaseLock = "ReleaseLock";

        [Display(Name = "Common_ReleaseLock_ResourceType", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ResourceType { get; set; }
        public const string PropertyResourceType = "ResourceType";
        
        [Display(Name = "Common_ReleaseLock_ResourceID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? ResourceID { get; set; }
        public const string PropertyResourceID = "ResourceID";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_LogReader", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class LogReader  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityLogReader = "LogReader";

        [Display(Name = "Common_LogReader_UserName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string UserName { get; set; }
        public const string PropertyUserName = "UserName";
        
        [Display(Name = "Common_LogReader_Workstation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Workstation { get; set; }
        public const string PropertyWorkstation = "Workstation";
        
        [Display(Name = "Common_LogReader_ContextInfo", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ContextInfo { get; set; }
        public const string PropertyContextInfo = "ContextInfo";
        
        [Display(Name = "Common_LogReader_Action", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Action { get; set; }
        public const string PropertyAction = "Action";
        
        [Display(Name = "Common_LogReader_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_LogReader_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_LogReader_Description", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Description { get; set; }
        public const string PropertyDescription = "Description";
        
        [Display(Name = "Common_LogReader_Created", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? Created { get; set; }
        public const string PropertyCreated = "Created";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_LogRelatedItemReader", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class LogRelatedItemReader  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityLogRelatedItemReader = "LogRelatedItemReader";

        [Display(Name = "Common_LogRelatedItemReader_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_LogRelatedItemReader_Relation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Relation { get; set; }
        public const string PropertyRelation = "Relation";
        
        [Display(Name = "Common_LogRelatedItemReader_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_LogRelatedItemReader_Log", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual Guid? LogID { get; set; }
        public const string PropertyLogID = "LogID";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_Log", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class Log  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityLog = "Log";

        [Display(Name = "Common_Log_Created", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? Created { get; set; }
        public const string PropertyCreated = "Created";
        
        [Display(Name = "Common_Log_UserName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string UserName { get; set; }
        public const string PropertyUserName = "UserName";
        
        [Display(Name = "Common_Log_Workstation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Workstation { get; set; }
        public const string PropertyWorkstation = "Workstation";
        
        [Display(Name = "Common_Log_ContextInfo", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ContextInfo { get; set; }
        public const string PropertyContextInfo = "ContextInfo";
        
        [Display(Name = "Common_Log_Action", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Action { get; set; }
        public const string PropertyAction = "Action";
        
        [Display(Name = "Common_Log_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_Log_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_Log_Description", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Description { get; set; }
        public const string PropertyDescription = "Description";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_AddToLog", typeof(CaptionsResourceClass))]
    public partial class AddToLog  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityAddToLog = "AddToLog";

        [Display(Name = "Common_AddToLog_Action", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Action { get; set; }
        public const string PropertyAction = "Action";
        
        [Display(Name = "Common_AddToLog_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_AddToLog_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_AddToLog_Description", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Description { get; set; }
        public const string PropertyDescription = "Description";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_LogRelatedItem", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class LogRelatedItem  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityLogRelatedItem = "LogRelatedItem";

        [Display(Name = "Common_LogRelatedItem_Log", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        [Required()]
        public virtual Guid? LogID { get; set; }
        public const string PropertyLogID = "LogID";
        
        [Display(Name = "Common_LogRelatedItem_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_LogRelatedItem_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_LogRelatedItem_Relation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Relation { get; set; }
        public const string PropertyRelation = "Relation";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RelatedEventsSource", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class RelatedEventsSource  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityRelatedEventsSource = "RelatedEventsSource";

        [Display(Name = "Common_RelatedEventsSource_Log", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? LogID { get; set; }
        public const string PropertyLogID = "LogID";
        
        [Display(Name = "Common_RelatedEventsSource_Relation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Relation { get; set; }
        public const string PropertyRelation = "Relation";
        
        [Display(Name = "Common_RelatedEventsSource_RelatedToTable", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string RelatedToTable { get; set; }
        public const string PropertyRelatedToTable = "RelatedToTable";
        
        [Display(Name = "Common_RelatedEventsSource_RelatedToItem", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? RelatedToItem { get; set; }
        public const string PropertyRelatedToItem = "RelatedToItem";
        
        [Display(Name = "Common_RelatedEventsSource_UserName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string UserName { get; set; }
        public const string PropertyUserName = "UserName";
        
        [Display(Name = "Common_RelatedEventsSource_Workstation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Workstation { get; set; }
        public const string PropertyWorkstation = "Workstation";
        
        [Display(Name = "Common_RelatedEventsSource_ContextInfo", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ContextInfo { get; set; }
        public const string PropertyContextInfo = "ContextInfo";
        
        [Display(Name = "Common_RelatedEventsSource_Action", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Action { get; set; }
        public const string PropertyAction = "Action";
        
        [Display(Name = "Common_RelatedEventsSource_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_RelatedEventsSource_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_RelatedEventsSource_Description", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Description { get; set; }
        public const string PropertyDescription = "Description";
        
        [Display(Name = "Common_RelatedEventsSource_Created", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? Created { get; set; }
        public const string PropertyCreated = "Created";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_Claim", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    [Rhetos.Mvc.Deactivatable]
    public partial class Claim  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityClaim = "Claim";

        [Display(Name = "Common_Claim_ClaimResource", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string ClaimResource { get; set; }
        public const string PropertyClaimResource = "ClaimResource";
        
        [Display(Name = "Common_Claim_ClaimRight", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string ClaimRight { get; set; }
        public const string PropertyClaimRight = "ClaimRight";
        
        [Display(Name = "Common_Claim_Active", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [DefaultValue(true)]
        public virtual bool? Active { get; set; }
        public const string PropertyActive = "Active";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_MyClaim", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.Extends(typeof(Rhetos.Mvc.Common.Claim))]
    public partial class MyClaim  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityMyClaim = "MyClaim";

        [Display(Name = "Common_MyClaim_Applies", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual bool? Applies { get; set; }
        public const string PropertyApplies = "Applies";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_Principal", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class Principal  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityPrincipal = "Principal";

        [Display(Name = "Common_Principal_Name", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Name { get; set; }
        public const string PropertyName = "Name";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_PrincipalHasRole", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class PrincipalHasRole  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityPrincipalHasRole = "PrincipalHasRole";

        [Display(Name = "Common_PrincipalHasRole_Principal", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? PrincipalID { get; set; }
        public const string PropertyPrincipalID = "PrincipalID";
        
        [Display(Name = "Common_PrincipalHasRole_Role", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual Guid? RoleID { get; set; }
        public const string PropertyRoleID = "RoleID";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_Role", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class Role  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityRole = "Role";

        [Display(Name = "Common_Role_Name", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Name { get; set; }
        public const string PropertyName = "Name";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RoleInheritsRole", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class RoleInheritsRole  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityRoleInheritsRole = "RoleInheritsRole";

        [Display(Name = "Common_RoleInheritsRole_UsersFrom", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? UsersFromID { get; set; }
        public const string PropertyUsersFromID = "UsersFromID";
        
        [Display(Name = "Common_RoleInheritsRole_PermissionsFrom", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual Guid? PermissionsFromID { get; set; }
        public const string PropertyPermissionsFromID = "PermissionsFromID";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_PrincipalPermission", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class PrincipalPermission  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityPrincipalPermission = "PrincipalPermission";

        [Display(Name = "Common_PrincipalPermission_Principal", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? PrincipalID { get; set; }
        public const string PropertyPrincipalID = "PrincipalID";
        
        [Display(Name = "Common_PrincipalPermission_Claim", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? ClaimID { get; set; }
        public const string PropertyClaimID = "ClaimID";
        
        [Display(Name = "Common_PrincipalPermission_IsAuthorized", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual bool? IsAuthorized { get; set; }
        public const string PropertyIsAuthorized = "IsAuthorized";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RolePermission", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class RolePermission  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityRolePermission = "RolePermission";

        [Display(Name = "Common_RolePermission_Role", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? RoleID { get; set; }
        public const string PropertyRoleID = "RoleID";
        
        [Display(Name = "Common_RolePermission_Claim", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? ClaimID { get; set; }
        public const string PropertyClaimID = "ClaimID";
        
        [Display(Name = "Common_RolePermission_IsAuthorized", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual bool? IsAuthorized { get; set; }
        public const string PropertyIsAuthorized = "IsAuthorized";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RowPermissionsReadItems", typeof(CaptionsResourceClass))]
    public partial class RowPermissionsReadItems 
    {
        public const string EntityRowPermissionsReadItems = "RowPermissionsReadItems";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RowPermissionsWriteItems", typeof(CaptionsResourceClass))]
    public partial class RowPermissionsWriteItems 
    {
        public const string EntityRowPermissionsWriteItems = "RowPermissionsWriteItems";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_Checkout", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class Checkout  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityCheckout = "Checkout";

        [Display(Name = "LightDMS_Checkout_DocumentID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? DocumentID { get; set; }
        public const string PropertyDocumentID = "DocumentID";
        
        [Display(Name = "LightDMS_Checkout_CreatedBy", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? CreatedByID { get; set; }
        public const string PropertyCreatedByID = "CreatedByID";
        
        [Display(Name = "LightDMS_Checkout_CreatedDate", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual DateTime? CreatedDate { get; set; }
        public const string PropertyCreatedDate = "CreatedDate";
        
        [Display(Name = "LightDMS_Checkout_Comment", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Comment { get; set; }
        public const string PropertyComment = "Comment";
        
        [Display(Name = "LightDMS_Checkout_Repository", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? RepositoryID { get; set; }
        public const string PropertyRepositoryID = "RepositoryID";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_MultipleDocumentCheckout", typeof(CaptionsResourceClass))]
    public partial class MultipleDocumentCheckout 
    {
        public const string EntityMultipleDocumentCheckout = "MultipleDocumentCheckout";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_NullDocumentCheckout", typeof(CaptionsResourceClass))]
    public partial class NullDocumentCheckout 
    {
        public const string EntityNullDocumentCheckout = "NullDocumentCheckout";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_DocumentEvent", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class DocumentEvent  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityDocumentEvent = "DocumentEvent";

        [Display(Name = "LightDMS_DocumentEvent_DocumentID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? DocumentID { get; set; }
        public const string PropertyDocumentID = "DocumentID";
        
        [Display(Name = "LightDMS_DocumentEvent_CreatedBy", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? CreatedByID { get; set; }
        public const string PropertyCreatedByID = "CreatedByID";
        
        [Display(Name = "LightDMS_DocumentEvent_CreatedDate", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual DateTime? CreatedDate { get; set; }
        public const string PropertyCreatedDate = "CreatedDate";
        
        [Display(Name = "LightDMS_DocumentEvent_Comment", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Comment { get; set; }
        public const string PropertyComment = "Comment";
        
        [Display(Name = "LightDMS_DocumentEvent_Repository", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? RepositoryID { get; set; }
        public const string PropertyRepositoryID = "RepositoryID";
        
        [Display(Name = "LightDMS_DocumentEvent_Checkout", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? CheckoutID { get; set; }
        public const string PropertyCheckoutID = "CheckoutID";
        
        [Display(Name = "LightDMS_DocumentEvent_DocumentVersion", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? DocumentVersionID { get; set; }
        public const string PropertyDocumentVersionID = "DocumentVersionID";
        
        [Display(Name = "LightDMS_DocumentEvent_UndoCheckout", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? UndoCheckoutID { get; set; }
        public const string PropertyUndoCheckoutID = "UndoCheckoutID";
        
        [Display(Name = "LightDMS_DocumentEvent_Subtype", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Subtype { get; set; }
        public const string PropertySubtype = "Subtype";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_DocumentStatusBeforeEvent", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.Extends(typeof(Rhetos.Mvc.LightDMS.DocumentEvent))]
    public partial class DocumentStatusBeforeEvent  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityDocumentStatusBeforeEvent = "DocumentStatusBeforeEvent";

        [Display(Name = "LightDMS_DocumentStatusBeforeEvent_PreviousEvent", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? PreviousEventID { get; set; }
        public const string PropertyPreviousEventID = "PreviousEventID";
        
        [Display(Name = "LightDMS_DocumentStatusBeforeEvent_DocumentID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? DocumentID { get; set; }
        public const string PropertyDocumentID = "DocumentID";
        
        [Display(Name = "LightDMS_DocumentStatusBeforeEvent_Checkout", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? CheckoutID { get; set; }
        public const string PropertyCheckoutID = "CheckoutID";
        
        [Display(Name = "LightDMS_DocumentStatusBeforeEvent_CheckedOutTo", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? CheckedOutToID { get; set; }
        public const string PropertyCheckedOutToID = "CheckedOutToID";
        
        [Display(Name = "LightDMS_DocumentStatusBeforeEvent_DocumentVersion", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? DocumentVersionID { get; set; }
        public const string PropertyDocumentVersionID = "DocumentVersionID";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_ComputeDocumentStatus", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class ComputeDocumentStatus  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityComputeDocumentStatus = "ComputeDocumentStatus";

        [Display(Name = "LightDMS_ComputeDocumentStatus_LastEventID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? LastEventID { get; set; }
        public const string PropertyLastEventID = "LastEventID";
        
        [Display(Name = "LightDMS_ComputeDocumentStatus_CheckedOutTo", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? CheckedOutToID { get; set; }
        public const string PropertyCheckedOutToID = "CheckedOutToID";
        
        [Display(Name = "LightDMS_ComputeDocumentStatus_IsCheckout", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual bool? IsCheckout { get; set; }
        public const string PropertyIsCheckout = "IsCheckout";
        
        [Display(Name = "LightDMS_ComputeDocumentStatus_LastVersion", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? LastVersionID { get; set; }
        public const string PropertyLastVersionID = "LastVersionID";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_DocumentStatus", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class DocumentStatus  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityDocumentStatus = "DocumentStatus";

        [Display(Name = "LightDMS_DocumentStatus_LastEventID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? LastEventID { get; set; }
        public const string PropertyLastEventID = "LastEventID";
        
        [Display(Name = "LightDMS_DocumentStatus_CheckedOutTo", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? CheckedOutToID { get; set; }
        public const string PropertyCheckedOutToID = "CheckedOutToID";
        
        [Display(Name = "LightDMS_DocumentStatus_IsCheckout", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual bool? IsCheckout { get; set; }
        public const string PropertyIsCheckout = "IsCheckout";
        
        [Display(Name = "LightDMS_DocumentStatus_LastVersion", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? LastVersionID { get; set; }
        public const string PropertyLastVersionID = "LastVersionID";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_DocumentVersion", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class DocumentVersion  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityDocumentVersion = "DocumentVersion";

        [Display(Name = "LightDMS_DocumentVersion_DocumentID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? DocumentID { get; set; }
        public const string PropertyDocumentID = "DocumentID";
        
        [Display(Name = "LightDMS_DocumentVersion_CreatedBy", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? CreatedByID { get; set; }
        public const string PropertyCreatedByID = "CreatedByID";
        
        [Display(Name = "LightDMS_DocumentVersion_CreatedDate", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual DateTime? CreatedDate { get; set; }
        public const string PropertyCreatedDate = "CreatedDate";
        
        [Display(Name = "LightDMS_DocumentVersion_Comment", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Comment { get; set; }
        public const string PropertyComment = "Comment";
        
        [Display(Name = "LightDMS_DocumentVersion_VersionNumber", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual int? VersionNumber { get; set; }
        public const string PropertyVersionNumber = "VersionNumber";
        
        [Display(Name = "LightDMS_DocumentVersion_FileName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        [Required()]
        public virtual string FileName { get; set; }
        public const string PropertyFileName = "FileName";
        
        [Display(Name = "LightDMS_DocumentVersion_FileContent", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual Guid? FileContentID { get; set; }
        public const string PropertyFileContentID = "FileContentID";
        
        [Display(Name = "LightDMS_DocumentVersion_Repository", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? RepositoryID { get; set; }
        public const string PropertyRepositoryID = "RepositoryID";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_OtherUserDocumentCheckIn", typeof(CaptionsResourceClass))]
    public partial class OtherUserDocumentCheckIn 
    {
        public const string EntityOtherUserDocumentCheckIn = "OtherUserDocumentCheckIn";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_DocumentVersionExt", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.Extends(typeof(Rhetos.Mvc.LightDMS.DocumentVersion))]
    public partial class DocumentVersionExt  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityDocumentVersionExt = "DocumentVersionExt";

        [Display(Name = "LightDMS_DocumentVersionExt_SizeInKBytes", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public virtual decimal? SizeInKBytes { get; set; }
        public const string PropertySizeInKBytes = "SizeInKBytes";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_FileContent", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class FileContent  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityFileContent = "FileContent";

        [Display(Name = "LightDMS_FileContent_Content", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual byte[] Content { get; set; }
        public const string PropertyContent = "Content";
        
        [Display(Name = "LightDMS_FileContent_CreatedDate", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual DateTime? CreatedDate { get; set; }
        public const string PropertyCreatedDate = "CreatedDate";
        
        [Display(Name = "LightDMS_FileContent_AzureStorage", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual bool? AzureStorage { get; set; }
        public const string PropertyAzureStorage = "AzureStorage";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_DocumentRepository", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class DocumentRepository  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityDocumentRepository = "DocumentRepository";

        [Display(Name = "LightDMS_DocumentRepository_Name", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Name { get; set; }
        public const string PropertyName = "Name";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_UndoCheckout", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class UndoCheckout  : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityUndoCheckout = "UndoCheckout";

        [Display(Name = "LightDMS_UndoCheckout_Repository", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? RepositoryID { get; set; }
        public const string PropertyRepositoryID = "RepositoryID";
        
        [Display(Name = "LightDMS_UndoCheckout_DocumentID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? DocumentID { get; set; }
        public const string PropertyDocumentID = "DocumentID";
        
        [Display(Name = "LightDMS_UndoCheckout_CreatedBy", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? CreatedByID { get; set; }
        public const string PropertyCreatedByID = "CreatedByID";
        
        [Display(Name = "LightDMS_UndoCheckout_CreatedDate", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual DateTime? CreatedDate { get; set; }
        public const string PropertyCreatedDate = "CreatedDate";
        
        [Display(Name = "LightDMS_UndoCheckout_Comment", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Comment { get; set; }
        public const string PropertyComment = "Comment";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_OtherUserDocumentUndoCheckout", typeof(CaptionsResourceClass))]
    public partial class OtherUserDocumentUndoCheckout 
    {
        public const string EntityOtherUserDocumentUndoCheckout = "OtherUserDocumentUndoCheckout";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_DocumentNotCheckouted", typeof(CaptionsResourceClass))]
    public partial class DocumentNotCheckouted 
    {
        public const string EntityDocumentNotCheckouted = "DocumentNotCheckouted";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_ContentIliAzureStorage", typeof(CaptionsResourceClass))]
    public partial class ContentIliAzureStorage 
    {
        public const string EntityContentIliAzureStorage = "ContentIliAzureStorage";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_SystemRequiredCreatedBy", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredCreatedBy 
    {
        public const string EntitySystemRequiredCreatedBy = "SystemRequiredCreatedBy";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_SystemRequiredCreatedDate", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredCreatedDate 
    {
        public const string EntitySystemRequiredCreatedDate = "SystemRequiredCreatedDate";
    }
}

namespace Rhetos.Mvc.LightDMS
{
    [Rhetos.Mvc.LocalizedDisplayName("LightDMS_SystemRequiredVersionNumber", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredVersionNumber 
    {
        public const string EntitySystemRequiredVersionNumber = "SystemRequiredVersionNumber";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredActive", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredActive 
    {
        public const string EntitySystemRequiredActive = "SystemRequiredActive";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredLog", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredLog 
    {
        public const string EntitySystemRequiredLog = "SystemRequiredLog";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredPrincipal", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredPrincipal 
    {
        public const string EntitySystemRequiredPrincipal = "SystemRequiredPrincipal";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredUsersFrom", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredUsersFrom 
    {
        public const string EntitySystemRequiredUsersFrom = "SystemRequiredUsersFrom";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredClaim", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredClaim 
    {
        public const string EntitySystemRequiredClaim = "SystemRequiredClaim";
    }
}

namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredRole", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredRole 
    {
        public const string EntitySystemRequiredRole = "SystemRequiredRole";
    }
}
