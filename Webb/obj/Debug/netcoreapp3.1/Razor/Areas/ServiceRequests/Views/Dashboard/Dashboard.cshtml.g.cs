#pragma checksum "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e6ded349724ded7f81ed6025f68adfee68a3c06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ServiceRequests_Views_Dashboard_Dashboard), @"mvc.1.0.view", @"/Areas/ServiceRequests/Views/Dashboard/Dashboard.cshtml")]
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
#line 1 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\_ViewImports.cshtml"
using Webb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\_ViewImports.cshtml"
using Webb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
using ASC.Models.BaseTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e6ded349724ded7f81ed6025f68adfee68a3c06", @"/Areas/ServiceRequests/Views/Dashboard/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdf3741c2a9dd8e8597c8fa201d47710477ebb3a", @"/Areas/ServiceRequests/Views/_ViewImports.cshtml")]
    public class Areas_ServiceRequests_Views_Dashboard_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Webb.Areas.ServiceRequests.Models.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
   ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_SecureLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\"></div>\r\n");
#nullable restore
#line 12 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
Write(await Html.PartialAsync("_ServiceRequestGrid", Model.ServiceRequests, new ViewDataDictionary(ViewData) {
 { "SectionName", SharedLocalizer["SectionHeader_ServiceRequests_Text"] },
 { "Id", "tblServiceRequests" },
 { "IsAudit", false }
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
 if (UserHttpContext.HttpContext.User.IsInRole(Roles.Admin.ToString()) ||
UserHttpContext.HttpContext.User.IsInRole(Roles.Engineer.ToString()))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
Write(await Html.PartialAsync("_ServiceRequestGrid", Model.AuditServiceRequests,
   new ViewDataDictionary(ViewData) {
    { "SectionName", "Recent Updates" },
    { "Id", "tblAuditServiceRequests" },
   { "IsAudit", true }
   }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
     
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
 if (UserHttpContext.HttpContext.User.IsInRole(Roles.Admin.ToString()))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col s6\">\r\n            <ul class=\"collection with-header height-300px overflow-y\">\r\n                <li class=\"collection-header\"><h5>Active Service Engineers</h5></li>\r\n");
#nullable restore
#line 33 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
                 if (Model.ActiveServiceRequests.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
                     foreach (var activeServiceRequest in Model.ActiveServiceRequests)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"collection-item\">\r\n                            <div>\r\n                                <span class=\"new badge\" data-badgecaption=\"\">\r\n                                    ");
#nullable restore
#line 40 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
                               Write(activeServiceRequest.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>");
#nullable restore
#line 41 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
                                  Write(activeServiceRequest.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 44 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""collection-item"">
                        <div class=""card-panel teal lighten-2 white-text"">
                            No Activer Service
                            Requests.
                        </div>
                    </li>
");
#nullable restore
#line 54 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 58 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            // Initialize DataTable to show list of Service Requests
            var table = $('#tblServiceRequests').DataTable({
                'pageLength': 3,
                // Number of records to be displayed per page
                'lengthMenu': [[3, 5, 10, -1], [3, 5, 10, 'All']],
                // Remove default Sorting
                'sorting': [],
                'columns': [{ ""visible"": false }, { ""visible"": false }, null, {
                    ""width"":
                        ""20%""
                }, null, null, null]
            });
            var table = $('#tblAuditServiceRequests').DataTable({
                'pageLength': 3,
                // Number of records to be displayed per page
                'lengthMenu': [[3, 5, 10, -1], [3, 5, 10, 'All']],
                // Remove default Sorting
                'sorting': [],
                'columns': [{ ""visible"": false }, { ""visible"": false }, null,
            ");
                WriteLiteral(@"    { ""width"": ""20%"" }, null, null, null, null]
            });

            // Set Styles for DataTable and Number of Records to be displayed dropdown
            $('.tblServiceRequests').css(""width"", ""100%"");
            $('select[name$=""ServiceRequests_length""]').formSelect();
            $('select').formSelect();
            $(""select[required]"").css({
                display: ""block"", position: 'absolute',
                visibility: 'hidden'
            })
            // On click of View icon, redirect to Service Request Details View based on RowKey
            $(document).on('click', '.view', function () {
             var tableId = '#' + $(this).parents('table').attr('id');
             var serviceRequest = $(tableId).DataTable().row($(this).parents('tr')).data();
             // For Service Request Table, populate id with RowKey
             var id = serviceRequest[0];
             // For Service Request Audit Table, populate id by spliting the Partition key with '-'
             if");
                WriteLiteral(" (tableId.indexOf(\'Audit\') >= 0)\r\n             id = serviceRequest[1].substring(serviceRequest[1].indexOf(\'-\') + 1,serviceRequest[1].length);\r\n             window.location.href = \'");
#nullable restore
#line 101 "F:\TaiLieu\HUYNHDUCHUY-PC\HKI_Nam3\KTTKPM\New folder\Webb\Areas\ServiceRequests\Views\Dashboard\Dashboard.cshtml"
                                Write(Url.Action("ServiceRequestDetails","ServiceRequest",new { Area = "ServiceRequests" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("?Id=\' + id;\r\n});\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor UserHttpContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webb.Areas.ServiceRequests.Models.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
