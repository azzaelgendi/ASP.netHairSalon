#pragma checksum "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c3f054a08d62d992e548a5c44a5a82e7349da9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AppointmentDetail_Details), @"mvc.1.0.view", @"/Views/AppointmentDetail/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AppointmentDetail/Details.cshtml", typeof(AspNetCore.Views_AppointmentDetail_Details))]
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
#line 1 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\_ViewImports.cshtml"
using Hair;

#line default
#line hidden
#line 2 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\_ViewImports.cshtml"
using Hair.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c3f054a08d62d992e548a5c44a5a82e7349da9e", @"/Views/AppointmentDetail/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef88d4fc264a245b423a7640f696ae18a7c8426a", @"/Views/_ViewImports.cshtml")]
    public class Views_AppointmentDetail_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hair.Models.AppointmentDetail>
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 131, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>AppointmentDetail</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(215, 52, false);
#line 14 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProcedureMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(311, 48, false);
#line 17 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProcedureMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(359, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(403, 47, false);
#line 20 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RetailPrice));

#line default
#line hidden
            EndContext();
            BeginContext(450, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(494, 43, false);
#line 23 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.RetailPrice));

#line default
#line hidden
            EndContext();
            BeginContext(537, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(581, 44, false);
#line 26 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(625, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(669, 40, false);
#line 29 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(709, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(753, 44, false);
#line 32 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(797, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(841, 40, false);
#line 35 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(881, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(925, 41, false);
#line 38 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(966, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1010, 37, false);
#line 41 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1091, 44, false);
#line 44 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1179, 40, false);
#line 47 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1263, 47, false);
#line 50 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Appointment));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1354, 57, false);
#line 53 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.Appointment.AppointmentId));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1455, 43, false);
#line 56 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1542, 44, false);
#line 59 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1633, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "494092b6940343c9ba6df9fa9eb6f2da", async() => {
                BeginContext(1696, 4, true);
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
#line 64 "C:\Users\AZZA ELGENDY\Desktop\github\ASP.netHairSalon\HairContainer\Hair\Views\AppointmentDetail\Details.cshtml"
                           WriteLiteral(Model.AppointmentDetailId);

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
            BeginContext(1704, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1712, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1371a54fce424777b6fe841658d3890e", async() => {
                BeginContext(1734, 12, true);
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
            BeginContext(1750, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hair.Models.AppointmentDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
