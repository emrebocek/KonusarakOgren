#pragma checksum "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e145c1d4141ce44727aa6f5cbfddc093e3f96de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_test_soru), @"mvc.1.0.view", @"/Views/test/soru.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/test/soru.cshtml", typeof(AspNetCore.Views_test_soru))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e145c1d4141ce44727aa6f5cbfddc093e3f96de", @"/Views/test/soru.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac675bbd588573610e9d0ceb70e69c3ea24a6c8a", @"/Views/_ViewImports.cshtml")]
    public class Views_test_soru : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<soruGetir>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
  
    ViewData["Title"] = "soru";
    int i = 0;
    int j = 0;

#line default
#line hidden
            BeginContext(105, 349, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88a71937763d4f55a85c643ac1a387a8", async() => {
                BeginContext(111, 336, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.4/jquery.min.js""></script>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(454, 37, true);
            WriteLiteral("\r\n    <div align=\"center\">\r\n\r\n<label>");
            EndContext();
            BeginContext(492, 14, false);
#line 15 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
  Write(ViewBag.baslik);

#line default
#line hidden
            EndContext();
            BeginContext(506, 111, true);
            WriteLiteral("</label>\r\n<br />\r\n\r\n<textarea id=\"konu\" style=\"margin: 0px; height: 242px; width: 500px; resize:none\" readonly>");
            EndContext();
            BeginContext(618, 14, false);
#line 18 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
                                                                                      Write(ViewBag.icerik);

#line default
#line hidden
            EndContext();
            BeginContext(632, 55, true);
            WriteLiteral("</textarea>\r\n<br />\r\n</div>\r\n    <div align=\"center\">\r\n");
            EndContext();
#line 22 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(738, 102, true);
            WriteLiteral("            <label id=\"\" placeholder=\"Soru giriniz\" style=\"margin: 0px; height: 25px; width: 500px; \">");
            EndContext();
            BeginContext(841, 12, false);
#line 25 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
                                                                                                 Write(item.sorular);

#line default
#line hidden
            EndContext();
            BeginContext(853, 63, true);
            WriteLiteral("</label>\r\n            <br />\r\n            <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 916, "\"", 923, 1);
#line 27 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 921, j, 921, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(924, 71, true);
            WriteLiteral(" style=\"margin: 0px; height:  25px; border-style:solid; width: 250px; \"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 995, "\"", 1006, 2);
#line 27 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1003, i, 1003, 2, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1005, "", 1006, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1007, "\"", 1031, 1);
#line 27 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1015, item.dogruCevap, 1015, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1032, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1034, 13, false);
#line 27 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
                                                                                                                                                 Write(item.secenekA);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
            BeginContext(1060, 33, true);
            WriteLiteral("            <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1093, "\"", 1104, 1);
#line 29 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1098, j+1, 1098, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1105, 71, true);
            WriteLiteral(" style=\"margin: 0px; height:  25px; border-style:solid; width: 250px; \"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1176, "\"", 1192, 2);
#line 29 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1184, i+1, 1184, 6, false);

#line default
#line hidden
            WriteAttributeValue("  ", 1190, "", 1192, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1193, "\"", 1217, 1);
#line 29 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1201, item.dogruCevap, 1201, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1218, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1220, 13, false);
#line 29 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
                                                                                                                                                          Write(item.secenekB);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 64, true);
            WriteLiteral("</button>\r\n            <br />\r\n            <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1297, "\"", 1308, 1);
#line 31 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1302, j+2, 1302, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1309, 68, true);
            WriteLiteral(" style=\"margin: 0px; height: 25px;border-style:solid; width: 250px;\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1377, "\"", 1392, 2);
#line 31 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1385, i+2, 1385, 6, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1391, "", 1392, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1393, "\"", 1417, 1);
#line 31 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1401, item.dogruCevap, 1401, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1418, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1420, 13, false);
#line 31 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
                                                                                                                                                      Write(item.secenekC);

#line default
#line hidden
            EndContext();
            BeginContext(1433, 44, true);
            WriteLiteral("</button>\r\n            <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1477, "\"", 1488, 1);
#line 32 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1482, j+3, 1482, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1489, 68, true);
            WriteLiteral(" style=\"margin: 0px; height: 25px;border-style:solid; width: 250px;\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1557, "\"", 1571, 1);
#line 32 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1565, i+3, 1565, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1572, "\"", 1596, 1);
#line 32 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
WriteAttributeValue("", 1580, item.dogruCevap, 1580, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1597, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1599, 13, false);
#line 32 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
                                                                                                                                                     Write(item.secenekD);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 31, true);
            WriteLiteral("</button>\r\n            <br />\r\n");
            EndContext();
#line 34 "C:\Users\Emre\source\repos\KonusarakOgren\KonusarakOgren\Views\test\soru.cshtml"
            i += 4;
            j += 4;
        }

#line default
#line hidden
            BeginContext(1696, 3194, true);
            WriteLiteral(@"        <button id=""gonder"" class=""btn btn-success"">Sınavı tamamla</button>
    </div>




<script type=""text/javascript"">
    var id1 = """";
    var sınıf1 = """";
    var id2 = """";
    var sınıf2 = """";
    var id3 = """";
    var sınıf3 = """";
    var id4 = """";
    var sınıf4 = """";
    var i = 0;

    $(""#0"").click(function () {

        id1 = $(this).text();
        sınıf1 = $(this).attr('class');


    }
    );
    $(""#1"").click(function () {

        id1 = $(this).text();
        sınıf1 = $(this).attr('class');


    }
    );
    $(""#2"").click(function () {

        id1 = $(this).text();
        sınıf1 = $(this).attr('class');


    }
    );
    $(""#3"").click(function () {

        id1 = $(this).text();
        sınıf1 = $(this).attr('class');


    }
    );
    $(""#4"").click(function () {

        id2 = $(this).text();
        sınıf2 = $(this).attr('class');


    }
    );
    $(""#5"").click(function () {

        id2 = $(this).text();
        sınıf2 =");
            WriteLiteral(@" $(this).attr('class');


    }
    );
    $(""#6"").click(function () {

        id2 = $(this).text();
        sınıf2 = $(this).attr('class');


    }
    );
    $(""#7"").click(function () {

        id2 = $(this).text();
        sınıf2 = $(this).attr('class');


    }
    );
    $(""#8"").click(function () {

        id3 = $(this).text();
        sınıf3 = $(this).attr('class');

    }
    );
    $(""#9"").click(function () {

        id3 = $(this).text();
        sınıf3 = $(this).attr('class');


    }
    );
    $(""#10"").click(function () {

        id3 = $(this).text();
        sınıf3 = $(this).attr('class');

    }
    );
    $(""#11"").click(function () {

        id3 = $(this).text();
        sınıf3 = $(this).attr('class');


    }
    );
    $(""#12"").click(function () {

        id4 = $(this).text();
        sınıf4 = $(this).attr('class');


    }
    );
    $(""#13"").click(function () {

        id4 = $(this).text();
        sınıf4 = $(this).attr('c");
            WriteLiteral(@"lass');

    }
    );
    $(""#14"").click(function () {

        id4 = $(this).text();
        sınıf4 = $(this).attr('class');


    }
    );
    $(""#15"").click(function () {

        id4 = $(this).text();
        sınıf4 = $(this).attr('class');


    }
    );

    $(""#gonder"").click(function () {

        if (id1 == $(""#0"").val()) {

            $(""."" + sınıf1).css('background', 'green')

        }
        else
            $(""."" + sınıf1).css('background', 'red')
        if (id2 == $(""#4"").val()) {
            $(""."" + sınıf2).css('background', 'green')

        }
        else
            $(""."" + sınıf2).css('background', 'red')
        if (id3 == $(""#8"").val()) {


            $(""."" + sınıf3).css('background', 'green')

        }
        else
            $(""."" + sınıf3).css('background', 'red')
        if (id4 == $(""#12"").val()) {

            $(""."" + sınıf4).css('background', 'green')

        }
        else
            $(""."" + sınıf4).css('background', 'red'");
            WriteLiteral(")\r\n        $(\"#gonder\").attr(\'disabled\', \'true\');\r\n        $(\"div button\").attr(\'disabled\', \'true\');\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<soruGetir>> Html { get; private set; }
    }
}
#pragma warning restore 1591
