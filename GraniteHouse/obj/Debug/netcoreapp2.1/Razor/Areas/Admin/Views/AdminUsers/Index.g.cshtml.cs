#pragma checksum "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3feaefaa15b38a3368fb6c6cad8c29b07287bbed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminUsers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminUsers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminUsers/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminUsers_Index))]
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
#line 1 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse;

#line default
#line hidden
#line 2 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3feaefaa15b38a3368fb6c6cad8c29b07287bbed", @"/Areas/Admin/Views/AdminUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add87ae52faa7df67fbebca5d3c39a845d0e03fe", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GraniteHouse.Models.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 170, true);
            WriteLiteral("\r\n<br /><br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Admin User list</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(270, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5ca079fa289417cb7ccadf9a0f92d22", async() => {
                BeginContext(343, 41, true);
                WriteLiteral("<i class=\"fas fa-plus\">&nbsp;</i>New User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(388, 141, true);
            WriteLiteral("        \r\n    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<table class=\"table table-striped border\">\r\n    <tr class=\"table-info\">\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(530, 32, false);
#line 23 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(562, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(606, 33, false);
#line 26 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
       Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(639, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(683, 39, false);
#line 29 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
       Write(Html.DisplayNameFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(722, 76, true);
            WriteLiteral("\r\n        </th>\r\n      \r\n        <th></th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 36 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(839, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(888, 31, false);
#line 40 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
           Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(919, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(975, 34, false);
#line 43 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
           Write(String.Format("{0:c}", item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1065, 38, false);
#line 46 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
           Write(Html.DisplayFor(m => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 49 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                 if(item.LockoutEnd !=null && item.LockoutEnd>DateTime.Now)
                {

#line default
#line hidden
            BeginContext(1238, 45, true);
            WriteLiteral("                    <label>Disabled</label>\r\n");
            EndContext();
#line 52 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1302, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 55 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                 if (item.LockoutEnd == null || item.LockoutEnd < DateTime.Now)
                {

#line default
#line hidden
            BeginContext(1439, 60, true);
            WriteLiteral("                    <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1499, "\"", 1534, 1);
#line 57 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
WriteAttributeValue("", 1506, Url.Action("Edit/"+item.Id), 1506, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1535, 142, true);
            WriteLiteral(">\r\n                        <i class=\"fas fa-edit\"></i>\r\n                    </a>\r\n                    <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1677, "\"", 1714, 1);
#line 60 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
WriteAttributeValue("", 1684, Url.Action("Delete/"+item.Id), 1684, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1715, 87, true);
            WriteLiteral(">\r\n                        <i class=\"fas fa-trash-alt\"></i>\r\n                    </a>\r\n");
            EndContext();
#line 63 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1821, 47, true);
            WriteLiteral("            </td>\r\n           \r\n        </tr>\r\n");
            EndContext();
#line 67 "E:\Veni\Learning Material\netCore2.1\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1875, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GraniteHouse.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
