#pragma checksum "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\LastFiveProjects\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0958f9e01828fb273e55eef6c2b40ab09c74e92c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LastFiveProjects_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LastFiveProjects/Default.cshtml")]
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
#line 1 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0958f9e01828fb273e55eef6c2b40ab09c74e92c", @"/Views/Shared/Components/LastFiveProjects/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1666001c2ad5ef6477b3166cd500a7db9edb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LastFiveProjects_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-md-8 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""d-flex flex-row justify-content-between"">
                <h4 class=""card-title mb-1"">Son Projelerim</h4>
                <p class=""text-muted mb-1"">Proje Durumları</p>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""preview-list"">
");
#nullable restore
#line 13 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\LastFiveProjects\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""preview-item border-bottom"">
                                <div class=""preview-thumbnail"">
                                    <div class=""preview-icon bg-primary"">
                                        <img alt=""Image placeholder""");
            BeginWriteAttribute("src", " src=\"", 824, "\"", 844, 1);
#nullable restore
#line 18 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\LastFiveProjects\Default.cshtml"
WriteAttributeValue("", 830, item.Platform, 830, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""preview-item-content d-sm-flex flex-grow"">
                                    <div class=""flex-grow"">
                                        <h6 class=""preview-subject"">");
#nullable restore
#line 23 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\LastFiveProjects\Default.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-muted mb-0\">Proje Fiyatı : ");
#nullable restore
#line 24 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\LastFiveProjects\Default.cshtml"
                                                                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"mr-auto text-sm-right pt-2 pt-sm-0\">\r\n                                        <p class=\"text-muted mb-0\">Tamamlanma Oranı : ");
#nullable restore
#line 27 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\LastFiveProjects\Default.cshtml"
                                                                                 Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 31 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\LastFiveProjects\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
