#pragma checksum "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Areas\Writer\Views\Default\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2f627ce5f99816ebef90d992d66cdaa011a6f8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default__FooterPartial), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/_FooterPartial.cshtml")]
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
#line 2 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f627ce5f99816ebef90d992d66cdaa011a6f8e", @"/Areas/Writer/Views/Default/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d314c8e2aa5a546823ab8834bcf8eff5eedb3a6", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Default__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<footer class=\"footer\">\r\n    <div class=\"d-sm-flex justify-content-center justify-content-sm-between\">\r\n        <span class=\"text-muted text-center text-sm-left d-block d-sm-inline-block\">Copyright © ");
#nullable restore
#line 4 "C:\Users\aa\Desktop\PROJELERİM\Core_Proje\Core_Proje\Areas\Writer\Views\Default\_FooterPartial.cshtml"
                                                                                           Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Tüm Hakları Saklıdır.</span>\r\n        <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\"> Asp.Net Core 5.0 Web Projesi <i class=\"ti-heart text-danger ml-1\"></i></span>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
