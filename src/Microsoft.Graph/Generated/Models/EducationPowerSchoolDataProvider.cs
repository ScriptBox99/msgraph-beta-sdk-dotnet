using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EducationPowerSchoolDataProvider : EducationSynchronizationDataProvider, IParsable {
        /// <summary>Indicates whether the source has multiple identifiers for a single student or teacher.</summary>
        public bool? AllowTeachersInMultipleSchools {
            get { return BackingStore?.Get<bool?>("allowTeachersInMultipleSchools"); }
            set { BackingStore?.Set("allowTeachersInMultipleSchools", value); }
        }
        /// <summary>The client ID used to connect to PowerSchool.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId {
            get { return BackingStore?.Get<string?>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
#nullable restore
#else
        public string ClientId {
            get { return BackingStore?.Get<string>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
#endif
        /// <summary>The client secret to authenticate the connection to the PowerSchool instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientSecret {
            get { return BackingStore?.Get<string?>("clientSecret"); }
            set { BackingStore?.Set("clientSecret", value); }
        }
#nullable restore
#else
        public string ClientSecret {
            get { return BackingStore?.Get<string>("clientSecret"); }
            set { BackingStore?.Set("clientSecret", value); }
        }
#endif
        /// <summary>The connection URL to the PowerSchool instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionUrl {
            get { return BackingStore?.Get<string?>("connectionUrl"); }
            set { BackingStore?.Set("connectionUrl", value); }
        }
#nullable restore
#else
        public string ConnectionUrl {
            get { return BackingStore?.Get<string>("connectionUrl"); }
            set { BackingStore?.Set("connectionUrl", value); }
        }
#endif
        /// <summary>Optional customization to be applied to the synchronization profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationCustomizations? Customizations {
            get { return BackingStore?.Get<EducationSynchronizationCustomizations?>("customizations"); }
            set { BackingStore?.Set("customizations", value); }
        }
#nullable restore
#else
        public EducationSynchronizationCustomizations Customizations {
            get { return BackingStore?.Get<EducationSynchronizationCustomizations>("customizations"); }
            set { BackingStore?.Set("customizations", value); }
        }
#endif
        /// <summary>The list of schools to sync.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SchoolsIds {
            get { return BackingStore?.Get<List<string>?>("schoolsIds"); }
            set { BackingStore?.Set("schoolsIds", value); }
        }
#nullable restore
#else
        public List<string> SchoolsIds {
            get { return BackingStore?.Get<List<string>>("schoolsIds"); }
            set { BackingStore?.Set("schoolsIds", value); }
        }
#endif
        /// <summary>The school year to sync.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchoolYear {
            get { return BackingStore?.Get<string?>("schoolYear"); }
            set { BackingStore?.Set("schoolYear", value); }
        }
#nullable restore
#else
        public string SchoolYear {
            get { return BackingStore?.Get<string>("schoolYear"); }
            set { BackingStore?.Set("schoolYear", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new educationPowerSchoolDataProvider and sets the default values.
        /// </summary>
        public EducationPowerSchoolDataProvider() : base() {
            OdataType = "#microsoft.graph.educationPowerSchoolDataProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationPowerSchoolDataProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationPowerSchoolDataProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowTeachersInMultipleSchools", n => { AllowTeachersInMultipleSchools = n.GetBoolValue(); } },
                {"clientId", n => { ClientId = n.GetStringValue(); } },
                {"clientSecret", n => { ClientSecret = n.GetStringValue(); } },
                {"connectionUrl", n => { ConnectionUrl = n.GetStringValue(); } },
                {"customizations", n => { Customizations = n.GetObjectValue<EducationSynchronizationCustomizations>(EducationSynchronizationCustomizations.CreateFromDiscriminatorValue); } },
                {"schoolsIds", n => { SchoolsIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"schoolYear", n => { SchoolYear = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowTeachersInMultipleSchools", AllowTeachersInMultipleSchools);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("clientSecret", ClientSecret);
            writer.WriteStringValue("connectionUrl", ConnectionUrl);
            writer.WriteObjectValue<EducationSynchronizationCustomizations>("customizations", Customizations);
            writer.WriteCollectionOfPrimitiveValues<string>("schoolsIds", SchoolsIds);
            writer.WriteStringValue("schoolYear", SchoolYear);
        }
    }
}
