#pragma checksum "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89caf49083ed7c318d715bb9c5003ae63d101982"
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
#nullable restore
#line 1 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89caf49083ed7c318d715bb9c5003ae63d101982", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d62047196b3bb28c903d31d84d9ba245fe5b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89caf49083ed7c318d715bb9c5003ae63d1019826597", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n\r\n    <title>Archivage 2.0</title>\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 402, "\"", 412, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"descriptison\">\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 445, "\"", 455, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">

    <!-- Favicons -->
    <link href=""assets/img/favicon.png"" rel=""icon"">
    <link href=""assets/img/apple-touch-icon.png"" rel=""apple-touch-icon"">

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,700,700i|Poppins:300,400,500,700"" rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link href=""assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/animate.css/animate.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/font-awesome/css/font-awesome.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/venobox/venobox.css"" rel=""stylesheet"">

    <!-- Template Main CSS File -->
    <link href=""assets/css/style.css"" rel=""stylesheet"">

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89caf49083ed7c318d715bb9c5003ae63d1019828899", async() => {
                WriteLiteral(@"

    <!-- ======= Header ======= -->
    <header id=""header"">
        <div class=""container"">

            <div id=""logo"" class=""pull-left"">
                <!--<a href=""#hero""><img src=""assets/img/logo.png"" alt=""""></a>
                Uncomment below if you prefer to use a text logo -->
                <h1><a href=""#hero"">ARCHI 2.0</a></h1>
            </div>

            <nav id=""nav-menu-container"">
                <ul class=""nav-menu"">
                    <li class=""menu-active""><a href=""#hero"">Home</a></li>
                    <li><a href=""#about"">About Us</a></li>
                    <li><a href=""#services"">Services</a></li>
                    <li><a href=""#team"">Team</a></li>


        
");
#nullable restore
#line 60 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li >\r\n\r\n");
#nullable restore
#line 64 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml"
                                  
                                    string name = @User.Identity.Name.Split('@').ElementAt(0);
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89caf49083ed7c318d715bb9c5003ae63d10198210760", async() => {
                    WriteLiteral("Hello ");
#nullable restore
#line 67 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml"
                                                                                                         Write(name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" !<br /> Update my infos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                            <li >\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89caf49083ed7c318d715bb9c5003ae63d10198212787", async() => {
                    WriteLiteral("\r\n                                    <button type=\"submit\" class=\"nav-link btn btn-link text-dark\">Logout</button>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml"
                                                                                                                  WriteLiteral(Url.Action("Index", "Home", new { area = "" }));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 74 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml"
                        }
                        else
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li >\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89caf49083ed7c318d715bb9c5003ae63d10198216413", async() => {
                    WriteLiteral("Login");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 81 "\\Mac\Home\Desktop\dotNetS2\project\project final final copy\untitled folder 2\DotNetCoreProject\DotNetCoreCsharpProject\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    
                </ul>
            </nav><!-- #nav-menu-container -->
        </div>
    </header><!-- End Header -->
    <!-- ======= Hero Section ======= -->
    <section id=""hero"">
        <div class=""hero-container"">
            <h1>Archivage 2.0</h1>
            <h2>Fait par des étudiants, pour des étudiants.</h2>
            <a href=""#about"" class=""btn-get-started""> </a>
        </div>
    </section><!-- End Hero Section -->

    <main id=""main"">

        <!-- ======= About Section ======= -->
        <section id=""about"">
            <div class=""container"">
                <div class=""row about-container"">

                    <div class=""col-lg-6 content order-lg-1 order-2"">
                        <h2 class=""title"">Objectif </h2>
                        <p>
                            Rendre la tache d'archivage plus facile pour l'utilisateur en assurant :
                        </p>

                        <div class=""icon-box wow fadeInUp"">
         ");
                WriteLiteral("                   <div class=\"icon\"><i class=\"fa fa-clock-o\"></i></div>\r\n                            <h4 class=\"title\"><a");
                BeginWriteAttribute("href", " href=\"", 4282, "\"", 4289, 0);
                EndWriteAttribute();
                WriteLiteral(@">Rapidité</a></h4>
                            <p class=""description"">De l'accès à toutes les fonctionnalités nécessaires</p>
                        </div>

                        <div class=""icon-box wow fadeInUp"" data-wow-delay=""0.2s"">
                            <div class=""icon""><i class=""fa fa-eye""></i></div>
                            <h4 class=""title""><a");
                BeginWriteAttribute("href", " href=\"", 4662, "\"", 4669, 0);
                EndWriteAttribute();
                WriteLiteral(@">Vue Globale</a></h4>
                            <p class=""description"">Aux fonctionnalités existantes</p>
                        </div>

                        <div class=""icon-box wow fadeInUp"" data-wow-delay=""0.4s"">
                            <div class=""icon""><i class=""fa fa-shield""></i></div>
                            <h4 class=""title""><a");
                BeginWriteAttribute("href", " href=\"", 5027, "\"", 5034, 0);
                EndWriteAttribute();
                WriteLiteral(@">Sécurité</a></h4>
                            <p class=""description"">De l'accès aux données  sensibles</p>
                        </div>

                    </div>

                    <div class=""col-lg-6 background order-lg-2 order-1 wow fadeInRight""></div>
                </div>

            </div>
        </section><!-- End About Section -->
        <!-- ======= Services Section ======= -->
        <section id=""services"">
            <div class=""container wow fadeIn"">
                <div class=""section-header"">
                    <h3 class=""section-title"">Services principaux</h3>
                    <p class=""section-description""></p>
                </div>
                <div class=""row"">
                    <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.2s"">
                        <div class=""box"">
                            <div class=""icon""><a");
                BeginWriteAttribute("href", " href=\"", 5942, "\"", 5949, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-graduation-cap\"></i></a></div>\r\n                            <h4 class=\"title\"><a");
                BeginWriteAttribute("href", " href=\"", 6047, "\"", 6054, 0);
                EndWriteAttribute();
                WriteLiteral(@">Inscription des étudiants</a></h4>
                            <p class=""description"">L'administrateur va importer un fichier excel contenant la liste des étudiants</p>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.4s"">
                        <div class=""box"">
                            <div class=""icon""><a");
                BeginWriteAttribute("href", " href=\"", 6466, "\"", 6473, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-user \"></i></a></div>\r\n                            <h4 class=\"title\"><a");
                BeginWriteAttribute("href", " href=\"", 6562, "\"", 6569, 0);
                EndWriteAttribute();
                WriteLiteral(@">Inscription des enseignant</a></h4>
                            <p class=""description"">L'administrateur va importer un fichier excel contenant la liste des enseignants</p>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.6s"">
                        <div class=""box"">
                            <div class=""icon""><a");
                BeginWriteAttribute("href", " href=\"", 6984, "\"", 6991, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-users \"></i></a></div>\r\n                            <h4 class=\"title\"><a");
                BeginWriteAttribute("href", " href=\"", 7081, "\"", 7088, 0);
                EndWriteAttribute();
                WriteLiteral(@">Création des groupes</a></h4>
                            <p class=""description"">L’étudiant doit s'identifier en suite le système va afficher la liste des étudiants selon son niveau pour trouver la possibilité de créer un groupe en cochant ses membres.</p>
                        </div>
                    </div>
                </div>
                </div>
        </section><!-- End Services Section -->
        <!-- ======= Team Section ======= -->
        <section id=""team"">
            <div class=""container wow fadeInUp"">
                <div class=""section-header"">
                    <h3 class=""section-title"">Équipe</h3>
                    <p class=""section-description"">Des futur ingénieurs enthousiaste</p>
                </div>
                <div class=""row"">
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""member"">
                            <div class=""pic""><img src=""assets/img/team-1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8062, "\"", 8068, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                            <h4>AZOUAY Mouad</h4>\r\n                            <span>Full Stack Developer</span>\r\n                            <div class=\"social\">\r\n\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 8278, "\"", 8285, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-google\"></i></a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 8355, "\"", 8362, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-linkedin""></i></a>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6"">
                        <div class=""member"">
                            <div class=""pic""><img src=""assets/img/team-2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8674, "\"", 8680, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                            <h4>DAHMAN Badr</h4>
                            <span>Full Stack Developer</span>
                            <div class=""social"">

                                <a href=""mailto:dahmanebader0@gmail.com""><i class=""fa fa-google""></i></a>
                                <a href=""https://www.linkedin.com/in/dahmane-badr/""><i class=""fa fa-linkedin""></i></a>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6"">
                        <div class=""member"">
                            <div class=""pic""><img src=""assets/img/team-3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 9356, "\"", 9362, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                            <h4>LIARI Samia</h4>
                            <span>Full Stack Developer</span>
                            <div class=""social"">

                                <a href=""mailto:liarisamia98@gmail.com""><i class=""fa fa-google""></i></a>
                                <a");
                BeginWriteAttribute("href", " href=\"", 9677, "\"", 9684, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-linkedin""></i></a>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6"">
                        <div class=""member"">
                            <div class=""pic""><img src=""assets/img/team-4.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 9996, "\"", 10002, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                            <h4>EL ADNANI Rachid</h4>
                            <span>Full Stack Developer & Designer</span>
                            <div class=""social"">

                                <a href=""mailto:eladnanirachid@gmail.com""><i class=""fa fa-google""></i></a>
                                <a href=""https://www.linkedin.com/in/rachid-el-adnani-78a3b618b/""><i class=""fa fa-linkedin""></i></a>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </section><!-- End Team Section -->

    </main><!-- End #main -->
    <!-- ======= Footer ======= -->
    <footer id=""footer"">
        <div class=""footer-top"">
            <div class=""container"">

            </div>
        </div>

        <div class=""container"">
            <div class=""copyright"">
                &copy; Copyright. All Rights Reserved
            </div>
        </div>
    </footer><!-- End Footer -->

 ");
                WriteLiteral(@"   <a href=""#"" class=""back-to-top""><i class=""fa fa-chevron-up""></i></a>

    <!-- Vendor JS Files -->
    <script src=""assets/vendor/jquery/jquery.min.js""></script>
    <script src=""assets/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/vendor/jquery.easing/jquery.easing.min.js""></script>
    <script src=""assets/vendor/php-email-form/validate.js""></script>
    <script src=""assets/vendor/counterup/counterup.min.js""></script>
    <script src=""assets/vendor/wow/wow.min.js""></script>
    <script src=""assets/vendor/waypoints/jquery.waypoints.min.js""></script>
    <script src=""assets/vendor/superfish/superfish.min.js""></script>
    <script src=""assets/vendor/hoverIntent/hoverIntent.js""></script>
    <script src=""assets/vendor/venobox/venobox.min.js""></script>

    <!-- Template Main JS File -->
    <script src=""assets/js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
