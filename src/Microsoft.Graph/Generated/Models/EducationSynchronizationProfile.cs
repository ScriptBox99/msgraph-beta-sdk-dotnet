// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationProfile : Entity, IParsable {
        /// <summary>The dataProvider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationDataProvider? DataProvider {
            get { return BackingStore?.Get<EducationSynchronizationDataProvider?>("dataProvider"); }
            set { BackingStore?.Set("dataProvider", value); }
        }
#nullable restore
#else
        public EducationSynchronizationDataProvider DataProvider {
            get { return BackingStore?.Get<EducationSynchronizationDataProvider>("dataProvider"); }
            set { BackingStore?.Set("dataProvider", value); }
        }
#endif
        /// <summary>Name of the configuration profile for syncing identities.</summary>
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
        /// <summary>All errors associated with this synchronization profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationSynchronizationError>? Errors {
            get { return BackingStore?.Get<List<EducationSynchronizationError>?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#nullable restore
#else
        public List<EducationSynchronizationError> Errors {
            get { return BackingStore?.Get<List<EducationSynchronizationError>>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#endif
        /// <summary>The date the profile should be considered expired and cease syncing. Provide the date in YYYY-MM-DD format, following ISO 8601. Maximum value is 18 months from profile creation.  (optional)</summary>
        public Date? ExpirationDate {
            get { return BackingStore?.Get<Date?>("expirationDate"); }
            set { BackingStore?.Set("expirationDate", value); }
        }
        /// <summary>Determines if School Data Sync should automatically replace unsupported special characters while syncing from source.</summary>
        public bool? HandleSpecialCharacterConstraint {
            get { return BackingStore?.Get<bool?>("handleSpecialCharacterConstraint"); }
            set { BackingStore?.Set("handleSpecialCharacterConstraint", value); }
        }
        /// <summary>The identitySynchronizationConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationIdentitySynchronizationConfiguration? IdentitySynchronizationConfiguration {
            get { return BackingStore?.Get<EducationIdentitySynchronizationConfiguration?>("identitySynchronizationConfiguration"); }
            set { BackingStore?.Set("identitySynchronizationConfiguration", value); }
        }
#nullable restore
#else
        public EducationIdentitySynchronizationConfiguration IdentitySynchronizationConfiguration {
            get { return BackingStore?.Get<EducationIdentitySynchronizationConfiguration>("identitySynchronizationConfiguration"); }
            set { BackingStore?.Set("identitySynchronizationConfiguration", value); }
        }
#endif
        /// <summary>License setup configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationSynchronizationLicenseAssignment>? LicensesToAssign {
            get { return BackingStore?.Get<List<EducationSynchronizationLicenseAssignment>?>("licensesToAssign"); }
            set { BackingStore?.Set("licensesToAssign", value); }
        }
#nullable restore
#else
        public List<EducationSynchronizationLicenseAssignment> LicensesToAssign {
            get { return BackingStore?.Get<List<EducationSynchronizationLicenseAssignment>>("licensesToAssign"); }
            set { BackingStore?.Set("licensesToAssign", value); }
        }
#endif
        /// <summary>The synchronization status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationProfileStatus? ProfileStatus {
            get { return BackingStore?.Get<EducationSynchronizationProfileStatus?>("profileStatus"); }
            set { BackingStore?.Set("profileStatus", value); }
        }
#nullable restore
#else
        public EducationSynchronizationProfileStatus ProfileStatus {
            get { return BackingStore?.Get<EducationSynchronizationProfileStatus>("profileStatus"); }
            set { BackingStore?.Set("profileStatus", value); }
        }
#endif
        /// <summary>The state of the profile. Possible values are: provisioning, provisioned, provisioningFailed, deleting, deletionFailed.</summary>
        public EducationSynchronizationProfileState? State {
            get { return BackingStore?.Get<EducationSynchronizationProfileState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationSynchronizationProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dataProvider", n => { DataProvider = n.GetObjectValue<EducationSynchronizationDataProvider>(EducationSynchronizationDataProvider.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<EducationSynchronizationError>(EducationSynchronizationError.CreateFromDiscriminatorValue)?.ToList(); } },
                {"expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                {"handleSpecialCharacterConstraint", n => { HandleSpecialCharacterConstraint = n.GetBoolValue(); } },
                {"identitySynchronizationConfiguration", n => { IdentitySynchronizationConfiguration = n.GetObjectValue<EducationIdentitySynchronizationConfiguration>(EducationIdentitySynchronizationConfiguration.CreateFromDiscriminatorValue); } },
                {"licensesToAssign", n => { LicensesToAssign = n.GetCollectionOfObjectValues<EducationSynchronizationLicenseAssignment>(EducationSynchronizationLicenseAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"profileStatus", n => { ProfileStatus = n.GetObjectValue<EducationSynchronizationProfileStatus>(EducationSynchronizationProfileStatus.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<EducationSynchronizationProfileState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationSynchronizationDataProvider>("dataProvider", DataProvider);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<EducationSynchronizationError>("errors", Errors);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteBoolValue("handleSpecialCharacterConstraint", HandleSpecialCharacterConstraint);
            writer.WriteObjectValue<EducationIdentitySynchronizationConfiguration>("identitySynchronizationConfiguration", IdentitySynchronizationConfiguration);
            writer.WriteCollectionOfObjectValues<EducationSynchronizationLicenseAssignment>("licensesToAssign", LicensesToAssign);
            writer.WriteObjectValue<EducationSynchronizationProfileStatus>("profileStatus", ProfileStatus);
            writer.WriteEnumValue<EducationSynchronizationProfileState>("state", State);
        }
    }
}
