using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ItemPatent : ItemFacet, IParsable {
        /// <summary>Descpription of the patent or filing.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Title of the patent or filing.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Indicates the patent is pending.</summary>
        public bool? IsPending {
            get { return BackingStore?.Get<bool?>("isPending"); }
            set { BackingStore?.Set("isPending", value); }
        }
        /// <summary>The date that the patent was granted.</summary>
        public Date? IssuedDate {
            get { return BackingStore?.Get<Date?>("issuedDate"); }
            set { BackingStore?.Set("issuedDate", value); }
        }
        /// <summary>Authority which granted the patent.</summary>
        public string IssuingAuthority {
            get { return BackingStore?.Get<string>("issuingAuthority"); }
            set { BackingStore?.Set("issuingAuthority", value); }
        }
        /// <summary>The patent number.</summary>
        public string Number {
            get { return BackingStore?.Get<string>("number"); }
            set { BackingStore?.Set("number", value); }
        }
        /// <summary>URL referencing the patent or filing.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ItemPatent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemPatent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isPending", n => { IsPending = n.GetBoolValue(); } },
                {"issuedDate", n => { IssuedDate = n.GetDateValue(); } },
                {"issuingAuthority", n => { IssuingAuthority = n.GetStringValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isPending", IsPending);
            writer.WriteDateValue("issuedDate", IssuedDate);
            writer.WriteStringValue("issuingAuthority", IssuingAuthority);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
