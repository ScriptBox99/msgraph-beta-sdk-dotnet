// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties used to assign a WinGet app to a group.
    /// </summary>
    public class WinGetAppAssignmentSettings : MobileAppAssignmentSettings, IParsable {
        /// <summary>The install time settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WinGetAppInstallTimeSettings? InstallTimeSettings {
            get { return BackingStore?.Get<WinGetAppInstallTimeSettings?>("installTimeSettings"); }
            set { BackingStore?.Set("installTimeSettings", value); }
        }
#nullable restore
#else
        public WinGetAppInstallTimeSettings InstallTimeSettings {
            get { return BackingStore?.Get<WinGetAppInstallTimeSettings>("installTimeSettings"); }
            set { BackingStore?.Set("installTimeSettings", value); }
        }
#endif
        /// <summary>Contains value for notification status.</summary>
        public WinGetAppNotification? Notifications {
            get { return BackingStore?.Get<WinGetAppNotification?>("notifications"); }
            set { BackingStore?.Set("notifications", value); }
        }
        /// <summary>The reboot settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WinGetAppRestartSettings? RestartSettings {
            get { return BackingStore?.Get<WinGetAppRestartSettings?>("restartSettings"); }
            set { BackingStore?.Set("restartSettings", value); }
        }
#nullable restore
#else
        public WinGetAppRestartSettings RestartSettings {
            get { return BackingStore?.Get<WinGetAppRestartSettings>("restartSettings"); }
            set { BackingStore?.Set("restartSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new winGetAppAssignmentSettings and sets the default values.
        /// </summary>
        public WinGetAppAssignmentSettings() : base() {
            OdataType = "#microsoft.graph.winGetAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WinGetAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WinGetAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"installTimeSettings", n => { InstallTimeSettings = n.GetObjectValue<WinGetAppInstallTimeSettings>(WinGetAppInstallTimeSettings.CreateFromDiscriminatorValue); } },
                {"notifications", n => { Notifications = n.GetEnumValue<WinGetAppNotification>(); } },
                {"restartSettings", n => { RestartSettings = n.GetObjectValue<WinGetAppRestartSettings>(WinGetAppRestartSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WinGetAppInstallTimeSettings>("installTimeSettings", InstallTimeSettings);
            writer.WriteEnumValue<WinGetAppNotification>("notifications", Notifications);
            writer.WriteObjectValue<WinGetAppRestartSettings>("restartSettings", RestartSettings);
        }
    }
}
