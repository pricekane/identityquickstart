#pragma checksum "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "934844f12eda160b43c1ecb5e626c09c7614c8b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_UserCodeConfirmation), @"mvc.1.0.view", @"/Views/Device/UserCodeConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Device/UserCodeConfirmation.cshtml", typeof(AspNetCore.Views_Device_UserCodeConfirmation))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934844f12eda160b43c1ecb5e626c09c7614c8b6", @"/Views/Device/UserCodeConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4c1f8a331756813dc62d0a9e9a6b6778f02506", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_UserCodeConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServer4.Quickstart.UI.Device.DeviceAuthorizationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ScopeListItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Callback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 93, true);
            WriteLiteral("\n<div class=\"page-header\">\n    <div class=\"row page-header\">\n        <div class=\"col-sm-10\">\n");
            EndContext();
#line 6 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
            BeginContext(226, 45, true);
            WriteLiteral("                <div class=\"client-logo\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 271, "\"", 297, 1);
#line 8 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 277, Model.ClientLogoUrl, 277, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(298, 8, true);
            WriteLiteral("></div>\n");
            EndContext();
#line 9 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
            }

#line default
#line hidden
            BeginContext(320, 33, true);
            WriteLiteral("            <h1>\n                ");
            EndContext();
            BeginContext(354, 16, false);
#line 11 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(370, 107, true);
            WriteLiteral("\n                <small>is requesting your permission</small>\n            </h1>\n        </div>\n    </div>\n\n");
            EndContext();
#line 17 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
     if (Model.ConfirmUserCode)
    {

#line default
#line hidden
            BeginContext(515, 165, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-8\">\n                <p>\n                    Please confirm that the authorization request quotes the code: \"");
            EndContext();
            BeginContext(681, 14, false);
#line 22 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                                                                               Write(Model.UserCode);

#line default
#line hidden
            EndContext();
            BeginContext(695, 58, true);
            WriteLiteral("\".\n                </p>\n            </div>\n        </div>\n");
            EndContext();
#line 26 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
    }

#line default
#line hidden
            BeginContext(759, 66, true);
            WriteLiteral("\n    <div class=\"row\">\n        <div class=\"col-sm-8\">\n            ");
            EndContext();
            BeginContext(825, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc0a061146514ed0aa3982d74c3c53b2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(862, 14, true);
            WriteLiteral("\n\n            ");
            EndContext();
            BeginContext(876, 2600, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d876918c6704950a921db6ef555a4c3", async() => {
                BeginContext(925, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(942, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "283667b402fc4fe495197021345d448c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 33 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserCode);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 33 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                                                   WriteLiteral(Model.UserCode);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1008, 80, true);
                WriteLiteral("\n\n                <div>Uncheck the permissions you do not wish to grant.</div>\n\n");
                EndContext();
#line 37 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
                BeginContext(1155, 325, true);
                WriteLiteral(@"                    <div class=""panel panel-default consent-buttons"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-user""></span>
                            Personal Information
                        </div>
                        <ul class=""list-group"">
");
                EndContext();
#line 45 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                             foreach (var scope in Model.IdentityScopes)
                            {

#line default
#line hidden
                BeginContext(1583, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1615, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "095bcf84e43e45ec94d1921f1b00ea1b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 47 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1663, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 48 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                            }

#line default
#line hidden
                BeginContext(1694, 57, true);
                WriteLiteral("                        </ul>\n                    </div>\n");
                EndContext();
#line 51 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
                BeginContext(1769, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 53 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
                BeginContext(1837, 308, true);
                WriteLiteral(@"                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-tasks""></span>
                            Application Access
                        </div>
                        <ul class=""list-group"">
");
                EndContext();
#line 61 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                             foreach (var scope in Model.ResourceScopes)
                            {

#line default
#line hidden
                BeginContext(2248, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2280, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4dfc40a90e2449e85e2874ff49fa221", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 63 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2327, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 64 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                            }

#line default
#line hidden
                BeginContext(2358, 57, true);
                WriteLiteral("                        </ul>\n                    </div>\n");
                EndContext();
#line 67 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
                BeginContext(2433, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 69 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
                BeginContext(2501, 111, true);
                WriteLiteral("                    <div class=\"consent-remember\">\n                        <label>\n                            ");
                EndContext();
                BeginContext(2612, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38e2cf12f64142f498a1c2f01aa33946", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 73 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2674, 127, true);
                WriteLiteral("\n                            <strong>Remember My Decision</strong>\n                        </label>\n                    </div>\n");
                EndContext();
#line 77 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
                BeginContext(2819, 246, true);
                WriteLiteral("\n                <div class=\"consent-buttons\">\n                    <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>Yes, Allow</button>\n                    <button name=\"button\" value=\"no\" class=\"btn\">No, Do Not Allow</button>\n");
                EndContext();
#line 82 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                     if (Model.ClientUrl != null)
                    {

#line default
#line hidden
                BeginContext(3137, 77, true);
                WriteLiteral("                        <a class=\"pull-right btn btn-default\" target=\"_blank\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3214, "\"", 3237, 1);
#line 84 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 3221, Model.ClientUrl, 3221, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3238, 118, true);
                WriteLiteral(">\n                            <span class=\"glyphicon glyphicon-info-sign\"></span>\n                            <strong>");
                EndContext();
                BeginContext(3357, 16, false);
#line 86 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                               Write(Model.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(3373, 39, true);
                WriteLiteral("</strong>\n                        </a>\n");
                EndContext();
#line 88 "C:\Users\kprice\projects\identityquickstart\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                    }

#line default
#line hidden
                BeginContext(3434, 35, true);
                WriteLiteral("                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3476, 33, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServer4.Quickstart.UI.Device.DeviceAuthorizationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
