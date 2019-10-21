#pragma checksum "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b44398d8e8b830758ed6369c0c1df859fc9e9ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Student), @"mvc.1.0.view", @"/Views/Student/Student.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Student.cshtml", typeof(AspNetCore.Views_Student_Student))]
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
#line 1 "D:\code-gym\FinalExamModule2\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#line 2 "D:\code-gym\FinalExamModule2\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#line 3 "D:\code-gym\FinalExamModule2\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models.Language.Response;

#line default
#line hidden
#line 4 "D:\code-gym\FinalExamModule2\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models.Level.Response;

#line default
#line hidden
#line 5 "D:\code-gym\FinalExamModule2\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models.Student;

#line default
#line hidden
#line 2 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
using StudentManagement.Models.Student.Request;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b44398d8e8b830758ed6369c0c1df859fc9e9ab", @"/Views/Student/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e7152929188a974b951a8a80a208507b2a63c03", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Models.Student.Response.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
  
    ViewData["Title"] = "Student";

#line default
#line hidden
            BeginContext(150, 128, true);
            WriteLiteral("\r\n<h1>Student</h1>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(279, 48, false);
#line 14 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayNameFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(327, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(389, 44, false);
#line 17 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(433, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(494, 45, false);
#line 20 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayNameFor(model => model.LevelName));

#line default
#line hidden
            EndContext();
            BeginContext(539, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(601, 41, false);
#line 23 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayFor(model => model.LevelName));

#line default
#line hidden
            EndContext();
            BeginContext(642, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(703, 40, false);
#line 26 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(743, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(805, 36, false);
#line 29 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(841, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(902, 46, false);
#line 32 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayNameFor(model => model.DayOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(948, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1010, 42, false);
#line 35 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayFor(model => model.DayOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1113, 39, false);
#line 38 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1214, 38, false);
#line 41 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayFor(model => model.SexStr));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1313, 41, false);
#line 44 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1416, 37, false);
#line 47 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1501, 129, false);
#line 52 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
Write(Html.ActionLink("Edit", "EditStudent", "Student", new UpdateStudent() { Id = Model.Id }, new { @class = "btn btn-outline-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1639, 105, false);
#line 53 "D:\code-gym\FinalExamModule2\StudentManagement\Views\Student\Student.cshtml"
Write(Html.ActionLink("Back to List", "StudentsList", "Student", null, new { @class = "btn btn-outline-dark" }));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManagement.Models.Student.Response.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591