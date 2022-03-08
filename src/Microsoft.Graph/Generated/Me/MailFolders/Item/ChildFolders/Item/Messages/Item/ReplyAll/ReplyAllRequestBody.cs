using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.MailFolders.Item.ChildFolders.Item.Messages.Item.ReplyAll {
    /// <summary>Provides operations to call the replyAll method.</summary>
    public class ReplyAllRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Comment { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Message Message { get; set; }
        /// <summary>
        /// Instantiates a new replyAllRequestBody and sets the default values.
        /// </summary>
        public ReplyAllRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ReplyAllRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReplyAllRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as ReplyAllRequestBody).Comment = n.GetStringValue(); } },
                {"message", (o,n) => { (o as ReplyAllRequestBody).Message = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Message>(MicrosoftGraphSdk.Models.Microsoft.Graph.Message.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Message>("message", Message);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
