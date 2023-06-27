using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRoleManagementAlertDefinition : Entity, IParsable {
        /// <summary>The description of the alert.</summary>
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
        /// <summary>The friendly display name that renders in Privileged Identity Management (PIM) alerts in the Azure portal.</summary>
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
        /// <summary>Long-form text that indicates the ways to prevent the alert from being triggered in your tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HowToPrevent {
            get { return BackingStore?.Get<string?>("howToPrevent"); }
            set { BackingStore?.Set("howToPrevent", value); }
        }
#nullable restore
#else
        public string HowToPrevent {
            get { return BackingStore?.Get<string>("howToPrevent"); }
            set { BackingStore?.Set("howToPrevent", value); }
        }
#endif
        /// <summary>true if the alert configuration can be customized in the tenant, and false otherwise. For example, the number and percentage thresholds of the &apos;There are too many global administrators&apos; alert can be configured by users, while the &apos;This organization does not have Azure AD Premium P2&apos; cannot be configured, because the criteria is restricted.</summary>
        public bool? IsConfigurable {
            get { return BackingStore?.Get<bool?>("isConfigurable"); }
            set { BackingStore?.Set("isConfigurable", value); }
        }
        /// <summary>true if the alert can be remediated, and false otherwise.</summary>
        public bool? IsRemediatable {
            get { return BackingStore?.Get<bool?>("isRemediatable"); }
            set { BackingStore?.Set("isRemediatable", value); }
        }
        /// <summary>The methods to mitigate the alert when it&apos;s triggered in the tenant. For example, to mitigate the &apos;There are too many global administrators&apos;, you could remove redundant privileged role assignments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MitigationSteps {
            get { return BackingStore?.Get<string?>("mitigationSteps"); }
            set { BackingStore?.Set("mitigationSteps", value); }
        }
#nullable restore
#else
        public string MitigationSteps {
            get { return BackingStore?.Get<string>("mitigationSteps"); }
            set { BackingStore?.Set("mitigationSteps", value); }
        }
#endif
        /// <summary>The identifier of the scope where the alert is related. / is the only supported one for the tenant. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeId {
            get { return BackingStore?.Get<string?>("scopeId"); }
            set { BackingStore?.Set("scopeId", value); }
        }
#nullable restore
#else
        public string ScopeId {
            get { return BackingStore?.Get<string>("scopeId"); }
            set { BackingStore?.Set("scopeId", value); }
        }
#endif
        /// <summary>The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Azure AD Roles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeType {
            get { return BackingStore?.Get<string?>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#nullable restore
#else
        public string ScopeType {
            get { return BackingStore?.Get<string>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#endif
        /// <summary>Security impact of the alert. For example, it could be information leaks or unauthorized access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecurityImpact {
            get { return BackingStore?.Get<string?>("securityImpact"); }
            set { BackingStore?.Set("securityImpact", value); }
        }
#nullable restore
#else
        public string SecurityImpact {
            get { return BackingStore?.Get<string>("securityImpact"); }
            set { BackingStore?.Set("securityImpact", value); }
        }
#endif
        /// <summary>Severity level of the alert. The possible values are: unknown, informational, low, medium, high, unknownFutureValue.</summary>
        public AlertSeverity? SeverityLevel {
            get { return BackingStore?.Get<AlertSeverity?>("severityLevel"); }
            set { BackingStore?.Set("severityLevel", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementAlertDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementAlertDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"howToPrevent", n => { HowToPrevent = n.GetStringValue(); } },
                {"isConfigurable", n => { IsConfigurable = n.GetBoolValue(); } },
                {"isRemediatable", n => { IsRemediatable = n.GetBoolValue(); } },
                {"mitigationSteps", n => { MitigationSteps = n.GetStringValue(); } },
                {"scopeId", n => { ScopeId = n.GetStringValue(); } },
                {"scopeType", n => { ScopeType = n.GetStringValue(); } },
                {"securityImpact", n => { SecurityImpact = n.GetStringValue(); } },
                {"severityLevel", n => { SeverityLevel = n.GetEnumValue<AlertSeverity>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("howToPrevent", HowToPrevent);
            writer.WriteBoolValue("isConfigurable", IsConfigurable);
            writer.WriteBoolValue("isRemediatable", IsRemediatable);
            writer.WriteStringValue("mitigationSteps", MitigationSteps);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
            writer.WriteStringValue("securityImpact", SecurityImpact);
            writer.WriteEnumValue<AlertSeverity>("severityLevel", SeverityLevel);
        }
    }
}
