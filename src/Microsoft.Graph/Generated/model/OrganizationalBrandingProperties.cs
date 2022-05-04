// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Organizational Branding Properties.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OrganizationalBrandingProperties>))]
    public partial class OrganizationalBrandingProperties : Entity
    {
    
        ///<summary>
        /// The internal OrganizationalBrandingProperties constructor
        ///</summary>
        protected internal OrganizationalBrandingProperties()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets background color.
        /// Color that appears in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.
        /// </summary>
        [JsonPropertyName("backgroundColor")]
        public string BackgroundColor { get; set; }
    
        /// <summary>
        /// Gets or sets background image.
        /// Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.
        /// </summary>
        [JsonPropertyName("backgroundImage")]
        public Stream BackgroundImage { get; set; }
    
        /// <summary>
        /// Gets or sets background image relative url.
        /// A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
        /// </summary>
        [JsonPropertyName("backgroundImageRelativeUrl")]
        public string BackgroundImageRelativeUrl { get; set; }
    
        /// <summary>
        /// Gets or sets banner logo.
        /// A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.
        /// </summary>
        [JsonPropertyName("bannerLogo")]
        public Stream BannerLogo { get; set; }
    
        /// <summary>
        /// Gets or sets banner logo relative url.
        /// A relative URL for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.
        /// </summary>
        [JsonPropertyName("bannerLogoRelativeUrl")]
        public string BannerLogoRelativeUrl { get; set; }
    
        /// <summary>
        /// Gets or sets cdn list.
        /// A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.
        /// </summary>
        [JsonPropertyName("cdnList")]
        public IEnumerable<string> CdnList { get; set; }
    
        /// <summary>
        /// Gets or sets custom account reset credentials url.
        /// A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
        /// </summary>
        [JsonPropertyName("customAccountResetCredentialsUrl")]
        public string CustomAccountResetCredentialsUrl { get; set; }
    
        /// <summary>
        /// Gets or sets custom cannot access your account text.
        /// A string to replace the default 'Can't access your account?' self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters.
        /// </summary>
        [JsonPropertyName("customCannotAccessYourAccountText")]
        public string CustomCannotAccessYourAccountText { get; set; }
    
        /// <summary>
        /// Gets or sets custom cannot access your account url.
        /// A custom URL to replace the default URL of the self-service password reset (SSPR) 'Can't access your account?' hyperlink on the sign-in page. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. DO NOT USE. Use customAccountResetCredentialsUrl instead.
        /// </summary>
        [JsonPropertyName("customCannotAccessYourAccountUrl")]
        public string CustomCannotAccessYourAccountUrl { get; set; }
    
        /// <summary>
        /// Gets or sets custom forgot my password text.
        /// A string to replace the default 'Forgot my password' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters.
        /// </summary>
        [JsonPropertyName("customForgotMyPasswordText")]
        public string CustomForgotMyPasswordText { get; set; }
    
        /// <summary>
        /// Gets or sets custom privacy and cookies text.
        /// A string to replace the default 'Privacy and Cookies' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
        /// </summary>
        [JsonPropertyName("customPrivacyAndCookiesText")]
        public string CustomPrivacyAndCookiesText { get; set; }
    
        /// <summary>
        /// Gets or sets custom privacy and cookies url.
        /// A custom URL to replace the default URL of the 'Privacy and Cookies' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
        /// </summary>
        [JsonPropertyName("customPrivacyAndCookiesUrl")]
        public string CustomPrivacyAndCookiesUrl { get; set; }
    
        /// <summary>
        /// Gets or sets custom reset it now text.
        /// A string to replace the default 'reset it now' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. DO NOT USE: Customization of the 'reset it now' hyperlink text is currently not supported.
        /// </summary>
        [JsonPropertyName("customResetItNowText")]
        public string CustomResetItNowText { get; set; }
    
        /// <summary>
        /// Gets or sets custom terms of use text.
        /// A string to replace the the default 'Terms of Use' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
        /// </summary>
        [JsonPropertyName("customTermsOfUseText")]
        public string CustomTermsOfUseText { get; set; }
    
        /// <summary>
        /// Gets or sets custom terms of use url.
        /// A custom URL to replace the default URL of the 'Terms of Use' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.
        /// </summary>
        [JsonPropertyName("customTermsOfUseUrl")]
        public string CustomTermsOfUseUrl { get; set; }
    
        /// <summary>
        /// Gets or sets favicon.
        /// A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.
        /// </summary>
        [JsonPropertyName("favicon")]
        public Stream Favicon { get; set; }
    
        /// <summary>
        /// Gets or sets favicon relative url.
        /// A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
        /// </summary>
        [JsonPropertyName("faviconRelativeUrl")]
        public string FaviconRelativeUrl { get; set; }
    
        /// <summary>
        /// Gets or sets header background color.
        /// The RGB color to apply to customize the color of the header.
        /// </summary>
        [JsonPropertyName("headerBackgroundColor")]
        public string HeaderBackgroundColor { get; set; }
    
        /// <summary>
        /// Gets or sets login page text visibility settings.
        /// Represents the various texts that can be hidden on the login page for a tenant.
        /// </summary>
        [JsonPropertyName("loginPageTextVisibilitySettings")]
        public LoginPageTextVisibilitySettings LoginPageTextVisibilitySettings { get; set; }
    
        /// <summary>
        /// Gets or sets sign in page text.
        /// Text that appears at the bottom of the sign-in box. Use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be in Unicode format and not exceed 1024 characters.
        /// </summary>
        [JsonPropertyName("signInPageText")]
        public string SignInPageText { get; set; }
    
        /// <summary>
        /// Gets or sets square logo.
        /// A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.
        /// </summary>
        [JsonPropertyName("squareLogo")]
        public Stream SquareLogo { get; set; }
    
        /// <summary>
        /// Gets or sets square logo relative url.
        /// A relative URL for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
        /// </summary>
        [JsonPropertyName("squareLogoRelativeUrl")]
        public string SquareLogoRelativeUrl { get; set; }
    
        /// <summary>
        /// Gets or sets username hint text.
        /// A string that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.
        /// </summary>
        [JsonPropertyName("usernameHintText")]
        public string UsernameHintText { get; set; }
    
    }
}

