#pragma checksum "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411fc3d197e9983671c33e07b0f983c003981752"
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
#line 1 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\_ViewImports.cshtml"
using WebApp.TemplatePattern;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\_ViewImports.cshtml"
using WebApp.TemplatePattern.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411fc3d197e9983671c33e07b0f983c003981752", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b7ddd758c6f338c990b1b452d7146f3676dfc90", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
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
        private global::WebApp.TemplatePattern.UserCards.UserCardTagHelper __WebApp_TemplatePattern_UserCards_UserCardTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\Home\Index.cshtml"
 foreach (var item in Model)
{
    count++;
    if (count == 1 || count % 5 == 1)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\Home\Index.cshtml"
   Write(Html.Raw("<div class='row row-cols-1 row-cols-md-4 g-4'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\Home\Index.cshtml"
                                                                   
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("user-card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411fc3d197e9983671c33e07b0f983c0039817524287", async() => {
            }
            );
            __WebApp_TemplatePattern_UserCards_UserCardTagHelper = CreateTagHelper<global::WebApp.TemplatePattern.UserCards.UserCardTagHelper>();
            __tagHelperExecutionContext.Add(__WebApp_TemplatePattern_UserCards_UserCardTagHelper);
#nullable restore
#line 15 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\Home\Index.cshtml"
__WebApp_TemplatePattern_UserCards_UserCardTagHelper.AppUser = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user", __WebApp_TemplatePattern_UserCards_UserCardTagHelper.AppUser, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 17 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\Home\Index.cshtml"
    if (count % 5 == 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\Home\Index.cshtml"
   Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Udemy\MyUdemyWorks\Mvc\AspNetCoreDesignPatterns\WebApp.TemplatePattern\Views\Home\Index.cshtml"
                           
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
