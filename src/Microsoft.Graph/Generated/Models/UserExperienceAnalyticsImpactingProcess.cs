using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsImpactingProcess : Entity, IParsable {
        /// <summary>The category of impacting process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category {
            get { return BackingStore?.Get<string?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public string Category {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>The description of process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The unique identifier of the impacted device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The impact value of the process. Valid values 0 to 1.79769313486232E+308</summary>
        public double? ImpactValue {
            get { return BackingStore?.Get<double?>("impactValue"); }
            set { BackingStore?.Set("impactValue", value); }
        }
        /// <summary>The process name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProcessName {
            get { return BackingStore?.Get<string?>("processName"); }
            set { BackingStore?.Set("processName", value); }
        }
#nullable restore
#else
        public string ProcessName {
            get { return BackingStore?.Get<string>("processName"); }
            set { BackingStore?.Set("processName", value); }
        }
#endif
        /// <summary>The publisher of the process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsImpactingProcess CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsImpactingProcess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"impactValue", n => { ImpactValue = n.GetDoubleValue(); } },
                {"processName", n => { ProcessName = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDoubleValue("impactValue", ImpactValue);
            writer.WriteStringValue("processName", ProcessName);
            writer.WriteStringValue("publisher", Publisher);
        }
    }
}
