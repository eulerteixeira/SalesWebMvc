#pragma checksum "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63fc1e67e77c39a213a34f5dbf11b77139c1bb43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Index), @"mvc.1.0.view", @"/Views/Sellers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Index.cshtml", typeof(AspNetCore.Views_Sellers_Index))]
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
#line 1 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63fc1e67e77c39a213a34f5dbf11b77139c1bb43", @"/Views/Sellers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc.Models.Seller>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
  
    ViewData["Title"] = "Sellers";

#line default
#line hidden
            BeginContext(90, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(97, 17, false);
#line 6 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(114, 147, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n       <thead>\r\n           <tr class=\"success\">\r\n               <th>\r\n                   ");
            EndContext();
            BeginContext(262, 40, false);
#line 12 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
              Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(302, 64, true);
            WriteLiteral("\r\n               </th>\r\n               <th>\r\n                   ");
            EndContext();
            BeginContext(367, 41, false);
#line 15 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
              Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(408, 64, true);
            WriteLiteral("\r\n               </th>\r\n               <th>\r\n                   ");
            EndContext();
            BeginContext(473, 45, false);
#line 18 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
              Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(518, 64, true);
            WriteLiteral("\r\n               </th>\r\n               <th>\r\n                   ");
            EndContext();
            BeginContext(583, 46, false);
#line 21 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
              Write(Html.DisplayNameFor(model => model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(629, 75, true);
            WriteLiteral("\r\n               </th>\r\n           </tr>\r\n       </thead>\r\n       <tbody>\r\n");
            EndContext();
#line 26 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
            foreach (var item in Model)
           {

#line default
#line hidden
            BeginContext(759, 57, true);
            WriteLiteral("           <tr>\r\n               <td>\r\n                   ");
            EndContext();
            BeginContext(817, 39, false);
#line 30 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
              Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(856, 64, true);
            WriteLiteral("\r\n               </td>\r\n               <td>\r\n                   ");
            EndContext();
            BeginContext(921, 40, false);
#line 33 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
              Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(961, 64, true);
            WriteLiteral("\r\n               </td>\r\n               <td>\r\n                   ");
            EndContext();
            BeginContext(1026, 44, false);
#line 36 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
              Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 64, true);
            WriteLiteral("\r\n               </td>\r\n               <td>\r\n                   ");
            EndContext();
            BeginContext(1135, 45, false);
#line 39 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
              Write(Html.DisplayFor(modelItem => item.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 42, true);
            WriteLiteral("\r\n               </td>\r\n           </tr>\r\n");
            EndContext();
#line 42 "C:\Course\Secao17\SalesWebMVC\SalesWebMvc\Views\Sellers\Index.cshtml"
           }

#line default
#line hidden
            BeginContext(1236, 42, true);
            WriteLiteral("\r\n\r\n\r\n       </tbody>\r\n       </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc.Models.Seller>> Html { get; private set; }
    }
}
#pragma warning restore 1591
