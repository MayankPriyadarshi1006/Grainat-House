#pragma checksum "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Views\Shared\_ButtonPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ad1c18bbe64d15f90dba159a218ada90b7c040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ButtonPartialView), @"mvc.1.0.view", @"/Views/Shared/_ButtonPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ButtonPartialView.cshtml", typeof(AspNetCore.Views_Shared__ButtonPartialView))]
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
#line 1 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Views\_ViewImports.cshtml"
using GraniteHouse;

#line default
#line hidden
#line 2 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Views\_ViewImports.cshtml"
using GraniteHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ad1c18bbe64d15f90dba159a218ada90b7c040", @"/Views/Shared/_ButtonPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add87ae52faa7df67fbebca5d3c39a845d0e03fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ButtonPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(132, 121, true);
            WriteLiteral("\r\n\r\n<td style=\"width:150px;\">\r\n    <div class=\"btn-group\" role=\"group\">\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 253, "\"", 286, 1);
#line 8 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Views\Shared\_ButtonPartialView.cshtml"
WriteAttributeValue("", 260, Url.Action("Edit/"+Model), 260, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(287, 99, true);
            WriteLiteral("><i class=\"fas fa-edit\" title=\"Edit\">Edit</i></a>\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 386, "\"", 421, 1);
#line 9 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Views\Shared\_ButtonPartialView.cshtml"
WriteAttributeValue("", 393, Url.Action("Delete/"+Model), 393, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(422, 104, true);
            WriteLiteral("><i class=\"fas fa-trash\" title=\"Delete\">Delete</i></a>\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 526, "\"", 562, 1);
#line 10 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Views\Shared\_ButtonPartialView.cshtml"
WriteAttributeValue("", 533, Url.Action("Details/"+Model), 533, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(563, 74, true);
            WriteLiteral("><i class=\"fas fa-list\" title=\"Details\">Details</i></a>\r\n    </div>\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
