using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// MacOS Software Update Configuration
    /// </summary>
    public class MacOSSoftwareUpdateConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Update behavior options for macOS software updates.</summary>
        public MacOSSoftwareUpdateBehavior? AllOtherUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>("allOtherUpdateBehavior"); }
            set { BackingStore?.Set("allOtherUpdateBehavior", value); }
        }
        /// <summary>Update behavior options for macOS software updates.</summary>
        public MacOSSoftwareUpdateBehavior? ConfigDataUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>("configDataUpdateBehavior"); }
            set { BackingStore?.Set("configDataUpdateBehavior", value); }
        }
        /// <summary>Update behavior options for macOS software updates.</summary>
        public MacOSSoftwareUpdateBehavior? CriticalUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>("criticalUpdateBehavior"); }
            set { BackingStore?.Set("criticalUpdateBehavior", value); }
        }
        /// <summary>Custom Time windows when updates will be allowed or blocked. This collection can contain a maximum of 20 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomUpdateTimeWindow>? CustomUpdateTimeWindows {
            get { return BackingStore?.Get<List<CustomUpdateTimeWindow>?>("customUpdateTimeWindows"); }
            set { BackingStore?.Set("customUpdateTimeWindows", value); }
        }
#nullable restore
#else
        public List<CustomUpdateTimeWindow> CustomUpdateTimeWindows {
            get { return BackingStore?.Get<List<CustomUpdateTimeWindow>>("customUpdateTimeWindows"); }
            set { BackingStore?.Set("customUpdateTimeWindows", value); }
        }
#endif
        /// <summary>Update behavior options for macOS software updates.</summary>
        public MacOSSoftwareUpdateBehavior? FirmwareUpdateBehavior {
            get { return BackingStore?.Get<MacOSSoftwareUpdateBehavior?>("firmwareUpdateBehavior"); }
            set { BackingStore?.Set("firmwareUpdateBehavior", value); }
        }
        /// <summary>The maximum number of times the system allows the user to postpone an update before it’s installed. Supported values: 0 - 366. Valid values 0 to 365</summary>
        public int? MaxUserDeferralsCount {
            get { return BackingStore?.Get<int?>("maxUserDeferralsCount"); }
            set { BackingStore?.Set("maxUserDeferralsCount", value); }
        }
        /// <summary>The scheduling priority for downloading and preparing the requested update. Default: Low. Possible values: Null, Low, High. Possible values are: low, high, unknownFutureValue.</summary>
        public MacOSPriority? Priority {
            get { return BackingStore?.Get<MacOSPriority?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>Update schedule type for macOS software updates.</summary>
        public MacOSSoftwareUpdateScheduleType? UpdateScheduleType {
            get { return BackingStore?.Get<MacOSSoftwareUpdateScheduleType?>("updateScheduleType"); }
            set { BackingStore?.Set("updateScheduleType", value); }
        }
        /// <summary>Minutes indicating UTC offset for each update time window</summary>
        public int? UpdateTimeWindowUtcOffsetInMinutes {
            get { return BackingStore?.Get<int?>("updateTimeWindowUtcOffsetInMinutes"); }
            set { BackingStore?.Set("updateTimeWindowUtcOffsetInMinutes", value); }
        }
        /// <summary>
        /// Instantiates a new macOSSoftwareUpdateConfiguration and sets the default values.
        /// </summary>
        public MacOSSoftwareUpdateConfiguration() : base() {
            OdataType = "#microsoft.graph.macOSSoftwareUpdateConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSSoftwareUpdateConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSoftwareUpdateConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allOtherUpdateBehavior", n => { AllOtherUpdateBehavior = n.GetEnumValue<MacOSSoftwareUpdateBehavior>(); } },
                {"configDataUpdateBehavior", n => { ConfigDataUpdateBehavior = n.GetEnumValue<MacOSSoftwareUpdateBehavior>(); } },
                {"criticalUpdateBehavior", n => { CriticalUpdateBehavior = n.GetEnumValue<MacOSSoftwareUpdateBehavior>(); } },
                {"customUpdateTimeWindows", n => { CustomUpdateTimeWindows = n.GetCollectionOfObjectValues<CustomUpdateTimeWindow>(CustomUpdateTimeWindow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"firmwareUpdateBehavior", n => { FirmwareUpdateBehavior = n.GetEnumValue<MacOSSoftwareUpdateBehavior>(); } },
                {"maxUserDeferralsCount", n => { MaxUserDeferralsCount = n.GetIntValue(); } },
                {"priority", n => { Priority = n.GetEnumValue<MacOSPriority>(); } },
                {"updateScheduleType", n => { UpdateScheduleType = n.GetEnumValue<MacOSSoftwareUpdateScheduleType>(); } },
                {"updateTimeWindowUtcOffsetInMinutes", n => { UpdateTimeWindowUtcOffsetInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MacOSSoftwareUpdateBehavior>("allOtherUpdateBehavior", AllOtherUpdateBehavior);
            writer.WriteEnumValue<MacOSSoftwareUpdateBehavior>("configDataUpdateBehavior", ConfigDataUpdateBehavior);
            writer.WriteEnumValue<MacOSSoftwareUpdateBehavior>("criticalUpdateBehavior", CriticalUpdateBehavior);
            writer.WriteCollectionOfObjectValues<CustomUpdateTimeWindow>("customUpdateTimeWindows", CustomUpdateTimeWindows);
            writer.WriteEnumValue<MacOSSoftwareUpdateBehavior>("firmwareUpdateBehavior", FirmwareUpdateBehavior);
            writer.WriteIntValue("maxUserDeferralsCount", MaxUserDeferralsCount);
            writer.WriteEnumValue<MacOSPriority>("priority", Priority);
            writer.WriteEnumValue<MacOSSoftwareUpdateScheduleType>("updateScheduleType", UpdateScheduleType);
            writer.WriteIntValue("updateTimeWindowUtcOffsetInMinutes", UpdateTimeWindowUtcOffsetInMinutes);
        }
    }
}
