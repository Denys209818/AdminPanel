#pragma checksum "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\Components\User\_UserCollection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75ac296a5be88c3704d077892c1f10b13ff06201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_User__UserCollection), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/User/_UserCollection.cshtml")]
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
#line 1 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\Components\User\_UserCollection.cshtml"
using IdentityAdminPanel.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ac296a5be88c3704d077892c1f10b13ff06201", @"/Areas/Admin/Views/Shared/Components/User/_UserCollection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_User__UserCollection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\Components\User\_UserCollection.cshtml"
  int counter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\Components\User\_UserCollection.cshtml"
 foreach (var user in Model) 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr class=\"draganddrop\">\r\n        <td scope=\"row\">");
#nullable restore
#line 8 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\Components\User\_UserCollection.cshtml"
                    Write(counter++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td >");
#nullable restore
#line 9 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\Components\User\_UserCollection.cshtml"
        Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"EmailTag\">");
#nullable restore
#line 10 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\Components\User\_UserCollection.cshtml"
                        Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 303, "\"", 328, 2);
            WriteAttributeValue("", 309, "/images/", 309, 8, true);
#nullable restore
#line 12 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\Components\User\_UserCollection.cshtml"
WriteAttributeValue("", 317, user.Image, 317, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"60\" alt=\"No image\" />\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\Components\User\_UserCollection.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
