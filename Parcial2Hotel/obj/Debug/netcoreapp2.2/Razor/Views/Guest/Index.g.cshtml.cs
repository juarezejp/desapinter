#pragma checksum "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "129462c410a106e78e8b8e7618fb1026ff9081d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guest_Index), @"mvc.1.0.view", @"/Views/Guest/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Guest/Index.cshtml", typeof(AspNetCore.Views_Guest_Index))]
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
#line 1 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\_ViewImports.cshtml"
using ResHotel;

#line default
#line hidden
#line 2 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\_ViewImports.cshtml"
using ResHotel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129462c410a106e78e8b8e7618fb1026ff9081d2", @"/Views/Guest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c1c136844b518ec2391dad0a3e50f0a27db134", @"/Views/_ViewImports.cshtml")]
    public class Views_Guest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResHotel.Models.Guest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(81, 25, true);
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            EndContext();
            BeginContext(106, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129462c410a106e78e8b8e7618fb1026ff9081d24727", async() => {
                BeginContext(129, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(143, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(230, 46, false);
#line 16 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestTitle));

#line default
#line hidden
            EndContext();
            BeginContext(276, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(329, 50, false);
#line 19 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestForenames));

#line default
#line hidden
            EndContext();
            BeginContext(379, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(432, 49, false);
#line 22 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(481, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(534, 44, false);
#line 25 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestDOB));

#line default
#line hidden
            EndContext();
            BeginContext(578, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(631, 54, false);
#line 28 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(685, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(738, 52, false);
#line 31 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(790, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(843, 55, false);
#line 34 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestAddressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(898, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(951, 59, false);
#line 37 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestAddressPostaleCode));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1063, 53, false);
#line 40 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 46 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1227, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1274, 45, false);
#line 49 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1372, 49, false);
#line 52 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestForenames));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1474, 48, false);
#line 55 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1575, 43, false);
#line 58 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestDOB));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1671, 53, false);
#line 61 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1724, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1777, 51, false);
#line 64 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1828, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1881, 54, false);
#line 67 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestAddressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1988, 58, false);
#line 70 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestAddressPostaleCode));

#line default
#line hidden
            EndContext();
            BeginContext(2046, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2099, 52, false);
#line 73 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestContactPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2151, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2203, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129462c410a106e78e8b8e7618fb1026ff9081d214295", async() => {
                BeginContext(2253, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
                                       WriteLiteral(item.GuestID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2261, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2280, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129462c410a106e78e8b8e7618fb1026ff9081d216654", async() => {
                BeginContext(2333, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
                                          WriteLiteral(item.GuestID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2344, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2363, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129462c410a106e78e8b8e7618fb1026ff9081d219019", async() => {
                BeginContext(2415, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
                                         WriteLiteral(item.GuestID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2425, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 81 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Guest\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2460, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ResHotel.Models.Guest>> Html { get; private set; }
    }
}
#pragma warning restore 1591