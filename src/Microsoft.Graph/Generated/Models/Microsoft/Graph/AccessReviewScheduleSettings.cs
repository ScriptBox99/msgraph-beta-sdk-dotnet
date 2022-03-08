using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class AccessReviewScheduleSettings : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.</summary>
        public List<AccessReviewApplyAction> ApplyActions { get; set; }
        /// <summary>Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.</summary>
        public bool? AutoApplyDecisionsEnabled { get; set; }
        /// <summary>Indicates whether decisions on previous access review stages are available for reviewers on an accessReviewInstance with multiple subsequent stages. If not provided, the default is disabled (false).</summary>
        public bool? DecisionHistoriesForReviewersEnabled { get; set; }
        /// <summary>Decision chosen if defaultDecisionEnabled is true. Can be one of Approve, Deny, or Recommendation.</summary>
        public string DefaultDecision { get; set; }
        /// <summary>Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.</summary>
        public bool? DefaultDecisionEnabled { get; set; }
        /// <summary>Duration of each recurrence of review (accessReviewInstance) in number of days.</summary>
        public int? InstanceDurationInDays { get; set; }
        /// <summary>Indicates whether reviewers are required to provide justification with their decision. Default value is false.</summary>
        public bool? JustificationRequiredOnApproval { get; set; }
        /// <summary>Indicates whether emails are enabled or disabled. Default value is false.</summary>
        public bool? MailNotificationsEnabled { get; set; }
        /// <summary>Optional. Describes the types of insights that aid reviewers to make access review decisions. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationInsightSettings setting will be used instead of the value of this property.</summary>
        public List<AccessReviewRecommendationInsightSetting> RecommendationInsightSettings { get; set; }
        /// <summary>Optional field. Indicates the period of inactivity (with respect to the start date of the review instance) that recommendations will be configured from. The recommendation will be to deny if the user is inactive during the look-back duration. For reviews of groups and Azure AD roles, any duration is accepted. For reviews of applications, 30 days is the maximum duration. If not specified, the duration is 30 days. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationLookBackDuration setting will be used instead of the value of this property.</summary>
        public TimeSpan? RecommendationLookBackDuration { get; set; }
        /// <summary>Indicates whether decision recommendations are enabled or disabled.</summary>
        public bool? RecommendationsEnabled { get; set; }
        /// <summary>Detailed settings for recurrence using the standard Outlook recurrence object.  Note: Only dayOfMonth, interval, and type (weekly, absoluteMonthly) properties are supported. Use the property startDate on recurrenceRange to determine the day the review starts.</summary>
        public PatternedRecurrence Recurrence { get; set; }
        /// <summary>Indicates whether reminders are enabled or disabled. Default value is false.</summary>
        public bool? ReminderNotificationsEnabled { get; set; }
        /// <summary>
        /// Instantiates a new accessReviewScheduleSettings and sets the default values.
        /// </summary>
        public AccessReviewScheduleSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessReviewScheduleSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewScheduleSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applyActions", (o,n) => { (o as AccessReviewScheduleSettings).ApplyActions = n.GetCollectionOfObjectValues<AccessReviewApplyAction>(AccessReviewApplyAction.CreateFromDiscriminatorValue).ToList(); } },
                {"autoApplyDecisionsEnabled", (o,n) => { (o as AccessReviewScheduleSettings).AutoApplyDecisionsEnabled = n.GetBoolValue(); } },
                {"decisionHistoriesForReviewersEnabled", (o,n) => { (o as AccessReviewScheduleSettings).DecisionHistoriesForReviewersEnabled = n.GetBoolValue(); } },
                {"defaultDecision", (o,n) => { (o as AccessReviewScheduleSettings).DefaultDecision = n.GetStringValue(); } },
                {"defaultDecisionEnabled", (o,n) => { (o as AccessReviewScheduleSettings).DefaultDecisionEnabled = n.GetBoolValue(); } },
                {"instanceDurationInDays", (o,n) => { (o as AccessReviewScheduleSettings).InstanceDurationInDays = n.GetIntValue(); } },
                {"justificationRequiredOnApproval", (o,n) => { (o as AccessReviewScheduleSettings).JustificationRequiredOnApproval = n.GetBoolValue(); } },
                {"mailNotificationsEnabled", (o,n) => { (o as AccessReviewScheduleSettings).MailNotificationsEnabled = n.GetBoolValue(); } },
                {"recommendationInsightSettings", (o,n) => { (o as AccessReviewScheduleSettings).RecommendationInsightSettings = n.GetCollectionOfObjectValues<AccessReviewRecommendationInsightSetting>(AccessReviewRecommendationInsightSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"recommendationLookBackDuration", (o,n) => { (o as AccessReviewScheduleSettings).RecommendationLookBackDuration = n.GetTimeSpanValue(); } },
                {"recommendationsEnabled", (o,n) => { (o as AccessReviewScheduleSettings).RecommendationsEnabled = n.GetBoolValue(); } },
                {"recurrence", (o,n) => { (o as AccessReviewScheduleSettings).Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderNotificationsEnabled", (o,n) => { (o as AccessReviewScheduleSettings).ReminderNotificationsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AccessReviewApplyAction>("applyActions", ApplyActions);
            writer.WriteBoolValue("autoApplyDecisionsEnabled", AutoApplyDecisionsEnabled);
            writer.WriteBoolValue("decisionHistoriesForReviewersEnabled", DecisionHistoriesForReviewersEnabled);
            writer.WriteStringValue("defaultDecision", DefaultDecision);
            writer.WriteBoolValue("defaultDecisionEnabled", DefaultDecisionEnabled);
            writer.WriteIntValue("instanceDurationInDays", InstanceDurationInDays);
            writer.WriteBoolValue("justificationRequiredOnApproval", JustificationRequiredOnApproval);
            writer.WriteBoolValue("mailNotificationsEnabled", MailNotificationsEnabled);
            writer.WriteCollectionOfObjectValues<AccessReviewRecommendationInsightSetting>("recommendationInsightSettings", RecommendationInsightSettings);
            writer.WriteTimeSpanValue("recommendationLookBackDuration", RecommendationLookBackDuration);
            writer.WriteBoolValue("recommendationsEnabled", RecommendationsEnabled);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteBoolValue("reminderNotificationsEnabled", ReminderNotificationsEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
