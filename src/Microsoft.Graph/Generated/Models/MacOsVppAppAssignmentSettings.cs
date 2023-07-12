using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties used to assign an Mac VPP mobile app to a group.
    /// </summary>
    public class MacOsVppAppAssignmentSettings : MobileAppAssignmentSettings, IParsable {
        /// <summary>When TRUE, indicates that the app should not be automatically updated with the latest version from Apple app store. When FALSE, indicates that the app may be auto updated. By default, this property is set to null which internally is treated as FALSE.</summary>
        public bool? PreventAutoAppUpdate {
            get { return BackingStore?.Get<bool?>("preventAutoAppUpdate"); }
            set { BackingStore?.Set("preventAutoAppUpdate", value); }
        }
        /// <summary>When TRUE, indicates that the app should not be backed up to iCloud. When FALSE, indicates that the app may be backed up to iCloud. By default, this property is set to null which internally is treated as FALSE.</summary>
        public bool? PreventManagedAppBackup {
            get { return BackingStore?.Get<bool?>("preventManagedAppBackup"); }
            set { BackingStore?.Set("preventManagedAppBackup", value); }
        }
        /// <summary>Whether or not to uninstall the app when device is removed from Intune.</summary>
        public bool? UninstallOnDeviceRemoval {
            get { return BackingStore?.Get<bool?>("uninstallOnDeviceRemoval"); }
            set { BackingStore?.Set("uninstallOnDeviceRemoval", value); }
        }
        /// <summary>Whether or not to use device licensing.</summary>
        public bool? UseDeviceLicensing {
            get { return BackingStore?.Get<bool?>("useDeviceLicensing"); }
            set { BackingStore?.Set("useDeviceLicensing", value); }
        }
        /// <summary>
        /// Instantiates a new macOsVppAppAssignmentSettings and sets the default values.
        /// </summary>
        public MacOsVppAppAssignmentSettings() : base() {
            OdataType = "#microsoft.graph.macOsVppAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOsVppAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOsVppAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"preventAutoAppUpdate", n => { PreventAutoAppUpdate = n.GetBoolValue(); } },
                {"preventManagedAppBackup", n => { PreventManagedAppBackup = n.GetBoolValue(); } },
                {"uninstallOnDeviceRemoval", n => { UninstallOnDeviceRemoval = n.GetBoolValue(); } },
                {"useDeviceLicensing", n => { UseDeviceLicensing = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("preventAutoAppUpdate", PreventAutoAppUpdate);
            writer.WriteBoolValue("preventManagedAppBackup", PreventManagedAppBackup);
            writer.WriteBoolValue("uninstallOnDeviceRemoval", UninstallOnDeviceRemoval);
            writer.WriteBoolValue("useDeviceLicensing", UseDeviceLicensing);
        }
    }
}
