﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 28 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Partial/AddNewPageEditPermalink.cshtml")]
    public partial class _Views_Page_Partial_AddNewPageEditPermalink_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Page.AddNewPageViewModel>
    {
        public _Views_Page_Partial_AddNewPageEditPermalink_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 35 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
   Write(PagesGlobalization.AddNewPage_Permalink);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 36 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
   Write(Html.Tooltip(PagesGlobalization.AddNewPage_Permalink_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-editor-link\"");

WriteLiteral(" id=\"bcms-page-editpermalink\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
                                                              Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"bcms-editor-path\"");

WriteLiteral(" id=\"bcms-page-permalink-info\"");

WriteLiteral(">");

            
            #line 39 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
                                                            Write(string.IsNullOrWhiteSpace(Model.PageUrl) ? Html.Raw("&nbsp;") : new MvcHtmlString(Html.Encode(Model.PageUrl)));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-editor-box bcms-js-edit-box\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 42 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
   Write(Html.Hidden("PagePermalinkHidden", Model.PageUrl, new { @id = "bcms-page-permalink" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
       Write(Html.TextBoxFor(model => model.PageUrl, new { @id = "bcms-page-permalink-edit", @class = "bcms-field-text bcms-js-url-path" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 45 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
       Write(Html.BcmsValidationMessageFor(f => f.PageUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(" id=\"bcms-save-permalink\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
                                                          Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\Page\Partial\AddNewPageEditPermalink.cshtml"
                                Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
