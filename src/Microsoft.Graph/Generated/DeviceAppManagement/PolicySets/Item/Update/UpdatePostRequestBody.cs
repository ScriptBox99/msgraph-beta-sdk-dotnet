// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceAppManagement.PolicySets.Item.Update {
    public class UpdatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The addedPolicySetItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PolicySetItem>? AddedPolicySetItems {
            get { return BackingStore?.Get<List<PolicySetItem>?>("addedPolicySetItems"); }
            set { BackingStore?.Set("addedPolicySetItems", value); }
        }
#nullable restore
#else
        public List<PolicySetItem> AddedPolicySetItems {
            get { return BackingStore?.Get<List<PolicySetItem>>("addedPolicySetItems"); }
            set { BackingStore?.Set("addedPolicySetItems", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>The assignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PolicySetAssignment>? Assignments {
            get { return BackingStore?.Get<List<PolicySetAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<PolicySetAssignment> Assignments {
            get { return BackingStore?.Get<List<PolicySetAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deletedPolicySetItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DeletedPolicySetItems {
            get { return BackingStore?.Get<List<string>?>("deletedPolicySetItems"); }
            set { BackingStore?.Set("deletedPolicySetItems", value); }
        }
#nullable restore
#else
        public List<string> DeletedPolicySetItems {
            get { return BackingStore?.Get<List<string>>("deletedPolicySetItems"); }
            set { BackingStore?.Set("deletedPolicySetItems", value); }
        }
#endif
        /// <summary>The updatedPolicySetItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PolicySetItem>? UpdatedPolicySetItems {
            get { return BackingStore?.Get<List<PolicySetItem>?>("updatedPolicySetItems"); }
            set { BackingStore?.Set("updatedPolicySetItems", value); }
        }
#nullable restore
#else
        public List<PolicySetItem> UpdatedPolicySetItems {
            get { return BackingStore?.Get<List<PolicySetItem>>("updatedPolicySetItems"); }
            set { BackingStore?.Set("updatedPolicySetItems", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new updatePostRequestBody and sets the default values.
        /// </summary>
        public UpdatePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addedPolicySetItems", n => { AddedPolicySetItems = n.GetCollectionOfObjectValues<PolicySetItem>(PolicySetItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<PolicySetAssignment>(PolicySetAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deletedPolicySetItems", n => { DeletedPolicySetItems = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"updatedPolicySetItems", n => { UpdatedPolicySetItems = n.GetCollectionOfObjectValues<PolicySetItem>(PolicySetItem.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PolicySetItem>("addedPolicySetItems", AddedPolicySetItems);
            writer.WriteCollectionOfObjectValues<PolicySetAssignment>("assignments", Assignments);
            writer.WriteCollectionOfPrimitiveValues<string>("deletedPolicySetItems", DeletedPolicySetItems);
            writer.WriteCollectionOfObjectValues<PolicySetItem>("updatedPolicySetItems", UpdatedPolicySetItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
