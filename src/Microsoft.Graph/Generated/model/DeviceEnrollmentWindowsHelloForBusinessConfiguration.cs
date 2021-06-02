// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Device Enrollment Windows Hello For Business Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceEnrollmentWindowsHelloForBusinessConfiguration>))]
    public partial class DeviceEnrollmentWindowsHelloForBusinessConfiguration : DeviceEnrollmentConfiguration
    {
    
        ///<summary>
        /// The DeviceEnrollmentWindowsHelloForBusinessConfiguration constructor
        ///</summary>
        public DeviceEnrollmentWindowsHelloForBusinessConfiguration()
        {
            this.ODataType = "microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration";
        }

        /// <summary>
        /// Gets or sets enhanced biometrics state.
        /// Controls the ability to use the anti-spoofing features for facial recognition on devices which support it. If set to disabled, anti-spoofing features are not allowed. If set to Not Configured, the user can choose whether they want to use anti-spoofing. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("enhancedBiometricsState")]
        public Enablement? EnhancedBiometricsState { get; set; }
    
        /// <summary>
        /// Gets or sets pin expiration in days.
        /// Controls the period of time (in days) that a PIN can be used before the system requires the user to change it. This must be set between 0 and 730, inclusive. If set to 0, the user's PIN will never expire
        /// </summary>
        [JsonPropertyName("pinExpirationInDays")]
        public Int32? PinExpirationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets pin lowercase characters usage.
        /// Controls the ability to use lowercase letters in the Windows Hello for Business PIN.  Allowed permits the use of lowercase letter(s), whereas Required ensures they are present. If set to Not Allowed, lowercase letters will not be permitted. Possible values are: allowed, required, disallowed.
        /// </summary>
        [JsonPropertyName("pinLowercaseCharactersUsage")]
        public WindowsHelloForBusinessPinUsage? PinLowercaseCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pin maximum length.
        /// Controls the maximum number of characters allowed for the Windows Hello for Business PIN. This value must be between 4 and 127, inclusive. This value must be greater than or equal to the value set for the minimum PIN.
        /// </summary>
        [JsonPropertyName("pinMaximumLength")]
        public Int32? PinMaximumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin minimum length.
        /// Controls the minimum number of characters required for the Windows Hello for Business PIN.  This value must be between 4 and 127, inclusive, and less than or equal to the value set for the maximum PIN.
        /// </summary>
        [JsonPropertyName("pinMinimumLength")]
        public Int32? PinMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin previous block count.
        /// Controls the ability to prevent users from using past PINs. This must be set between 0 and 50, inclusive, and the current PIN of the user is included in that count. If set to 0, previous PINs are not stored. PIN history is not preserved through a PIN reset.
        /// </summary>
        [JsonPropertyName("pinPreviousBlockCount")]
        public Int32? PinPreviousBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets pin special characters usage.
        /// Controls the ability to use special characters in the Windows Hello for Business PIN.  Allowed permits the use of special character(s), whereas Required ensures they are present. If set to Not Allowed, special character(s) will not be permitted. Possible values are: allowed, required, disallowed.
        /// </summary>
        [JsonPropertyName("pinSpecialCharactersUsage")]
        public WindowsHelloForBusinessPinUsage? PinSpecialCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pin uppercase characters usage.
        /// Controls the ability to use uppercase letters in the Windows Hello for Business PIN.  Allowed permits the use of uppercase letter(s), whereas Required ensures they are present. If set to Not Allowed, uppercase letters will not be permitted. Possible values are: allowed, required, disallowed.
        /// </summary>
        [JsonPropertyName("pinUppercaseCharactersUsage")]
        public WindowsHelloForBusinessPinUsage? PinUppercaseCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets remote passport enabled.
        /// Controls the use of Remote Windows Hello for Business. Remote Windows Hello for Business provides the ability for a portable, registered device to be usable as a companion for desktop authentication. The desktop must be Azure AD joined and the companion device must have a Windows Hello for Business PIN.
        /// </summary>
        [JsonPropertyName("remotePassportEnabled")]
        public bool? RemotePassportEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets security device required.
        /// Controls whether to require a Trusted Platform Module (TPM) for provisioning Windows Hello for Business. A TPM provides an additional security benefit in that data stored on it cannot be used on other devices. If set to False, all devices can provision Windows Hello for Business even if there is not a usable TPM.
        /// </summary>
        [JsonPropertyName("securityDeviceRequired")]
        public bool? SecurityDeviceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets security key for sign in.
        /// Security key for Sign In provides the capacity for remotely turning ON/OFF Windows Hello Sercurity Keyl Not configured will honor configurations done on the clinet. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("securityKeyForSignIn")]
        public Enablement? SecurityKeyForSignIn { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Controls whether to allow the device to be configured for Windows Hello for Business. If set to disabled, the user cannot provision Windows Hello for Business except on Azure Active Directory joined mobile phones if otherwise required. If set to Not Configured, Intune will not override client defaults. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("state")]
        public Enablement? State { get; set; }
    
        /// <summary>
        /// Gets or sets unlock with biometrics enabled.
        /// Controls the use of biometric gestures, such as face and fingerprint, as an alternative to the Windows Hello for Business PIN.  If set to False, biometric gestures are not allowed. Users must still configure a PIN as a backup in case of failures.
        /// </summary>
        [JsonPropertyName("unlockWithBiometricsEnabled")]
        public bool? UnlockWithBiometricsEnabled { get; set; }
    
    }
}

