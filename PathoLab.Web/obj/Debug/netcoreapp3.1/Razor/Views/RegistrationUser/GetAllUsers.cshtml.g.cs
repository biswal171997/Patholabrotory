#pragma checksum "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d9ea8bc9eae3883315cc13c333abba6e8fc4c3eaac1547aa2eeac95e134ae21c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistrationUser_GetAllUsers), @"mvc.1.0.view", @"/Views/RegistrationUser/GetAllUsers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d9ea8bc9eae3883315cc13c333abba6e8fc4c3eaac1547aa2eeac95e134ae21c", @"/Views/RegistrationUser/GetAllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"efe64be18ad298390ae23b73ed793dc8ec42f6099de9d3a886c7c094529c1c06", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RegistrationUser_GetAllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PathoLab.Domain.UserRegistration.UserModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RegistrationUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "User_Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Designation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Dname"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("indsearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btnok"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
  
    ViewData["Title"] = "ViewDoctor";
    Layout = "~/Views/Shared/_LayoutDynamic.cshtml";
    var ResultData = ViewBag.Result as List<PathoLab.Domain.UserRegistration.UserModel>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-title"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ea8bc9eae3883315cc13c333abba6e8fc4c3eaac1547aa2eeac95e134ae21c8574", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ea8bc9eae3883315cc13c333abba6e8fc4c3eaac1547aa2eeac95e134ae21c10059", async() => {
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
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n            <!-- Search Panel-->\r\n\r\n\r\n            <div class=\"search-container\">\r\n                <div class=\"search-sec\" style=\"display: block;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ea8bc9eae3883315cc13c333abba6e8fc4c3eaac1547aa2eeac95e134ae21c11757", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group form-row\">\r\n");
                WriteLiteral("                            <div class=\"col-12 col-md-6 col-xl-3\">\r\n                                <label class=\"control-label\">Designation Name</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ea8bc9eae3883315cc13c333abba6e8fc4c3eaac1547aa2eeac95e134ae21c12333", async() => {
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 36 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.DesignationName,"DesignationId","Designation"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DesignationId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-12 col-md-6 col-xl-3\">\r\n                                <label class=\"control-label\">Name</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9ea8bc9eae3883315cc13c333abba6e8fc4c3eaac1547aa2eeac95e134ae21c14955", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 41 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FullName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>

                            <div class=""col-lg-2 "">
                                <button id=""btnSearch"" class=""btn btn-primary mt-xl-4 mt-2""> <i class=""fa fa-search""></i> Search</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""text-center""> <a class=""searchopen"" title=""Search"" data-toggle=""tooltip"" data-placement=""bottom""> <i class=""icon-angle-arrow-down""></i> </a></div>
            </div>

            <!-- Search Panel -->
            <!--===================================================-->
            <div class=""card-body "">
");
#nullable restore
#line 56 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                 if (ResultData != null && ResultData.ToList().Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""table-responsive"">
                    <a href=""/RegistrationUser/ExportToExcelRegistrationUser""><i class=""fa fa-file-excel-o"" style=""font-size:24px""></i></a>

                    <table data-toggle=""table"" id=""tblDoctor"" class=""table"">
                        <thead>
                            <tr>
                                <th width=""60px"" class=""align-top text-center"">Sl#</th>

                                <th width=""150px"" class=""align-top"">
                                    Name
                                </th>
                                <th width=""150px"" class=""align-top"">
                                    User Name
                                </th>

                                <th width=""150px"" class=""align-top"">
                                    Email
                                </th>
                                <th width=""150px"" class=""align-top"">
                                    Mobile
                      ");
            WriteLiteral(@"          <th width=""150px"" class=""align-top"">
                                    Gender
                                </th>
                                <th width=""150px"" class=""align-top"">
                                    Age
                                </th>
                                <th width=""150px"" class=""align-top"">
                                    Designation
                                </th>
                                
                                <th width=""150px"" class=""align-top"">Action</th>
                            </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 92 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                  
                                    int count = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                 foreach (var list in ResultData)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 98 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 101 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                   Write(list.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 104 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                   Write(list.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 108 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                   Write(list.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 111 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                   Write(list.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 114 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                   Write(list.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 117 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                   Write(list.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 120 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                   Write(list.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    \r\n                                    <td>\r\n");
            WriteLiteral("                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 6181, "\"", 6224, 3);
            WriteAttributeValue("", 6191, "updateDepartment(\'", 6191, 18, true);
#nullable restore
#line 125 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
WriteAttributeValue("", 6209, list.UserId, 6209, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6221, "\');", 6221, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-primary mr-3\"");
            BeginWriteAttribute("title", " title=\"", 6251, "\"", 6259, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Edit\"><i class=\"icon-edit1\"></i><b>Edit</b></a><br />\r\n\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 6381, "\"", 6420, 3);
            WriteAttributeValue("", 6391, "deleteDoctor(\'", 6391, 14, true);
#nullable restore
#line 127 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
WriteAttributeValue("", 6405, list.UserId, 6405, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6417, "\');", 6417, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"");
            BeginWriteAttribute("title", " title=\"", 6441, "\"", 6449, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Delete\"><i class=\"icon-trash-21\"></i><b>Delete</b></a><br />\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 130 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                                count++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n");
#nullable restore
#line 135 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"norecord\"> No Record Found</div>\r\n");
#nullable restore
#line 139 "D:\testcode\patholab\updatedPatholab\Patholab\Patholab\lab - Copy\PathoLAb\PathoLab.Web\Views\RegistrationUser\GetAllUsers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""clearfix col-sm-12""></div>
            </div>
            <div class=""modal fade"" id=""SubmitModal"" tabindex=""1"" role=""dialog""
                 aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 style=""color:aquamarine"">User Details</h5>
                        </div>
                        <div class=""modal-body"">
                            <h6 class=""modalMsg""></h6>
                        </div>
                        <div class=""modal-footer"">
");
            WriteLiteral(@"
                            <input type=""submit"" class=""btn btn-info btn-sm submitConfirm hbtn"" value=""Yes"" styk=""display:none"" />
                            <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"">No</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""modal fade"" id=""DSubmitModal"" tabindex=""1"" role=""dialog""
                 aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 style=""color:aquamarine"">User Details</h5>
                        </div>
                        <div class=""modal-body"">
                            <h6 class=""DmodalMsg""></h6>
                        </div>
            ");
            WriteLiteral(@"            <div class=""modal-footer"">
                            <input type=""submit"" class=""btn btn-info btn-sm DsubmitConfirm hbtn"" value=""Yes"" styk=""display:none"" />
                            <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"">No</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""modal fade"" id=""SuccessModal"" tabindex=""1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""resultMsg"" style=""color:blue""></h5>
                        </div>
                        <div class=""modal-body"">
                            <h5 class=""msgsuccess""></h5>
                      ");
            WriteLiteral("  </div>\r\n                        <div class=\"modal-footer\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ea8bc9eae3883315cc13c333abba6e8fc4c3eaac1547aa2eeac95e134ae21c31000", async() => {
                WriteLiteral("Close");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <!--===================================================-->
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        getDataTable();
    })



   
    //Pagination
    function getDataTable() {
        $('#tblDoctor').DataTable({
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
                //    customize: function (win) { $(win.document.body).css('font-size', '10pt').prepend('<img src=""' + origin + '/images/t5-logo-white.png""  style=""position:absolute; top:0; left:0;"" />'); $(win.document.body).find('table').addClass('co");
            WriteLiteral(@"mpact').css('font-size', 'inherit'); }

                //}
                ,
                {
                    extend: 'pageLength'
                }
            ],
            ""lengthMenu"": [
                [10, 25, 50, 100, 1000 - 1],
                ['10 rows', '25 rows', '50 rows', '100 rows', '1000 rows', 'Show all']
            ]
        });
    }
    //  function updateDepartment(DepartmentId) {
    //    if (confirm(""Are you sure you want to update ?"")) {
    //        location.href = ""/RegistrationUser/User_Registration?id="" + DepartmentId;
    //    }
    //}
    var x;
    function updateDepartment(DepartmentId) {
        $('.modalMsg').text('Are you sure to Update the details ?');
        $('.submitConfirm').css('display', 'block');
        $('#SubmitModal').modal(""show"");
        x = DepartmentId;
            //location.href = ""/RegistrationUser/User_Registration?id="" + DepartmentId;
       // }
    }

    $("".submitConfirm"").click(function () {
        locatio");
            WriteLiteral(@"n.href = ""/RegistrationUser/User_Registration?id="" + x;
    });

   
    var dl;
    function deleteDoctor(UserId) {
        $('.DmodalMsg').text('Are you sure to delete ?');
        $('.DsubmitConfirm').css('display', 'block');
        $('#DSubmitModal').modal(""show"");
        dl = UserId;
    }

    $("".DsubmitConfirm"").click(function () {
        $.ajax({
            url: ""/RegistrationUser/DeleteDoctor?id="" + dl,
            type: ""POST"",
            dataType: ""json"",
            contentType: ""application/json;charset=UTF-8"",
            success: function (data) {
                if (data == ""3"") {
                    $('.modalMsg').text('');
                    $('#DSubmitModal').modal(""hide"");
                    $('.msgsuccess').text('Data Deleted successfully.');
                    $('#SuccessModal').modal('show');
                   /* window.location.href = ""/RegistrationUser/GetAllUsers"";*/
                }


            },
            error: function (error) {
     ");
            WriteLiteral(@"           jsonValue = jQuery.parseJSON(error.responseText);
                bootbox.alert(""Error : "" + jsonValue);
            }
        });

    });

    //function deleteDoctor(UserId) {
    //    if (confirm(""Are you sure you want to delete ?"")) {
    //        $.ajax({
    //            url: ""/RegistrationUser/DeleteDoctor?id="" + UserId,
    //            type: ""POST"",
    //            dataType: ""json"",
    //            contentType: ""application/json;charset=UTF-8"",
    //            success: function (data) {
    //                if (data == ""3"") {
                      
    //                    window.location.href = ""/RegistrationUser/GetAllUsers"";
    //                }
                    
                   
    //            },
    //            error: function (error) {
    //                jsonValue = jQuery.parseJSON(error.responseText);
    //                bootbox.alert(""Error : "" + jsonValue);
    //            }
    //        });
    //    }
    //}
</scr");
            WriteLiteral("ipt>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PathoLab.Domain.UserRegistration.UserModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
