#pragma checksum "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98f6ea3fe3eb92817dc8646a134072ee1cac0eed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentInfoes_Details), @"mvc.1.0.view", @"/Views/StudentInfoes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StudentInfoes/Details.cshtml", typeof(AspNetCore.Views_StudentInfoes_Details))]
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
#line 1 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\_ViewImports.cshtml"
using G2_UMA;

#line default
#line hidden
#line 2 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\_ViewImports.cshtml"
using G2_UMA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f6ea3fe3eb92817dc8646a134072ee1cac0eed", @"/Views/StudentInfoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c7351e2d68b6582c4041611a7a4d7fdeafed3f", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentInfoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<G2_UMA.Models.StudentInfo>
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>StudentInfo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(205, 42, false);
#line 14 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.std_id));

#line default
#line hidden
            EndContext();
            BeginContext(247, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(291, 38, false);
#line 17 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.std_id));

#line default
#line hidden
            EndContext();
            BeginContext(329, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(373, 40, false);
#line 20 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(457, 36, false);
#line 23 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(493, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(537, 39, false);
#line 26 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.age));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(620, 35, false);
#line 29 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.age));

#line default
#line hidden
            EndContext();
            BeginContext(655, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(699, 42, false);
#line 32 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
            EndContext();
            BeginContext(741, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(785, 38, false);
#line 35 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.gender));

#line default
#line hidden
            EndContext();
            BeginContext(823, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(867, 41, false);
#line 38 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Class));

#line default
#line hidden
            EndContext();
            BeginContext(908, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(952, 37, false);
#line 41 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Class));

#line default
#line hidden
            EndContext();
            BeginContext(989, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1033, 40, false);
#line 44 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.paid));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1117, 36, false);
#line 47 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.paid));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1197, 39, false);
#line 50 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.due));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1280, 35, false);
#line 53 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.due));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1362, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3bf8e1d68d742f9bce74442b7edf8fc", async() => {
                BeginContext(1408, 4, true);
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
#line 58 "E:\I U B A T\PPRROOJJEECCTT\Visual Project With Payment\G2B_UMA\G2_UMA\Views\StudentInfoes\Details.cshtml"
                           WriteLiteral(Model.id);

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
            BeginContext(1416, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1424, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16490bf5115c429abe3f91de61917664", async() => {
                BeginContext(1446, 12, true);
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
            BeginContext(1462, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<G2_UMA.Models.StudentInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591