#pragma checksum "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eec2b671152970dd0fc3a77b6a0b664578da85b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Details.cshtml", typeof(AspNetCore.Views_Customer_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eec2b671152970dd0fc3a77b6a0b664578da85b7", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c1c136844b518ec2391dad0a3e50f0a27db134", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResHotel.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 123, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Customer</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(197, 49, false);
#line 14 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerTitle));

#line default
#line hidden
            EndContext();
            BeginContext(246, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(307, 45, false);
#line 17 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerTitle));

#line default
#line hidden
            EndContext();
            BeginContext(352, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(412, 53, false);
#line 20 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(465, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(526, 49, false);
#line 23 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(575, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(635, 52, false);
#line 26 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(687, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(748, 48, false);
#line 29 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(796, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(856, 47, false);
#line 32 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(903, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(964, 43, false);
#line 35 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1067, 57, false);
#line 38 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1185, 53, false);
#line 41 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1298, 55, false);
#line 44 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1414, 51, false);
#line 47 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1525, 58, false);
#line 50 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1583, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1644, 54, false);
#line 53 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1698, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1758, 61, false);
#line 56 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1880, 57, false);
#line 59 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1937, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1997, 53, false);
#line 62 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2111, 49, false);
#line 65 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2160, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2220, 53, false);
#line 68 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2273, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2334, 49, false);
#line 71 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2383, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2443, 54, false);
#line 74 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerMobilPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2558, 50, false);
#line 77 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerMobilPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2608, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2668, 55, false);
#line 80 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerCustomEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2723, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2784, 51, false);
#line 83 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerCustomEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2835, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(2877, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eec2b671152970dd0fc3a77b6a0b664578da85b714873", async() => {
                BeginContext(2931, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\ELADIO\Documents\uni\AplicacionesInternet\Parcial2Hotel\Views\Customer\Details.cshtml"
                           WriteLiteral(Model.CustomerID);

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
            BeginContext(2939, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2946, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eec2b671152970dd0fc3a77b6a0b664578da85b717216", async() => {
                BeginContext(2968, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2984, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResHotel.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591