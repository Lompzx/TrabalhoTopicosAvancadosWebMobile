#pragma checksum "E:\Projetos\Trabalho\Views\CaseMode\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b3913fe930ca52590fcad3bfa6e400ccaa07249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaseMode_Index), @"mvc.1.0.view", @"/Views/CaseMode/Index.cshtml")]
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
#line 1 "E:\Projetos\Trabalho\Views\_ViewImports.cshtml"
using Trabalho;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos\Trabalho\Views\_ViewImports.cshtml"
using Trabalho.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3913fe930ca52590fcad3bfa6e400ccaa07249", @"/Views/CaseMode/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"144a28452bbadd1937956901db50b7659e4dc440", @"/Views/_ViewImports.cshtml")]
    public class Views_CaseMode_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CaseModeModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <a href=\"/CaseMode/Create\" class=\"btn btn-info\">Adicionar</a>\r\n    </div>\r\n</div>\r\n<br/>\r\n\r\n<div class=\"container\">    \r\n    <div class=\"row d-flex justify-content-center\">\r\n");
#nullable restore
#line 12 "E:\Projetos\Trabalho\Views\CaseMode\Index.cshtml"
         foreach (var item in Model)
        {            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-group\" style=\"margin: 5px;\">\r\n                <div class=\"card\" style=\"width: 18rem; padding: 1px;\">\r\n                    <img style=\"max-height: 250px;\"");
            BeginWriteAttribute("src", " src=\"", 510, "\"", 530, 1);
#nullable restore
#line 16 "E:\Projetos\Trabalho\Views\CaseMode\Index.cshtml"
WriteAttributeValue("", 516, item.ImageUrl, 516, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 552, "\"", 572, 1);
#nullable restore
#line 16 "E:\Projetos\Trabalho\Views\CaseMode\Index.cshtml"
WriteAttributeValue("", 558, item.ImageUrl, 558, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 18 "E:\Projetos\Trabalho\Views\CaseMode\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <h3>R$");
#nullable restore
#line 19 "E:\Projetos\Trabalho\Views\CaseMode\Index.cshtml"
                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 20 "E:\Projetos\Trabalho\Views\CaseMode\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>                            \r\n                        </div>\r\n                        <div class=\"card-footer\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 959, "\"", 991, 2);
            WriteAttributeValue("", 966, "/CaseMode/detail/", 966, 17, true);
#nullable restore
#line 23 "E:\Projetos\Trabalho\Views\CaseMode\Index.cshtml"
WriteAttributeValue("", 983, item.Id, 983, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"card-text\"><small class=\"text-muted\">Detalhes..</small></a>\r\n                        </div>\r\n                </div>                    \r\n            </div>            \r\n");
#nullable restore
#line 27 "E:\Projetos\Trabalho\Views\CaseMode\Index.cshtml"
        }    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CaseModeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
