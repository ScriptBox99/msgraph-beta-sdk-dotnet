// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Exchange Active Sync services.</summary>
    [Flags]
    public enum EasServices {
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Enables synchronization of calendars.</summary>
        [EnumMember(Value = "calendars")]
        Calendars = 2,
        /// <summary>Enables synchronization of contacts.</summary>
        [EnumMember(Value = "contacts")]
        Contacts = 4,
        /// <summary>Enables synchronization of email.</summary>
        [EnumMember(Value = "email")]
        Email = 8,
        /// <summary>Enables synchronization of notes.</summary>
        [EnumMember(Value = "notes")]
        Notes = 16,
        /// <summary>Enables synchronization of reminders.</summary>
        [EnumMember(Value = "reminders")]
        Reminders = 32,
    }
}
