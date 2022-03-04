using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Admin : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A container for service communications resources. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ServiceAnnouncement ServiceAnnouncement { get; set; }
        /// <summary>A container for all Windows Update for Business deployment service functionality. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Windows Windows { get; set; }
        /// <summary>
        /// Instantiates a new Admin and sets the default values.
        /// </summary>
        public Admin() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Admin CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Admin();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"serviceAnnouncement", (o,n) => { (o as Admin).ServiceAnnouncement = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ServiceAnnouncement>(MicrosoftGraphSdk.Models.Microsoft.Graph.ServiceAnnouncement.CreateFromDiscriminatorValue); } },
                {"windows", (o,n) => { (o as Admin).Windows = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Windows>(MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Windows.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ServiceAnnouncement>("serviceAnnouncement", ServiceAnnouncement);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Windows>("windows", Windows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
