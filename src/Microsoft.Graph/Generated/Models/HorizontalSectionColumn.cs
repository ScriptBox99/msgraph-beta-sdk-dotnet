// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class HorizontalSectionColumn : Entity, IParsable {
        /// <summary>The collection of WebParts in this column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WebPart>? Webparts {
            get { return BackingStore?.Get<List<WebPart>?>("webparts"); }
            set { BackingStore?.Set("webparts", value); }
        }
#nullable restore
#else
        public List<WebPart> Webparts {
            get { return BackingStore?.Get<List<WebPart>>("webparts"); }
            set { BackingStore?.Set("webparts", value); }
        }
#endif
        /// <summary>Width of the column. A horizontal section is divided into 12 grids. A column should have a value of 1-12 to represent its range spans. For example, there can be two columns both have a width of 6 in a section.</summary>
        public int? Width {
            get { return BackingStore?.Get<int?>("width"); }
            set { BackingStore?.Set("width", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HorizontalSectionColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HorizontalSectionColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"webparts", n => { Webparts = n.GetCollectionOfObjectValues<WebPart>(WebPart.CreateFromDiscriminatorValue)?.ToList(); } },
                {"width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WebPart>("webparts", Webparts);
            writer.WriteIntValue("width", Width);
        }
    }
}
