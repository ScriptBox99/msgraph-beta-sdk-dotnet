using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum HuntingRuleErrorCode {
        [EnumMember(Value = "queryExecutionFailed")]
        QueryExecutionFailed,
        [EnumMember(Value = "queryExecutionThrottling")]
        QueryExecutionThrottling,
        [EnumMember(Value = "queryExceededResultSize")]
        QueryExceededResultSize,
        [EnumMember(Value = "queryLimitsExceeded")]
        QueryLimitsExceeded,
        [EnumMember(Value = "queryTimeout")]
        QueryTimeout,
        [EnumMember(Value = "alertCreationFailed")]
        AlertCreationFailed,
        [EnumMember(Value = "alertReportNotFound")]
        AlertReportNotFound,
        [EnumMember(Value = "partialRowsFailed")]
        PartialRowsFailed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
