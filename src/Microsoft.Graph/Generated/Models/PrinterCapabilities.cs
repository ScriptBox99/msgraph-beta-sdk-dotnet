using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrinterCapabilities : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A list of supported bottom margins(in microns) for the printer.</summary>
        public List<int?> BottomMargins {
            get { return BackingStore?.Get<List<int?>>("bottomMargins"); }
            set { BackingStore?.Set("bottomMargins", value); }
        }
        /// <summary>True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.</summary>
        public bool? Collation {
            get { return BackingStore?.Get<bool?>("collation"); }
            set { BackingStore?.Set("collation", value); }
        }
        /// <summary>The color modes supported by the printer. Valid values are described in the following table.</summary>
        public List<string> ColorModes {
            get { return BackingStore?.Get<List<string>>("colorModes"); }
            set { BackingStore?.Set("colorModes", value); }
        }
        /// <summary>A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.</summary>
        public List<string> ContentTypes {
            get { return BackingStore?.Get<List<string>>("contentTypes"); }
            set { BackingStore?.Set("contentTypes", value); }
        }
        /// <summary>The range of copies per job supported by the printer.</summary>
        public IntegerRange CopiesPerJob {
            get { return BackingStore?.Get<IntegerRange>("copiesPerJob"); }
            set { BackingStore?.Set("copiesPerJob", value); }
        }
        /// <summary>The list of print resolutions in DPI that are supported by the printer.</summary>
        public List<int?> Dpis {
            get { return BackingStore?.Get<List<int?>>("dpis"); }
            set { BackingStore?.Set("dpis", value); }
        }
        /// <summary>The list of duplex modes that are supported by the printer. Valid values are described in the following table.</summary>
        public List<string> DuplexModes {
            get { return BackingStore?.Get<List<string>>("duplexModes"); }
            set { BackingStore?.Set("duplexModes", value); }
        }
        /// <summary>The feedDirections property</summary>
        public List<string> FeedDirections {
            get { return BackingStore?.Get<List<string>>("feedDirections"); }
            set { BackingStore?.Set("feedDirections", value); }
        }
        /// <summary>The list of feed orientations that are supported by the printer.</summary>
        public List<string> FeedOrientations {
            get { return BackingStore?.Get<List<string>>("feedOrientations"); }
            set { BackingStore?.Set("feedOrientations", value); }
        }
        /// <summary>Finishing processes the printer supports for a printed document.</summary>
        public List<string> Finishings {
            get { return BackingStore?.Get<List<string>>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
        /// <summary>Supported input bins for the printer.</summary>
        public List<string> InputBins {
            get { return BackingStore?.Get<List<string>>("inputBins"); }
            set { BackingStore?.Set("inputBins", value); }
        }
        /// <summary>True if color printing is supported by the printer; false otherwise. Read-only.</summary>
        public bool? IsColorPrintingSupported {
            get { return BackingStore?.Get<bool?>("isColorPrintingSupported"); }
            set { BackingStore?.Set("isColorPrintingSupported", value); }
        }
        /// <summary>True if the printer supports printing by page ranges; false otherwise.</summary>
        public bool? IsPageRangeSupported {
            get { return BackingStore?.Get<bool?>("isPageRangeSupported"); }
            set { BackingStore?.Set("isPageRangeSupported", value); }
        }
        /// <summary>A list of supported left margins(in microns) for the printer.</summary>
        public List<int?> LeftMargins {
            get { return BackingStore?.Get<List<int?>>("leftMargins"); }
            set { BackingStore?.Set("leftMargins", value); }
        }
        /// <summary>The media (i.e., paper) colors supported by the printer.</summary>
        public List<string> MediaColors {
            get { return BackingStore?.Get<List<string>>("mediaColors"); }
            set { BackingStore?.Set("mediaColors", value); }
        }
        /// <summary>The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes. Valid values are in the following table.</summary>
        public List<string> MediaSizes {
            get { return BackingStore?.Get<List<string>>("mediaSizes"); }
            set { BackingStore?.Set("mediaSizes", value); }
        }
        /// <summary>The media types supported by the printer.</summary>
        public List<string> MediaTypes {
            get { return BackingStore?.Get<List<string>>("mediaTypes"); }
            set { BackingStore?.Set("mediaTypes", value); }
        }
        /// <summary>The presentation directions supported by the printer. Supported values are described in the following table.</summary>
        public List<string> MultipageLayouts {
            get { return BackingStore?.Get<List<string>>("multipageLayouts"); }
            set { BackingStore?.Set("multipageLayouts", value); }
        }
        /// <summary>The print orientations supported by the printer. Valid values are described in the following table.</summary>
        public List<string> Orientations {
            get { return BackingStore?.Get<List<string>>("orientations"); }
            set { BackingStore?.Set("orientations", value); }
        }
        /// <summary>The printer&apos;s supported output bins (trays).</summary>
        public List<string> OutputBins {
            get { return BackingStore?.Get<List<string>>("outputBins"); }
            set { BackingStore?.Set("outputBins", value); }
        }
        /// <summary>Supported number of Input Pages to impose upon a single Impression.</summary>
        public List<int?> PagesPerSheet {
            get { return BackingStore?.Get<List<int?>>("pagesPerSheet"); }
            set { BackingStore?.Set("pagesPerSheet", value); }
        }
        /// <summary>The print qualities supported by the printer.</summary>
        public List<string> Qualities {
            get { return BackingStore?.Get<List<string>>("qualities"); }
            set { BackingStore?.Set("qualities", value); }
        }
        /// <summary>A list of supported right margins(in microns) for the printer.</summary>
        public List<int?> RightMargins {
            get { return BackingStore?.Get<List<int?>>("rightMargins"); }
            set { BackingStore?.Set("rightMargins", value); }
        }
        /// <summary>Supported print scalings.</summary>
        public List<string> Scalings {
            get { return BackingStore?.Get<List<string>>("scalings"); }
            set { BackingStore?.Set("scalings", value); }
        }
        /// <summary>The supportedColorConfigurations property</summary>
        public List<string> SupportedColorConfigurations {
            get { return BackingStore?.Get<List<string>>("supportedColorConfigurations"); }
            set { BackingStore?.Set("supportedColorConfigurations", value); }
        }
        /// <summary>The supportedCopiesPerJob property</summary>
        public IntegerRange SupportedCopiesPerJob {
            get { return BackingStore?.Get<IntegerRange>("supportedCopiesPerJob"); }
            set { BackingStore?.Set("supportedCopiesPerJob", value); }
        }
        /// <summary>The supportedDocumentMimeTypes property</summary>
        public List<string> SupportedDocumentMimeTypes {
            get { return BackingStore?.Get<List<string>>("supportedDocumentMimeTypes"); }
            set { BackingStore?.Set("supportedDocumentMimeTypes", value); }
        }
        /// <summary>The supportedDuplexConfigurations property</summary>
        public List<string> SupportedDuplexConfigurations {
            get { return BackingStore?.Get<List<string>>("supportedDuplexConfigurations"); }
            set { BackingStore?.Set("supportedDuplexConfigurations", value); }
        }
        /// <summary>The supportedFinishings property</summary>
        public List<string> SupportedFinishings {
            get { return BackingStore?.Get<List<string>>("supportedFinishings"); }
            set { BackingStore?.Set("supportedFinishings", value); }
        }
        /// <summary>The supportedMediaColors property</summary>
        public List<string> SupportedMediaColors {
            get { return BackingStore?.Get<List<string>>("supportedMediaColors"); }
            set { BackingStore?.Set("supportedMediaColors", value); }
        }
        /// <summary>The supportedMediaSizes property</summary>
        public List<string> SupportedMediaSizes {
            get { return BackingStore?.Get<List<string>>("supportedMediaSizes"); }
            set { BackingStore?.Set("supportedMediaSizes", value); }
        }
        /// <summary>The supportedMediaTypes property</summary>
        public List<string> SupportedMediaTypes {
            get { return BackingStore?.Get<List<string>>("supportedMediaTypes"); }
            set { BackingStore?.Set("supportedMediaTypes", value); }
        }
        /// <summary>The supportedOrientations property</summary>
        public List<string> SupportedOrientations {
            get { return BackingStore?.Get<List<string>>("supportedOrientations"); }
            set { BackingStore?.Set("supportedOrientations", value); }
        }
        /// <summary>The supportedOutputBins property</summary>
        public List<string> SupportedOutputBins {
            get { return BackingStore?.Get<List<string>>("supportedOutputBins"); }
            set { BackingStore?.Set("supportedOutputBins", value); }
        }
        /// <summary>The supportedPagesPerSheet property</summary>
        public IntegerRange SupportedPagesPerSheet {
            get { return BackingStore?.Get<IntegerRange>("supportedPagesPerSheet"); }
            set { BackingStore?.Set("supportedPagesPerSheet", value); }
        }
        /// <summary>The supportedPresentationDirections property</summary>
        public List<string> SupportedPresentationDirections {
            get { return BackingStore?.Get<List<string>>("supportedPresentationDirections"); }
            set { BackingStore?.Set("supportedPresentationDirections", value); }
        }
        /// <summary>The supportedPrintQualities property</summary>
        public List<string> SupportedPrintQualities {
            get { return BackingStore?.Get<List<string>>("supportedPrintQualities"); }
            set { BackingStore?.Set("supportedPrintQualities", value); }
        }
        /// <summary>True if the printer supports scaling PDF pages to match the print media size; false otherwise.</summary>
        public bool? SupportsFitPdfToPage {
            get { return BackingStore?.Get<bool?>("supportsFitPdfToPage"); }
            set { BackingStore?.Set("supportsFitPdfToPage", value); }
        }
        /// <summary>A list of supported top margins(in microns) for the printer.</summary>
        public List<int?> TopMargins {
            get { return BackingStore?.Get<List<int?>>("topMargins"); }
            set { BackingStore?.Set("topMargins", value); }
        }
        /// <summary>
        /// Instantiates a new printerCapabilities and sets the default values.
        /// </summary>
        public PrinterCapabilities() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrinterCapabilities CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bottomMargins", n => { BottomMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"collation", n => { Collation = n.GetBoolValue(); } },
                {"colorModes", n => { ColorModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"copiesPerJob", n => { CopiesPerJob = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"dpis", n => { Dpis = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"duplexModes", n => { DuplexModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"feedDirections", n => { FeedDirections = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"feedOrientations", n => { FeedOrientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"finishings", n => { Finishings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"inputBins", n => { InputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isColorPrintingSupported", n => { IsColorPrintingSupported = n.GetBoolValue(); } },
                {"isPageRangeSupported", n => { IsPageRangeSupported = n.GetBoolValue(); } },
                {"leftMargins", n => { LeftMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"mediaColors", n => { MediaColors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaSizes", n => { MediaSizes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaTypes", n => { MediaTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"multipageLayouts", n => { MultipageLayouts = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"orientations", n => { Orientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"outputBins", n => { OutputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"pagesPerSheet", n => { PagesPerSheet = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"qualities", n => { Qualities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"rightMargins", n => { RightMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"scalings", n => { Scalings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedColorConfigurations", n => { SupportedColorConfigurations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedCopiesPerJob", n => { SupportedCopiesPerJob = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"supportedDocumentMimeTypes", n => { SupportedDocumentMimeTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedDuplexConfigurations", n => { SupportedDuplexConfigurations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedFinishings", n => { SupportedFinishings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedMediaColors", n => { SupportedMediaColors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedMediaSizes", n => { SupportedMediaSizes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedMediaTypes", n => { SupportedMediaTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedOrientations", n => { SupportedOrientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedOutputBins", n => { SupportedOutputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedPagesPerSheet", n => { SupportedPagesPerSheet = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"supportedPresentationDirections", n => { SupportedPresentationDirections = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedPrintQualities", n => { SupportedPrintQualities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportsFitPdfToPage", n => { SupportsFitPdfToPage = n.GetBoolValue(); } },
                {"topMargins", n => { TopMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("bottomMargins", BottomMargins);
            writer.WriteBoolValue("collation", Collation);
            writer.WriteCollectionOfPrimitiveValues<string>("colorModes", ColorModes);
            writer.WriteCollectionOfPrimitiveValues<string>("contentTypes", ContentTypes);
            writer.WriteObjectValue<IntegerRange>("copiesPerJob", CopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<int?>("dpis", Dpis);
            writer.WriteCollectionOfPrimitiveValues<string>("duplexModes", DuplexModes);
            writer.WriteCollectionOfPrimitiveValues<string>("feedDirections", FeedDirections);
            writer.WriteCollectionOfPrimitiveValues<string>("feedOrientations", FeedOrientations);
            writer.WriteCollectionOfPrimitiveValues<string>("finishings", Finishings);
            writer.WriteCollectionOfPrimitiveValues<string>("inputBins", InputBins);
            writer.WriteBoolValue("isColorPrintingSupported", IsColorPrintingSupported);
            writer.WriteBoolValue("isPageRangeSupported", IsPageRangeSupported);
            writer.WriteCollectionOfPrimitiveValues<int?>("leftMargins", LeftMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaColors", MediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaSizes", MediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaTypes", MediaTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("multipageLayouts", MultipageLayouts);
            writer.WriteCollectionOfPrimitiveValues<string>("orientations", Orientations);
            writer.WriteCollectionOfPrimitiveValues<string>("outputBins", OutputBins);
            writer.WriteCollectionOfPrimitiveValues<int?>("pagesPerSheet", PagesPerSheet);
            writer.WriteCollectionOfPrimitiveValues<string>("qualities", Qualities);
            writer.WriteCollectionOfPrimitiveValues<int?>("rightMargins", RightMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("scalings", Scalings);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedColorConfigurations", SupportedColorConfigurations);
            writer.WriteObjectValue<IntegerRange>("supportedCopiesPerJob", SupportedCopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedDocumentMimeTypes", SupportedDocumentMimeTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedDuplexConfigurations", SupportedDuplexConfigurations);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedFinishings", SupportedFinishings);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedMediaColors", SupportedMediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedMediaSizes", SupportedMediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedMediaTypes", SupportedMediaTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedOrientations", SupportedOrientations);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedOutputBins", SupportedOutputBins);
            writer.WriteObjectValue<IntegerRange>("supportedPagesPerSheet", SupportedPagesPerSheet);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedPresentationDirections", SupportedPresentationDirections);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedPrintQualities", SupportedPrintQualities);
            writer.WriteBoolValue("supportsFitPdfToPage", SupportsFitPdfToPage);
            writer.WriteCollectionOfPrimitiveValues<int?>("topMargins", TopMargins);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
