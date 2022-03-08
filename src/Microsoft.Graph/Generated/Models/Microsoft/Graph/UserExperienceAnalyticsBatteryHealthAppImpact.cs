using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class UserExperienceAnalyticsBatteryHealthAppImpact : Entity, IParsable {
        /// <summary>Number of active devices for using that app over a 14-day period. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDevices { get; set; }
        /// <summary>User friendly display name for the app. Eg: Outlook</summary>
        public string AppDisplayName { get; set; }
        /// <summary>App name. Eg: oltk.exe</summary>
        public string AppName { get; set; }
        /// <summary>App publisher. Eg: Microsoft Corporation</summary>
        public string AppPublisher { get; set; }
        /// <summary>The percent of total battery power used by this application when the device was not plugged into AC power, over 14 days computed across all devices in the tenant. Unit in percentage. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? BatteryUsagePercentage { get; set; }
        /// <summary>true if the user had active interaction with the app.</summary>
        public bool? IsForegroundApp { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsBatteryHealthAppImpact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthAppImpact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeDevices", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthAppImpact).ActiveDevices = n.GetIntValue(); } },
                {"appDisplayName", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthAppImpact).AppDisplayName = n.GetStringValue(); } },
                {"appName", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthAppImpact).AppName = n.GetStringValue(); } },
                {"appPublisher", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthAppImpact).AppPublisher = n.GetStringValue(); } },
                {"batteryUsagePercentage", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthAppImpact).BatteryUsagePercentage = n.GetDoubleValue(); } },
                {"isForegroundApp", (o,n) => { (o as UserExperienceAnalyticsBatteryHealthAppImpact).IsForegroundApp = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDevices", ActiveDevices);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteDoubleValue("batteryUsagePercentage", BatteryUsagePercentage);
            writer.WriteBoolValue("isForegroundApp", IsForegroundApp);
        }
    }
}
