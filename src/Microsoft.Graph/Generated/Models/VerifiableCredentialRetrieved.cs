using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VerifiableCredentialRetrieved : VerifiableCredentialRequirementStatus, IParsable {
        /// <summary>The specific date and time that the presentation request will expire and a new one will need to be generated.</summary>
        public DateTimeOffset? ExpiryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expiryDateTime"); }
            set { BackingStore?.Set("expiryDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new verifiableCredentialRetrieved and sets the default values.
        /// </summary>
        public VerifiableCredentialRetrieved() : base() {
            OdataType = "#microsoft.graph.verifiableCredentialRetrieved";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VerifiableCredentialRetrieved CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifiableCredentialRetrieved();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"expiryDateTime", n => { ExpiryDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("expiryDateTime", ExpiryDateTime);
        }
    }
}
