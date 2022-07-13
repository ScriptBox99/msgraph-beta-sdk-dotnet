using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageMultipleChoiceQuestion : AccessPackageQuestion, IParsable {
        /// <summary>Indicates whether requestor can select multiple choices as their answer.</summary>
        public bool? AllowsMultipleSelection {
            get { return BackingStore?.Get<bool?>("allowsMultipleSelection"); }
            set { BackingStore?.Set("allowsMultipleSelection", value); }
        }
        /// <summary>List of answer choices.</summary>
        public List<AccessPackageAnswerChoice> Choices {
            get { return BackingStore?.Get<List<AccessPackageAnswerChoice>>("choices"); }
            set { BackingStore?.Set("choices", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageMultipleChoiceQuestion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageMultipleChoiceQuestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowsMultipleSelection", n => { AllowsMultipleSelection = n.GetBoolValue(); } },
                {"choices", n => { Choices = n.GetCollectionOfObjectValues<AccessPackageAnswerChoice>(AccessPackageAnswerChoice.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowsMultipleSelection", AllowsMultipleSelection);
            writer.WriteCollectionOfObjectValues<AccessPackageAnswerChoice>("choices", Choices);
        }
    }
}
