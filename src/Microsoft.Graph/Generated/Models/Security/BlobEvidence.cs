using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class BlobEvidence : AlertEvidence, IParsable {
        /// <summary>The blobContainer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BlobContainerEvidence? BlobContainer {
            get { return BackingStore?.Get<BlobContainerEvidence?>("blobContainer"); }
            set { BackingStore?.Set("blobContainer", value); }
        }
#nullable restore
#else
        public BlobContainerEvidence BlobContainer {
            get { return BackingStore?.Get<BlobContainerEvidence>("blobContainer"); }
            set { BackingStore?.Set("blobContainer", value); }
        }
#endif
        /// <summary>The etag property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Etag {
            get { return BackingStore?.Get<string?>("etag"); }
            set { BackingStore?.Set("etag", value); }
        }
#nullable restore
#else
        public string Etag {
            get { return BackingStore?.Get<string>("etag"); }
            set { BackingStore?.Set("etag", value); }
        }
#endif
        /// <summary>The fileHashes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FileHash>? FileHashes {
            get { return BackingStore?.Get<List<FileHash>?>("fileHashes"); }
            set { BackingStore?.Set("fileHashes", value); }
        }
#nullable restore
#else
        public List<FileHash> FileHashes {
            get { return BackingStore?.Get<List<FileHash>>("fileHashes"); }
            set { BackingStore?.Set("fileHashes", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url {
            get { return BackingStore?.Get<string?>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#nullable restore
#else
        public string Url {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new blobEvidence and sets the default values.
        /// </summary>
        public BlobEvidence() : base() {
            OdataType = "#microsoft.graph.security.blobEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BlobEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BlobEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"blobContainer", n => { BlobContainer = n.GetObjectValue<BlobContainerEvidence>(BlobContainerEvidence.CreateFromDiscriminatorValue); } },
                {"etag", n => { Etag = n.GetStringValue(); } },
                {"fileHashes", n => { FileHashes = n.GetCollectionOfObjectValues<FileHash>(FileHash.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<BlobContainerEvidence>("blobContainer", BlobContainer);
            writer.WriteStringValue("etag", Etag);
            writer.WriteCollectionOfObjectValues<FileHash>("fileHashes", FileHashes);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("url", Url);
        }
    }
}
