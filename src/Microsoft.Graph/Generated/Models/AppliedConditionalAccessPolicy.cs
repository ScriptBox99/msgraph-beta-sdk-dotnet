using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppliedConditionalAccessPolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The custom authentication strength enforced in a Conditional Access policy.</summary>
        public Microsoft.Graph.Beta.Models.AuthenticationStrength AuthenticationStrength {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationStrength>(nameof(AuthenticationStrength)); }
            set { BackingStore?.Set(nameof(AuthenticationStrength), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Refers to the conditional access policy conditions that are not satisfied. The possible values are: none, application, users, devicePlatform, location, clientType, signInRisk, userRisk, time, deviceState, client,ipAddressSeenByAzureAD,ipAddressSeenByResourceProvider,unknownFutureValue,servicePrincipals,servicePrincipalRisk. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: servicePrincipals,servicePrincipalRisk.</summary>
        public ConditionalAccessConditions? ConditionsNotSatisfied {
            get { return BackingStore?.Get<ConditionalAccessConditions?>(nameof(ConditionsNotSatisfied)); }
            set { BackingStore?.Set(nameof(ConditionsNotSatisfied), value); }
        }
        /// <summary>Refers to the conditional access policy conditions that are satisfied. The possible values are: none, application, users, devicePlatform, location, clientType, signInRisk, userRisk, time, deviceState, client,ipAddressSeenByAzureAD,ipAddressSeenByResourceProvider,unknownFutureValue,servicePrincipals,servicePrincipalRisk. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: servicePrincipals,servicePrincipalRisk.</summary>
        public ConditionalAccessConditions? ConditionsSatisfied {
            get { return BackingStore?.Get<ConditionalAccessConditions?>(nameof(ConditionsSatisfied)); }
            set { BackingStore?.Set(nameof(ConditionsSatisfied), value); }
        }
        /// <summary>Name of the conditional access policy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Refers to the grant controls enforced by the conditional access policy (example: &apos;Require multi-factor authentication&apos;).</summary>
        public List<string> EnforcedGrantControls {
            get { return BackingStore?.Get<List<string>>(nameof(EnforcedGrantControls)); }
            set { BackingStore?.Set(nameof(EnforcedGrantControls), value); }
        }
        /// <summary>Refers to the session controls enforced by the conditional access policy (example: &apos;Require app enforced controls&apos;).</summary>
        public List<string> EnforcedSessionControls {
            get { return BackingStore?.Get<List<string>>(nameof(EnforcedSessionControls)); }
            set { BackingStore?.Set(nameof(EnforcedSessionControls), value); }
        }
        /// <summary>List of key-value pairs containing each matched exclude condition in the conditional access policy. Example: [{&apos;devicePlatform&apos; : &apos;DevicePlatform&apos;}] means the policy didn’t apply, because the DevicePlatform condition was a match.</summary>
        public List<ConditionalAccessRuleSatisfied> ExcludeRulesSatisfied {
            get { return BackingStore?.Get<List<ConditionalAccessRuleSatisfied>>(nameof(ExcludeRulesSatisfied)); }
            set { BackingStore?.Set(nameof(ExcludeRulesSatisfied), value); }
        }
        /// <summary>Identifier of the conditional access policy.</summary>
        public string Id {
            get { return BackingStore?.Get<string>(nameof(Id)); }
            set { BackingStore?.Set(nameof(Id), value); }
        }
        /// <summary>List of key-value pairs containing each matched include condition in the conditional access policy. Example: [{ &apos;application&apos; : &apos;AllApps&apos;}, {&apos;users&apos;: &apos;Group&apos;}], meaning Application condition was a match because AllApps are included and Users condition was a match because the user was part of the included Group rule.</summary>
        public List<ConditionalAccessRuleSatisfied> IncludeRulesSatisfied {
            get { return BackingStore?.Get<List<ConditionalAccessRuleSatisfied>>(nameof(IncludeRulesSatisfied)); }
            set { BackingStore?.Set(nameof(IncludeRulesSatisfied), value); }
        }
        /// <summary>Indicates the result of the CA policy that was triggered. Possible values are: success, failure, notApplied (Policy isn&apos;t applied because policy conditions were not met),notEnabled (This is due to the policy in disabled state), unknown, unknownFutureValue, reportOnlySuccess, reportOnlyFailure, reportOnlyNotApplied, reportOnlyInterrupted. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: reportOnlySuccess, reportOnlyFailure, reportOnlyNotApplied, reportOnlyInterrupted.</summary>
        public AppliedConditionalAccessPolicyResult? Result {
            get { return BackingStore?.Get<AppliedConditionalAccessPolicyResult?>(nameof(Result)); }
            set { BackingStore?.Set(nameof(Result), value); }
        }
        /// <summary>Refers to the session controls that a sign-in activity did not satisfy. (Example: Application enforced Restrictions).</summary>
        public List<string> SessionControlsNotSatisfied {
            get { return BackingStore?.Get<List<string>>(nameof(SessionControlsNotSatisfied)); }
            set { BackingStore?.Set(nameof(SessionControlsNotSatisfied), value); }
        }
        /// <summary>
        /// Instantiates a new appliedConditionalAccessPolicy and sets the default values.
        /// </summary>
        public AppliedConditionalAccessPolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AppliedConditionalAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppliedConditionalAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authenticationStrength", n => { AuthenticationStrength = n.GetObjectValue<Microsoft.Graph.Beta.Models.AuthenticationStrength>(Microsoft.Graph.Beta.Models.AuthenticationStrength.CreateFromDiscriminatorValue); } },
                {"conditionsNotSatisfied", n => { ConditionsNotSatisfied = n.GetEnumValue<ConditionalAccessConditions>(); } },
                {"conditionsSatisfied", n => { ConditionsSatisfied = n.GetEnumValue<ConditionalAccessConditions>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enforcedGrantControls", n => { EnforcedGrantControls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"enforcedSessionControls", n => { EnforcedSessionControls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"excludeRulesSatisfied", n => { ExcludeRulesSatisfied = n.GetCollectionOfObjectValues<ConditionalAccessRuleSatisfied>(ConditionalAccessRuleSatisfied.CreateFromDiscriminatorValue).ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"includeRulesSatisfied", n => { IncludeRulesSatisfied = n.GetCollectionOfObjectValues<ConditionalAccessRuleSatisfied>(ConditionalAccessRuleSatisfied.CreateFromDiscriminatorValue).ToList(); } },
                {"result", n => { Result = n.GetEnumValue<AppliedConditionalAccessPolicyResult>(); } },
                {"sessionControlsNotSatisfied", n => { SessionControlsNotSatisfied = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AuthenticationStrength>("authenticationStrength", AuthenticationStrength);
            writer.WriteEnumValue<ConditionalAccessConditions>("conditionsNotSatisfied", ConditionsNotSatisfied);
            writer.WriteEnumValue<ConditionalAccessConditions>("conditionsSatisfied", ConditionsSatisfied);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedGrantControls", EnforcedGrantControls);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedSessionControls", EnforcedSessionControls);
            writer.WriteCollectionOfObjectValues<ConditionalAccessRuleSatisfied>("excludeRulesSatisfied", ExcludeRulesSatisfied);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<ConditionalAccessRuleSatisfied>("includeRulesSatisfied", IncludeRulesSatisfied);
            writer.WriteEnumValue<AppliedConditionalAccessPolicyResult>("result", Result);
            writer.WriteCollectionOfPrimitiveValues<string>("sessionControlsNotSatisfied", SessionControlsNotSatisfied);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
