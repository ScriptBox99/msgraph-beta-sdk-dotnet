// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// BitLocker Fixed Drive Policies.
    /// </summary>
    public class BitLockerFixedDrivePolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Select the encryption method for fixed drives. Possible values are: aesCbc128, aesCbc256, xtsAes128, xtsAes256.</summary>
        public BitLockerEncryptionMethod? EncryptionMethod {
            get { return BackingStore?.Get<BitLockerEncryptionMethod?>("encryptionMethod"); }
            set { BackingStore?.Set("encryptionMethod", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>This policy setting allows you to control how BitLocker-protected fixed data drives are recovered in the absence of the required credentials. This policy setting is applied when you turn on BitLocker.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BitLockerRecoveryOptions? RecoveryOptions {
            get { return BackingStore?.Get<BitLockerRecoveryOptions?>("recoveryOptions"); }
            set { BackingStore?.Set("recoveryOptions", value); }
        }
#nullable restore
#else
        public BitLockerRecoveryOptions RecoveryOptions {
            get { return BackingStore?.Get<BitLockerRecoveryOptions>("recoveryOptions"); }
            set { BackingStore?.Set("recoveryOptions", value); }
        }
#endif
        /// <summary>This policy setting determines whether BitLocker protection is required for fixed data drives to be writable on a computer.</summary>
        public bool? RequireEncryptionForWriteAccess {
            get { return BackingStore?.Get<bool?>("requireEncryptionForWriteAccess"); }
            set { BackingStore?.Set("requireEncryptionForWriteAccess", value); }
        }
        /// <summary>
        /// Instantiates a new bitLockerFixedDrivePolicy and sets the default values.
        /// </summary>
        public BitLockerFixedDrivePolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BitLockerFixedDrivePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BitLockerFixedDrivePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"encryptionMethod", n => { EncryptionMethod = n.GetEnumValue<BitLockerEncryptionMethod>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recoveryOptions", n => { RecoveryOptions = n.GetObjectValue<BitLockerRecoveryOptions>(BitLockerRecoveryOptions.CreateFromDiscriminatorValue); } },
                {"requireEncryptionForWriteAccess", n => { RequireEncryptionForWriteAccess = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<BitLockerEncryptionMethod>("encryptionMethod", EncryptionMethod);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<BitLockerRecoveryOptions>("recoveryOptions", RecoveryOptions);
            writer.WriteBoolValue("requireEncryptionForWriteAccess", RequireEncryptionForWriteAccess);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
