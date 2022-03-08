using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsRemoteConnection.SummarizeDeviceRemoteConnectionWithSummarizeBy {
    /// <summary>Provides operations to call the summarizeDeviceRemoteConnection method.</summary>
    public class SummarizeDeviceRemoteConnectionWithSummarizeByResponse : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.UserExperienceAnalyticsRemoteConnection> Value { get; set; }
        /// <summary>
        /// Instantiates a new summarizeDeviceRemoteConnectionWithSummarizeByResponse and sets the default values.
        /// </summary>
        public SummarizeDeviceRemoteConnectionWithSummarizeByResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SummarizeDeviceRemoteConnectionWithSummarizeByResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SummarizeDeviceRemoteConnectionWithSummarizeByResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as SummarizeDeviceRemoteConnectionWithSummarizeByResponse).Value = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.UserExperienceAnalyticsRemoteConnection>(MicrosoftGraphSdk.Models.Microsoft.Graph.UserExperienceAnalyticsRemoteConnection.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.UserExperienceAnalyticsRemoteConnection>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
