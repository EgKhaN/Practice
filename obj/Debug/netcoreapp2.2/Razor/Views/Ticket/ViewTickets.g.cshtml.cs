#pragma checksum "C:\Users\EgK\source\repos\Alıştırma\Views\Ticket\ViewTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cce15d3c5e9fa28f6be374086944048ef989091"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_ViewTickets), @"mvc.1.0.view", @"/Views/Ticket/ViewTickets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/ViewTickets.cshtml", typeof(AspNetCore.Views_Ticket_ViewTickets))]
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
#line 1 "C:\Users\EgK\source\repos\Alıştırma\Views\_ViewImports.cshtml"
using Alıştırma.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cce15d3c5e9fa28f6be374086944048ef989091", @"/Views/Ticket/ViewTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae5155ed3462aa5d55c26ce7055510ee6ea9780", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_ViewTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ticket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\EgK\source\repos\Alıştırma\Views\Ticket\ViewTickets.cshtml"
  
    ViewData["Title"] = "ViewTasks";

#line default
#line hidden
            BeginContext(73, 30, true);
            WriteLiteral("\r\n<h1>ViewTasks</h1>\r\n\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\EgK\source\repos\Alıştırma\Views\Ticket\ViewTickets.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(144, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(157, 7, false);
#line 11 "C:\Users\EgK\source\repos\Alıştırma\Views\Ticket\ViewTickets.cshtml"
       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(164, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(168, 10, false);
#line 11 "C:\Users\EgK\source\repos\Alıştırma\Views\Ticket\ViewTickets.cshtml"
                  Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(178, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "C:\Users\EgK\source\repos\Alıştırma\Views\Ticket\ViewTickets.cshtml"
    }

#line default
#line hidden
            BeginContext(192, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
