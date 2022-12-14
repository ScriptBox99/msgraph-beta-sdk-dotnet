namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum MobileAppDependencyType {
        /// <summary>Indicates that the child app should be detected before installing the parent app.</summary>
        Detect,
        /// <summary>Indicates that the child app should be installed before installing the parent app.</summary>
        AutoInstall,
    }
}
