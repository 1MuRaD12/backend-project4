#pragma checksum "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Views\Shared\_PlantPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95648a571eaa95e26f74bf64c1c9aba62f2528a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PlantPartialView), @"mvc.1.0.view", @"/Views/Shared/_PlantPartialView.cshtml")]
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
#line 1 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Views\_ViewImports.cshtml"
using AP204_Pronia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Views\_ViewImports.cshtml"
using AP204_Pronia.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95648a571eaa95e26f74bf64c1c9aba62f2528a1", @"/Views/Shared/_PlantPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7855f28c605a46286007b16b7fd8db3fc7444ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__PlantPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("secondary-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Views\Shared\_PlantPartialView.cshtml"
                           foreach (Plant item in Model.Plants)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-xl-3 col-md-4 col-sm-6"">
                                <div class=""product-item"">
                                    <div class=""product-img"">
                                        <a href=""shop.html"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "95648a571eaa95e26f74bf64c1c9aba62f2528a14882", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 475, "~/assets/images/website-images//", 475, 32, true);
#nullable restore
#line 8 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Views\Shared\_PlantPartialView.cshtml"
AddHtmlAttributeValue("", 507, item.PlantImages.FirstOrDefault(p=>p.IsMain == true).ImagePath, 507, 63, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "95648a571eaa95e26f74bf64c1c9aba62f2528a16663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 773, "~/assets/images/website-images//", 773, 32, true);
#nullable restore
#line 11 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Views\Shared\_PlantPartialView.cshtml"
AddHtmlAttributeValue("", 805, item.PlantImages.FirstOrDefault(p=>p.IsMain == false).ImagePath, 805, 64, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                        <div class=""product-add-action"">
                                            <ul>
                                                <li>
                                                    <a href=""wishlist.html""
                                                       data-tippy=""Add to wishlist""
                                                       data-tippy-inertia=""true""
                                                       data-tippy-animation=""shift-away""
                                                       data-tippy-delay=""50""
                                                       data-tippy-arrow=""true""
                                                       data-tippy-theme=""sharpborder"">
                                                        <i class=""pe-7s-like""></i>
                                                    </a>
                                                </li>
                     ");
            WriteLiteral(@"                           <li class=""quuickview-btn""
                                                    data-bs-toggle=""modal""
                                                    data-bs-target=""#quickModal"">
                                                    <a href=""#""
                                                       data-tippy=""Quickview""
                                                       data-tippy-inertia=""true""
                                                       data-tippy-animation=""shift-away""
                                                       data-tippy-delay=""50""
                                                       data-tippy-arrow=""true""
                                                       data-tippy-theme=""sharpborder"">
                                                        <i class=""pe-7s-look""></i>
                                                    </a>
                                                </li>
                                                <li");
            WriteLiteral(@">
                                                    <a href=""cart.html""
                                                       data-tippy=""Add to cart""
                                                       data-tippy-inertia=""true""
                                                       data-tippy-animation=""shift-away""
                                                       data-tippy-delay=""50""
                                                       data-tippy-arrow=""true""
                                                       data-tippy-theme=""sharpborder"">
                                                        <i class=""pe-7s-cart""></i>
                                                    </a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class=""product-content"">
                                        <a");
            WriteLiteral(" class=\"product-name\" href=\"shop.html\">");
#nullable restore
#line 55 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Views\Shared\_PlantPartialView.cshtml"
                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <div class=\"price-box pb-1\">\r\n                                            <span class=\"new-price\">$");
#nullable restore
#line 57 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Views\Shared\_PlantPartialView.cshtml"
                                                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                        <div class=""rating-box"">
                                            <ul>
                                                <li><i class=""fa fa-star""></i></li>
                                                <li><i class=""fa fa-star""></i></li>
                                                <li><i class=""fa fa-star""></i></li>
                                                <li><i class=""fa fa-star""></i></li>
                                                <li><i class=""fa fa-star""></i></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 71 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Views\Shared\_PlantPartialView.cshtml"
                                
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
