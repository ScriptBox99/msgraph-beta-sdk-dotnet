using Microsoft.Graph.Beta.Models.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Site : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place in this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemAnalytics? Analytics {
            get { return BackingStore?.Get<ItemAnalytics?>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#nullable restore
#else
        public ItemAnalytics Analytics {
            get { return BackingStore?.Get<ItemAnalytics>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#endif
        /// <summary>The collection of column definitions reusable across lists under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? Columns {
            get { return BackingStore?.Get<List<ColumnDefinition>?>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#nullable restore
#else
        public List<ColumnDefinition> Columns {
            get { return BackingStore?.Get<List<ColumnDefinition>>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#endif
        /// <summary>The collection of content types defined for this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContentType>? ContentTypes {
            get { return BackingStore?.Get<List<ContentType>?>("contentTypes"); }
            set { BackingStore?.Set("contentTypes", value); }
        }
#nullable restore
#else
        public List<ContentType> ContentTypes {
            get { return BackingStore?.Get<List<ContentType>>("contentTypes"); }
            set { BackingStore?.Set("contentTypes", value); }
        }
#endif
        /// <summary>The deleted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Deleted? Deleted {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Deleted?>("deleted"); }
            set { BackingStore?.Set("deleted", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Deleted Deleted {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Deleted>("deleted"); }
            set { BackingStore?.Set("deleted", value); }
        }
#endif
        /// <summary>The full title for the site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The default drive (document library) for this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Drive? Drive {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Drive?>("drive"); }
            set { BackingStore?.Set("drive", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Drive Drive {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Drive>("drive"); }
            set { BackingStore?.Set("drive", value); }
        }
#endif
        /// <summary>The collection of drives (document libraries) under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Drive>? Drives {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Drive>?>("drives"); }
            set { BackingStore?.Set("drives", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Drive> Drives {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Drive>>("drives"); }
            set { BackingStore?.Set("drives", value); }
        }
#endif
        /// <summary>The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? ExternalColumns {
            get { return BackingStore?.Get<List<ColumnDefinition>?>("externalColumns"); }
            set { BackingStore?.Set("externalColumns", value); }
        }
#nullable restore
#else
        public List<ColumnDefinition> ExternalColumns {
            get { return BackingStore?.Get<List<ColumnDefinition>>("externalColumns"); }
            set { BackingStore?.Set("externalColumns", value); }
        }
#endif
        /// <summary>The informationProtection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.InformationProtection? InformationProtection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InformationProtection?>("informationProtection"); }
            set { BackingStore?.Set("informationProtection", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.InformationProtection InformationProtection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InformationProtection>("informationProtection"); }
            set { BackingStore?.Set("informationProtection", value); }
        }
#endif
        /// <summary>Used to address any item contained in this site. This collection cannot be enumerated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BaseItem>? Items {
            get { return BackingStore?.Get<List<BaseItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<BaseItem> Items {
            get { return BackingStore?.Get<List<BaseItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>The collection of lists under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<List>? Lists {
            get { return BackingStore?.Get<List<List>?>("lists"); }
            set { BackingStore?.Set("lists", value); }
        }
#nullable restore
#else
        public List<List> Lists {
            get { return BackingStore?.Get<List<List>>("lists"); }
            set { BackingStore?.Set("lists", value); }
        }
#endif
        /// <summary>The onenote property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Onenote? Onenote {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Onenote?>("onenote"); }
            set { BackingStore?.Set("onenote", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Onenote Onenote {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Onenote>("onenote"); }
            set { BackingStore?.Set("onenote", value); }
        }
#endif
        /// <summary>The collection of long running operations for the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RichLongRunningOperation>? Operations {
            get { return BackingStore?.Get<List<RichLongRunningOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<RichLongRunningOperation> Operations {
            get { return BackingStore?.Get<List<RichLongRunningOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The collection of pages in the SitePages list in this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SitePage>? Pages {
            get { return BackingStore?.Get<List<SitePage>?>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#nullable restore
#else
        public List<SitePage> Pages {
            get { return BackingStore?.Get<List<SitePage>>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#endif
        /// <summary>The permissions associated with the site. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Permission>? Permissions {
            get { return BackingStore?.Get<List<Permission>?>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#nullable restore
#else
        public List<Permission> Permissions {
            get { return BackingStore?.Get<List<Permission>>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#endif
        /// <summary>If present, indicates that this is the root site in the site collection. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Root? Root {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Root?>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Root Root {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Root>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#endif
        /// <summary>The settings on this site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SiteSettings? Settings {
            get { return BackingStore?.Get<SiteSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public SiteSettings Settings {
            get { return BackingStore?.Get<SiteSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharepointIds? SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds?>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharepointIds SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#endif
        /// <summary>Provides details about the site&apos;s site collection. Available only on the root site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SiteCollection? SiteCollection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SiteCollection?>("siteCollection"); }
            set { BackingStore?.Set("siteCollection", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SiteCollection SiteCollection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SiteCollection>("siteCollection"); }
            set { BackingStore?.Set("siteCollection", value); }
        }
#endif
        /// <summary>The collection of the sub-sites under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Site>? Sites {
            get { return BackingStore?.Get<List<Site>?>("sites"); }
            set { BackingStore?.Set("sites", value); }
        }
#nullable restore
#else
        public List<Site> Sites {
            get { return BackingStore?.Get<List<Site>>("sites"); }
            set { BackingStore?.Set("sites", value); }
        }
#endif
        /// <summary>The termStore under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Store? TermStore {
            get { return BackingStore?.Get<Store?>("termStore"); }
            set { BackingStore?.Set("termStore", value); }
        }
#nullable restore
#else
        public Store TermStore {
            get { return BackingStore?.Get<Store>("termStore"); }
            set { BackingStore?.Set("termStore", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new site and sets the default values.
        /// </summary>
        public Site() : base() {
            OdataType = "#microsoft.graph.site";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Site CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Site();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deleted", n => { Deleted = n.GetObjectValue<Microsoft.Graph.Beta.Models.Deleted>(Microsoft.Graph.Beta.Models.Deleted.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue); } },
                {"drives", n => { Drives = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalColumns", n => { ExternalColumns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"informationProtection", n => { InformationProtection = n.GetObjectValue<Microsoft.Graph.Beta.Models.InformationProtection>(Microsoft.Graph.Beta.Models.InformationProtection.CreateFromDiscriminatorValue); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<BaseItem>(BaseItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lists", n => { Lists = n.GetCollectionOfObjectValues<List>(List.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onenote", n => { Onenote = n.GetObjectValue<Microsoft.Graph.Beta.Models.Onenote>(Microsoft.Graph.Beta.Models.Onenote.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<RichLongRunningOperation>(RichLongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pages", n => { Pages = n.GetCollectionOfObjectValues<SitePage>(SitePage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"permissions", n => { Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"root", n => { Root = n.GetObjectValue<Microsoft.Graph.Beta.Models.Root>(Microsoft.Graph.Beta.Models.Root.CreateFromDiscriminatorValue); } },
                {"settings", n => { Settings = n.GetObjectValue<SiteSettings>(SiteSettings.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>(Microsoft.Graph.Beta.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"siteCollection", n => { SiteCollection = n.GetObjectValue<Microsoft.Graph.Beta.Models.SiteCollection>(Microsoft.Graph.Beta.Models.SiteCollection.CreateFromDiscriminatorValue); } },
                {"sites", n => { Sites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue)?.ToList(); } },
                {"termStore", n => { TermStore = n.GetObjectValue<Store>(Store.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<ContentType>("contentTypes", ContentTypes);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Deleted>("deleted", Deleted);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Drive>("drives", Drives);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("externalColumns", ExternalColumns);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.InformationProtection>("informationProtection", InformationProtection);
            writer.WriteCollectionOfObjectValues<BaseItem>("items", Items);
            writer.WriteCollectionOfObjectValues<List>("lists", Lists);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<RichLongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<SitePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Root>("root", Root);
            writer.WriteObjectValue<SiteSettings>("settings", Settings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SiteCollection>("siteCollection", SiteCollection);
            writer.WriteCollectionOfObjectValues<Site>("sites", Sites);
            writer.WriteObjectValue<Store>("termStore", TermStore);
        }
    }
}
