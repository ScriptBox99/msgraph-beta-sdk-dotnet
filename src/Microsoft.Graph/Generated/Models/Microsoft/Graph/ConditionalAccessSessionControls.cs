using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityContainer singleton.</summary>
    public class ConditionalAccessSessionControls : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Session control to enforce application restrictions. Only Exchange Online and Sharepoint Online support this session control.</summary>
        public ApplicationEnforcedRestrictionsSessionControl ApplicationEnforcedRestrictions { get; set; }
        /// <summary>Session control to apply cloud app security.</summary>
        public CloudAppSecuritySessionControl CloudAppSecurity { get; set; }
        /// <summary>Session control for continuous access evaluation settings.</summary>
        public ContinuousAccessEvaluationSessionControl ContinuousAccessEvaluation { get; set; }
        /// <summary>Session control that determines whether it is acceptable for Azure AD to extend existing sessions based on information collected prior to an outage or not.</summary>
        public bool? DisableResilienceDefaults { get; set; }
        /// <summary>Session control to define whether to persist cookies or not. All apps should be selected for this session control to work correctly.</summary>
        public PersistentBrowserSessionControl PersistentBrowser { get; set; }
        /// <summary>Session control to enforce signin frequency.</summary>
        public SignInFrequencySessionControl SignInFrequency { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessSessionControls and sets the default values.
        /// </summary>
        public ConditionalAccessSessionControls() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConditionalAccessSessionControls CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessSessionControls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationEnforcedRestrictions", (o,n) => { (o as ConditionalAccessSessionControls).ApplicationEnforcedRestrictions = n.GetObjectValue<ApplicationEnforcedRestrictionsSessionControl>(ApplicationEnforcedRestrictionsSessionControl.CreateFromDiscriminatorValue); } },
                {"cloudAppSecurity", (o,n) => { (o as ConditionalAccessSessionControls).CloudAppSecurity = n.GetObjectValue<CloudAppSecuritySessionControl>(CloudAppSecuritySessionControl.CreateFromDiscriminatorValue); } },
                {"continuousAccessEvaluation", (o,n) => { (o as ConditionalAccessSessionControls).ContinuousAccessEvaluation = n.GetObjectValue<ContinuousAccessEvaluationSessionControl>(ContinuousAccessEvaluationSessionControl.CreateFromDiscriminatorValue); } },
                {"disableResilienceDefaults", (o,n) => { (o as ConditionalAccessSessionControls).DisableResilienceDefaults = n.GetBoolValue(); } },
                {"persistentBrowser", (o,n) => { (o as ConditionalAccessSessionControls).PersistentBrowser = n.GetObjectValue<PersistentBrowserSessionControl>(PersistentBrowserSessionControl.CreateFromDiscriminatorValue); } },
                {"signInFrequency", (o,n) => { (o as ConditionalAccessSessionControls).SignInFrequency = n.GetObjectValue<SignInFrequencySessionControl>(SignInFrequencySessionControl.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApplicationEnforcedRestrictionsSessionControl>("applicationEnforcedRestrictions", ApplicationEnforcedRestrictions);
            writer.WriteObjectValue<CloudAppSecuritySessionControl>("cloudAppSecurity", CloudAppSecurity);
            writer.WriteObjectValue<ContinuousAccessEvaluationSessionControl>("continuousAccessEvaluation", ContinuousAccessEvaluation);
            writer.WriteBoolValue("disableResilienceDefaults", DisableResilienceDefaults);
            writer.WriteObjectValue<PersistentBrowserSessionControl>("persistentBrowser", PersistentBrowser);
            writer.WriteObjectValue<SignInFrequencySessionControl>("signInFrequency", SignInFrequency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
