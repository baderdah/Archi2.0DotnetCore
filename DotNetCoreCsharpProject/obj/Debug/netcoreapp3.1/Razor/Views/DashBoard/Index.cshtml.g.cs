#pragma checksum "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "664f82ac99fb645d00b1500e314de3ee81fa83a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_Index), @"mvc.1.0.view", @"/Views/DashBoard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664f82ac99fb645d00b1500e314de3ee81fa83a5", @"/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d62047196b3bb28c903d31d84d9ba245fe5b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCoreCsharpProject.ViewModels.UsersTabViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tabname", "Calendrier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SwitchToTabs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tabname", "ListePfeInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tabname", "ListePfeGtr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- model DotNetCoreCsharpProject.-->\n");
            WriteLiteral(@"
 <h1>Dashboard</h1>
 <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
     <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
         <span class=""navbar-toggler-icon""></span>
     </button>
     <div class=""collapse navbar-collapse"" id=""navbarNav"">
         <ul class=""navbar-nav"">
             <li role=""presentation""");
            BeginWriteAttribute("class", " class=\"", 597, "\"", 712, 2);
            WriteAttributeValue("", 605, "nav-item", 605, 8, true);
#nullable restore
#line 16 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
WriteAttributeValue(" ", 613, Model.ActiveTab == DotNetCoreCsharpProject.ViewModels.Tab.Calendrier ? "active" : string.Empty , 614, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "664f82ac99fb645d00b1500e314de3ee81fa83a56390", async() => {
                WriteLiteral("Calendrier   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tabname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tabname"] = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n             <li role=\"presentation\"");
            BeginWriteAttribute("class", " class=\"", 850, "\"", 968, 2);
            WriteAttributeValue("", 858, "nav-item", 858, 8, true);
#nullable restore
#line 17 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
WriteAttributeValue("  ", 866, Model.ActiveTab == DotNetCoreCsharpProject.ViewModels.Tab.ListePfeInfo ? "active" : string.Empty , 868, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "664f82ac99fb645d00b1500e314de3ee81fa83a58786", async() => {
                WriteLiteral("Liste des Pfe Info    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tabname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tabname"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n             <li role=\"presentation\"");
            BeginWriteAttribute("class", " class=\"", 1117, "\"", 1234, 2);
            WriteAttributeValue("", 1125, "nav-item", 1125, 8, true);
#nullable restore
#line 18 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
WriteAttributeValue("  ", 1133, Model.ActiveTab == DotNetCoreCsharpProject.ViewModels.Tab.ListePfeGtr ? "active" : string.Empty , 1135, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "664f82ac99fb645d00b1500e314de3ee81fa83a511195", async() => {
                WriteLiteral("Liste des Pfe GTR   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tabname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tabname"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n             <li role=\"presentation\"");
            BeginWriteAttribute("class", " class=\"", 1380, "\"", 1498, 2);
            WriteAttributeValue("", 1388, "nav-item", 1388, 8, true);
#nullable restore
#line 19 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
WriteAttributeValue("  ", 1396, Model.ActiveTab == DotNetCoreCsharpProject.ViewModels.Tab.PlanningSout ? "active" : string.Empty , 1398, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 1502, "\"", 1556, 2);
            WriteAttributeValue("", 1509, "/Files/planning/", 1509, 16, true);
#nullable restore
#line 19 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
WriteAttributeValue("", 1525, ViewBag.PlanningSoutenanceFile, 1525, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"nav-link\">afficher le planning</a></li>\n         </ul>\n     </div>\n </nav>\n\n");
#nullable restore
#line 24 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
      switch (Model.ActiveTab)
     {
         case DotNetCoreCsharpProject.ViewModels.Tab.Calendrier:
             

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
        Write(await Component.InvokeAsync("Calendrier"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
                                                       ;
             break;
         case DotNetCoreCsharpProject.ViewModels.Tab.ListePfeInfo:
             

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
        Write(await Component.InvokeAsync("ListePfeInfo"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
                                                         ;
             break;
         case DotNetCoreCsharpProject.ViewModels.Tab.ListePfeGtr:
             

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
        Write(await Component.InvokeAsync("ListePfeGtr"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
                                                        ;
             break;
         case DotNetCoreCsharpProject.ViewModels.Tab.PlanningSout:
             

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
        Write(await Component.InvokeAsync("PlanningSout"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\DashBoard\Index.cshtml"
                                                         ;
             break;
         default:
             break;
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetCoreCsharpProject.ViewModels.UsersTabViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
