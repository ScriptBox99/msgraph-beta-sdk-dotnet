using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Item : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The baseUnitOfMeasureId property</summary>
        public Guid? BaseUnitOfMeasureId {
            get { return BackingStore?.Get<Guid?>("baseUnitOfMeasureId"); }
            set { BackingStore?.Set("baseUnitOfMeasureId", value); }
        }
        /// <summary>The blocked property</summary>
        public bool? Blocked {
            get { return BackingStore?.Get<bool?>("blocked"); }
            set { BackingStore?.Set("blocked", value); }
        }
        /// <summary>The displayName property</summary>
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
        /// <summary>The gtin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Gtin {
            get { return BackingStore?.Get<string?>("gtin"); }
            set { BackingStore?.Set("gtin", value); }
        }
#nullable restore
#else
        public string Gtin {
            get { return BackingStore?.Get<string>("gtin"); }
            set { BackingStore?.Set("gtin", value); }
        }
#endif
        /// <summary>The id property</summary>
        public Guid? Id {
            get { return BackingStore?.Get<Guid?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The inventory property</summary>
        public decimal? Inventory {
            get { return BackingStore?.Get<decimal?>("inventory"); }
            set { BackingStore?.Set("inventory", value); }
        }
        /// <summary>The itemCategory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ItemCategory? ItemCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ItemCategory?>("itemCategory"); }
            set { BackingStore?.Set("itemCategory", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ItemCategory ItemCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ItemCategory>("itemCategory"); }
            set { BackingStore?.Set("itemCategory", value); }
        }
#endif
        /// <summary>The itemCategoryCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemCategoryCode {
            get { return BackingStore?.Get<string?>("itemCategoryCode"); }
            set { BackingStore?.Set("itemCategoryCode", value); }
        }
#nullable restore
#else
        public string ItemCategoryCode {
            get { return BackingStore?.Get<string>("itemCategoryCode"); }
            set { BackingStore?.Set("itemCategoryCode", value); }
        }
#endif
        /// <summary>The itemCategoryId property</summary>
        public Guid? ItemCategoryId {
            get { return BackingStore?.Get<Guid?>("itemCategoryId"); }
            set { BackingStore?.Set("itemCategoryId", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number {
            get { return BackingStore?.Get<string?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public string Number {
            get { return BackingStore?.Get<string>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The picture property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Picture>? Picture {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Picture>?>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Picture> Picture {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Picture>>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
#endif
        /// <summary>The priceIncludesTax property</summary>
        public bool? PriceIncludesTax {
            get { return BackingStore?.Get<bool?>("priceIncludesTax"); }
            set { BackingStore?.Set("priceIncludesTax", value); }
        }
        /// <summary>The taxGroupCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxGroupCode {
            get { return BackingStore?.Get<string?>("taxGroupCode"); }
            set { BackingStore?.Set("taxGroupCode", value); }
        }
#nullable restore
#else
        public string TaxGroupCode {
            get { return BackingStore?.Get<string>("taxGroupCode"); }
            set { BackingStore?.Set("taxGroupCode", value); }
        }
#endif
        /// <summary>The taxGroupId property</summary>
        public Guid? TaxGroupId {
            get { return BackingStore?.Get<Guid?>("taxGroupId"); }
            set { BackingStore?.Set("taxGroupId", value); }
        }
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>The unitCost property</summary>
        public decimal? UnitCost {
            get { return BackingStore?.Get<decimal?>("unitCost"); }
            set { BackingStore?.Set("unitCost", value); }
        }
        /// <summary>The unitPrice property</summary>
        public decimal? UnitPrice {
            get { return BackingStore?.Get<decimal?>("unitPrice"); }
            set { BackingStore?.Set("unitPrice", value); }
        }
        /// <summary>
        /// Instantiates a new item and sets the default values.
        /// </summary>
        public Item() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Item CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Item();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"baseUnitOfMeasureId", n => { BaseUnitOfMeasureId = n.GetGuidValue(); } },
                {"blocked", n => { Blocked = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"gtin", n => { Gtin = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"inventory", n => { Inventory = n.GetDecimalValue(); } },
                {"itemCategory", n => { ItemCategory = n.GetObjectValue<Microsoft.Graph.Beta.Models.ItemCategory>(Microsoft.Graph.Beta.Models.ItemCategory.CreateFromDiscriminatorValue); } },
                {"itemCategoryCode", n => { ItemCategoryCode = n.GetStringValue(); } },
                {"itemCategoryId", n => { ItemCategoryId = n.GetGuidValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"picture", n => { Picture = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>(Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue)?.ToList(); } },
                {"priceIncludesTax", n => { PriceIncludesTax = n.GetBoolValue(); } },
                {"taxGroupCode", n => { TaxGroupCode = n.GetStringValue(); } },
                {"taxGroupId", n => { TaxGroupId = n.GetGuidValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"unitCost", n => { UnitCost = n.GetDecimalValue(); } },
                {"unitPrice", n => { UnitPrice = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("baseUnitOfMeasureId", BaseUnitOfMeasureId);
            writer.WriteBoolValue("blocked", Blocked);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("gtin", Gtin);
            writer.WriteGuidValue("id", Id);
            writer.WriteDecimalValue("inventory", Inventory);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ItemCategory>("itemCategory", ItemCategory);
            writer.WriteStringValue("itemCategoryCode", ItemCategoryCode);
            writer.WriteGuidValue("itemCategoryId", ItemCategoryId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>("picture", Picture);
            writer.WriteBoolValue("priceIncludesTax", PriceIncludesTax);
            writer.WriteStringValue("taxGroupCode", TaxGroupCode);
            writer.WriteGuidValue("taxGroupId", TaxGroupId);
            writer.WriteStringValue("type", Type);
            writer.WriteDecimalValue("unitCost", UnitCost);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
