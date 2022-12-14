using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    /// <summary>
    /// Provides operations to manage the collection of externalConnection entities.
    /// </summary>
    public class ConnectionOperation : Entity, IParsable {
        /// <summary>If status is failed, provides more information about the error that caused the failure.</summary>
        public Microsoft.Graph.Beta.Models.PublicError Error {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PublicError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
        /// <summary>Indicates the status of the asynchronous operation. Possible values are: unspecified, inprogress, completed, failed.</summary>
        public ConnectionOperationStatus? Status {
            get { return BackingStore?.Get<ConnectionOperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConnectionOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectionOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"error", n => { Error = n.GetObjectValue<Microsoft.Graph.Beta.Models.PublicError>(Microsoft.Graph.Beta.Models.PublicError.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<ConnectionOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PublicError>("error", Error);
            writer.WriteEnumValue<ConnectionOperationStatus>("status", Status);
        }
    }
}
