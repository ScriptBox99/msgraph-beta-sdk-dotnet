using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.AssignmentFilters.ValidateFilter {
    /// <summary>Provides operations to call the validateFilter method.</summary>
    public class ValidateFilterPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceAndAppManagementAssignmentFilter property</summary>
        public Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter DeviceAndAppManagementAssignmentFilter {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter>("deviceAndAppManagementAssignmentFilter"); }
            set { BackingStore?.Set("deviceAndAppManagementAssignmentFilter", value); }
        }
        /// <summary>
        /// Instantiates a new validateFilterPostRequestBody and sets the default values.
        /// </summary>
        public ValidateFilterPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ValidateFilterPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidateFilterPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceAndAppManagementAssignmentFilter", n => { DeviceAndAppManagementAssignmentFilter = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter>(Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter>("deviceAndAppManagementAssignmentFilter", DeviceAndAppManagementAssignmentFilter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
