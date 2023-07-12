using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represents an ADMX decimalTextBox element and an ADMX decimal element.
    /// </summary>
    public class GroupPolicyPresentationDecimalTextBox : GroupPolicyUploadedPresentation, IParsable {
        /// <summary>An unsigned integer that specifies the initial value for the decimal text box. The default value is 1.</summary>
        public long? DefaultValue {
            get { return BackingStore?.Get<long?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
        /// <summary>An unsigned integer that specifies the maximum allowed value. The default value is 9999.</summary>
        public long? MaxValue {
            get { return BackingStore?.Get<long?>("maxValue"); }
            set { BackingStore?.Set("maxValue", value); }
        }
        /// <summary>An unsigned integer that specifies the minimum allowed value. The default value is 0.</summary>
        public long? MinValue {
            get { return BackingStore?.Get<long?>("minValue"); }
            set { BackingStore?.Set("minValue", value); }
        }
        /// <summary>Requirement to enter a value in the parameter box. The default value is false.</summary>
        public bool? Required {
            get { return BackingStore?.Get<bool?>("required"); }
            set { BackingStore?.Set("required", value); }
        }
        /// <summary>If true, create a spin control; otherwise, create a text box for numeric entry. The default value is true.</summary>
        public bool? Spin {
            get { return BackingStore?.Get<bool?>("spin"); }
            set { BackingStore?.Set("spin", value); }
        }
        /// <summary>An unsigned integer that specifies the increment of change for the spin control. The default value is 1.</summary>
        public long? SpinStep {
            get { return BackingStore?.Get<long?>("spinStep"); }
            set { BackingStore?.Set("spinStep", value); }
        }
        /// <summary>
        /// Instantiates a new groupPolicyPresentationDecimalTextBox and sets the default values.
        /// </summary>
        public GroupPolicyPresentationDecimalTextBox() : base() {
            OdataType = "#microsoft.graph.groupPolicyPresentationDecimalTextBox";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyPresentationDecimalTextBox CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationDecimalTextBox();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetLongValue(); } },
                {"maxValue", n => { MaxValue = n.GetLongValue(); } },
                {"minValue", n => { MinValue = n.GetLongValue(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
                {"spin", n => { Spin = n.GetBoolValue(); } },
                {"spinStep", n => { SpinStep = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("defaultValue", DefaultValue);
            writer.WriteLongValue("maxValue", MaxValue);
            writer.WriteLongValue("minValue", MinValue);
            writer.WriteBoolValue("required", Required);
            writer.WriteBoolValue("spin", Spin);
            writer.WriteLongValue("spinStep", SpinStep);
        }
    }
}
