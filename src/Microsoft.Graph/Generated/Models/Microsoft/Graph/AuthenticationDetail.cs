using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class AuthenticationDetail : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of authentication method used to perform this step of authentication. Possible values: Password, SMS, Voice, Authenticator App, Software OATH token, Satisfied by token, Previously satisfied.</summary>
        public string AuthenticationMethod { get; set; }
        /// <summary>Details about the authentication method used to perform this authentication step. For example, phone number (for SMS and voice), device name (for Authenticator app), and password source (e.g. cloud, AD FS, PTA, PHS).</summary>
        public string AuthenticationMethodDetail { get; set; }
        /// <summary>Represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AuthenticationStepDateTime { get; set; }
        /// <summary>The step of authentication that this satisfied. For example, primary authentication, or multi-factor authentication.</summary>
        public string AuthenticationStepRequirement { get; set; }
        /// <summary>Details about why the step succeeded or failed. For examples, user is blocked, fraud code entered, no phone input - timed out, phone unreachable, or claim in token.</summary>
        public string AuthenticationStepResultDetail { get; set; }
        /// <summary>Indicates the status of the authentication step. Possible values: succeeded, failed.</summary>
        public bool? Succeeded { get; set; }
        /// <summary>
        /// Instantiates a new authenticationDetail and sets the default values.
        /// </summary>
        public AuthenticationDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AuthenticationDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"authenticationMethod", (o,n) => { (o as AuthenticationDetail).AuthenticationMethod = n.GetStringValue(); } },
                {"authenticationMethodDetail", (o,n) => { (o as AuthenticationDetail).AuthenticationMethodDetail = n.GetStringValue(); } },
                {"authenticationStepDateTime", (o,n) => { (o as AuthenticationDetail).AuthenticationStepDateTime = n.GetDateTimeOffsetValue(); } },
                {"authenticationStepRequirement", (o,n) => { (o as AuthenticationDetail).AuthenticationStepRequirement = n.GetStringValue(); } },
                {"authenticationStepResultDetail", (o,n) => { (o as AuthenticationDetail).AuthenticationStepResultDetail = n.GetStringValue(); } },
                {"succeeded", (o,n) => { (o as AuthenticationDetail).Succeeded = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authenticationMethod", AuthenticationMethod);
            writer.WriteStringValue("authenticationMethodDetail", AuthenticationMethodDetail);
            writer.WriteDateTimeOffsetValue("authenticationStepDateTime", AuthenticationStepDateTime);
            writer.WriteStringValue("authenticationStepRequirement", AuthenticationStepRequirement);
            writer.WriteStringValue("authenticationStepResultDetail", AuthenticationStepResultDetail);
            writer.WriteBoolValue("succeeded", Succeeded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
