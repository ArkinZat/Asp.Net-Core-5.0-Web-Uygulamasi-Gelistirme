#pragma checksum "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970b37224a88b793eb0d33678e59c94950f635fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970b37224a88b793eb0d33678e59c94950f635fe", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1666001c2ad5ef6477b3166cd500a7db9edb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Yeteneklerim</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px"">Bildiğim programlama dilleri ve bu dilleri etkin şekilde kullanabilme oranlarım mevcuttur. Yeni bir programlama dili öğrenmek ve bunu uygulayabilmek benim için hızlı bir şekilde gerçekleşmektedir.</p>
        </div>
        <div class=""bg-light p-3"">
            <div class=""row"">
                <div class=""col-md-12"">
");
#nullable restore
#line 15 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                     foreach (var item in Model)
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"py-1\">\r\n                            <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 18 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 18 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                              Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                            <div class=\"progress my-1\">\r\n                                <div class=\"progress-bar bg-primary\" role=\"progressbar\" data-aos=\"zoom-in-right\" data-aos-delay=\"100\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 1164, "\"", 1191, 3);
            WriteAttributeValue("", 1172, "width:", 1172, 6, true);
#nullable restore
#line 20 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1178, item.Value, 1179, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1190, "%", 1190, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1192, "\"", 1219, 1);
#nullable restore
#line 20 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 1208, item.Value, 1208, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 23 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591