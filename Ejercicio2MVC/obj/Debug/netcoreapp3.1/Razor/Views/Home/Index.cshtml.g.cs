#pragma checksum "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d050a0f591785faa340126910b6f94926418ff13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\_ViewImports.cshtml"
using Ejercicio2MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\_ViewImports.cshtml"
using Ejercicio2MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d050a0f591785faa340126910b6f94926418ff13", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c13048f3a6aade94c96a7ed64c7798e42aa0692", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>EJERCICIO 2: Indicar cual es el Mayor y Menor</h1>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 4 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
         using (Html.BeginForm("Index", "Home", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 228, "\"", 236, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                ");
#nullable restore
#line 9 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number1,
                   new { @class = "form-control", placeholder = "Numero 1",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 11 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number1, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 13 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number2,
                   new { @class = "form-control", placeholder = "Numero 2",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number2, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 17 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number3,
                       new { @class = "form-control", placeholder = "Numero 3",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number3, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 21 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number4,
                       new { @class = "form-control", placeholder = "Numero 4",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 23 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number4, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 25 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number5,
                       new { @class = "form-control", placeholder = "Numero 5",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number5, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 29 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number6,
                       new { @class = "form-control", placeholder = "Numero 6",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number6, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 33 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number7,
                       new { @class = "form-control", placeholder = "Numero 7",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number7, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 37 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number8,
                       new { @class = "form-control", placeholder = "Numero 8",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number8, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 41 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number9,
                       new { @class = "form-control", placeholder = "Numero 9",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 43 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number9, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 45 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(x => x.number10,
                       new { @class = "form-control", placeholder = "Numero 10",type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 47 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.number10, null, new { @class = "txt" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                <button class=\"btn btn-primary\" type=\"submit\">\r\n                    Enviar numeros\r\n                </button>\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin-left:5%\">\r\n            <br />\r\n            <p class=\"text-muted\">El numero Mayor Es: ");
#nullable restore
#line 57 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                 Write(ViewData["NumeroMax"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br />\r\n            <p class=\"text-muted\">El numero Menor Es: ");
#nullable restore
#line 59 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                 Write(ViewData["NumeroMin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div style=\"margin:5%\">\r\n            <h4>Suma de los digitos</h4>\r\n            <table style=\"border:inset\" class=\"table table-dark\">\r\n                \r\n                <tr style=\"border:black 3px;\">\r\n");
#nullable restore
#line 67 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 69 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma0" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 70 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n");
#nullable restore
#line 74 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 76 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma1" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 77 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n");
#nullable restore
#line 80 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 82 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma2" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 83 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n");
#nullable restore
#line 86 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 88 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma3" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 89 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n");
#nullable restore
#line 92 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 94 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma4" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 95 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n");
#nullable restore
#line 98 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 100 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma5" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 101 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n");
#nullable restore
#line 104 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 106 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma6" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 107 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n");
#nullable restore
#line 110 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 112 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma7" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 113 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n");
#nullable restore
#line 116 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 118 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma8" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 119 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n");
#nullable restore
#line 122 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                     for (int i = 0; i <= 9; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border:black 2px solid;\">");
#nullable restore
#line 124 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                                                       Write(ViewData["Suma9" + i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 125 "C:\Users\chris\source\repos\Ejercicio2MVC\Ejercicio2MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                \r\n\r\n            </table>\r\n        </div>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data> Html { get; private set; }
    }
}
#pragma warning restore 1591
