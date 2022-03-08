using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class CaseSettings : Entity, IParsable {
        /// <summary>The OCR (Optical Character Recognition) settings for the case.</summary>
        public OcrSettings Ocr { get; set; }
        /// <summary>The redundancy (near duplicate and email threading) detection settings for the case.</summary>
        public RedundancyDetectionSettings RedundancyDetection { get; set; }
        /// <summary>The Topic Modeling (Themes) settings for the case.</summary>
        public TopicModelingSettings TopicModeling { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CaseSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CaseSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"ocr", (o,n) => { (o as CaseSettings).Ocr = n.GetObjectValue<OcrSettings>(OcrSettings.CreateFromDiscriminatorValue); } },
                {"redundancyDetection", (o,n) => { (o as CaseSettings).RedundancyDetection = n.GetObjectValue<RedundancyDetectionSettings>(RedundancyDetectionSettings.CreateFromDiscriminatorValue); } },
                {"topicModeling", (o,n) => { (o as CaseSettings).TopicModeling = n.GetObjectValue<TopicModelingSettings>(TopicModelingSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OcrSettings>("ocr", Ocr);
            writer.WriteObjectValue<RedundancyDetectionSettings>("redundancyDetection", RedundancyDetection);
            writer.WriteObjectValue<TopicModelingSettings>("topicModeling", TopicModeling);
        }
    }
}
