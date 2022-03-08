using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getAttackSimulationSimulationUserCoverage method.</summary>
    public class AttackSimulationSimulationUserCoverage : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>User in an attack simulation and training campaign.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser AttackSimulationUser { get; set; }
        /// <summary>Number of link clicks in the received payloads by the user in attack simulation and training campaigns.</summary>
        public int? ClickCount { get; set; }
        /// <summary>Number of compromising actions by the user in attack simulation and training campaigns.</summary>
        public int? CompromisedCount { get; set; }
        /// <summary>Date and time of latest attack simulation and training campaign that the user was included in.</summary>
        public DateTimeOffset? LatestSimulationDateTime { get; set; }
        /// <summary>Number of attack simulation and training campaigns that the user was included in.</summary>
        public int? SimulationCount { get; set; }
        /// <summary>
        /// Instantiates a new attackSimulationSimulationUserCoverage and sets the default values.
        /// </summary>
        public AttackSimulationSimulationUserCoverage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AttackSimulationSimulationUserCoverage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationSimulationUserCoverage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attackSimulationUser", (o,n) => { (o as AttackSimulationSimulationUserCoverage).AttackSimulationUser = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser>(MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"clickCount", (o,n) => { (o as AttackSimulationSimulationUserCoverage).ClickCount = n.GetIntValue(); } },
                {"compromisedCount", (o,n) => { (o as AttackSimulationSimulationUserCoverage).CompromisedCount = n.GetIntValue(); } },
                {"latestSimulationDateTime", (o,n) => { (o as AttackSimulationSimulationUserCoverage).LatestSimulationDateTime = n.GetDateTimeOffsetValue(); } },
                {"simulationCount", (o,n) => { (o as AttackSimulationSimulationUserCoverage).SimulationCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteIntValue("clickCount", ClickCount);
            writer.WriteIntValue("compromisedCount", CompromisedCount);
            writer.WriteDateTimeOffsetValue("latestSimulationDateTime", LatestSimulationDateTime);
            writer.WriteIntValue("simulationCount", SimulationCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
