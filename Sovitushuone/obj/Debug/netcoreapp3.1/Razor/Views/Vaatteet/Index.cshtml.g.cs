#pragma checksum "C:\Users\timop\source\repos\Projekti\Sovitushuone\Views\Vaatteet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86abf39f04b2db00445cc10c756e2269d46aca4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vaatteet_Index), @"mvc.1.0.view", @"/Views/Vaatteet/Index.cshtml")]
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
#line 1 "C:\Users\timop\source\repos\Projekti\Sovitushuone\Views\_ViewImports.cshtml"
using Sovitushuone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\timop\source\repos\Projekti\Sovitushuone\Views\_ViewImports.cshtml"
using Sovitushuone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86abf39f04b2db00445cc10c756e2269d46aca4d", @"/Views/Vaatteet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c052bb11dc6e49331bb7b14280bef14b8eb6fa8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Vaatteet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sovitushuone.Models.Vaatteet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/OBJLoader.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/MTLLoader.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/OrbitControls.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n");
#nullable restore
#line 3 "C:\Users\timop\source\repos\Projekti\Sovitushuone\Views\Vaatteet\Index.cshtml"
      
        ViewData["Title"] = "Index";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abf39f04b2db00445cc10c756e2269d46aca4d4735", async() => {
                WriteLiteral(@"


        <style>
            .frame {
                width: 700px;
                height: 500px;
                border: 3px solid #ccc;
                background: #eee;
                margin: auto;
                padding: 15px 10px;
            }

            img {
                width: 100%;
                height: 100%;
            }
        </style>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h1>Vaatteet</h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abf39f04b2db00445cc10c756e2269d46aca4d6117", async() => {
                WriteLiteral("\r\n        \r\n        <script src=\"js/three.js\"></script>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abf39f04b2db00445cc10c756e2269d46aca4d6444", async() => {
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abf39f04b2db00445cc10c756e2269d46aca4d7547", async() => {
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abf39f04b2db00445cc10c756e2269d46aca4d8650", async() => {
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
                WriteLiteral(@"


        <script>
             //Luodaan uusi ThreeJS scene ja renderer
             //Maaritellaan asetukset
            const scene = new THREE.Scene();
            const renderer = new THREE.WebGLRenderer({ alpha: true });
            var windowHalfX = 1000 / 2;
            var windowHalfY = 700 / 2;
            renderer.setClearColor(new THREE.Color(""hsl(0, 0%, 10%)""));

            renderer.setPixelRatio(window.devicePixelRatio);
            renderer.setSize(1000, 700);




            //Perspektiivikameran asetukset ja luonti
            const camera = new THREE.PerspectiveCamera(50, window.innerWidth / window.innerHeight, 1, 5000);
            camera.rotation.y = 45 / 180 * Math.PI;
            camera.position.x = 800;
            camera.position.y = 100;
            camera.position.z = 1000;
            //Valojen luonti ja asetukset

            const light = new THREE.AmbientLight(0xffffff, 0.25);

            keyLight = new THREE.DirectionalLight(new THREE.Color('hsl(30");
                WriteLiteral(@", 100%, 75%)'), 0.50);
            keyLight.position.set(-100, 0, 100);

            fillLight = new THREE.DirectionalLight(new THREE.Color('hsl(240, 100%, 75%)'), 0.50);
            fillLight.position.set(100, 0, 100);

            backLight = new THREE.DirectionalLight(0xffffff, 0.50);
            backLight.position.set(100, 0, -100).normalize();

            //Objektinlataaja
            const loader = new THREE.OBJLoader();



            //Rendererin asetukset
            renderer.setSize(window.innerWidth, window.innerHeight);
            document.body.appendChild(renderer.domElement);
            const renderingParent = new THREE.Group();
            const controls = new THREE.OrbitControls(camera, renderer.domElement);

            loader.load(
                // objektin osoite
                'objects/Tpaita.obj',

                // Funktio kutsutaan kun lataus on valmis
                function (object) {

                    window.addEventListener('resize', onWindowRes");
                WriteLiteral(@"ize, false);
                    // objektin koko ja tekstuuri
                    renderingParent.scale.set(0.4, 0.4, 0.4);
                    renderingParent.add(object);
                    object.traverse(object => {
                        if (object.material) {
                            object.material.vertexColors = true;
                            object.position.set(0, 200, 10)
                        }
                    });

                    scene.add(renderingParent);




                },


                // kutsutaan kun lataus on kesken
                function (xhr) {

                    console.log((xhr.loaded / xhr.total * 100) + '% loaded');

                },
                // kutsutaan virhetilanteessa
                function (error) {

                    console.log('An error happened');

                }
            );
            
            loader.load(
                // objektin osoite
                'objects/mies.obj',

       ");
                WriteLiteral(@"         
                function (object) {

                    window.addEventListener('resize', onWindowResize, false);
                     // objektin koko ja tekstuuri
                    renderingParent.scale.set(0.3, 0.3, 0.3);
                    renderingParent.add(object);
                    object.traverse(object => {
                        if (object.material) {
                            object.material.vertexColors = true;
                        }
                    });

                    scene.add(renderingParent);

                    scene.add(light);
                    scene.add(keyLight);
                    scene.add(fillLight);
                    scene.add(backLight);


                },


                 // kutsutaan kun lataus on kesken
                function (xhr) {

                    console.log((xhr.loaded / xhr.total * 100) + '% loaded');

                },
                // kutsutaan virhetilanteessa
                function (error");
                WriteLiteral(@") {

                    console.log('An error happened');

                }
            );
             // renderoidaan scene
            function animate() {
                requestAnimationFrame(animate);

                renderer.render(scene, camera);
            }
             // kutsutaan ikkunankoon muutoksessa
            function onWindowResize() {
                windowHalfX = 1000 / 2;
                windowHalfY = 700 / 2;
                camera.aspect = 1000 / 700;
                camera.updateProjectionMatrix();
                renderer.setSize(1000, 700);
            }

            animate();




        </script>


    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sovitushuone.Models.Vaatteet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
