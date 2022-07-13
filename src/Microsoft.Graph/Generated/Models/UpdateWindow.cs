using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UpdateWindow : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>End of a time window during which agents can receive updates</summary>
        public Time? UpdateWindowEndTime {
            get { return BackingStore?.Get<Time?>("updateWindowEndTime"); }
            set { BackingStore?.Set("updateWindowEndTime", value); }
        }
        /// <summary>Start of a time window during which agents can receive updates</summary>
        public Time? UpdateWindowStartTime {
            get { return BackingStore?.Get<Time?>("updateWindowStartTime"); }
            set { BackingStore?.Set("updateWindowStartTime", value); }
        }
        /// <summary>
        /// Instantiates a new updateWindow and sets the default values.
        /// </summary>
        public UpdateWindow() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateWindow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateWindow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"updateWindowEndTime", n => { UpdateWindowEndTime = n.GetTimeValue(); } },
                {"updateWindowStartTime", n => { UpdateWindowStartTime = n.GetTimeValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeValue("updateWindowEndTime", UpdateWindowEndTime);
            writer.WriteTimeValue("updateWindowStartTime", UpdateWindowStartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
