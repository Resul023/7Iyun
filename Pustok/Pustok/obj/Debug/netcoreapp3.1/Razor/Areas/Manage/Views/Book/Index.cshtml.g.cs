#pragma checksum "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3030dd1b2e09ad336454d98d58e7b188b6afbc27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Book_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.Areas.Manage.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3030dd1b2e09ad336454d98d58e7b188b6afbc27", @"/Areas/Manage/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e4a459fc1e5ef747f7e0cde22fece096a4dfe2", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<container>
    <row>
        <div class=""col-md-10 mx-auto"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">FullName</th>
                        <th scope=""col"">CostPrice</th>
                        <th scope=""col"">SalePrice</th>
                        <th scope=""col"">AuthorName</th>
                        <th scope=""col"">Genre</th>


                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 24 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\Book\Index.cshtml"
                     for (int i = 0; i < Model.Books.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <tr>\r\n                             <th scope=\"col\">");
#nullable restore
#line 27 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\Book\Index.cshtml"
                                        Write(Model.Books[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                             <th scope=\"col\">");
#nullable restore
#line 28 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\Book\Index.cshtml"
                                        Write(Model.Books[i].CostPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                             <th scope=\"col\">");
#nullable restore
#line 29 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\Book\Index.cshtml"
                                        Write(Model.Books[i].SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                             <th scope=\"col\">");
#nullable restore
#line 30 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\Book\Index.cshtml"
                                        Write(Model.Books[i].Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                             <th scope=\"col\">");
#nullable restore
#line 31 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\Book\Index.cshtml"
                                        Write(Model.Books[i].Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                         </tr>\r\n");
#nullable restore
#line 34 "C:\Users\User\Desktop\7Iyun\Pustok\Pustok\Areas\Manage\Views\Book\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </row>\r\n</container>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
