#pragma checksum "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49cc3603e0de2705dd9ec67184d56ab3977ce7f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\CSharpWebProjects\Code360StudentApp\Views\_ViewImports.cshtml"
using Code360StudentApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CSharpWebProjects\Code360StudentApp\Views\_ViewImports.cshtml"
using Code360StudentApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CSharpWebProjects\Code360StudentApp\Views\_ViewImports.cshtml"
using Code360StudentApp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49cc3603e0de2705dd9ec67184d56ab3977ce7f9", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de443335ec7c6a71b484c388a3d5799e90e61197", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
  
    ViewBag.Title = "Employee Details";
    var photoPath = "~/img/" + (Model.student.Photo ?? "no-image.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<section id=\"breacrumb\">\r\n    <div class=\"container\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"active\">Dashboard / ");
#nullable restore
#line 17 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                      Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
        </ol>
    </div>
</section>

<section id=""main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""list-group"">
                    <a href=""index.html"" class=""list-group-item list-group-item-action active main-color-bg"">
                        <i class=""fa fa-cog""></i> Dashboard
                    </a>
                    <a href=""pages.html"" class=""list-group-item list-group-item-action""> <i class=""fa fa-book""></i> Pages <span class=""badge badge-primary badge-pill"">3</span></a>
                    <a href=""users.html"" class=""list-group-item list-group-item-action""><i class=""fa fa-user-circle"" aria-hidden=""true""></i> Users <span class=""badge badge-primary badge-pill"">14</span></a>
                    <a href=""posts.html"" class=""list-group-item list-group-item-action""><i class=""fa fa-pencil""></i> Posts <span class=""badge badge-primary badge-pill"">20</span></a>

                </div>

                <div cla");
            WriteLiteral(@"ss=""card card-body mt-3"">
                    <h4>Disk Space Used</h4>
                    <div class=""progress"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 65%;"" aria-valuenow=""65"" aria-valuemin=""0"" aria-valuemax=""100"">65%</div>
                    </div>
                </div>
                <div class=""card card-body"">
                    <h4>Bandwidth Used</h4>
                    <div class=""progress"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 45%;"" aria-valuenow=""45"" aria-valuemin=""0"" aria-valuemax=""100"">45%</div>
                    </div>
                </div>
            </div>
            <div class=""col-md-9"">


                <!-- user table  -->

                <div class=""panel-body"">
                    <div class=""row"">
                        <div class=""col-md-8 mx-auto"">

                            <div class=""card"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "49cc3603e0de2705dd9ec67184d56ab3977ce7f97882", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                                   WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 59 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 61 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                                      Write(Model.student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <div class=\"card-text\">\r\n                                        <p>Email: ");
#nullable restore
#line 63 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                             Write(Model.student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; | &nbsp; Phone: ");
#nullable restore
#line 63 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                                                                         Write(Model.student.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        <p>Address: ");
#nullable restore
#line 64 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                               Write(Model.student.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Marital Status: ");
#nullable restore
#line 65 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                                      Write(Model.student.MaritalStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; | &nbsp; Health: ");
#nullable restore
#line 65 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                                                                                           Write(Model.student.HealthCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        <p>Nationality: ");
#nullable restore
#line 66 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                                   Write(Model.student.Nationalty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Status: ");
#nullable restore
#line 67 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                              Write(Model.student.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; | &nbsp; Admission Type: ");
#nullable restore
#line 67 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                                                                                    Write(Model.student.AdmissionType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                    </div>\r\n\r\n                                    <h3 class=\"text-center\">Next Of Kin Details</h3>\r\n                                    <p>");
#nullable restore
#line 71 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                  Write(Model.student.NextOFKinName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 72 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                  Write(Model.student.NextOfKinNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 73 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
                                  Write(Model.student.NextOfKinAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"text-center\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49cc3603e0de2705dd9ec67184d56ab3977ce7f914281", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 106 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n        window.onload = function () {\r\n            alert(\"");
#nullable restore
#line 110 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
              Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n        }\r\n        </script>\r\n");
#nullable restore
#line 113 "C:\CSharpWebProjects\Code360StudentApp\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591