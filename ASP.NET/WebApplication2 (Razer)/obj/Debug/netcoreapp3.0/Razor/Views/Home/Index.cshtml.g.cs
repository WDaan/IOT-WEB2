#pragma checksum "C:\Users\daanw\Documents\GitHub\IOT-WEB2\ASP.NET\WebApplication2 (Razer)\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2180d5d2b87cd7a3521310608b18b20ef4e7f670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2180d5d2b87cd7a3521310608b18b20ef4e7f670", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2__Razer_.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\daanw\Documents\GitHub\IOT-WEB2\ASP.NET\WebApplication2 (Razer)\Views\Home\Index.cshtml"
  
    //TODO 03: View zonder shared layout
    //Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 22 "C:\Users\daanw\Documents\GitHub\IOT-WEB2\ASP.NET\WebApplication2 (Razer)\Views\Home\Index.cshtml"
  
    //TODO 04: View met shared layout

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 30 "C:\Users\daanw\Documents\GitHub\IOT-WEB2\ASP.NET\WebApplication2 (Razer)\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Product name..."; //title van de pagina

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div data-ProductID=\"");
#nullable restore
#line 34 "C:\Users\daanw\Documents\GitHub\IOT-WEB2\ASP.NET\WebApplication2 (Razer)\Views\Home\Index.cshtml"
                Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-Stocklevel=\"");
#nullable restore
#line 34 "C:\Users\daanw\Documents\GitHub\IOT-WEB2\ASP.NET\WebApplication2 (Razer)\Views\Home\Index.cshtml"
                                                   Write(ViewBag.StockLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <div>Product name: ");
#nullable restore
#line 35 "C:\Users\daanw\Documents\GitHub\IOT-WEB2\ASP.NET\WebApplication2 (Razer)\Views\Home\Index.cshtml"
                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Product Price: ");
#nullable restore
#line 36 "C:\Users\daanw\Documents\GitHub\IOT-WEB2\ASP.NET\WebApplication2 (Razer)\Views\Home\Index.cshtml"
                    Write($"{Model.Price:C2}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Stock Level: ");
#nullable restore
#line 37 "C:\Users\daanw\Documents\GitHub\IOT-WEB2\ASP.NET\WebApplication2 (Razer)\Views\Home\Index.cshtml"
                 Write(ViewBag.StockLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2__Razer_.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
