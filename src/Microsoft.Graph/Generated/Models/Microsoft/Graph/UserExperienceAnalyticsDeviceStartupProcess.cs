using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsDeviceStartupProcess : Entity, IParsable {
        /// <summary>The user experience analytics device id.</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>User experience analytics device startup process name.</summary>
        public string ProcessName { get; set; }
        /// <summary>The user experience analytics device startup process product name.</summary>
        public string ProductName { get; set; }
        /// <summary>The User experience analytics device startup process publisher.</summary>
        public string Publisher { get; set; }
        /// <summary>User experience analytics device startup process impact in milliseconds.</summary>
        public int? StartupImpactInMs { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsDeviceStartupProcess CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceStartupProcess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"managedDeviceId", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcess).ManagedDeviceId = n.GetStringValue(); } },
                {"processName", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcess).ProcessName = n.GetStringValue(); } },
                {"productName", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcess).ProductName = n.GetStringValue(); } },
                {"publisher", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcess).Publisher = n.GetStringValue(); } },
                {"startupImpactInMs", (o,n) => { (o as UserExperienceAnalyticsDeviceStartupProcess).StartupImpactInMs = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("processName", ProcessName);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteIntValue("startupImpactInMs", StartupImpactInMs);
        }
    }
}
