using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class DetectionAction : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The alertTemplate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.AlertTemplate? AlertTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AlertTemplate?>("alertTemplate"); }
            set { BackingStore?.Set("alertTemplate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.AlertTemplate AlertTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AlertTemplate>("alertTemplate"); }
            set { BackingStore?.Set("alertTemplate", value); }
        }
#endif
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
        /// <summary>The organizationalScope property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.OrganizationalScope? OrganizationalScope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.OrganizationalScope?>("organizationalScope"); }
            set { BackingStore?.Set("organizationalScope", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.OrganizationalScope OrganizationalScope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.OrganizationalScope>("organizationalScope"); }
            set { BackingStore?.Set("organizationalScope", value); }
        }
#endif
        /// <summary>The responseActions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ResponseAction>? ResponseActions {
            get { return BackingStore?.Get<List<ResponseAction>?>("responseActions"); }
            set { BackingStore?.Set("responseActions", value); }
        }
#nullable restore
#else
        public List<ResponseAction> ResponseActions {
            get { return BackingStore?.Get<List<ResponseAction>>("responseActions"); }
            set { BackingStore?.Set("responseActions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new detectionAction and sets the default values.
        /// </summary>
        public DetectionAction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DetectionAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DetectionAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alertTemplate", n => { AlertTemplate = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.AlertTemplate>(Microsoft.Graph.Beta.Models.Security.AlertTemplate.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organizationalScope", n => { OrganizationalScope = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.OrganizationalScope>(Microsoft.Graph.Beta.Models.Security.OrganizationalScope.CreateFromDiscriminatorValue); } },
                {"responseActions", n => { ResponseActions = n.GetCollectionOfObjectValues<ResponseAction>(ResponseAction.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.AlertTemplate>("alertTemplate", AlertTemplate);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.OrganizationalScope>("organizationalScope", OrganizationalScope);
            writer.WriteCollectionOfObjectValues<ResponseAction>("responseActions", ResponseActions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
