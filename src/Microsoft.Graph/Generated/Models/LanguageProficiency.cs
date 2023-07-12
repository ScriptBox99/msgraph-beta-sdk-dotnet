using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class LanguageProficiency : ItemFacet, IParsable {
        /// <summary>Contains the long-form name for the language.</summary>
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
        /// <summary>The proficiency property</summary>
        public LanguageProficiencyLevel? Proficiency {
            get { return BackingStore?.Get<LanguageProficiencyLevel?>("proficiency"); }
            set { BackingStore?.Set("proficiency", value); }
        }
        /// <summary>Represents the users reading comprehension for the language represented by the object. Possible values are: elementary, conversational, limitedWorking, professionalWorking, fullProfessional, nativeOrBilingual, unknownFutureValue.</summary>
        public LanguageProficiencyLevel? Reading {
            get { return BackingStore?.Get<LanguageProficiencyLevel?>("reading"); }
            set { BackingStore?.Set("reading", value); }
        }
        /// <summary>Represents the users spoken proficiency for the language represented by the object. Possible values are: elementary, conversational, limitedWorking, professionalWorking, fullProfessional, nativeOrBilingual, unknownFutureValue.</summary>
        public LanguageProficiencyLevel? Spoken {
            get { return BackingStore?.Get<LanguageProficiencyLevel?>("spoken"); }
            set { BackingStore?.Set("spoken", value); }
        }
        /// <summary>Contains the four-character BCP47 name for the language (en-US, no-NB, en-AU).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tag {
            get { return BackingStore?.Get<string?>("tag"); }
            set { BackingStore?.Set("tag", value); }
        }
#nullable restore
#else
        public string Tag {
            get { return BackingStore?.Get<string>("tag"); }
            set { BackingStore?.Set("tag", value); }
        }
#endif
        /// <summary>The thumbnailUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailUrl {
            get { return BackingStore?.Get<string?>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
#nullable restore
#else
        public string ThumbnailUrl {
            get { return BackingStore?.Get<string>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
#endif
        /// <summary>Represents the users written proficiency for the language represented by the object. Possible values are: elementary, conversational, limitedWorking, professionalWorking, fullProfessional, nativeOrBilingual, unknownFutureValue.</summary>
        public LanguageProficiencyLevel? Written {
            get { return BackingStore?.Get<LanguageProficiencyLevel?>("written"); }
            set { BackingStore?.Set("written", value); }
        }
        /// <summary>
        /// Instantiates a new languageProficiency and sets the default values.
        /// </summary>
        public LanguageProficiency() : base() {
            OdataType = "#microsoft.graph.languageProficiency";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LanguageProficiency CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LanguageProficiency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"proficiency", n => { Proficiency = n.GetEnumValue<LanguageProficiencyLevel>(); } },
                {"reading", n => { Reading = n.GetEnumValue<LanguageProficiencyLevel>(); } },
                {"spoken", n => { Spoken = n.GetEnumValue<LanguageProficiencyLevel>(); } },
                {"tag", n => { Tag = n.GetStringValue(); } },
                {"thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
                {"written", n => { Written = n.GetEnumValue<LanguageProficiencyLevel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<LanguageProficiencyLevel>("proficiency", Proficiency);
            writer.WriteEnumValue<LanguageProficiencyLevel>("reading", Reading);
            writer.WriteEnumValue<LanguageProficiencyLevel>("spoken", Spoken);
            writer.WriteStringValue("tag", Tag);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteEnumValue<LanguageProficiencyLevel>("written", Written);
        }
    }
}
