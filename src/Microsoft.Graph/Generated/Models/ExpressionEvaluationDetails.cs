using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ExpressionEvaluationDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents expression which has been evaluated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expression {
            get { return BackingStore?.Get<string?>("expression"); }
            set { BackingStore?.Set("expression", value); }
        }
#nullable restore
#else
        public string Expression {
            get { return BackingStore?.Get<string>("expression"); }
            set { BackingStore?.Set("expression", value); }
        }
#endif
        /// <summary>Represents the details of the evaluation of the expression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExpressionEvaluationDetails>? ExpressionEvaluationDetailsProp {
            get { return BackingStore?.Get<List<ExpressionEvaluationDetails>?>("expressionEvaluationDetails"); }
            set { BackingStore?.Set("expressionEvaluationDetails", value); }
        }
#nullable restore
#else
        public List<ExpressionEvaluationDetails> ExpressionEvaluationDetailsProp {
            get { return BackingStore?.Get<List<ExpressionEvaluationDetails>>("expressionEvaluationDetails"); }
            set { BackingStore?.Set("expressionEvaluationDetails", value); }
        }
#endif
        /// <summary>Represents the value of the result of the current expression.</summary>
        public bool? ExpressionResult {
            get { return BackingStore?.Get<bool?>("expressionResult"); }
            set { BackingStore?.Set("expressionResult", value); }
        }
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
        /// <summary>Defines the name of the property and the value of that property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PropertyToEvaluate? PropertyToEvaluate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PropertyToEvaluate?>("propertyToEvaluate"); }
            set { BackingStore?.Set("propertyToEvaluate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PropertyToEvaluate PropertyToEvaluate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PropertyToEvaluate>("propertyToEvaluate"); }
            set { BackingStore?.Set("propertyToEvaluate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new expressionEvaluationDetails and sets the default values.
        /// </summary>
        public ExpressionEvaluationDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExpressionEvaluationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpressionEvaluationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expression", n => { Expression = n.GetStringValue(); } },
                {"expressionEvaluationDetails", n => { ExpressionEvaluationDetailsProp = n.GetCollectionOfObjectValues<ExpressionEvaluationDetails>(ExpressionEvaluationDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"expressionResult", n => { ExpressionResult = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"propertyToEvaluate", n => { PropertyToEvaluate = n.GetObjectValue<Microsoft.Graph.Beta.Models.PropertyToEvaluate>(Microsoft.Graph.Beta.Models.PropertyToEvaluate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expression", Expression);
            writer.WriteCollectionOfObjectValues<ExpressionEvaluationDetails>("expressionEvaluationDetails", ExpressionEvaluationDetailsProp);
            writer.WriteBoolValue("expressionResult", ExpressionResult);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PropertyToEvaluate>("propertyToEvaluate", PropertyToEvaluate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
