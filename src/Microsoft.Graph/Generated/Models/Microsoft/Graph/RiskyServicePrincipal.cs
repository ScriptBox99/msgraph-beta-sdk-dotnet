using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RiskyServicePrincipal : Entity, IParsable {
        /// <summary>true if the service principal account is enabled; otherwise, false.</summary>
        public bool? AccountEnabled { get; set; }
        /// <summary>The globally unique identifier for the associated application (its appId property), if any.</summary>
        public string AppId { get; set; }
        /// <summary>The display name for the service principal.</summary>
        public string DisplayName { get; set; }
        public List<RiskyServicePrincipalHistoryItem> History { get; set; }
        /// <summary>Indicates whether Azure AD is currently processing the service principal's risky state.</summary>
        public bool? IsProcessing { get; set; }
        /// <summary>Details of the detected risk. Note: Details for this property are only available for Azure AD Premium P2 customers. P1 customers will be returned hidden. The possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden,  adminConfirmedUserCompromised, unknownFutureValue, adminConfirmedServicePrincipalCompromised, adminDismissedAllRiskForServicePrincipal. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: adminConfirmedServicePrincipalCompromised , adminDismissedAllRiskForServicePrincipal.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RiskDetail? RiskDetail { get; set; }
        /// <summary>The date and time that the risk state was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2021 is 2021-01-01T00:00:00Z. Supports $filter (eq).</summary>
        public DateTimeOffset? RiskLastUpdatedDateTime { get; set; }
        /// <summary>Level of the detected risky workload identity. The possible values are: low, medium, high, hidden, none, unknownFutureValue. Supports $filter (eq).</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RiskLevel? RiskLevel { get; set; }
        /// <summary>State of the service principal's risk. The possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RiskState? RiskState { get; set; }
        /// <summary>Identifies whether the service principal represents an Application, a ManagedIdentity, or a legacy application (socialIdp). This is set by Azure AD internally and is inherited from servicePrincipal.</summary>
        public string ServicePrincipalType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RiskyServicePrincipal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RiskyServicePrincipal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accountEnabled", (o,n) => { (o as RiskyServicePrincipal).AccountEnabled = n.GetBoolValue(); } },
                {"appId", (o,n) => { (o as RiskyServicePrincipal).AppId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as RiskyServicePrincipal).DisplayName = n.GetStringValue(); } },
                {"history", (o,n) => { (o as RiskyServicePrincipal).History = n.GetCollectionOfObjectValues<RiskyServicePrincipalHistoryItem>(RiskyServicePrincipalHistoryItem.CreateFromDiscriminatorValue).ToList(); } },
                {"isProcessing", (o,n) => { (o as RiskyServicePrincipal).IsProcessing = n.GetBoolValue(); } },
                {"riskDetail", (o,n) => { (o as RiskyServicePrincipal).RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskLastUpdatedDateTime", (o,n) => { (o as RiskyServicePrincipal).RiskLastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskLevel", (o,n) => { (o as RiskyServicePrincipal).RiskLevel = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", (o,n) => { (o as RiskyServicePrincipal).RiskState = n.GetEnumValue<RiskState>(); } },
                {"servicePrincipalType", (o,n) => { (o as RiskyServicePrincipal).ServicePrincipalType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<RiskyServicePrincipalHistoryItem>("history", History);
            writer.WriteBoolValue("isProcessing", IsProcessing);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteDateTimeOffsetValue("riskLastUpdatedDateTime", RiskLastUpdatedDateTime);
            writer.WriteEnumValue<RiskLevel>("riskLevel", RiskLevel);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteStringValue("servicePrincipalType", ServicePrincipalType);
        }
    }
}
