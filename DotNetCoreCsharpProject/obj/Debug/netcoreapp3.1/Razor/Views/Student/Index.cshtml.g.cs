#pragma checksum "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7cbf4ca9f9a8990a029cc63907bb7a11c54b9fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\_ViewImports.cshtml"
using DotNetCoreCsharpProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\_ViewImports.cshtml"
using DotNetCoreCsharpProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cbf4ca9f9a8990a029cc63907bb7a11c54b9fd", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d62047196b3bb28c903d31d84d9ba245fe5b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DotNetCoreCsharpProject.Entities.Students>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div id=\"division\" class=\"container-fluid p-1 bg-dark text-white\">\n\n");
#nullable restore
#line 9 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
             if (Model.Count() >= 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""d-flex m-3 justify-content-center"">
            <button type=""button"" onclick=""location.href ='/Student/addReport?id=1'"" class=""btn-lg btn-primary m-4"">Rapport d'avancement 1</button>
            <button type=""button"" onclick=""location.href ='/Student/addReport?id=2'"" class=""btn-lg btn-warning m-4"">Rapport d'avancement 2</button>
            <button type=""button"" onclick=""location.href ='/Student/addReport?id=3'"" class=""btn-lg btn-danger m-4"">Rapport d'avancement 3</button>
            <button type=""button"" onclick=""location.href ='/Student/addReport?id=4'"" class=""btn-lg btn-light m-4"">Rapport d'avancement 4</button>

        </div>
                <h1 class=""text-center text-white"">Bonjour ");
#nullable restore
#line 18 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                                                      Write(ViewBag.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\n");
            WriteLiteral(@"                <div>
                    <h1 class=""text-center text-white"">Mon groupe </h1>

                    <table id=""tblStudent"" class=""table table-bordered table-striped table-hover"">
                        <thead>
                            <tr>
                                <th align=""left"" class=""productth text-white"">Nom</th>
                                <th align=""left"" class=""productth text-white"">Email</th>
                                <th align=""left"" class=""productth text-white"">Phone</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 32 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                              
                                foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td class=\"prtoducttd text-white\">");
#nullable restore
#line 36 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                                                                     Write(item.IdUserNavigation.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 36 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                                                                                                     Write(item.IdUserNavigation.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"prtoducttd text-white\">");
#nullable restore
#line 37 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                                                                     Write(item.IdUserNavigation.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                        <td class=\"prtoducttd text-white\">");
#nullable restore
#line 38 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                                                                     Write(item.IdUserNavigation.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                    </tr>\n");
#nullable restore
#line 40 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                        <div class=""d-flex m-3 justify-content-center"">
                        <button type=""button"" id=""newGrp"" onclick=""location.href ='/Student/addReport?id=5'"" class=""btn-lg btn-success m-4"">Rapport final</button>
                        </div>
                    </div>
");
#nullable restore
#line 48 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                     if (Model.Count() == 1 && Model.FirstOrDefault().GroupId == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1 class=\"text-center text-white\">Bonjour ");
#nullable restore
#line 51 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"
                                                              Write(ViewBag.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                        <h1 class=""text-center text-white"">Pensez à créer votre groupe </h1>
                        <div class=""d-flex m-3 justify-content-center"">
                            <button type=""button"" id=""newGrp"" onclick=""location.href ='/Student/addNewGroup'"" class=""btn-lg btn-info m-4"">Add a new Group</button>
                        </div>
");
#nullable restore
#line 56 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Student\Index.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DotNetCoreCsharpProject.Entities.Students>> Html { get; private set; }
    }
}
#pragma warning restore 1591
