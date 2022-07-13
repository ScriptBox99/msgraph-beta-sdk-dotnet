using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AttackSimulationRepeatOffender : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>User in an attack simulation and training campaign.</summary>
        public Microsoft.Graph.Beta.Models.AttackSimulationUser AttackSimulationUser {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AttackSimulationUser>("attackSimulationUser"); }
            set { BackingStore?.Set("attackSimulationUser", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of repeat offences of the user in attack simulation and training campaigns.</summary>
        public int? RepeatOffenceCount {
            get { return BackingStore?.Get<int?>("repeatOffenceCount"); }
            set { BackingStore?.Set("repeatOffenceCount", value); }
        }
        /// <summary>
        /// Instantiates a new attackSimulationRepeatOffender and sets the default values.
        /// </summary>
        public AttackSimulationRepeatOffender() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AttackSimulationRepeatOffender CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationRepeatOffender();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attackSimulationUser", n => { AttackSimulationUser = n.GetObjectValue<Microsoft.Graph.Beta.Models.AttackSimulationUser>(Microsoft.Graph.Beta.Models.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"repeatOffenceCount", n => { RepeatOffenceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteIntValue("repeatOffenceCount", RepeatOffenceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
