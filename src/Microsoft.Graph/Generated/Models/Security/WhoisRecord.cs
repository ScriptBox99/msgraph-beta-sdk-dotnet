using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class WhoisRecord : Entity, IParsable {
        /// <summary>The abuse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Abuse {
            get { return BackingStore?.Get<WhoisContact?>("abuse"); }
            set { BackingStore?.Set("abuse", value); }
        }
#nullable restore
#else
        public WhoisContact Abuse {
            get { return BackingStore?.Get<WhoisContact>("abuse"); }
            set { BackingStore?.Set("abuse", value); }
        }
#endif
        /// <summary>The admin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Admin {
            get { return BackingStore?.Get<WhoisContact?>("admin"); }
            set { BackingStore?.Set("admin", value); }
        }
#nullable restore
#else
        public WhoisContact Admin {
            get { return BackingStore?.Get<WhoisContact>("admin"); }
            set { BackingStore?.Set("admin", value); }
        }
#endif
        /// <summary>The billing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Billing {
            get { return BackingStore?.Get<WhoisContact?>("billing"); }
            set { BackingStore?.Set("billing", value); }
        }
#nullable restore
#else
        public WhoisContact Billing {
            get { return BackingStore?.Get<WhoisContact>("billing"); }
            set { BackingStore?.Set("billing", value); }
        }
#endif
        /// <summary>The domainStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainStatus {
            get { return BackingStore?.Get<string?>("domainStatus"); }
            set { BackingStore?.Set("domainStatus", value); }
        }
#nullable restore
#else
        public string DomainStatus {
            get { return BackingStore?.Get<string>("domainStatus"); }
            set { BackingStore?.Set("domainStatus", value); }
        }
#endif
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The host property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.Host? Host {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.Host?>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.Host Host {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.Host>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#endif
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The lastUpdateDateTime property</summary>
        public DateTimeOffset? LastUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdateDateTime"); }
            set { BackingStore?.Set("lastUpdateDateTime", value); }
        }
        /// <summary>The nameservers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WhoisNameserver>? Nameservers {
            get { return BackingStore?.Get<List<WhoisNameserver>?>("nameservers"); }
            set { BackingStore?.Set("nameservers", value); }
        }
#nullable restore
#else
        public List<WhoisNameserver> Nameservers {
            get { return BackingStore?.Get<List<WhoisNameserver>>("nameservers"); }
            set { BackingStore?.Set("nameservers", value); }
        }
#endif
        /// <summary>The noc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Noc {
            get { return BackingStore?.Get<WhoisContact?>("noc"); }
            set { BackingStore?.Set("noc", value); }
        }
#nullable restore
#else
        public WhoisContact Noc {
            get { return BackingStore?.Get<WhoisContact>("noc"); }
            set { BackingStore?.Set("noc", value); }
        }
#endif
        /// <summary>The rawWhoisText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RawWhoisText {
            get { return BackingStore?.Get<string?>("rawWhoisText"); }
            set { BackingStore?.Set("rawWhoisText", value); }
        }
#nullable restore
#else
        public string RawWhoisText {
            get { return BackingStore?.Get<string>("rawWhoisText"); }
            set { BackingStore?.Set("rawWhoisText", value); }
        }
#endif
        /// <summary>The registrant property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Registrant {
            get { return BackingStore?.Get<WhoisContact?>("registrant"); }
            set { BackingStore?.Set("registrant", value); }
        }
#nullable restore
#else
        public WhoisContact Registrant {
            get { return BackingStore?.Get<WhoisContact>("registrant"); }
            set { BackingStore?.Set("registrant", value); }
        }
#endif
        /// <summary>The registrar property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Registrar {
            get { return BackingStore?.Get<WhoisContact?>("registrar"); }
            set { BackingStore?.Set("registrar", value); }
        }
#nullable restore
#else
        public WhoisContact Registrar {
            get { return BackingStore?.Get<WhoisContact>("registrar"); }
            set { BackingStore?.Set("registrar", value); }
        }
#endif
        /// <summary>The registrationDateTime property</summary>
        public DateTimeOffset? RegistrationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("registrationDateTime"); }
            set { BackingStore?.Set("registrationDateTime", value); }
        }
        /// <summary>The technical property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Technical {
            get { return BackingStore?.Get<WhoisContact?>("technical"); }
            set { BackingStore?.Set("technical", value); }
        }
#nullable restore
#else
        public WhoisContact Technical {
            get { return BackingStore?.Get<WhoisContact>("technical"); }
            set { BackingStore?.Set("technical", value); }
        }
#endif
        /// <summary>The whoisServer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WhoisServer {
            get { return BackingStore?.Get<string?>("whoisServer"); }
            set { BackingStore?.Set("whoisServer", value); }
        }
#nullable restore
#else
        public string WhoisServer {
            get { return BackingStore?.Get<string>("whoisServer"); }
            set { BackingStore?.Set("whoisServer", value); }
        }
#endif
        /// <summary>The zone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Zone {
            get { return BackingStore?.Get<WhoisContact?>("zone"); }
            set { BackingStore?.Set("zone", value); }
        }
#nullable restore
#else
        public WhoisContact Zone {
            get { return BackingStore?.Get<WhoisContact>("zone"); }
            set { BackingStore?.Set("zone", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WhoisRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WhoisRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"abuse", n => { Abuse = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                {"admin", n => { Admin = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                {"billing", n => { Billing = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                {"domainStatus", n => { DomainStatus = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"host", n => { Host = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.Host>(Microsoft.Graph.Beta.Models.Security.Host.CreateFromDiscriminatorValue); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"nameservers", n => { Nameservers = n.GetCollectionOfObjectValues<WhoisNameserver>(WhoisNameserver.CreateFromDiscriminatorValue)?.ToList(); } },
                {"noc", n => { Noc = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                {"rawWhoisText", n => { RawWhoisText = n.GetStringValue(); } },
                {"registrant", n => { Registrant = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                {"registrar", n => { Registrar = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                {"registrationDateTime", n => { RegistrationDateTime = n.GetDateTimeOffsetValue(); } },
                {"technical", n => { Technical = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                {"whoisServer", n => { WhoisServer = n.GetStringValue(); } },
                {"zone", n => { Zone = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WhoisContact>("abuse", Abuse);
            writer.WriteObjectValue<WhoisContact>("admin", Admin);
            writer.WriteObjectValue<WhoisContact>("billing", Billing);
            writer.WriteStringValue("domainStatus", DomainStatus);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.Host>("host", Host);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteCollectionOfObjectValues<WhoisNameserver>("nameservers", Nameservers);
            writer.WriteObjectValue<WhoisContact>("noc", Noc);
            writer.WriteStringValue("rawWhoisText", RawWhoisText);
            writer.WriteObjectValue<WhoisContact>("registrant", Registrant);
            writer.WriteObjectValue<WhoisContact>("registrar", Registrar);
            writer.WriteDateTimeOffsetValue("registrationDateTime", RegistrationDateTime);
            writer.WriteObjectValue<WhoisContact>("technical", Technical);
            writer.WriteStringValue("whoisServer", WhoisServer);
            writer.WriteObjectValue<WhoisContact>("zone", Zone);
        }
    }
}
