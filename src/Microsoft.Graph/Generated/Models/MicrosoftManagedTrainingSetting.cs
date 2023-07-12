using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftManagedTrainingSetting : TrainingSetting, IParsable {
        /// <summary>The completionDateTime property</summary>
        public DateTimeOffset? CompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completionDateTime"); }
            set { BackingStore?.Set("completionDateTime", value); }
        }
        /// <summary>The trainingCompletionDuration property</summary>
        public Microsoft.Graph.Beta.Models.TrainingCompletionDuration? TrainingCompletionDuration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TrainingCompletionDuration?>("trainingCompletionDuration"); }
            set { BackingStore?.Set("trainingCompletionDuration", value); }
        }
        /// <summary>
        /// Instantiates a new microsoftManagedTrainingSetting and sets the default values.
        /// </summary>
        public MicrosoftManagedTrainingSetting() : base() {
            OdataType = "#microsoft.graph.microsoftManagedTrainingSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftManagedTrainingSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftManagedTrainingSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"trainingCompletionDuration", n => { TrainingCompletionDuration = n.GetEnumValue<TrainingCompletionDuration>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteEnumValue<TrainingCompletionDuration>("trainingCompletionDuration", TrainingCompletionDuration);
        }
    }
}
