using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class GovernanceRuleSetting : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The id of the rule. For example, ExpirationRule and MfaRule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleIdentifier {
            get { return BackingStore?.Get<string?>("ruleIdentifier"); }
            set { BackingStore?.Set("ruleIdentifier", value); }
        }
#nullable restore
#else
        public string RuleIdentifier {
            get { return BackingStore?.Get<string>("ruleIdentifier"); }
            set { BackingStore?.Set("ruleIdentifier", value); }
        }
#endif
        /// <summary>The settings of the rule. The value is a JSON string with a list of pairs in the format of ParameterName:ParameterValue. For example, {&apos;permanentAssignment&apos;:false,&apos;maximumGrantPeriodInMinutes&apos;:129600}</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Setting {
            get { return BackingStore?.Get<string?>("setting"); }
            set { BackingStore?.Set("setting", value); }
        }
#nullable restore
#else
        public string Setting {
            get { return BackingStore?.Get<string>("setting"); }
            set { BackingStore?.Set("setting", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new governanceRuleSetting and sets the default values.
        /// </summary>
        public GovernanceRuleSetting() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GovernanceRuleSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceRuleSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"ruleIdentifier", n => { RuleIdentifier = n.GetStringValue(); } },
                {"setting", n => { Setting = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("ruleIdentifier", RuleIdentifier);
            writer.WriteStringValue("setting", Setting);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
