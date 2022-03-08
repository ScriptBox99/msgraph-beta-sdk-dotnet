namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the restart method.</summary>
    public enum SynchronizationJobRestartScope {
        None,
        ConnectorDataStore,
        Escrows,
        Watermark,
        QuarantineState,
        Full,
        ForceDeletes,
    }
}
