// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Windows 10 force update schedule for Kiosk devices.
    /// </summary>
    public class WindowsKioskForceUpdateSchedule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Day of month. Valid values 1 to 31</summary>
        public int? DayofMonth {
            get { return BackingStore?.Get<int?>("dayofMonth"); }
            set { BackingStore?.Set("dayofMonth", value); }
        }
        /// <summary>The dayofWeek property</summary>
        public DayOfWeekObject? DayofWeek {
            get { return BackingStore?.Get<DayOfWeekObject?>("dayofWeek"); }
            set { BackingStore?.Set("dayofWeek", value); }
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
        /// <summary>Possible values for App update on Windows10 recurrence.</summary>
        public Windows10AppsUpdateRecurrence? Recurrence {
            get { return BackingStore?.Get<Windows10AppsUpdateRecurrence?>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
        /// <summary>If true, runs the task immediately if StartDateTime is in the past, else, runs at the next recurrence.</summary>
        public bool? RunImmediatelyIfAfterStartDateTime {
            get { return BackingStore?.Get<bool?>("runImmediatelyIfAfterStartDateTime"); }
            set { BackingStore?.Set("runImmediatelyIfAfterStartDateTime", value); }
        }
        /// <summary>The start time for the force restart.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new windowsKioskForceUpdateSchedule and sets the default values.
        /// </summary>
        public WindowsKioskForceUpdateSchedule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WindowsKioskForceUpdateSchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskForceUpdateSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dayofMonth", n => { DayofMonth = n.GetIntValue(); } },
                {"dayofWeek", n => { DayofWeek = n.GetEnumValue<DayOfWeekObject>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recurrence", n => { Recurrence = n.GetEnumValue<Windows10AppsUpdateRecurrence>(); } },
                {"runImmediatelyIfAfterStartDateTime", n => { RunImmediatelyIfAfterStartDateTime = n.GetBoolValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("dayofMonth", DayofMonth);
            writer.WriteEnumValue<DayOfWeekObject>("dayofWeek", DayofWeek);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Windows10AppsUpdateRecurrence>("recurrence", Recurrence);
            writer.WriteBoolValue("runImmediatelyIfAfterStartDateTime", RunImmediatelyIfAfterStartDateTime);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
