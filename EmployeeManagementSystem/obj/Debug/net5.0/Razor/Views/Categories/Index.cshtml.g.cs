#pragma checksum "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c20df86ef34cc2f0aae3bb018dd5b6bc3b9b69bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
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
#line 1 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\_ViewImports.cshtml"
using EmployeeManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\_ViewImports.cshtml"
using EmployeeManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c20df86ef34cc2f0aae3bb018dd5b6bc3b9b69bf", @"/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d74a7592af933458469e08f9ca7634db2dc2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManagementSystem.Models.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
   ViewBag.Title = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div id=""categoryDiv"" class=""col-md-2"" style=""overflow:scroll;"">
        <h2>Categories</h2>
        <p>
            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#categoryModal"">Create New</button>
        </p>
");
#nullable restore
#line 11 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\n    <div class=\"card-header\">\n        ");
#nullable restore
#line 15 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"card-body\">\n");
            WriteLiteral("    </div>\n    <div class=\"card-footer\">\n        <button class=\"btn btn-warning\" data-toggle=\"modal\" data-target=\"#editCategoryModal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 757, "\"", 789, 3);
            WriteAttributeValue("", 767, "editCategory(", 767, 13, true);
#nullable restore
#line 21 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
WriteAttributeValue("", 780, item.ID, 780, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 788, ")", 788, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>&nbsp;&nbsp;\n        <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 853, "\"", 883, 3);
            WriteAttributeValue("", 863, "getDetails(", 863, 11, true);
#nullable restore
#line 22 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
WriteAttributeValue("", 874, item.ID, 874, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 882, ")", 882, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Details</button>&nbsp;&nbsp;\n        <button class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#deleteCategoryModal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1007, "\"", 1041, 3);
            WriteAttributeValue("", 1017, "deleteCategory(", 1017, 15, true);
#nullable restore
#line 23 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
WriteAttributeValue("", 1032, item.ID, 1032, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1040, ")", 1040, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\n    </div>\n</div>\n                <br />");
#nullable restore
#line 26 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div id=""itemsDiv"" class=""col-md-10"" style=""overflow:scroll;"">
    </div>
</div>

<div class=""modal fade"" id=""categoryModal"" tabindex=""-1"" aria-labelledby=""categoryModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
");
#nullable restore
#line 36 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
               Html.RenderPartial("Create", new EmployeeManagementSystem.Models.Category()); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""modal fade"" id=""editCategoryModal"" tabindex=""-1"" aria-labelledby=""editCategoryModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div id=""editCategoryModalContent"" class=""modal-content"">
        </div>
    </div>
</div>

<div class=""modal fade"" id=""deleteCategoryModal"" tabindex=""-1"" aria-labelledby=""deleteCategoryModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div id=""deleteCategoryModalContent"" class=""modal-content"">
        </div>
    </div>
</div>

<div class=""modal fade"" id=""itemModal"" tabindex=""-1"" aria-labelledby=""itemModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div id=""itemModalContent"" class=""modal-content"">
        </div>
    </div>
</div>

<div class=""modal fade"" id=""editItemModal"" tabindex=""-1"" aria-labelledby=""editItemModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div id=""editItemModalContent"" class=""modal-content"">
        </div>
    </div>
</div>

<div cla");
            WriteLiteral("ss=\"modal fade\" id=\"deleteItemModal\" tabindex=\"-1\" aria-labelledby=\"deleteItemModalLabel\" aria-hidden=\"true\">\n    <div class=\"modal-dialog\">\n        <div id=\"deletItemModalContent\" class=\"modal-content\">\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    \n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c20df86ef34cc2f0aae3bb018dd5b6bc3b9b69bf9962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c20df86ef34cc2f0aae3bb018dd5b6bc3b9b69bf11059", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c20df86ef34cc2f0aae3bb018dd5b6bc3b9b69bf12157", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <script>\n        $(document).ready(function () {\n            $(\"#categoryDiv\").height($(window).height() * .85);\n            $(\"#itemsDiv\").height($(window).height() * .85);\n\n            if (isNaN(");
#nullable restore
#line 87 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
                 Write(TempData["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(") == false) {\n                var link = \'");
#nullable restore
#line 88 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
                       Write(Url.Action("GetCategoryWiseItems", "Categories", new { id = @TempData["id"] }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                $(""#itemsDiv"").load(link);
            }

            $('#categoryModal').on('shown.bs.modal', function () {
                $('#Name').trigger('focus');
            });

            $('#categoryModal').on('hidden.bs.modal', function (event) {
                $(""input[type=text]"").val("""");
                $(""input[type=number]"").val("""");
                $(""input[type=datetime-local]"").val("""");
                $('#sl').val('0');

                $(""img[data-tag='itemImageinCategory']"").each(function () {
                    $(this).attr(""src"", ""/Images/transparent_phone.jpg"");
                });

                $(""div"").each(function () {
                    if (parseInt(this.id) > 0) {
                        this.remove();
                    }
                })
            });

            $('#addModelButton').on('click', function () {
                var present_sl = parseInt($('#sl').val());
                var next_sl = parseInt(present_sl) + 1;
                var next_item = '<div");
                WriteLiteral(@" id=""' + next_sl + '"">' + $('#' + present_sl).html() + '</div>';
                next_item = next_item.split('_' + present_sl.toString()).join('_' + next_sl.toString());
                next_item = next_item.split('[' + present_sl.toString() + ']').join('[' + next_sl.toString() + ']');
                $('#' + present_sl).after(next_item);
                $('#sl').val(next_sl);
            });

            $('#itemModal').on('hidden.bs.modal', function (event) {
                $(""input[type=text]"").val("""");
                $(""input[type=number]"").val("""");
                $(""input[type=datetime-local]"").val("""");
            });
        });

        function editCategory(e) {
            var link = '");
#nullable restore
#line 131 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
                   Write(Url.Action("Edit", "Categories", new { id = "-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\n            link = link.replace(\"-1\", e);\n            $(\"#editCategoryModalContent\").load(link);\n        }\n\n        function deleteCategory(e) {\n            var link = \'");
#nullable restore
#line 137 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
                   Write(Url.Action("Delete", "Categories", new { id = "-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\n            link = link.replace(\"-1\", e);\n            $(\"#deleteCategoryModalContent\").load(link);\n        }\n\n        function getDetails(e) {\n            var link = \'");
#nullable restore
#line 143 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
                   Write(Url.Action("GetCategoryWiseItems", "Categories", new { id = "-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\n            link = link.replace(\"-1\", e);\n            $(\"#itemsDiv\").load(link);\n        }\n\n        function loadItem(e) {\n            var link = \'");
#nullable restore
#line 149 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
                   Write(Url.Action("Create", "Items", new { id = "-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\n            link = link.replace(\"-1\", e);\n            $(\"#itemModalContent\").load(link);\n        }\n\n        function editItem(e) {\n            var link = \'");
#nullable restore
#line 155 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
                   Write(Url.Action("Edit", "Items", new { id = "-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\n            link = link.replace(\"-1\", e);\n            $(\"#editItemModalContent\").load(link);\n        }\n\n        function deleteItem(e) {\n            var link = \'");
#nullable restore
#line 161 "C:\Users\IT\OneDrive\Desktop\EmployeeManagementSystem\EmployeeManagementSystem\Views\Categories\Index.cshtml"
                   Write(Url.Action("Delete", "Items", new { id = "-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            link = link.replace(""-1"", e);
            $(""#deletItemModalContent"").load(link);
        }

        var loadImage = function (event) {
            if (event.target.files && event.target.files[0]) {
                var img = document.getElementById('itemImage');
                img.src = URL.createObjectURL(event.target.files[0]);
            }
        }

        var editImage = function (event) {
            if (event.target.files && event.target.files[0]) {
                var img = document.querySelector('img[alt = ""Edit Image""]')
                img.src = URL.createObjectURL(event.target.files[0]);
            }
        }

        var changeImage = function (obj, event) {
            if (event.target.files && event.target.files[0]) {
                console.log(obj.dataset.tag);
                var img = document.getElementById(obj.dataset.tag);
                img.src = URL.createObjectURL(event.target.files[0]);
            }
        }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeManagementSystem.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
