// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Windows Feature Update Profile
    /// </summary>
    public class WindowsFeatureUpdateProfile : Entity, IParsable {
        /// <summary>The list of group assignments of the profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsFeatureUpdateProfileAssignment>? Assignments {
            get { return BackingStore?.Get<List<WindowsFeatureUpdateProfileAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<WindowsFeatureUpdateProfileAssignment> Assignments {
            get { return BackingStore?.Get<List<WindowsFeatureUpdateProfileAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The date time that the profile was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Friendly display name of the quality update profile deployable content</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeployableContentDisplayName {
            get { return BackingStore?.Get<string?>("deployableContentDisplayName"); }
            set { BackingStore?.Set("deployableContentDisplayName", value); }
        }
#nullable restore
#else
        public string DeployableContentDisplayName {
            get { return BackingStore?.Get<string>("deployableContentDisplayName"); }
            set { BackingStore?.Set("deployableContentDisplayName", value); }
        }
#endif
        /// <summary>The description of the profile which is specified by the user.</summary>
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
        /// <summary>The display name of the profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The last supported date for a feature update</summary>
        public DateTimeOffset? EndOfSupportDate {
            get { return BackingStore?.Get<DateTimeOffset?>("endOfSupportDate"); }
            set { BackingStore?.Set("endOfSupportDate", value); }
        }
        /// <summary>The feature update version that will be deployed to the devices targeted by this profile. The version could be any supported version for example 1709, 1803 or 1809 and so on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FeatureUpdateVersion {
            get { return BackingStore?.Get<string?>("featureUpdateVersion"); }
            set { BackingStore?.Set("featureUpdateVersion", value); }
        }
#nullable restore
#else
        public string FeatureUpdateVersion {
            get { return BackingStore?.Get<string>("featureUpdateVersion"); }
            set { BackingStore?.Set("featureUpdateVersion", value); }
        }
#endif
        /// <summary>If true, the latest Microsoft Windows 10 update will be installed on devices ineligible for Microsoft Windows 11</summary>
        public bool? InstallLatestWindows10OnWindows11IneligibleDevice {
            get { return BackingStore?.Get<bool?>("installLatestWindows10OnWindows11IneligibleDevice"); }
            set { BackingStore?.Set("installLatestWindows10OnWindows11IneligibleDevice", value); }
        }
        /// <summary>The date time that the profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>List of Scope Tags for this Feature Update entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>The windows update rollout settings, including offer start date time, offer end date time, and days between each set of offers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsUpdateRolloutSettings? RolloutSettings {
            get { return BackingStore?.Get<WindowsUpdateRolloutSettings?>("rolloutSettings"); }
            set { BackingStore?.Set("rolloutSettings", value); }
        }
#nullable restore
#else
        public WindowsUpdateRolloutSettings RolloutSettings {
            get { return BackingStore?.Get<WindowsUpdateRolloutSettings>("rolloutSettings"); }
            set { BackingStore?.Set("rolloutSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsFeatureUpdateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsFeatureUpdateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<WindowsFeatureUpdateProfileAssignment>(WindowsFeatureUpdateProfileAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deployableContentDisplayName", n => { DeployableContentDisplayName = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endOfSupportDate", n => { EndOfSupportDate = n.GetDateTimeOffsetValue(); } },
                {"featureUpdateVersion", n => { FeatureUpdateVersion = n.GetStringValue(); } },
                {"installLatestWindows10OnWindows11IneligibleDevice", n => { InstallLatestWindows10OnWindows11IneligibleDevice = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"rolloutSettings", n => { RolloutSettings = n.GetObjectValue<WindowsUpdateRolloutSettings>(WindowsUpdateRolloutSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WindowsFeatureUpdateProfileAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deployableContentDisplayName", DeployableContentDisplayName);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endOfSupportDate", EndOfSupportDate);
            writer.WriteStringValue("featureUpdateVersion", FeatureUpdateVersion);
            writer.WriteBoolValue("installLatestWindows10OnWindows11IneligibleDevice", InstallLatestWindows10OnWindows11IneligibleDevice);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteObjectValue<WindowsUpdateRolloutSettings>("rolloutSettings", RolloutSettings);
        }
    }
}
