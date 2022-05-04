using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.ReviewSets.Item.Queries.Item.Export {
    /// <summary>Provides operations to call the export method.</summary>
    public class ExportRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The azureBlobContainer property</summary>
        public string AzureBlobContainer { get; set; }
        /// <summary>The azureBlobToken property</summary>
        public string AzureBlobToken { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The exportOptions property</summary>
        public Microsoft.Graph.Beta.Models.Security.ExportOptions? ExportOptions { get; set; }
        /// <summary>The exportStructure property</summary>
        public ExportFileStructure? ExportStructure { get; set; }
        /// <summary>The outputName property</summary>
        public string OutputName { get; set; }
        /// <summary>
        /// Instantiates a new exportRequestBody and sets the default values.
        /// </summary>
        public ExportRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExportRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExportRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"azureBlobContainer", n => { AzureBlobContainer = n.GetStringValue(); } },
                {"azureBlobToken", n => { AzureBlobToken = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"exportOptions", n => { ExportOptions = n.GetEnumValue<ExportOptions>(); } },
                {"exportStructure", n => { ExportStructure = n.GetEnumValue<ExportFileStructure>(); } },
                {"outputName", n => { OutputName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("azureBlobContainer", AzureBlobContainer);
            writer.WriteStringValue("azureBlobToken", AzureBlobToken);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<ExportOptions>("exportOptions", ExportOptions);
            writer.WriteEnumValue<ExportFileStructure>("exportStructure", ExportStructure);
            writer.WriteStringValue("outputName", OutputName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
