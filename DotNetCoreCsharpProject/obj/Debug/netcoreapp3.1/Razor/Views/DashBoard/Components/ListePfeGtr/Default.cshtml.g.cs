#pragma checksum "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f86695fe28b66c9649b0aa42fb7b0636ab85a2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_Components_ListePfeGtr_Default), @"mvc.1.0.view", @"/Views/DashBoard/Components/ListePfeGtr/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f86695fe28b66c9649b0aa42fb7b0636ab85a2f", @"/Views/DashBoard/Components/ListePfeGtr/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d62047196b3bb28c903d31d84d9ba245fe5b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_DashBoard_Components_ListePfeGtr_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotNetCoreCsharpProject.ViewModels.GroupsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <th>#</th>\n        <th>Membres</th>\n        <th>Encadrant Interne</th>\n        <th>Sujet et Ville</th>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 12 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
         foreach (var grp in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 16 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
               Write(Html.DisplayFor(modelItem => grp.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 19 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
                     foreach (var student in grp.students)
                    {
                        string fullNameStd = student.LastName + ' ' + student.FirstName;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
                   Write(Html.DisplayFor(modelItem => fullNameStd));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\n");
#nullable restore
#line 24 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n                <td>\n");
#nullable restore
#line 27 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
                      
                        string fullNameEnc = grp.encadrant.LastName + ' ' + grp.encadrant.FirstName;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
                   Write(Html.DisplayFor(modelItem => fullNameEnc));

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n                <td>\n                    ");
#nullable restore
#line 34 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
               Write(Html.DisplayFor(modelItem => grp.sujet));

#line default
#line hidden
#nullable disable
            WriteLiteral(".[\n                    ");
#nullable restore
#line 35 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
               Write(Html.DisplayFor(modelItem => grp.ville));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ]\n                </td>\n\n            </tr>\n");
#nullable restore
#line 39 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Components\ListePfeGtr\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotNetCoreCsharpProject.ViewModels.GroupsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591