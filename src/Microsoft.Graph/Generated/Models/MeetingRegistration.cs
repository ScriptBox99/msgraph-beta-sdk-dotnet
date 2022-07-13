using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingRegistration : MeetingRegistrationBase, IParsable {
        /// <summary>Custom registration questions.</summary>
        public List<MeetingRegistrationQuestion> CustomQuestions {
            get { return BackingStore?.Get<List<MeetingRegistrationQuestion>>("customQuestions"); }
            set { BackingStore?.Set("customQuestions", value); }
        }
        /// <summary>The description of the meeting.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The meeting end time in UTC.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The number of times the registration page has been visited. Read-only.</summary>
        public int? RegistrationPageViewCount {
            get { return BackingStore?.Get<int?>("registrationPageViewCount"); }
            set { BackingStore?.Set("registrationPageViewCount", value); }
        }
        /// <summary>The URL of the registration page. Read-only.</summary>
        public string RegistrationPageWebUrl {
            get { return BackingStore?.Get<string>("registrationPageWebUrl"); }
            set { BackingStore?.Set("registrationPageWebUrl", value); }
        }
        /// <summary>The meeting speaker&apos;s information.</summary>
        public List<MeetingSpeaker> Speakers {
            get { return BackingStore?.Get<List<MeetingSpeaker>>("speakers"); }
            set { BackingStore?.Set("speakers", value); }
        }
        /// <summary>The meeting start time in UTC.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The subject of the meeting.</summary>
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MeetingRegistration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingRegistration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customQuestions", n => { CustomQuestions = n.GetCollectionOfObjectValues<MeetingRegistrationQuestion>(MeetingRegistrationQuestion.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"registrationPageViewCount", n => { RegistrationPageViewCount = n.GetIntValue(); } },
                {"registrationPageWebUrl", n => { RegistrationPageWebUrl = n.GetStringValue(); } },
                {"speakers", n => { Speakers = n.GetCollectionOfObjectValues<MeetingSpeaker>(MeetingSpeaker.CreateFromDiscriminatorValue).ToList(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MeetingRegistrationQuestion>("customQuestions", CustomQuestions);
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteIntValue("registrationPageViewCount", RegistrationPageViewCount);
            writer.WriteStringValue("registrationPageWebUrl", RegistrationPageWebUrl);
            writer.WriteCollectionOfObjectValues<MeetingSpeaker>("speakers", Speakers);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
