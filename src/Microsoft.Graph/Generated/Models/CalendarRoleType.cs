namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public enum CalendarRoleType {
        None,
        FreeBusyRead,
        LimitedRead,
        Read,
        Write,
        DelegateWithoutPrivateEventAccess,
        DelegateWithPrivateEventAccess,
        Custom,
    }
}
