#pragma checksum "C:\Projects\AE\CSharpSpaceXApp\CSharpSpaceXApp\Views\Error\APIError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d74bc1c952724c1086372c950939ea524db0034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_APIError), @"mvc.1.0.view", @"/Views/Error/APIError.cshtml")]
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
#line 1 "C:\Projects\AE\CSharpSpaceXApp\CSharpSpaceXApp\Views\_ViewImports.cshtml"
using CSharpSpaceXApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\AE\CSharpSpaceXApp\CSharpSpaceXApp\Views\_ViewImports.cshtml"
using CSharpSpaceXApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d74bc1c952724c1086372c950939ea524db0034", @"/Views/Error/APIError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af8fb68bfdf60918f569f0bae7ba7b9c475bf1ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_APIError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\AE\CSharpSpaceXApp\CSharpSpaceXApp\Views\Error\APIError.cshtml"
  
    ViewBag.Title = "Error occurred";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\AE\CSharpSpaceXApp\CSharpSpaceXApp\Views\Error\APIError.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>We have a problem</h1>

<p>Sorry, an error occurred while executing your request. The SpaceX API is not responding</p>
<p>Plese, try again later!</p>
<div class=""space-pic"">
    <img src=""https://miro.medium.com/max/3780/1*teBtR_0pirBnX4nURoMvLA.jpeg"" width=""1135"" height=""500""/>
</div>");
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