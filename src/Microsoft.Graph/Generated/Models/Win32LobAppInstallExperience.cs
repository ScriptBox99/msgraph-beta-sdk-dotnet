using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains installation experience properties for a Win32 App</summary>
    public class Win32LobAppInstallExperience : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device restart behavior. Possible values are: basedOnReturnCode, allow, suppress, force.</summary>
        public Win32LobAppRestartBehavior? DeviceRestartBehavior {
            get { return BackingStore?.Get<Win32LobAppRestartBehavior?>(nameof(DeviceRestartBehavior)); }
            set { BackingStore?.Set(nameof(DeviceRestartBehavior), value); }
        }
        /// <summary>Indicates the type of execution context the app runs in. Possible values are: system, user.</summary>
        public RunAsAccountType? RunAsAccount {
            get { return BackingStore?.Get<RunAsAccountType?>(nameof(RunAsAccount)); }
            set { BackingStore?.Set(nameof(RunAsAccount), value); }
        }
        /// <summary>
        /// Instantiates a new win32LobAppInstallExperience and sets the default values.
        /// </summary>
        public Win32LobAppInstallExperience() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Win32LobAppInstallExperience CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppInstallExperience();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceRestartBehavior", n => { DeviceRestartBehavior = n.GetEnumValue<Win32LobAppRestartBehavior>(); } },
                {"runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Win32LobAppRestartBehavior>("deviceRestartBehavior", DeviceRestartBehavior);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
