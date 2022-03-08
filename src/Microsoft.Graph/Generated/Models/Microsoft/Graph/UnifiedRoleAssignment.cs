using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the roleManagement singleton.</summary>
    public class UnifiedRoleAssignment : Entity, IParsable {
        /// <summary>Read-only property with details of the app specific scope when the assignment scope is app specific. Containment entity. Supports $expand.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AppScope AppScope { get; set; }
        /// <summary>Identifier of the app-specific scope when the assignment scope is app-specific.  Either this property or directoryScopeId is required. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units. Supports $filter (eq, in).</summary>
        public string AppScopeId { get; set; }
        public string Condition { get; set; }
        /// <summary>The directory object that is the scope of the assignment. Read-only. Supports $expand.</summary>
        public DirectoryObject DirectoryScope { get; set; }
        /// <summary>Identifier of the directory object representing the scope of the assignment.  Either this property or appScopeId is required. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only. Supports $filter (eq, in).</summary>
        public string DirectoryScopeId { get; set; }
        /// <summary>Referencing the assigned principal. Read-only. Supports $expand.</summary>
        public DirectoryObject Principal { get; set; }
        /// <summary>Identifier of the principal to which the assignment is granted. Supports $filter (eq, in).</summary>
        public string PrincipalId { get; set; }
        public string PrincipalOrganizationId { get; set; }
        /// <summary>The scope at which the unifiedRoleAssignment applies. This is / for service-wide. DO NOT USE. This property will be deprecated soon.</summary>
        public string ResourceScope { get; set; }
        /// <summary>The roleDefinition the assignment is for.  Supports $expand. roleDefinition.Id will be auto expanded.</summary>
        public UnifiedRoleDefinition RoleDefinition { get; set; }
        /// <summary>Identifier of the role definition the assignment is for. Read only. Supports $filter (eq, in).</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appScope", (o,n) => { (o as UnifiedRoleAssignment).AppScope = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AppScope>(MicrosoftGraphSdk.Models.Microsoft.Graph.AppScope.CreateFromDiscriminatorValue); } },
                {"appScopeId", (o,n) => { (o as UnifiedRoleAssignment).AppScopeId = n.GetStringValue(); } },
                {"condition", (o,n) => { (o as UnifiedRoleAssignment).Condition = n.GetStringValue(); } },
                {"directoryScope", (o,n) => { (o as UnifiedRoleAssignment).DirectoryScope = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"directoryScopeId", (o,n) => { (o as UnifiedRoleAssignment).DirectoryScopeId = n.GetStringValue(); } },
                {"principal", (o,n) => { (o as UnifiedRoleAssignment).Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", (o,n) => { (o as UnifiedRoleAssignment).PrincipalId = n.GetStringValue(); } },
                {"principalOrganizationId", (o,n) => { (o as UnifiedRoleAssignment).PrincipalOrganizationId = n.GetStringValue(); } },
                {"resourceScope", (o,n) => { (o as UnifiedRoleAssignment).ResourceScope = n.GetStringValue(); } },
                {"roleDefinition", (o,n) => { (o as UnifiedRoleAssignment).RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", (o,n) => { (o as UnifiedRoleAssignment).RoleDefinitionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteStringValue("condition", Condition);
            writer.WriteObjectValue<DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteStringValue("principalOrganizationId", PrincipalOrganizationId);
            writer.WriteStringValue("resourceScope", ResourceScope);
            writer.WriteObjectValue<UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
        }
    }
}
