using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum UserDefaultAuthenticationMethodType {
        [EnumMember(Value = "push")]
        Push,
        [EnumMember(Value = "oath")]
        Oath,
        [EnumMember(Value = "voiceMobile")]
        VoiceMobile,
        [EnumMember(Value = "voiceAlternateMobile")]
        VoiceAlternateMobile,
        [EnumMember(Value = "voiceOffice")]
        VoiceOffice,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
