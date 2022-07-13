using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Search {
    public class Bookmark : SearchAnswer, IParsable {
        /// <summary>Timestamp of when the bookmark will stop to appear as a search result. Set as null for always available.</summary>
        public DateTimeOffset? AvailabilityEndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("availabilityEndDateTime"); }
            set { BackingStore?.Set("availabilityEndDateTime", value); }
        }
        /// <summary>Timestamp of when the bookmark will start to appear as a search result. Set as null for always available.</summary>
        public DateTimeOffset? AvailabilityStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("availabilityStartDateTime"); }
            set { BackingStore?.Set("availabilityStartDateTime", value); }
        }
        /// <summary>Categories commonly used to describe this bookmark. For example, IT and HR.</summary>
        public List<string> Categories {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
        /// <summary>List of security groups able to view this bookmark.</summary>
        public List<string> GroupIds {
            get { return BackingStore?.Get<List<string>>("groupIds"); }
            set { BackingStore?.Set("groupIds", value); }
        }
        /// <summary>True if this bookmark was suggested to the admin by a user or was mined and suggested by Microsoft. Read-only.</summary>
        public bool? IsSuggested {
            get { return BackingStore?.Get<bool?>("isSuggested"); }
            set { BackingStore?.Set("isSuggested", value); }
        }
        /// <summary>Keywords that trigger this bookmark to appear in search results.</summary>
        public AnswerKeyword Keywords {
            get { return BackingStore?.Get<AnswerKeyword>("keywords"); }
            set { BackingStore?.Set("keywords", value); }
        }
        /// <summary>A list of language names that are geographically specific and that this bookmark can be viewed in. Each language tag value follows the pattern {language}-{region}. As an example, en-us is English as used in the United States. See supported language tags for the list of possible values.</summary>
        public List<string> LanguageTags {
            get { return BackingStore?.Get<List<string>>("languageTags"); }
            set { BackingStore?.Set("languageTags", value); }
        }
        /// <summary>List of devices and operating systems able to view this bookmark. Possible values are: unknown, android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, androidASOP.</summary>
        public List<string> Platforms {
            get { return BackingStore?.Get<List<string>>("platforms"); }
            set { BackingStore?.Set("platforms", value); }
        }
        /// <summary>List of Power Apps associated with this bookmark. If users add existing Power Apps to a bookmark, they can complete tasks, such as to enter vacation time or to report expenses on the search results page.</summary>
        public List<string> PowerAppIds {
            get { return BackingStore?.Get<List<string>>("powerAppIds"); }
            set { BackingStore?.Set("powerAppIds", value); }
        }
        /// <summary>The state property</summary>
        public AnswerState? State {
            get { return BackingStore?.Get<AnswerState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>Variations of a bookmark for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings will apply to all variations.</summary>
        public List<AnswerVariant> TargetedVariations {
            get { return BackingStore?.Get<List<AnswerVariant>>("targetedVariations"); }
            set { BackingStore?.Set("targetedVariations", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Bookmark CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bookmark();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"availabilityEndDateTime", n => { AvailabilityEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"availabilityStartDateTime", n => { AvailabilityStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"groupIds", n => { GroupIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isSuggested", n => { IsSuggested = n.GetBoolValue(); } },
                {"keywords", n => { Keywords = n.GetObjectValue<AnswerKeyword>(AnswerKeyword.CreateFromDiscriminatorValue); } },
                {"languageTags", n => { LanguageTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"platforms", n => { Platforms = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"powerAppIds", n => { PowerAppIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"state", n => { State = n.GetEnumValue<AnswerState>(); } },
                {"targetedVariations", n => { TargetedVariations = n.GetCollectionOfObjectValues<AnswerVariant>(AnswerVariant.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("availabilityEndDateTime", AvailabilityEndDateTime);
            writer.WriteDateTimeOffsetValue("availabilityStartDateTime", AvailabilityStartDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfPrimitiveValues<string>("groupIds", GroupIds);
            writer.WriteBoolValue("isSuggested", IsSuggested);
            writer.WriteObjectValue<AnswerKeyword>("keywords", Keywords);
            writer.WriteCollectionOfPrimitiveValues<string>("languageTags", LanguageTags);
            writer.WriteCollectionOfPrimitiveValues<string>("platforms", Platforms);
            writer.WriteCollectionOfPrimitiveValues<string>("powerAppIds", PowerAppIds);
            writer.WriteEnumValue<AnswerState>("state", State);
            writer.WriteCollectionOfObjectValues<AnswerVariant>("targetedVariations", TargetedVariations);
        }
    }
}
