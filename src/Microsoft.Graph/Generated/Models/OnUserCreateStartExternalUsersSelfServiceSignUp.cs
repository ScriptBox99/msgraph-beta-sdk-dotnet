using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnUserCreateStartExternalUsersSelfServiceSignUp : OnUserCreateStartHandler, IParsable {
        /// <summary>The type of user object to create. The possible values are: member, guest, unknownFutureValue.</summary>
        public UserType? UserTypeToCreate {
            get { return BackingStore?.Get<UserType?>("userTypeToCreate"); }
            set { BackingStore?.Set("userTypeToCreate", value); }
        }
        /// <summary>
        /// Instantiates a new onUserCreateStartExternalUsersSelfServiceSignUp and sets the default values.
        /// </summary>
        public OnUserCreateStartExternalUsersSelfServiceSignUp() : base() {
            OdataType = "#microsoft.graph.onUserCreateStartExternalUsersSelfServiceSignUp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnUserCreateStartExternalUsersSelfServiceSignUp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnUserCreateStartExternalUsersSelfServiceSignUp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"userTypeToCreate", n => { UserTypeToCreate = n.GetEnumValue<UserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<UserType>("userTypeToCreate", UserTypeToCreate);
        }
    }
}
