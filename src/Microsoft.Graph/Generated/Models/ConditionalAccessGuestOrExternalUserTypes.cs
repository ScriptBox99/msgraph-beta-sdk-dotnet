namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum ConditionalAccessGuestOrExternalUserTypes {
        None,
        InternalGuest,
        B2bCollaborationGuest,
        B2bCollaborationMember,
        B2bDirectConnectUser,
        OtherExternalUser,
        ServiceProvider,
        UnknownFutureValue,
    }
}
