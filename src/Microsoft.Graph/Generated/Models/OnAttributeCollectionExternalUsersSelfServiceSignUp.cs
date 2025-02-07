// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnAttributeCollectionExternalUsersSelfServiceSignUp : OnAttributeCollectionHandler, IParsable {
        /// <summary>Required. The configuration for how attributes are displayed in the sign up experience defined by a user flow, like the externalUsersSelfServiceSignupEventsFlow, specifically on the attribute collection page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationAttributeCollectionPage? AttributeCollectionPage {
            get { return BackingStore?.Get<AuthenticationAttributeCollectionPage?>("attributeCollectionPage"); }
            set { BackingStore?.Set("attributeCollectionPage", value); }
        }
#nullable restore
#else
        public AuthenticationAttributeCollectionPage AttributeCollectionPage {
            get { return BackingStore?.Get<AuthenticationAttributeCollectionPage>("attributeCollectionPage"); }
            set { BackingStore?.Set("attributeCollectionPage", value); }
        }
#endif
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityUserFlowAttribute>? Attributes {
            get { return BackingStore?.Get<List<IdentityUserFlowAttribute>?>("attributes"); }
            set { BackingStore?.Set("attributes", value); }
        }
#nullable restore
#else
        public List<IdentityUserFlowAttribute> Attributes {
            get { return BackingStore?.Get<List<IdentityUserFlowAttribute>>("attributes"); }
            set { BackingStore?.Set("attributes", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new onAttributeCollectionExternalUsersSelfServiceSignUp and sets the default values.
        /// </summary>
        public OnAttributeCollectionExternalUsersSelfServiceSignUp() : base() {
            OdataType = "#microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnAttributeCollectionExternalUsersSelfServiceSignUp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnAttributeCollectionExternalUsersSelfServiceSignUp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attributeCollectionPage", n => { AttributeCollectionPage = n.GetObjectValue<AuthenticationAttributeCollectionPage>(AuthenticationAttributeCollectionPage.CreateFromDiscriminatorValue); } },
                {"attributes", n => { Attributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>(IdentityUserFlowAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AuthenticationAttributeCollectionPage>("attributeCollectionPage", AttributeCollectionPage);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("attributes", Attributes);
        }
    }
}
