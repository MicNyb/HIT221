#pragma checksum "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29747533b5780926e138c67e21735eb5d5ae7e07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lessons_Details), @"mvc.1.0.view", @"/Views/Lessons/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29747533b5780926e138c67e21735eb5d5ae7e07", @"/Views/Lessons/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Lessons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment1.Models.Lesson>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Lesson</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LessonDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.LessonDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LessonTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.LessonTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Paid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Paid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Student));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.StudentFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Instrument));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Instrument.StudentInstrument));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.TutorFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DurationCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.DurationCost.LessonDurationCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29747533b5780926e138c67e21735eb5d5ae7e079669", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 58 "C:\Users\Michael Nyback\Desktop\CDU\2021 SEM2\HIT339\Assignments\2\github_repo\HIT221\Assignment1\Assignment1\Views\Lessons\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29747533b5780926e138c67e21735eb5d5ae7e0711870", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment1.Models.Lesson> Html { get; private set; }
    }
}
#pragma warning restore 1591
