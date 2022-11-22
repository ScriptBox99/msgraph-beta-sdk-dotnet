// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum CloudPcOnPremisesConnectionHealthCheckErrorType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CloudPcOnPremisesConnectionHealthCheckErrorType
    {
    
        /// <summary>
        /// Dns Check Fqdn Not Found
        /// </summary>
        DnsCheckFqdnNotFound = 100,
	
        /// <summary>
        /// Dns Check Name With Invalid Character
        /// </summary>
        DnsCheckNameWithInvalidCharacter = 101,
	
        /// <summary>
        /// Dns Check Unknown Error
        /// </summary>
        DnsCheckUnknownError = 199,
	
        /// <summary>
        /// Ad Join Check Fqdn Not Found
        /// </summary>
        AdJoinCheckFqdnNotFound = 200,
	
        /// <summary>
        /// Ad Join Check Incorrect Credentials
        /// </summary>
        AdJoinCheckIncorrectCredentials = 201,
	
        /// <summary>
        /// Ad Join Check Organizational Unit Not Found
        /// </summary>
        AdJoinCheckOrganizationalUnitNotFound = 202,
	
        /// <summary>
        /// Ad Join Check Organizational Unit Incorrect Format
        /// </summary>
        AdJoinCheckOrganizationalUnitIncorrectFormat = 203,
	
        /// <summary>
        /// Ad Join Check Computer Object Already Exists
        /// </summary>
        AdJoinCheckComputerObjectAlreadyExists = 204,
	
        /// <summary>
        /// Ad Join Check Access Denied
        /// </summary>
        AdJoinCheckAccessDenied = 205,
	
        /// <summary>
        /// Ad Join Check Credentials Expired
        /// </summary>
        AdJoinCheckCredentialsExpired = 206,
	
        /// <summary>
        /// Ad Join Check Account Locked Or Disabled
        /// </summary>
        AdJoinCheckAccountLockedOrDisabled = 207,
	
        /// <summary>
        /// Ad Join Check Account Quota Exceeded
        /// </summary>
        AdJoinCheckAccountQuotaExceeded = 208,
	
        /// <summary>
        /// Ad Join Check Unknown Error
        /// </summary>
        AdJoinCheckUnknownError = 299,
	
        /// <summary>
        /// Endpoint Connectivity Check Cloud Pc Url Not Allow Listed
        /// </summary>
        EndpointConnectivityCheckCloudPcUrlNotAllowListed = 300,
	
        /// <summary>
        /// Endpoint Connectivity Check WVDUrl Not Allow Listed
        /// </summary>
        EndpointConnectivityCheckWVDUrlNotAllowListed = 301,
	
        /// <summary>
        /// Endpoint Connectivity Check Intune Url Not Allow Listed
        /// </summary>
        EndpointConnectivityCheckIntuneUrlNotAllowListed = 302,
	
        /// <summary>
        /// Endpoint Connectivity Check Azure ADUrl Not Allow Listed
        /// </summary>
        EndpointConnectivityCheckAzureADUrlNotAllowListed = 303,
	
        /// <summary>
        /// Endpoint Connectivity Check Locale Url Not Allow Listed
        /// </summary>
        EndpointConnectivityCheckLocaleUrlNotAllowListed = 304,
	
        /// <summary>
        /// Endpoint Connectivity Check Unknown Error
        /// </summary>
        EndpointConnectivityCheckUnknownError = 399,
	
        /// <summary>
        /// Azure Ad Device Sync Check Device Not Found
        /// </summary>
        AzureAdDeviceSyncCheckDeviceNotFound = 400,
	
        /// <summary>
        /// Azure Ad Device Sync Check Long Sync Circle
        /// </summary>
        AzureAdDeviceSyncCheckLongSyncCircle = 401,
	
        /// <summary>
        /// Azure Ad Device Sync Check Connect Disabled
        /// </summary>
        AzureAdDeviceSyncCheckConnectDisabled = 402,
	
        /// <summary>
        /// Azure Ad Device Sync Check Duration Exceeded
        /// </summary>
        AzureAdDeviceSyncCheckDurationExceeded = 403,
	
        /// <summary>
        /// Azure Ad Device Sync Check Scp Not Configured
        /// </summary>
        AzureAdDeviceSyncCheckScpNotConfigured = 404,
	
        /// <summary>
        /// Azure Ad Device Sync Check Transient Service Error
        /// </summary>
        AzureAdDeviceSyncCheckTransientServiceError = 498,
	
        /// <summary>
        /// Azure Ad Device Sync Check Unknown Error
        /// </summary>
        AzureAdDeviceSyncCheckUnknownError = 499,
	
        /// <summary>
        /// Resource Availability Check No Subnet IP
        /// </summary>
        ResourceAvailabilityCheckNoSubnetIP = 500,
	
        /// <summary>
        /// Resource Availability Check Subscription Disabled
        /// </summary>
        ResourceAvailabilityCheckSubscriptionDisabled = 501,
	
        /// <summary>
        /// Resource Availability Check Azure Policy Violation
        /// </summary>
        ResourceAvailabilityCheckAzurePolicyViolation = 502,
	
        /// <summary>
        /// Resource Availability Check Subscription Not Found
        /// </summary>
        ResourceAvailabilityCheckSubscriptionNotFound = 503,
	
        /// <summary>
        /// Resource Availability Check Subscription Transferred
        /// </summary>
        ResourceAvailabilityCheckSubscriptionTransferred = 504,
	
        /// <summary>
        /// Resource Availability Check General Subscription Error
        /// </summary>
        ResourceAvailabilityCheckGeneralSubscriptionError = 505,
	
        /// <summary>
        /// Resource Availability Check Unsupported VNet Region
        /// </summary>
        ResourceAvailabilityCheckUnsupportedVNetRegion = 506,
	
        /// <summary>
        /// Resource Availability Check Resource Group Invalid
        /// </summary>
        ResourceAvailabilityCheckResourceGroupInvalid = 507,
	
        /// <summary>
        /// Resource Availability Check VNet Invalid
        /// </summary>
        ResourceAvailabilityCheckVNetInvalid = 508,
	
        /// <summary>
        /// Resource Availability Check Subnet Invalid
        /// </summary>
        ResourceAvailabilityCheckSubnetInvalid = 509,
	
        /// <summary>
        /// Resource Availability Check Resource Group Being Deleted
        /// </summary>
        ResourceAvailabilityCheckResourceGroupBeingDeleted = 510,
	
        /// <summary>
        /// Resource Availability Check VNet Being Moved
        /// </summary>
        ResourceAvailabilityCheckVNetBeingMoved = 511,
	
        /// <summary>
        /// Resource Availability Check Subnet Delegation Failed
        /// </summary>
        ResourceAvailabilityCheckSubnetDelegationFailed = 512,
	
        /// <summary>
        /// Resource Availability Check Subnet With External Resources
        /// </summary>
        ResourceAvailabilityCheckSubnetWithExternalResources = 513,
	
        /// <summary>
        /// Resource Availability Check Resource Group Locked For Readonly
        /// </summary>
        ResourceAvailabilityCheckResourceGroupLockedForReadonly = 514,
	
        /// <summary>
        /// Resource Availability Check Resource Group Locked For Delete
        /// </summary>
        ResourceAvailabilityCheckResourceGroupLockedForDelete = 515,
	
        /// <summary>
        /// Resource Availability Check No Intune Reader Role Error
        /// </summary>
        ResourceAvailabilityCheckNoIntuneReaderRoleError = 516,
	
        /// <summary>
        /// Resource Availability Check Intune Default Windows Restriction Violation
        /// </summary>
        ResourceAvailabilityCheckIntuneDefaultWindowsRestrictionViolation = 517,
	
        /// <summary>
        /// Resource Availability Check Intune Custom Windows Restriction Violation
        /// </summary>
        ResourceAvailabilityCheckIntuneCustomWindowsRestrictionViolation = 518,
	
        /// <summary>
        /// Resource Availability Check Transient Service Error
        /// </summary>
        ResourceAvailabilityCheckTransientServiceError = 598,
	
        /// <summary>
        /// Resource Availability Check Unknown Error
        /// </summary>
        ResourceAvailabilityCheckUnknownError = 599,
	
        /// <summary>
        /// Permission Check No Subscription Reader Role
        /// </summary>
        PermissionCheckNoSubscriptionReaderRole = 600,
	
        /// <summary>
        /// Permission Check No Resource Group Owner Role
        /// </summary>
        PermissionCheckNoResourceGroupOwnerRole = 601,
	
        /// <summary>
        /// Permission Check No VNet Contributor Role
        /// </summary>
        PermissionCheckNoVNetContributorRole = 602,
	
        /// <summary>
        /// Permission Check No Resource Group Network Contributor Role
        /// </summary>
        PermissionCheckNoResourceGroupNetworkContributorRole = 603,
	
        /// <summary>
        /// Permission Check Transient Service Error
        /// </summary>
        PermissionCheckTransientServiceError = 698,
	
        /// <summary>
        /// Permission Check Unknown Error
        /// </summary>
        PermissionCheckUnknownError = 699,
	
        /// <summary>
        /// Udp Connectivity Check Stun Url Not Allow Listed
        /// </summary>
        UdpConnectivityCheckStunUrlNotAllowListed = 800,
	
        /// <summary>
        /// Udp Connectivity Check Unknown Error
        /// </summary>
        UdpConnectivityCheckUnknownError = 899,
	
        /// <summary>
        /// Internal Server Error Deployment Canceled
        /// </summary>
        InternalServerErrorDeploymentCanceled = 900,
	
        /// <summary>
        /// Internal Server Error Allocate Resource Failed
        /// </summary>
        InternalServerErrorAllocateResourceFailed = 901,
	
        /// <summary>
        /// Internal Server Error VMDeployment Timeout
        /// </summary>
        InternalServerErrorVMDeploymentTimeout = 902,
	
        /// <summary>
        /// Internal Server Error Unable To Run Dsc Script
        /// </summary>
        InternalServerErrorUnableToRunDscScript = 903,
	
        /// <summary>
        /// Internal Server Unknown Error
        /// </summary>
        InternalServerUnknownError = 999,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 1000,
	
    }
}
