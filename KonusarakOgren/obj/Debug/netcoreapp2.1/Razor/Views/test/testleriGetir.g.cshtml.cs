#pragma checksum "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\testleriGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b81479d77e2e669a9b9fdbe925fd8e89ec515561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_test_testleriGetir), @"mvc.1.0.view", @"/Views/test/testleriGetir.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/test/testleriGetir.cshtml", typeof(AspNetCore.Views_test_testleriGetir))]
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
#line 2 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\_ViewImports.cshtml"
using KonusarakOgren.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81479d77e2e669a9b9fdbe925fd8e89ec515561", @"/Views/test/testleriGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac675bbd588573610e9d0ceb70e69c3ea24a6c8a", @"/Views/_ViewImports.cshtml")]
    public class Views_test_testleriGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<soru>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\testleriGetir.cshtml"
  
    ViewData["Title"] = "testleriGetir";
    int i = 1;

#line default
#line hidden
            BeginContext(86, 485, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
<a href=""/Home/Index"" class=""btn btn-primary"">Makale Oluştur</a>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Başlık</th>
            <th scope=""col""></th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\testleriGetir.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
            BeginContext(634, 56, true);
            WriteLiteral("        <tr>\r\n            \r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(691, 1, false);
#line 24 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\testleriGetir.cshtml"
                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(692, 25, true);
            WriteLiteral("</th>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 717, "\"", 743, 2);
            WriteAttributeValue("", 724, "/test/soru/", 724, 11, true);
#line 25 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\testleriGetir.cshtml"
WriteAttributeValue("", 735, item.id, 735, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(744, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(746, 11, false);
#line 25 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\testleriGetir.cshtml"
                                         Write(item.baslik);

#line default
#line hidden
            EndContext();
            BeginContext(757, 29, true);
            WriteLiteral("</a></td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 786, "\"", 811, 2);
            WriteAttributeValue("", 793, "/test/sil/", 793, 10, true);
#line 26 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\testleriGetir.cshtml"
WriteAttributeValue("", 803, item.id, 803, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(812, 43, true);
            WriteLiteral(">Sil</a></td>\r\n           \r\n        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\testleriGetir.cshtml"
            i++;
        }

#line default
#line hidden
            BeginContext(884, 16, true);
            WriteLiteral("\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<soru>> Html { get; private set; }
    }
}
#pragma warning restore 1591