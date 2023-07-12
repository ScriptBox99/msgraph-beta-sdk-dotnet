using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp : OnInteractiveAuthFlowStartHandler, IParsable {
        /// <summary>Optional. Specifes whether the authentication flow includes an option to sign up (create account) as well as sign in. Default value is false meaning only sign in is enabled.</summary>
        public bool? IsSignUpAllowed {
            get { return BackingStore?.Get<bool?>("isSignUpAllowed"); }
            set { BackingStore?.Set("isSignUpAllowed", value); }
        }
        /// <summary>
        /// Instantiates a new onInteractiveAuthFlowStartExternalUsersSelfServiceSignUp and sets the default values.
        /// </summary>
        public OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp() : base() {
            OdataType = "#microsoft.graph.onInteractiveAuthFlowStartExternalUsersSelfServiceSignUp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isSignUpAllowed", n => { IsSignUpAllowed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isSignUpAllowed", IsSignUpAllowed);
        }
    }
}
