#pragma checksum "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fcc62a1b9bec6f3da6309d8a0b8594c694a367a00c01c4945ceb65d8af02fce6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubMenu_ViewSubMenu), @"mvc.1.0.view", @"/Views/SubMenu/ViewSubMenu.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\_ViewImports.cshtml"
using PathoLab.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\_ViewImports.cshtml"
using PathoLab.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fcc62a1b9bec6f3da6309d8a0b8594c694a367a00c01c4945ceb65d8af02fce6", @"/Views/SubMenu/ViewSubMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efe64be18ad298390ae23b73ed793dc8ec42f6099de9d3a886c7c094529c1c06", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SubMenu_ViewSubMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PathoLab.Domain.SubMenuMaster.SubMenuClass>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SubMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSubMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewSubMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
  
    ViewData["Title"] = "ViewSubSubMenu";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";
    var ResultData = ViewBag.Result as List<PathoLab.Domain.SubMenuMaster.SubMenuClass>;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb p-0 mb-0 bg-transparent"" id=""navigation"">
            </ol>
        </nav>
    </div>

</div>
<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs nav-fill"" role=""tablist"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcc62a1b9bec6f3da6309d8a0b8594c694a367a00c01c4945ceb65d8af02fce65958", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcc62a1b9bec6f3da6309d8a0b8594c694a367a00c01c4945ceb65d8af02fce67443", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n\r\n            <div class=\"card-body \">\r\n");
#nullable restore
#line 30 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                 if (ResultData != null && ResultData.ToList().Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table data-toggle=""table"" id=""tblSubMenu"" class=""table"">
                            <thead>
                                <tr>
                                    <th width=""60px"" class=""align-top text-center"">Sl#</th>
                                    <th width=""150px"" class=""align-top"">
                                        Menu Name
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        SubMenu Name
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        SubMenu URL
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Sl.No
                                    </th>
                                    <th width=""1");
            WriteLiteral(@"50px"" class=""align-top"">
                                        SubMenu Description
                                    </th>
                                    <th width=""150px"" class=""align-top"">Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 56 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                                  
                                    int count = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                                 foreach (var list in ResultData)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 62 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                                                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 64 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                                       Write(list.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 67 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                                       Write(list.SubMenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 70 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                                       Write(list.SubMenuURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 73 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                                       Write(list.SlNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 76 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                                       Write(list.SubMenuDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3641, "\"", 3684, 3);
            WriteAttributeValue("", 3651, "updateSubMenu(\'", 3651, 15, true);
#nullable restore
#line 79 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
WriteAttributeValue("", 3666, list.SubMenuId, 3666, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3681, "\');", 3681, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-primary mr-3\"");
            BeginWriteAttribute("title", " title=\"", 3711, "\"", 3719, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Edit\"><i class=\"icon-edit1\"></i><b>Edit</b></a><br />\r\n                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3843, "\"", 3886, 3);
            WriteAttributeValue("", 3853, "deleteSubMenu(\'", 3853, 15, true);
#nullable restore
#line 80 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
WriteAttributeValue("", 3868, list.SubMenuId, 3868, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3883, "\');", 3883, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"");
            BeginWriteAttribute("title", " title=\"", 3907, "\"", 3915, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Delete\"><i class=\"icon-trash-21\"></i><b>Delete</b></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 83 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                                    count++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 88 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"norecord\"> No Record Found </div>\r\n");
#nullable restore
#line 92 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\SubMenu\ViewSubMenu.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""clearfix col-sm-12""></div>
            </div>
            <!--===================================================-->
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        getDataTable();
    })


    //Update Department
    function updateSubMenu(SubMenuId) {
        if (confirm(""Are you sure you want to update ?"")) {
            location.href = ""/SubMenu/AddSubMenu?SubMenuId="" + SubMenuId;
        }
    }

    //Delete Department
    function deleteSubMenu(SubMenuId) {
        if (confirm(""Are you sure you want to delete ?"")) {
            $.ajax({
                url: ""/SubMenu/DeleteSubMenu?SubMenuId="" + SubMenuId,
                type: ""POST"",
                dataType: ""json"",
                contentType: ""application/json;charset=UTF-8"",
                success: function (data) {
                    if (data == ""3"") {
                        alert(""SubMenu Deleted Successfully"");
                        window.locat");
            WriteLiteral(@"ion.reload();
                    }
                    else if (data == ""4"") {
                        alert(""SubMenu Already In Use!"");
                        window.location.reload();
                    }
                    else { }
                },
                error: function (error) {
                    jsonValue = jQuery.parseJSON(error.responseText);
                    bootbox.alert(""Error : "" + jsonValue);
                }
            });
        }
    }

    //Pagination
    function getDataTable() {
        $('#tblSubMenu').DataTable({
            ""searching"": true,
            //""bStateSave"": true,
            ""dom"": 'Bfrtip',
            ""autoWidth"": false,
            ""buttons"": [
                //{
                //    extend: 'print',
                //    title: 'Manage Block',
                //    exportOptions: {
                //        columns: [0, 1, 2, 3, 4]
                //    },
                //    customize: function (win) { $(win.docu");
            WriteLiteral(@"ment.body).css('font-size', '10pt').prepend('<img src=""' + origin + '/images/t5-logo-white.png""  style=""position:absolute; top:0; left:0;"" />'); $(win.document.body).find('table').addClass('compact').css('font-size', 'inherit'); }

                //}
                ,
                {
                    extend: 'pageLength'
                }
            ],
            ""lengthSubMenu"": [
                [10, 25, 50, 100, 1000 - 1],
                ['10 rows', '25 rows', '50 rows', '100 rows', '1000 rows', 'Show all']
            ]
        });
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PathoLab.Domain.SubMenuMaster.SubMenuClass> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
