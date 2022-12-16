using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the admin singleton.
    /// </summary>
    public class OnPremisesDirectorySynchronization : Entity, IParsable {
        /// <summary>Consists of configurations that can be fine-tuned and impact the on-premises directory synchronization process for a tenant.</summary>
        public OnPremisesDirectorySynchronizationConfiguration Configuration {
            get { return BackingStore?.Get<OnPremisesDirectorySynchronizationConfiguration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
        /// <summary>The features property</summary>
        public OnPremisesDirectorySynchronizationFeature Features {
            get { return BackingStore?.Get<OnPremisesDirectorySynchronizationFeature>("features"); }
            set { BackingStore?.Set("features", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnPremisesDirectorySynchronization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesDirectorySynchronization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configuration", n => { Configuration = n.GetObjectValue<OnPremisesDirectorySynchronizationConfiguration>(OnPremisesDirectorySynchronizationConfiguration.CreateFromDiscriminatorValue); } },
                {"features", n => { Features = n.GetObjectValue<OnPremisesDirectorySynchronizationFeature>(OnPremisesDirectorySynchronizationFeature.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnPremisesDirectorySynchronizationConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<OnPremisesDirectorySynchronizationFeature>("features", Features);
        }
    }
}
