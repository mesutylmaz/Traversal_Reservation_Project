#pragma checksum "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\Shared\Components\_CommentListFilterPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b0f8be545e77da4fa4413577373d79969ed61d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__CommentListFilterPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_CommentListFilterPartial/Default.cshtml")]
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
#line 1 "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\_ViewImports.cshtml"
using Traversal_Rezervasyon_Projesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\_ViewImports.cshtml"
using Traversal_Rezervasyon_Projesi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\Shared\Components\_CommentListFilterPartial\Default.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0f8be545e77da4fa4413577373d79969ed61d5", @"/Views/Shared/Components/_CommentListFilterPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff46cca8b7b175e1961cbf76d4397568dabf726", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__CommentListFilterPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/images/c1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"comments mt-5\">\r\n    <h4 class=\"side-title \">Yorumlar (2)</h4>\r\n");
#nullable restore
#line 6 "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\Shared\Components\_CommentListFilterPartial\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media mt-4\">\r\n            <div class=\"img-circle\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1b0f8be545e77da4fa4413577373d79969ed61d55354", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"media-body\">\r\n\r\n                <ul class=\"time-rply mb-3\">\r\n                    <li>\r\n                        <a href=\"#URL\" class=\"name mt-0 mb-2 d-block\">");
#nullable restore
#line 16 "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\Shared\Components\_CommentListFilterPartial\Default.cshtml"
                                                                 Write(item.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        ");
#nullable restore
#line 17 "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\Shared\Components\_CommentListFilterPartial\Default.cshtml"
                   Write(item.CommentDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\Shared\Components\_CommentListFilterPartial\Default.cshtml"
                                                           Write(item.CommentDate.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        \r\n                    </li>\r\n");
            WriteLiteral("                </ul>\r\n                <p>\r\n                    ");
#nullable restore
#line 25 "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\Shared\Components\_CommentListFilterPartial\Default.cshtml"
               Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <br />\r\n                <a href=\"#\" class=\"btn btn-info reply\" style=\"background-color:darkcyan; color:aliceblue;\">Yanıtla</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\Yılmaz Ailesi\Desktop\GitHub Projeleri\Traversal_Rezervasyon_Projesi\Traversal_Rezervasyon_Projesi\Views\Shared\Components\_CommentListFilterPartial\Default.cshtml"

        
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
