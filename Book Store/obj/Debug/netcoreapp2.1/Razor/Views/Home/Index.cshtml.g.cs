#pragma checksum "D:\Workspace\C#\Book Store\Book Store\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "529ea541c07699443c641cd53adce5d9b6ded15e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Workspace\C#\Book Store\Book Store\Views\_ViewImports.cshtml"
using BookStore.ViewModels;

#line default
#line hidden
#line 2 "D:\Workspace\C#\Book Store\Book Store\Views\_ViewImports.cshtml"
using Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529ea541c07699443c641cd53adce5d9b6ded15e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0edb5aac7262abe548a9010a48005bca61e62a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 57, true);
            WriteLiteral("\r\n<h1>Favourite Books</h1>\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 5 "D:\Workspace\C#\Book Store\Book Store\Views\Home\Index.cshtml"
      
        foreach (Book book in Model.favBooks)
        {
            

#line default
#line hidden
            BeginContext(158, 31, false);
#line 8 "D:\Workspace\C#\Book Store\Book Store\Views\Home\Index.cshtml"
       Write(Html.Partial("_AllBooks", book));

#line default
#line hidden
            EndContext();
#line 8 "D:\Workspace\C#\Book Store\Book Store\Views\Home\Index.cshtml"
                                            
        }
    

#line default
#line hidden
            BeginContext(209, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591