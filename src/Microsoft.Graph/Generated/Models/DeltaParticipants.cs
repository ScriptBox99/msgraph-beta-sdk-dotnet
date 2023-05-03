using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeltaParticipants : Entity, IParsable {
        /// <summary>The participants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Participant>? Participants {
            get { return BackingStore?.Get<List<Participant>?>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#nullable restore
#else
        public List<Participant> Participants {
            get { return BackingStore?.Get<List<Participant>>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#endif
        /// <summary>The sequence number for the roster update that is used to identify the notification order.</summary>
        public long? SequenceNumber {
            get { return BackingStore?.Get<long?>("sequenceNumber"); }
            set { BackingStore?.Set("sequenceNumber", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeltaParticipants CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeltaParticipants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"participants", n => { Participants = n.GetCollectionOfObjectValues<Participant>(Participant.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sequenceNumber", n => { SequenceNumber = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Participant>("participants", Participants);
            writer.WriteLongValue("sequenceNumber", SequenceNumber);
        }
    }
}
