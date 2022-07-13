using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class LogonUser : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Domain of user account used to logon.</summary>
        public string AccountDomain {
            get { return BackingStore?.Get<string>("accountDomain"); }
            set { BackingStore?.Set("accountDomain", value); }
        }
        /// <summary>Account name of user account used to logon.</summary>
        public string AccountName {
            get { return BackingStore?.Get<string>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
        /// <summary>User Account type, per Windows definition. Possible values are: unknown, standard, power, administrator.</summary>
        public UserAccountSecurityType? AccountType {
            get { return BackingStore?.Get<UserAccountSecurityType?>("accountType"); }
            set { BackingStore?.Set("accountType", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>DateTime at which the earliest logon by this user account occurred (provider-determined period). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>DateTime at which the latest logon by this user account occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>User logon ID.</summary>
        public string LogonId {
            get { return BackingStore?.Get<string>("logonId"); }
            set { BackingStore?.Set("logonId", value); }
        }
        /// <summary>Collection of the logon types observed for the logged on user from when first to last seen. Possible values are: unknown, interactive, remoteInteractive, network, batch, service.</summary>
        public List<string> LogonTypes {
            get { return BackingStore?.Get<List<string>>("logonTypes"); }
            set { BackingStore?.Set("logonTypes", value); }
        }
        /// <summary>
        /// Instantiates a new logonUser and sets the default values.
        /// </summary>
        public LogonUser() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static LogonUser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LogonUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accountDomain", n => { AccountDomain = n.GetStringValue(); } },
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"accountType", n => { AccountType = n.GetEnumValue<UserAccountSecurityType>(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"logonId", n => { LogonId = n.GetStringValue(); } },
                {"logonTypes", n => { LogonTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountDomain", AccountDomain);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteEnumValue<UserAccountSecurityType>("accountType", AccountType);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("logonId", LogonId);
            writer.WriteCollectionOfPrimitiveValues<string>("logonTypes", LogonTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
