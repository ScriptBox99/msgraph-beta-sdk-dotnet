// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Constraint that enforces an AbstractComplex type has or is set to a particular value
    /// </summary>
    public class DeviceManagementSettingAbstractImplementationConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>List of value which means not configured for the setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedAbstractImplementationDefinitionIds {
            get { return BackingStore?.Get<List<string>?>("allowedAbstractImplementationDefinitionIds"); }
            set { BackingStore?.Set("allowedAbstractImplementationDefinitionIds", value); }
        }
#nullable restore
#else
        public List<string> AllowedAbstractImplementationDefinitionIds {
            get { return BackingStore?.Get<List<string>>("allowedAbstractImplementationDefinitionIds"); }
            set { BackingStore?.Set("allowedAbstractImplementationDefinitionIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementSettingAbstractImplementationConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingAbstractImplementationConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingAbstractImplementationConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingAbstractImplementationConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingAbstractImplementationConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedAbstractImplementationDefinitionIds", n => { AllowedAbstractImplementationDefinitionIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedAbstractImplementationDefinitionIds", AllowedAbstractImplementationDefinitionIds);
        }
    }
}
