#pragma checksum "/Users/aherntb/programming/Golf.Stats/src/mvc/golf.stats/Views/ScoreCard/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daac039c849806278ada1cb0fb243fd86235a0b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ScoreCard_Index), @"mvc.1.0.view", @"/Views/ScoreCard/Index.cshtml")]
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
#line 1 "/Users/aherntb/programming/Golf.Stats/src/mvc/golf.stats/Views/_ViewImports.cshtml"
using golf.stats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aherntb/programming/Golf.Stats/src/mvc/golf.stats/Views/_ViewImports.cshtml"
using golf.stats.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daac039c849806278ada1cb0fb243fd86235a0b6", @"/Views/ScoreCard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb2b2cc4bca09f4a652c95f23c694d1eed350fd", @"/Views/_ViewImports.cshtml")]
    public class Views_ScoreCard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Score Card</h1>\n");
#nullable restore
#line 2 "/Users/aherntb/programming/Golf.Stats/src/mvc/golf.stats/Views/ScoreCard/Index.cshtml"
Write(Html.ActionLink("Post Some Stats","PostStats","ScoreCard"));

#line default
#line hidden
#nullable disable
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
