using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of chat entities.</summary>
    public class TeamsTab : Entity, IParsable {
        /// <summary>Container for custom settings applied to a tab. The tab is considered configured only once this property is set.</summary>
        public TeamsTabConfiguration Configuration { get; set; }
        /// <summary>Name of the tab.</summary>
        public string DisplayName { get; set; }
        public string MessageId { get; set; }
        /// <summary>Index of the order used for sorting tabs.</summary>
        public string SortOrderIndex { get; set; }
        /// <summary>The application that is linked to the tab. This cannot be changed after tab creation.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.TeamsApp TeamsApp { get; set; }
        public string TeamsAppId { get; set; }
        /// <summary>Deep link URL of the tab instance. Read only.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsTab CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsTab();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configuration", (o,n) => { (o as TeamsTab).Configuration = n.GetObjectValue<TeamsTabConfiguration>(TeamsTabConfiguration.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as TeamsTab).DisplayName = n.GetStringValue(); } },
                {"messageId", (o,n) => { (o as TeamsTab).MessageId = n.GetStringValue(); } },
                {"sortOrderIndex", (o,n) => { (o as TeamsTab).SortOrderIndex = n.GetStringValue(); } },
                {"teamsApp", (o,n) => { (o as TeamsTab).TeamsApp = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.TeamsApp>(MicrosoftGraphSdk.Models.Microsoft.Graph.TeamsApp.CreateFromDiscriminatorValue); } },
                {"teamsAppId", (o,n) => { (o as TeamsTab).TeamsAppId = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as TeamsTab).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamsTabConfiguration>("configuration", Configuration);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("messageId", MessageId);
            writer.WriteStringValue("sortOrderIndex", SortOrderIndex);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
