using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceComplianceScriptError : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Error code for rule validation.</summary>
        public Microsoft.Graph.Beta.Models.Code? Code {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Code?>("code"); }
            set { BackingStore?.Set("code", value); }
        }
        /// <summary>Error code for rule validation.</summary>
        public Microsoft.Graph.Beta.Models.DeviceComplianceScriptRulesValidationError? DeviceComplianceScriptRulesValidationError {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceComplianceScriptRulesValidationError?>("deviceComplianceScriptRulesValidationError"); }
            set { BackingStore?.Set("deviceComplianceScriptRulesValidationError", value); }
        }
        /// <summary>Error message.</summary>
        public string Message {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
        /// <summary>The type property</summary>
        public string Type {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new deviceComplianceScriptError and sets the default values.
        /// </summary>
        public DeviceComplianceScriptError() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            Type = "#microsoft.graph.deviceComplianceScriptError";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceComplianceScriptError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceComplianceScriptRuleError" => new DeviceComplianceScriptRuleError(),
                _ => new DeviceComplianceScriptError(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code", n => { Code = n.GetEnumValue<Code>(); } },
                {"deviceComplianceScriptRulesValidationError", n => { DeviceComplianceScriptRulesValidationError = n.GetEnumValue<DeviceComplianceScriptRulesValidationError>(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"@odata.type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Code>("code", Code);
            writer.WriteEnumValue<DeviceComplianceScriptRulesValidationError>("deviceComplianceScriptRulesValidationError", DeviceComplianceScriptRulesValidationError);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("@odata.type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
