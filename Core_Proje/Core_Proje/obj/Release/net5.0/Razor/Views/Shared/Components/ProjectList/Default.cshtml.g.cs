#pragma checksum "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea1b373cc9e2fb1f88c5bea6618bd385bb28f4e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea1b373cc9e2fb1f88c5bea6618bd385bb28f4e9", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1666001c2ad5ef6477b3166cd500a7db9edb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Ana Görsel</th>
                                <th>Proje Adı</th>
                                <th>URL</th>
                                <th>Fiyat</th>
                                <th>Tamamlanma Oranı</th>
                                <th>Durum</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 22 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 25 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.PortfolioID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><img");
            BeginWriteAttribute("src", " src=\"", 1042, "\"", 1062, 1);
#nullable restore
#line 26 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1048, item.ImageUrl, 1048, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.PorjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1371, "\"", 1420, 2);
            WriteAttributeValue("", 1378, "/Portfolio/EditPortfolio/", 1378, 25, true);
#nullable restore
#line 32 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1403, item.PortfolioID, 1403, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div class=\"badge badge-outline-success\">Detayları Gör</div></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
