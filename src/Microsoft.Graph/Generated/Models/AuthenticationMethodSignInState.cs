namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AuthenticationMethodSignInState {
        NotSupported,
        NotAllowedByPolicy,
        NotEnabled,
        PhoneNumberNotUnique,
        Ready,
        NotConfigured,
        UnknownFutureValue,
    }
}
