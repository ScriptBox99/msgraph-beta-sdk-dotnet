// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class IdentityContainer : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Represents entry point for API connectors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityApiConnector>? ApiConnectors {
            get { return BackingStore?.Get<List<IdentityApiConnector>?>("apiConnectors"); }
            set { BackingStore?.Set("apiConnectors", value); }
        }
#nullable restore
#else
        public List<IdentityApiConnector> ApiConnectors {
            get { return BackingStore?.Get<List<IdentityApiConnector>>("apiConnectors"); }
            set { BackingStore?.Set("apiConnectors", value); }
        }
#endif
        /// <summary>The authenticationEventListeners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationEventListener>? AuthenticationEventListeners {
            get { return BackingStore?.Get<List<AuthenticationEventListener>?>("authenticationEventListeners"); }
            set { BackingStore?.Set("authenticationEventListeners", value); }
        }
#nullable restore
#else
        public List<AuthenticationEventListener> AuthenticationEventListeners {
            get { return BackingStore?.Get<List<AuthenticationEventListener>>("authenticationEventListeners"); }
            set { BackingStore?.Set("authenticationEventListeners", value); }
        }
#endif
        /// <summary>Represents the entry point for self-service sign up and sign in user flows in both Microsoft Entra workforce and customer tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationEventsFlow>? AuthenticationEventsFlows {
            get { return BackingStore?.Get<List<AuthenticationEventsFlow>?>("authenticationEventsFlows"); }
            set { BackingStore?.Set("authenticationEventsFlows", value); }
        }
#nullable restore
#else
        public List<AuthenticationEventsFlow> AuthenticationEventsFlows {
            get { return BackingStore?.Get<List<AuthenticationEventsFlow>>("authenticationEventsFlows"); }
            set { BackingStore?.Set("authenticationEventsFlows", value); }
        }
#endif
        /// <summary>Represents entry point for B2C identity userflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<B2cIdentityUserFlow>? B2cUserFlows {
            get { return BackingStore?.Get<List<B2cIdentityUserFlow>?>("b2cUserFlows"); }
            set { BackingStore?.Set("b2cUserFlows", value); }
        }
#nullable restore
#else
        public List<B2cIdentityUserFlow> B2cUserFlows {
            get { return BackingStore?.Get<List<B2cIdentityUserFlow>>("b2cUserFlows"); }
            set { BackingStore?.Set("b2cUserFlows", value); }
        }
#endif
        /// <summary>Represents entry point for B2X and self-service sign-up identity userflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<B2xIdentityUserFlow>? B2xUserFlows {
            get { return BackingStore?.Get<List<B2xIdentityUserFlow>?>("b2xUserFlows"); }
            set { BackingStore?.Set("b2xUserFlows", value); }
        }
#nullable restore
#else
        public List<B2xIdentityUserFlow> B2xUserFlows {
            get { return BackingStore?.Get<List<B2xIdentityUserFlow>>("b2xUserFlows"); }
            set { BackingStore?.Set("b2xUserFlows", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>the entry point for the Conditional Access (CA) object model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessRoot? ConditionalAccess {
            get { return BackingStore?.Get<ConditionalAccessRoot?>("conditionalAccess"); }
            set { BackingStore?.Set("conditionalAccess", value); }
        }
#nullable restore
#else
        public ConditionalAccessRoot ConditionalAccess {
            get { return BackingStore?.Get<ConditionalAccessRoot>("conditionalAccess"); }
            set { BackingStore?.Set("conditionalAccess", value); }
        }
#endif
        /// <summary>Represents entry point for continuous access evaluation policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy? ContinuousAccessEvaluationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy?>("continuousAccessEvaluationPolicy"); }
            set { BackingStore?.Set("continuousAccessEvaluationPolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy ContinuousAccessEvaluationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>("continuousAccessEvaluationPolicy"); }
            set { BackingStore?.Set("continuousAccessEvaluationPolicy", value); }
        }
#endif
        /// <summary>The customAuthenticationExtensions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomAuthenticationExtension>? CustomAuthenticationExtensions {
            get { return BackingStore?.Get<List<CustomAuthenticationExtension>?>("customAuthenticationExtensions"); }
            set { BackingStore?.Set("customAuthenticationExtensions", value); }
        }
#nullable restore
#else
        public List<CustomAuthenticationExtension> CustomAuthenticationExtensions {
            get { return BackingStore?.Get<List<CustomAuthenticationExtension>>("customAuthenticationExtensions"); }
            set { BackingStore?.Set("customAuthenticationExtensions", value); }
        }
#endif
        /// <summary>Represents entry point for identity provider base.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderBase>? IdentityProviders {
            get { return BackingStore?.Get<List<IdentityProviderBase>?>("identityProviders"); }
            set { BackingStore?.Set("identityProviders", value); }
        }
#nullable restore
#else
        public List<IdentityProviderBase> IdentityProviders {
            get { return BackingStore?.Get<List<IdentityProviderBase>>("identityProviders"); }
            set { BackingStore?.Set("identityProviders", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Represents entry point for identity userflow attributes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityUserFlowAttribute>? UserFlowAttributes {
            get { return BackingStore?.Get<List<IdentityUserFlowAttribute>?>("userFlowAttributes"); }
            set { BackingStore?.Set("userFlowAttributes", value); }
        }
#nullable restore
#else
        public List<IdentityUserFlowAttribute> UserFlowAttributes {
            get { return BackingStore?.Get<List<IdentityUserFlowAttribute>>("userFlowAttributes"); }
            set { BackingStore?.Set("userFlowAttributes", value); }
        }
#endif
        /// <summary>The userFlows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityUserFlow>? UserFlows {
            get { return BackingStore?.Get<List<IdentityUserFlow>?>("userFlows"); }
            set { BackingStore?.Set("userFlows", value); }
        }
#nullable restore
#else
        public List<IdentityUserFlow> UserFlows {
            get { return BackingStore?.Get<List<IdentityUserFlow>>("userFlows"); }
            set { BackingStore?.Set("userFlows", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new identityContainer and sets the default values.
        /// </summary>
        public IdentityContainer() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IdentityContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"apiConnectors", n => { ApiConnectors = n.GetCollectionOfObjectValues<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationEventListeners", n => { AuthenticationEventListeners = n.GetCollectionOfObjectValues<AuthenticationEventListener>(AuthenticationEventListener.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationEventsFlows", n => { AuthenticationEventsFlows = n.GetCollectionOfObjectValues<AuthenticationEventsFlow>(AuthenticationEventsFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"b2cUserFlows", n => { B2cUserFlows = n.GetCollectionOfObjectValues<B2cIdentityUserFlow>(B2cIdentityUserFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"b2xUserFlows", n => { B2xUserFlows = n.GetCollectionOfObjectValues<B2xIdentityUserFlow>(B2xIdentityUserFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccess", n => { ConditionalAccess = n.GetObjectValue<ConditionalAccessRoot>(ConditionalAccessRoot.CreateFromDiscriminatorValue); } },
                {"continuousAccessEvaluationPolicy", n => { ContinuousAccessEvaluationPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>(Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy.CreateFromDiscriminatorValue); } },
                {"customAuthenticationExtensions", n => { CustomAuthenticationExtensions = n.GetCollectionOfObjectValues<CustomAuthenticationExtension>(CustomAuthenticationExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"identityProviders", n => { IdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"userFlowAttributes", n => { UserFlowAttributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>(IdentityUserFlowAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userFlows", n => { UserFlows = n.GetCollectionOfObjectValues<IdentityUserFlow>(IdentityUserFlow.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<IdentityApiConnector>("apiConnectors", ApiConnectors);
            writer.WriteCollectionOfObjectValues<AuthenticationEventListener>("authenticationEventListeners", AuthenticationEventListeners);
            writer.WriteCollectionOfObjectValues<AuthenticationEventsFlow>("authenticationEventsFlows", AuthenticationEventsFlows);
            writer.WriteCollectionOfObjectValues<B2cIdentityUserFlow>("b2cUserFlows", B2cUserFlows);
            writer.WriteCollectionOfObjectValues<B2xIdentityUserFlow>("b2xUserFlows", B2xUserFlows);
            writer.WriteObjectValue<ConditionalAccessRoot>("conditionalAccess", ConditionalAccess);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>("continuousAccessEvaluationPolicy", ContinuousAccessEvaluationPolicy);
            writer.WriteCollectionOfObjectValues<CustomAuthenticationExtension>("customAuthenticationExtensions", CustomAuthenticationExtensions);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
            writer.WriteCollectionOfObjectValues<IdentityUserFlow>("userFlows", UserFlows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
