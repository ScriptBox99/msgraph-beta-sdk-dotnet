// <auto-generated/>
using Microsoft.Graph.Beta.Financials.Companies.Item.Accounts;
using Microsoft.Graph.Beta.Financials.Companies.Item.AgedAccountsPayable;
using Microsoft.Graph.Beta.Financials.Companies.Item.AgedAccountsReceivable;
using Microsoft.Graph.Beta.Financials.Companies.Item.CompanyInformation;
using Microsoft.Graph.Beta.Financials.Companies.Item.CountriesRegions;
using Microsoft.Graph.Beta.Financials.Companies.Item.Currencies;
using Microsoft.Graph.Beta.Financials.Companies.Item.CustomerPaymentJournals;
using Microsoft.Graph.Beta.Financials.Companies.Item.CustomerPayments;
using Microsoft.Graph.Beta.Financials.Companies.Item.Customers;
using Microsoft.Graph.Beta.Financials.Companies.Item.DimensionValues;
using Microsoft.Graph.Beta.Financials.Companies.Item.Dimensions;
using Microsoft.Graph.Beta.Financials.Companies.Item.Employees;
using Microsoft.Graph.Beta.Financials.Companies.Item.GeneralLedgerEntries;
using Microsoft.Graph.Beta.Financials.Companies.Item.ItemCategories;
using Microsoft.Graph.Beta.Financials.Companies.Item.Items;
using Microsoft.Graph.Beta.Financials.Companies.Item.JournalLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.Journals;
using Microsoft.Graph.Beta.Financials.Companies.Item.PaymentMethods;
using Microsoft.Graph.Beta.Financials.Companies.Item.PaymentTerms;
using Microsoft.Graph.Beta.Financials.Companies.Item.Picture;
using Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoiceLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.PurchaseInvoices;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemos;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoiceLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesInvoices;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesOrderLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesOrders;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesQuoteLines;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesQuotes;
using Microsoft.Graph.Beta.Financials.Companies.Item.ShipmentMethods;
using Microsoft.Graph.Beta.Financials.Companies.Item.TaxAreas;
using Microsoft.Graph.Beta.Financials.Companies.Item.TaxGroups;
using Microsoft.Graph.Beta.Financials.Companies.Item.UnitsOfMeasure;
using Microsoft.Graph.Beta.Financials.Companies.Item.Vendors;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Financials.Companies.Item {
    /// <summary>
    /// Provides operations to manage the companies property of the microsoft.graph.financials entity.
    /// </summary>
    public class CompanyItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the accounts property of the microsoft.graph.company entity.</summary>
        public AccountsRequestBuilder Accounts { get =>
            new AccountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the agedAccountsPayable property of the microsoft.graph.company entity.</summary>
        public AgedAccountsPayableRequestBuilder AgedAccountsPayable { get =>
            new AgedAccountsPayableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the agedAccountsReceivable property of the microsoft.graph.company entity.</summary>
        public AgedAccountsReceivableRequestBuilder AgedAccountsReceivable { get =>
            new AgedAccountsReceivableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the companyInformation property of the microsoft.graph.company entity.</summary>
        public CompanyInformationRequestBuilder CompanyInformation { get =>
            new CompanyInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the countriesRegions property of the microsoft.graph.company entity.</summary>
        public CountriesRegionsRequestBuilder CountriesRegions { get =>
            new CountriesRegionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the currencies property of the microsoft.graph.company entity.</summary>
        public CurrenciesRequestBuilder Currencies { get =>
            new CurrenciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customerPaymentJournals property of the microsoft.graph.company entity.</summary>
        public CustomerPaymentJournalsRequestBuilder CustomerPaymentJournals { get =>
            new CustomerPaymentJournalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customerPayments property of the microsoft.graph.company entity.</summary>
        public CustomerPaymentsRequestBuilder CustomerPayments { get =>
            new CustomerPaymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customers property of the microsoft.graph.company entity.</summary>
        public CustomersRequestBuilder Customers { get =>
            new CustomersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dimensions property of the microsoft.graph.company entity.</summary>
        public DimensionsRequestBuilder Dimensions { get =>
            new DimensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dimensionValues property of the microsoft.graph.company entity.</summary>
        public DimensionValuesRequestBuilder DimensionValues { get =>
            new DimensionValuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the employees property of the microsoft.graph.company entity.</summary>
        public EmployeesRequestBuilder Employees { get =>
            new EmployeesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the generalLedgerEntries property of the microsoft.graph.company entity.</summary>
        public GeneralLedgerEntriesRequestBuilder GeneralLedgerEntries { get =>
            new GeneralLedgerEntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the itemCategories property of the microsoft.graph.company entity.</summary>
        public ItemCategoriesRequestBuilder ItemCategories { get =>
            new ItemCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the items property of the microsoft.graph.company entity.</summary>
        public ItemsRequestBuilder Items { get =>
            new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the journalLines property of the microsoft.graph.company entity.</summary>
        public JournalLinesRequestBuilder JournalLines { get =>
            new JournalLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the journals property of the microsoft.graph.company entity.</summary>
        public JournalsRequestBuilder Journals { get =>
            new JournalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the paymentMethods property of the microsoft.graph.company entity.</summary>
        public PaymentMethodsRequestBuilder PaymentMethods { get =>
            new PaymentMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the paymentTerms property of the microsoft.graph.company entity.</summary>
        public PaymentTermsRequestBuilder PaymentTerms { get =>
            new PaymentTermsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the picture property of the microsoft.graph.company entity.</summary>
        public PictureRequestBuilder Picture { get =>
            new PictureRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the purchaseInvoiceLines property of the microsoft.graph.company entity.</summary>
        public PurchaseInvoiceLinesRequestBuilder PurchaseInvoiceLines { get =>
            new PurchaseInvoiceLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the purchaseInvoices property of the microsoft.graph.company entity.</summary>
        public PurchaseInvoicesRequestBuilder PurchaseInvoices { get =>
            new PurchaseInvoicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the salesCreditMemoLines property of the microsoft.graph.company entity.</summary>
        public SalesCreditMemoLinesRequestBuilder SalesCreditMemoLines { get =>
            new SalesCreditMemoLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the salesCreditMemos property of the microsoft.graph.company entity.</summary>
        public SalesCreditMemosRequestBuilder SalesCreditMemos { get =>
            new SalesCreditMemosRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the salesInvoiceLines property of the microsoft.graph.company entity.</summary>
        public SalesInvoiceLinesRequestBuilder SalesInvoiceLines { get =>
            new SalesInvoiceLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the salesInvoices property of the microsoft.graph.company entity.</summary>
        public SalesInvoicesRequestBuilder SalesInvoices { get =>
            new SalesInvoicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the salesOrderLines property of the microsoft.graph.company entity.</summary>
        public SalesOrderLinesRequestBuilder SalesOrderLines { get =>
            new SalesOrderLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the salesOrders property of the microsoft.graph.company entity.</summary>
        public SalesOrdersRequestBuilder SalesOrders { get =>
            new SalesOrdersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the salesQuoteLines property of the microsoft.graph.company entity.</summary>
        public SalesQuoteLinesRequestBuilder SalesQuoteLines { get =>
            new SalesQuoteLinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the salesQuotes property of the microsoft.graph.company entity.</summary>
        public SalesQuotesRequestBuilder SalesQuotes { get =>
            new SalesQuotesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the shipmentMethods property of the microsoft.graph.company entity.</summary>
        public ShipmentMethodsRequestBuilder ShipmentMethods { get =>
            new ShipmentMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the taxAreas property of the microsoft.graph.company entity.</summary>
        public TaxAreasRequestBuilder TaxAreas { get =>
            new TaxAreasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the taxGroups property of the microsoft.graph.company entity.</summary>
        public TaxGroupsRequestBuilder TaxGroups { get =>
            new TaxGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the unitsOfMeasure property of the microsoft.graph.company entity.</summary>
        public UnitsOfMeasureRequestBuilder UnitsOfMeasure { get =>
            new UnitsOfMeasureRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the vendors property of the microsoft.graph.company entity.</summary>
        public VendorsRequestBuilder Vendors { get =>
            new VendorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new CompanyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CompanyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/financials/companies/{company%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CompanyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CompanyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/financials/companies/{company%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get companies from financials
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Company?> GetAsync(Action<CompanyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Company> GetAsync(Action<CompanyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Company>(requestInfo, Company.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get companies from financials
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CompanyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CompanyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CompanyItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CompanyItemRequestBuilder WithUrl(string rawUrl) {
            return new CompanyItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get companies from financials
        /// </summary>
        public class CompanyItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CompanyItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CompanyItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CompanyItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new CompanyItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CompanyItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
