#pragma checksum "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Views\Shared\Components\Navbar\_NavbarData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d468405ecadceb8a59306cbd03af0238b79c1a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navbar__NavbarData), @"mvc.1.0.view", @"/Views/Shared/Components/Navbar/_NavbarData.cshtml")]
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
#line 1 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Views\_ViewImports.cshtml"
using IdentityAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Views\_ViewImports.cshtml"
using IdentityAdminPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d468405ecadceb8a59306cbd03af0238b79c1a6", @"/Views/Shared/Components/Navbar/_NavbarData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113bcbd4b3f565d28e3136a42c0a5263286d4e55", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Navbar__NavbarData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDataViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n    <div class=\"me-2\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 68, "\"", 94, 2);
            WriteAttributeValue("", 74, "/images/", 74, 8, true);
#nullable restore
#line 4 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Views\Shared\Components\Navbar\_NavbarData.cshtml"
WriteAttributeValue("", 82, Model.Image, 82, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle\" width=\"30\" height=\"30\" alt=\"Default image\" />\r\n        <b class=\"text-dark\">");
#nullable restore
#line 5 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Views\Shared\Components\Navbar\_NavbarData.cshtml"
                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDataViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
