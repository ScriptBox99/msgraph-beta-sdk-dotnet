using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10EnrollmentCompletionPageConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Allow or block device reset on installation failure</summary>
        public bool? AllowDeviceResetOnInstallFailure {
            get { return BackingStore?.Get<bool?>("allowDeviceResetOnInstallFailure"); }
            set { BackingStore?.Set("allowDeviceResetOnInstallFailure", value); }
        }
        /// <summary>Allow the user to continue using the device on installation failure</summary>
        public bool? AllowDeviceUseOnInstallFailure {
            get { return BackingStore?.Get<bool?>("allowDeviceUseOnInstallFailure"); }
            set { BackingStore?.Set("allowDeviceUseOnInstallFailure", value); }
        }
        /// <summary>Allow or block log collection on installation failure</summary>
        public bool? AllowLogCollectionOnInstallFailure {
            get { return BackingStore?.Get<bool?>("allowLogCollectionOnInstallFailure"); }
            set { BackingStore?.Set("allowLogCollectionOnInstallFailure", value); }
        }
        /// <summary>Install all required apps as non blocking apps during white glove</summary>
        public bool? AllowNonBlockingAppInstallation {
            get { return BackingStore?.Get<bool?>("allowNonBlockingAppInstallation"); }
            set { BackingStore?.Set("allowNonBlockingAppInstallation", value); }
        }
        /// <summary>Allow the user to retry the setup on installation failure</summary>
        public bool? BlockDeviceSetupRetryByUser {
            get { return BackingStore?.Get<bool?>("blockDeviceSetupRetryByUser"); }
            set { BackingStore?.Set("blockDeviceSetupRetryByUser", value); }
        }
        /// <summary>Set custom error message to show upon installation failure</summary>
        public string CustomErrorMessage {
            get { return BackingStore?.Get<string>("customErrorMessage"); }
            set { BackingStore?.Set("customErrorMessage", value); }
        }
        /// <summary>Only show installation progress for first user post enrollment</summary>
        public bool? DisableUserStatusTrackingAfterFirstUser {
            get { return BackingStore?.Get<bool?>("disableUserStatusTrackingAfterFirstUser"); }
            set { BackingStore?.Set("disableUserStatusTrackingAfterFirstUser", value); }
        }
        /// <summary>Set installation progress timeout in minutes</summary>
        public int? InstallProgressTimeoutInMinutes {
            get { return BackingStore?.Get<int?>("installProgressTimeoutInMinutes"); }
            set { BackingStore?.Set("installProgressTimeoutInMinutes", value); }
        }
        /// <summary>Selected applications to track the installation status</summary>
        public List<string> SelectedMobileAppIds {
            get { return BackingStore?.Get<List<string>>("selectedMobileAppIds"); }
            set { BackingStore?.Set("selectedMobileAppIds", value); }
        }
        /// <summary>Show or hide installation progress to user</summary>
        public bool? ShowInstallationProgress {
            get { return BackingStore?.Get<bool?>("showInstallationProgress"); }
            set { BackingStore?.Set("showInstallationProgress", value); }
        }
        /// <summary>Only show installation progress for Autopilot enrollment scenarios</summary>
        public bool? TrackInstallProgressForAutopilotOnly {
            get { return BackingStore?.Get<bool?>("trackInstallProgressForAutopilotOnly"); }
            set { BackingStore?.Set("trackInstallProgressForAutopilotOnly", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10EnrollmentCompletionPageConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10EnrollmentCompletionPageConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowDeviceResetOnInstallFailure", n => { AllowDeviceResetOnInstallFailure = n.GetBoolValue(); } },
                {"allowDeviceUseOnInstallFailure", n => { AllowDeviceUseOnInstallFailure = n.GetBoolValue(); } },
                {"allowLogCollectionOnInstallFailure", n => { AllowLogCollectionOnInstallFailure = n.GetBoolValue(); } },
                {"allowNonBlockingAppInstallation", n => { AllowNonBlockingAppInstallation = n.GetBoolValue(); } },
                {"blockDeviceSetupRetryByUser", n => { BlockDeviceSetupRetryByUser = n.GetBoolValue(); } },
                {"customErrorMessage", n => { CustomErrorMessage = n.GetStringValue(); } },
                {"disableUserStatusTrackingAfterFirstUser", n => { DisableUserStatusTrackingAfterFirstUser = n.GetBoolValue(); } },
                {"installProgressTimeoutInMinutes", n => { InstallProgressTimeoutInMinutes = n.GetIntValue(); } },
                {"selectedMobileAppIds", n => { SelectedMobileAppIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"showInstallationProgress", n => { ShowInstallationProgress = n.GetBoolValue(); } },
                {"trackInstallProgressForAutopilotOnly", n => { TrackInstallProgressForAutopilotOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowDeviceResetOnInstallFailure", AllowDeviceResetOnInstallFailure);
            writer.WriteBoolValue("allowDeviceUseOnInstallFailure", AllowDeviceUseOnInstallFailure);
            writer.WriteBoolValue("allowLogCollectionOnInstallFailure", AllowLogCollectionOnInstallFailure);
            writer.WriteBoolValue("allowNonBlockingAppInstallation", AllowNonBlockingAppInstallation);
            writer.WriteBoolValue("blockDeviceSetupRetryByUser", BlockDeviceSetupRetryByUser);
            writer.WriteStringValue("customErrorMessage", CustomErrorMessage);
            writer.WriteBoolValue("disableUserStatusTrackingAfterFirstUser", DisableUserStatusTrackingAfterFirstUser);
            writer.WriteIntValue("installProgressTimeoutInMinutes", InstallProgressTimeoutInMinutes);
            writer.WriteCollectionOfPrimitiveValues<string>("selectedMobileAppIds", SelectedMobileAppIds);
            writer.WriteBoolValue("showInstallationProgress", ShowInstallationProgress);
            writer.WriteBoolValue("trackInstallProgressForAutopilotOnly", TrackInstallProgressForAutopilotOnly);
        }
    }
}
