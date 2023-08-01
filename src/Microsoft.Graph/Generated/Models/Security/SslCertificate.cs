using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class SslCertificate : Artifact, IParsable {
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The fingerprint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fingerprint {
            get { return BackingStore?.Get<string?>("fingerprint"); }
            set { BackingStore?.Set("fingerprint", value); }
        }
#nullable restore
#else
        public string Fingerprint {
            get { return BackingStore?.Get<string>("fingerprint"); }
            set { BackingStore?.Set("fingerprint", value); }
        }
#endif
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The issueDateTime property</summary>
        public DateTimeOffset? IssueDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("issueDateTime"); }
            set { BackingStore?.Set("issueDateTime", value); }
        }
        /// <summary>The issuer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SslCertificateEntity? Issuer {
            get { return BackingStore?.Get<SslCertificateEntity?>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#nullable restore
#else
        public SslCertificateEntity Issuer {
            get { return BackingStore?.Get<SslCertificateEntity>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#endif
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The relatedHosts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Host>? RelatedHosts {
            get { return BackingStore?.Get<List<Host>?>("relatedHosts"); }
            set { BackingStore?.Set("relatedHosts", value); }
        }
#nullable restore
#else
        public List<Host> RelatedHosts {
            get { return BackingStore?.Get<List<Host>>("relatedHosts"); }
            set { BackingStore?.Set("relatedHosts", value); }
        }
#endif
        /// <summary>The serialNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>The sha1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha1 {
            get { return BackingStore?.Get<string?>("sha1"); }
            set { BackingStore?.Set("sha1", value); }
        }
#nullable restore
#else
        public string Sha1 {
            get { return BackingStore?.Get<string>("sha1"); }
            set { BackingStore?.Set("sha1", value); }
        }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SslCertificateEntity? Subject {
            get { return BackingStore?.Get<SslCertificateEntity?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public SslCertificateEntity Subject {
            get { return BackingStore?.Get<SslCertificateEntity>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new sslCertificate and sets the default values.
        /// </summary>
        public SslCertificate() : base() {
            OdataType = "#microsoft.graph.security.sslCertificate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SslCertificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SslCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"fingerprint", n => { Fingerprint = n.GetStringValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"issueDateTime", n => { IssueDateTime = n.GetDateTimeOffsetValue(); } },
                {"issuer", n => { Issuer = n.GetObjectValue<SslCertificateEntity>(SslCertificateEntity.CreateFromDiscriminatorValue); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"relatedHosts", n => { RelatedHosts = n.GetCollectionOfObjectValues<Host>(Host.CreateFromDiscriminatorValue)?.ToList(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"sha1", n => { Sha1 = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetObjectValue<SslCertificateEntity>(SslCertificateEntity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("fingerprint", Fingerprint);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("issueDateTime", IssueDateTime);
            writer.WriteObjectValue<SslCertificateEntity>("issuer", Issuer);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteCollectionOfObjectValues<Host>("relatedHosts", RelatedHosts);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("sha1", Sha1);
            writer.WriteObjectValue<SslCertificateEntity>("subject", Subject);
        }
    }
}
