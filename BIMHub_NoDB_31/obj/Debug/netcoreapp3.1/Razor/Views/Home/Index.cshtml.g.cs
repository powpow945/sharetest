#pragma checksum "D:\RESI\03-Sample\DotnetCore\BIMHub_NoDB_31\BIMHub_NoDB_31\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afc8a61c86defa8314619b9258c95b216b9cec38"
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
#line 1 "D:\RESI\03-Sample\DotnetCore\BIMHub_NoDB_31\BIMHub_NoDB_31\Views\_ViewImports.cshtml"
using BIMHub_NoDB_31;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RESI\03-Sample\DotnetCore\BIMHub_NoDB_31\BIMHub_NoDB_31\Views\_ViewImports.cshtml"
using BIMHub_NoDB_31.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc8a61c86defa8314619b9258c95b216b9cec38", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bc3e76a12d71130b403f85fc51e2ce6d03d36a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\RESI\03-Sample\DotnetCore\BIMHub_NoDB_31\BIMHub_NoDB_31\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Viewer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "D:\RESI\03-Sample\DotnetCore\BIMHub_NoDB_31\BIMHub_NoDB_31\Views\Home\Index.cshtml"
Write(ViewBag.urn_filename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-11 viewer\" id=\"viewer\"></div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://developer.api.autodesk.com/modelderivative/v2/viewers/7.*/style.min.css\" type=\"text/css\">\r\n    <style>\r\n        .viewer {\r\n            height: calc(100vh - 227px);\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://developer.api.autodesk.com/modelderivative/v2/viewers/7.*/viewer3D.min.js""></script>
    <script type=""text/javascript"">
        var api_url = '/Home';
        //var api_url = '/BIMHub/api/Home';
        var viewer; //Forge Viewer

        $(document).ready(function () {
            launchViewer();
        })

        var options = {
            env: 'AutodeskProduction',
            api: 'derivativeV2',  // for models uploaded to EMEA change this option to 'derivativeV2_EU'
            getAccessToken: getForgeToken
        };

        function getForgeToken(callback) {
            $.ajax({
                url: api_url + '/gettoken',
                success: function (res) {
                    //console.log(res.access_token);
                    callback(res.access_token, res.expires_in);
                },
                error: function () {
                    Swal.fire({
                        icon: 'error',
                        title: 'getForgeTok");
                WriteLiteral(@"en，請聯繫 萬鼎BIM中心-王韋翔工程師'
                    });
                }
            });
        }

        function launchViewer() {
            var documentId = 'urn:dXJuOmFkc2sub2JqZWN0czpvcy5vYmplY3Q6cmVpX29ubGluZS8yMDE5MDYxN18lRTQlQjglQUQlRTklQkMlOEUlRTklOUIlODYlRTUlOUMlOTglRTclQUMlQUMlRTQlQkElOEMlRTclQjglQkQlRTklODMlQTglRTUlQTQlQTclRTYlQTglOTMlRTYlOTYlQjAlRTUlQkIlQkElRTUlQjclQTUlRTclQTglOEJfJUU2JTk1JUI0JUU1JTkwJTg4Lm53ZA==';
            Autodesk.Viewing.Initializer(options, function () {
                var htmlDiv = document.getElementById('viewer');
                viewer = new Autodesk.Viewing.GuiViewer3D(htmlDiv, {});
                var startedCode = viewer.start();
                if (startedCode > 0) {
                    alert('Failed to create a Viewer: WebGL not supported.');
                    return;
                }
                console.log('Initialization complete, loading a model next...');
                Autodesk.Viewing.Document.load(documentId, onDocumentLoadSuccess, onD");
                WriteLiteral(@"ocumentLoadFailure);
            });
        }

        function onDocumentLoadSuccess(viewerDocument) {
            var defaultModel = viewerDocument.getRoot().getDefaultGeometry();
            viewer.loadDocumentNode(viewerDocument, defaultModel);
        }
        function onDocumentLoadFailure(viewerErrorCode) {
            alert('onDocumentLoadFailure() - errorCode:' + viewerErrorCode);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591