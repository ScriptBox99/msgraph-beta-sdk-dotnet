namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum AndroidForWorkRequiredPasswordType {
        /// <summary>Device default value, no intent.</summary>
        DeviceDefault,
        /// <summary>Low security biometrics based password required.</summary>
        LowSecurityBiometric,
        /// <summary>Required.</summary>
        Required,
        /// <summary>At least numeric password required.</summary>
        AtLeastNumeric,
        /// <summary>Numeric complex password required.</summary>
        NumericComplex,
        /// <summary>At least alphabetic password required.</summary>
        AtLeastAlphabetic,
        /// <summary>At least alphanumeric password required.</summary>
        AtLeastAlphanumeric,
        /// <summary>At least alphanumeric with symbols password required.</summary>
        AlphanumericWithSymbols,
    }
}
