#pragma checksum "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8650c5e9ac819676eaf67ceba4d44fd523097060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Navigation), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Navigation.cshtml")]
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
#line 1 "C:\Users\Denis\Desktop\ASP.NET Core MVC\HomeWorks\IdentityAdminPanel\IdentityAdminPanel\Areas\Admin\Views\Shared\_Navigation.cshtml"
using IdentityAdminPanel.Areas.Admin.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8650c5e9ac819676eaf67ceba4d44fd523097060", @"/Areas/Admin/Views/Shared/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav nav-tabs metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    <img alt=""image"" class=""rounded-circle"" width=""48"" height=""48"" src=""https://cropas.by/wp-content/uploads/2015/05/admin.jpg"" />
                    
                        <span class=""block m-t-xs font-bold"">Денис Кравчук</span>
                        <span class=""text-muted text-xs block"">Адміністратор сайту</span>
                    
                </div>
                <div class=""logo-element"">
                    IN+
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-bs-target=""#adduser"" data-bs-toggle=""tab""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Додати користувача</span></a>
            </li>
            <li class=""nav-item"">
        ");
            WriteLiteral(@"        <a href=""#edituser"" class=""nav-link"" data-bs-target=""#edituser"" data-bs-toggle=""tab""><i class=""fa fa-diamond""></i> <span class=""nav-label"">Редагувати користувача</span></a>
            </li>
            <li class=""nav-item"">
                <a href=""#deleteuser"" class=""nav-link"" data-bs-target=""#deleteuser"" data-bs-toggle=""tab""><i class=""fa fa-bar-chart-o""></i> <span class=""nav-label"">Видалити користувача</span></a>
            </li>
        </ul>
    </div>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
