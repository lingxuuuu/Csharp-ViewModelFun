#pragma checksum "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_ViewModelFun\Views\Home\numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2214a51e56f3e5c15f1440ef0c3c5d0306502f6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_numbers), @"mvc.1.0.view", @"/Views/Home/numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/numbers.cshtml", typeof(AspNetCore.Views_Home_numbers))]
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
#line 1 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_ViewModelFun\Views\_ViewImports.cshtml"
using Csharp_ViewModelFun;

#line default
#line hidden
#line 2 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_ViewModelFun\Views\Home\numbers.cshtml"
using Csharp_ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2214a51e56f3e5c15f1440ef0c3c5d0306502f6c", @"/Views/Home/numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ddf632edf768642c09a38629834dd30673e86c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Number>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("    <h3>Here are some numbers!</h3>\r\n");
            EndContext();
#line 4 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_ViewModelFun\Views\Home\numbers.cshtml"
  
    foreach(var x in @Model.list){

#line default
#line hidden
            BeginContext(127, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(139, 1, false);
#line 6 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_ViewModelFun\Views\Home\numbers.cshtml"
      Write(x);

#line default
#line hidden
            EndContext();
            BeginContext(140, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 7 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_ViewModelFun\Views\Home\numbers.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Number> Html { get; private set; }
    }
}
#pragma warning restore 1591
