#pragma checksum "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d63bca505157a43a20070b84f9fb4eeb1b029ef2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Shared_Components_Notification_Default), @"mvc.1.0.view", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
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
#line 2 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63bca505157a43a20070b84f9fb4eeb1b029ef2", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d314c8e2aa5a546823ab8834bcf8eff5eedb3a6", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Shared_Components_Notification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
   string color = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <p class=\"mb-0 font-weight-normal float-left dropdown-header\">Bildirimler</p>\r\n");
#nullable restore
#line 6 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
     foreach (var item in Model)
    {
        if (item.Status == "Yeni Yazı")
        {
            color = "preview-icon bg-success";
        }
        if (item.Status == "Spor")
        {
            color = "preview-icon bg-warning";
        }
        if (item.Status == "Eğitim")
        {
            color = "preview-icon bg-secondary";
        }
        if (item.Status == "Bilim")
        {
            color = "preview-icon bg-primary";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a class=\"dropdown-item preview-item\"");
            BeginWriteAttribute("href", " href=\"", 770, "\"", 821, 2);
            WriteAttributeValue("", 777, "/Writer/Default/AnnouncementDetails/", 777, 36, true);
#nullable restore
#line 24 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue("", 813, item.ID, 813, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"preview-thumbnail\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 882, "\"", 896, 1);
#nullable restore
#line 26 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue("", 890, color, 890, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i class=\"ti-info-alt mx-0\"></i>\r\n            </div>\r\n        </div>\r\n        <div class=\"preview-item-content\">\r\n            <h6 class=\"preview-subject font-weight-normal\">");
#nullable restore
#line 31 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p class=\"font-weight-light small-text mb-0 text-muted\">\r\n                ");
#nullable restore
#line 33 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </a>\r\n");
#nullable restore
#line 37 "C:\Users\aa\Desktop\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
