#pragma checksum "C:\Users\tengh\OneDrive\桌面\CodingDojo\03302019 C#_from now on\ORM\delicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3df0050e08284ffeba53c53e4b603c11e11056f5"
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
#line 1 "C:\Users\tengh\OneDrive\桌面\CodingDojo\03302019 C#_from now on\ORM\delicious\Views\_ViewImports.cshtml"
using delicious;

#line default
#line hidden
#line 1 "C:\Users\tengh\OneDrive\桌面\CodingDojo\03302019 C#_from now on\ORM\delicious\Views\Home\Index.cshtml"
using delicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df0050e08284ffeba53c53e4b603c11e11056f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd5c177e80329bdfee9122de6b0e9098ab09c8dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 127, true);
            WriteLiteral("\r\n<h2>Welcome to CRUDelicious</h2>\r\n<p>Check out some recent dishes</p>\r\n<button><a href=\"/new\">Add a Dish</a></button>\r\n<hr>\r\n");
            EndContext();
#line 8 "C:\Users\tengh\OneDrive\桌面\CodingDojo\03302019 C#_from now on\ORM\delicious\Views\Home\Index.cshtml"
 foreach(var d in @Model){

#line default
#line hidden
            BeginContext(199, 7, true);
            WriteLiteral("  <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 206, "\"", 222, 1);
#line 9 "C:\Users\tengh\OneDrive\桌面\CodingDojo\03302019 C#_from now on\ORM\delicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 213, d.DishId, 213, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(223, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(225, 6, false);
#line 9 "C:\Users\tengh\OneDrive\桌面\CodingDojo\03302019 C#_from now on\ORM\delicious\Views\Home\Index.cshtml"
                    Write(d.Name);

#line default
#line hidden
            EndContext();
            BeginContext(231, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(240, 6, false);
#line 9 "C:\Users\tengh\OneDrive\桌面\CodingDojo\03302019 C#_from now on\ORM\delicious\Views\Home\Index.cshtml"
                                   Write(d.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(246, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "C:\Users\tengh\OneDrive\桌面\CodingDojo\03302019 C#_from now on\ORM\delicious\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
