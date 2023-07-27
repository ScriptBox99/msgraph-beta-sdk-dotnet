using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DirectoryObject1 : Entity, IParsable {
        /// <summary>Conceptual container for user and group directory objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AdministrativeUnit>? AdministrativeUnits {
            get { return BackingStore?.Get<List<AdministrativeUnit>?>("administrativeUnits"); }
            set { BackingStore?.Set("administrativeUnits", value); }
        }
#nullable restore
#else
        public List<AdministrativeUnit> AdministrativeUnits {
            get { return BackingStore?.Get<List<AdministrativeUnit>>("administrativeUnits"); }
            set { BackingStore?.Set("administrativeUnits", value); }
        }
#endif
        /// <summary>Group of related custom security attribute definitions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttributeSet>? AttributeSets {
            get { return BackingStore?.Get<List<AttributeSet>?>("attributeSets"); }
            set { BackingStore?.Set("attributeSets", value); }
        }
#nullable restore
#else
        public List<AttributeSet> AttributeSets {
            get { return BackingStore?.Get<List<AttributeSet>>("attributeSets"); }
            set { BackingStore?.Set("attributeSets", value); }
        }
#endif
        /// <summary>The certificateAuthorities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CertificateAuthorityPath? CertificateAuthorities {
            get { return BackingStore?.Get<CertificateAuthorityPath?>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#nullable restore
#else
        public CertificateAuthorityPath CertificateAuthorities {
            get { return BackingStore?.Get<CertificateAuthorityPath>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#endif
        /// <summary>Schema of a custom security attributes (key-value pairs).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomSecurityAttributeDefinition>? CustomSecurityAttributeDefinitions {
            get { return BackingStore?.Get<List<CustomSecurityAttributeDefinition>?>("customSecurityAttributeDefinitions"); }
            set { BackingStore?.Set("customSecurityAttributeDefinitions", value); }
        }
#nullable restore
#else
        public List<CustomSecurityAttributeDefinition> CustomSecurityAttributeDefinitions {
            get { return BackingStore?.Get<List<CustomSecurityAttributeDefinition>>("customSecurityAttributeDefinitions"); }
            set { BackingStore?.Set("customSecurityAttributeDefinitions", value); }
        }
#endif
        /// <summary>The deletedItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? DeletedItems {
            get { return BackingStore?.Get<List<DirectoryObject>?>("deletedItems"); }
            set { BackingStore?.Set("deletedItems", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> DeletedItems {
            get { return BackingStore?.Get<List<DirectoryObject>>("deletedItems"); }
            set { BackingStore?.Set("deletedItems", value); }
        }
#endif
        /// <summary>The featureRolloutPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FeatureRolloutPolicy>? FeatureRolloutPolicies {
            get { return BackingStore?.Get<List<FeatureRolloutPolicy>?>("featureRolloutPolicies"); }
            set { BackingStore?.Set("featureRolloutPolicies", value); }
        }
#nullable restore
#else
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies {
            get { return BackingStore?.Get<List<FeatureRolloutPolicy>>("featureRolloutPolicies"); }
            set { BackingStore?.Set("featureRolloutPolicies", value); }
        }
#endif
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderBase>? FederationConfigurations {
            get { return BackingStore?.Get<List<IdentityProviderBase>?>("federationConfigurations"); }
            set { BackingStore?.Set("federationConfigurations", value); }
        }
#nullable restore
#else
        public List<IdentityProviderBase> FederationConfigurations {
            get { return BackingStore?.Get<List<IdentityProviderBase>>("federationConfigurations"); }
            set { BackingStore?.Set("federationConfigurations", value); }
        }
#endif
        /// <summary>The impactedResources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImpactedResource>? ImpactedResources {
            get { return BackingStore?.Get<List<ImpactedResource>?>("impactedResources"); }
            set { BackingStore?.Set("impactedResources", value); }
        }
#nullable restore
#else
        public List<ImpactedResource> ImpactedResources {
            get { return BackingStore?.Get<List<ImpactedResource>>("impactedResources"); }
            set { BackingStore?.Set("impactedResources", value); }
        }
#endif
        /// <summary>A collection of external Azure AD users whose profile data has been shared with the Azure AD tenant. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InboundSharedUserProfile>? InboundSharedUserProfiles {
            get { return BackingStore?.Get<List<InboundSharedUserProfile>?>("inboundSharedUserProfiles"); }
            set { BackingStore?.Set("inboundSharedUserProfiles", value); }
        }
#nullable restore
#else
        public List<InboundSharedUserProfile> InboundSharedUserProfiles {
            get { return BackingStore?.Get<List<InboundSharedUserProfile>>("inboundSharedUserProfiles"); }
            set { BackingStore?.Set("inboundSharedUserProfiles", value); }
        }
#endif
        /// <summary>A container for on-premises directory synchronization functionalities that are available for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnPremisesDirectorySynchronization>? OnPremisesSynchronization {
            get { return BackingStore?.Get<List<OnPremisesDirectorySynchronization>?>("onPremisesSynchronization"); }
            set { BackingStore?.Set("onPremisesSynchronization", value); }
        }
#nullable restore
#else
        public List<OnPremisesDirectorySynchronization> OnPremisesSynchronization {
            get { return BackingStore?.Get<List<OnPremisesDirectorySynchronization>>("onPremisesSynchronization"); }
            set { BackingStore?.Set("onPremisesSynchronization", value); }
        }
#endif
        /// <summary>The outboundSharedUserProfiles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OutboundSharedUserProfile>? OutboundSharedUserProfiles {
            get { return BackingStore?.Get<List<OutboundSharedUserProfile>?>("outboundSharedUserProfiles"); }
            set { BackingStore?.Set("outboundSharedUserProfiles", value); }
        }
#nullable restore
#else
        public List<OutboundSharedUserProfile> OutboundSharedUserProfiles {
            get { return BackingStore?.Get<List<OutboundSharedUserProfile>>("outboundSharedUserProfiles"); }
            set { BackingStore?.Set("outboundSharedUserProfiles", value); }
        }
#endif
        /// <summary>List of recommended improvements to improve tenant posture.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recommendation>? Recommendations {
            get { return BackingStore?.Get<List<Recommendation>?>("recommendations"); }
            set { BackingStore?.Set("recommendations", value); }
        }
#nullable restore
#else
        public List<Recommendation> Recommendations {
            get { return BackingStore?.Get<List<Recommendation>>("recommendations"); }
            set { BackingStore?.Set("recommendations", value); }
        }
#endif
        /// <summary>The sharedEmailDomains property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SharedEmailDomain>? SharedEmailDomains {
            get { return BackingStore?.Get<List<SharedEmailDomain>?>("sharedEmailDomains"); }
            set { BackingStore?.Set("sharedEmailDomains", value); }
        }
#nullable restore
#else
        public List<SharedEmailDomain> SharedEmailDomains {
            get { return BackingStore?.Get<List<SharedEmailDomain>>("sharedEmailDomains"); }
            set { BackingStore?.Set("sharedEmailDomains", value); }
        }
#endif
        /// <summary>List of commercial subscriptions that an organization has acquired.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CompanySubscription>? Subscriptions {
            get { return BackingStore?.Get<List<CompanySubscription>?>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#nullable restore
#else
        public List<CompanySubscription> Subscriptions {
            get { return BackingStore?.Get<List<CompanySubscription>>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DirectoryObject1 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryObject1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfObjectValues<AdministrativeUnit>(AdministrativeUnit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attributeSets", n => { AttributeSets = n.GetCollectionOfObjectValues<AttributeSet>(AttributeSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"certificateAuthorities", n => { CertificateAuthorities = n.GetObjectValue<CertificateAuthorityPath>(CertificateAuthorityPath.CreateFromDiscriminatorValue); } },
                {"customSecurityAttributeDefinitions", n => { CustomSecurityAttributeDefinitions = n.GetCollectionOfObjectValues<CustomSecurityAttributeDefinition>(CustomSecurityAttributeDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deletedItems", n => { DeletedItems = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"federationConfigurations", n => { FederationConfigurations = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"impactedResources", n => { ImpactedResources = n.GetCollectionOfObjectValues<ImpactedResource>(ImpactedResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"inboundSharedUserProfiles", n => { InboundSharedUserProfiles = n.GetCollectionOfObjectValues<InboundSharedUserProfile>(InboundSharedUserProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesSynchronization", n => { OnPremisesSynchronization = n.GetCollectionOfObjectValues<OnPremisesDirectorySynchronization>(OnPremisesDirectorySynchronization.CreateFromDiscriminatorValue)?.ToList(); } },
                {"outboundSharedUserProfiles", n => { OutboundSharedUserProfiles = n.GetCollectionOfObjectValues<OutboundSharedUserProfile>(OutboundSharedUserProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"recommendations", n => { Recommendations = n.GetCollectionOfObjectValues<Recommendation>(Recommendation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sharedEmailDomains", n => { SharedEmailDomains = n.GetCollectionOfObjectValues<SharedEmailDomain>(SharedEmailDomain.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<CompanySubscription>(CompanySubscription.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AdministrativeUnit>("administrativeUnits", AdministrativeUnits);
            writer.WriteCollectionOfObjectValues<AttributeSet>("attributeSets", AttributeSets);
            writer.WriteObjectValue<CertificateAuthorityPath>("certificateAuthorities", CertificateAuthorities);
            writer.WriteCollectionOfObjectValues<CustomSecurityAttributeDefinition>("customSecurityAttributeDefinitions", CustomSecurityAttributeDefinitions);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("deletedItems", DeletedItems);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("federationConfigurations", FederationConfigurations);
            writer.WriteCollectionOfObjectValues<ImpactedResource>("impactedResources", ImpactedResources);
            writer.WriteCollectionOfObjectValues<InboundSharedUserProfile>("inboundSharedUserProfiles", InboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<OnPremisesDirectorySynchronization>("onPremisesSynchronization", OnPremisesSynchronization);
            writer.WriteCollectionOfObjectValues<OutboundSharedUserProfile>("outboundSharedUserProfiles", OutboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<Recommendation>("recommendations", Recommendations);
            writer.WriteCollectionOfObjectValues<SharedEmailDomain>("sharedEmailDomains", SharedEmailDomains);
            writer.WriteCollectionOfObjectValues<CompanySubscription>("subscriptions", Subscriptions);
        }
    }
}
