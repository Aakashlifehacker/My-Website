#pragma checksum "C:\Users\Zachariasz\Desktop\Zachariasz Jankowski\Views\Projects\Android.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1024067cc24b0a23f183e40c900f877f2a071e03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Android), @"mvc.1.0.view", @"/Views/Projects/Android.cshtml")]
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
#line 1 "C:\Users\Zachariasz\Desktop\Zachariasz Jankowski\Views\_ViewImports.cshtml"
using Zachariasz_Jankowski;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zachariasz\Desktop\Zachariasz Jankowski\Views\_ViewImports.cshtml"
using Zachariasz_Jankowski.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1024067cc24b0a23f183e40c900f877f2a071e03", @"/Views/Projects/Android.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f9309c3dc0693d8b22ca99e3d0777860a302bb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Android : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "footer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/folding.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Zachariasz\Desktop\Zachariasz Jankowski\Views\Projects\Android.cshtml"
  
    ViewData["Title"] = "Receipt Manager";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<main>
    <div class=""bg-white article container col-lg-6 offset-lg-3 pl-0 pr-0"">



        <div class=""top_andro m-0 pl-0 pr-0"">


            <div class=""backProject  col-lg-10 offset-lg-1""><a class=""backBG p-1 pr-2"" href=""/Projects""><img src=""/Images/arrow.png"" width=""20"" height=""20"" class=""d-inline-block""");
            BeginWriteAttribute("alt", " alt=\"", 379, "\"", 385, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 389, "\"", 397, 0);
            EndWriteAttribute();
            WriteLiteral(@">back to project selection</i></a></div>

            <h1 class=""projects d-flex justify-content-center pb-0 mb-0 mt-3""><b class=""shadow-sm  titleTop pl-2 pr-2"">Receipt Manager</b></h1>
            <div class=""under d-flex justify-content-center mt-0 ""><strong class=""title pl-2 pr-2 shadow-sm  "">Android || Google API</strong></div>

        </div>

        <div class=""pt-5 col-lg-10 offset-lg-1"">


");
#nullable restore
#line 26 "C:\Users\Zachariasz\Desktop\Zachariasz Jankowski\Views\Projects\Android.cshtml"
              
                string timeSpan = "";
                int days = (int)ViewData["days"];
                if (days == 0) timeSpan = "today";
                if (days == 1) timeSpan = "yesterday";
                else if (days > 0 && days < 30) timeSpan = days.ToString() + " days ago";
                else if (days >= 30)
                {
                    int fullMonths = (days - (days % 30)) / 30;
                    if (fullMonths == 1) timeSpan = fullMonths.ToString() + " month ago";
                    else timeSpan = fullMonths.ToString() + " months ago";
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\Zachariasz\Desktop\Zachariasz Jankowski\Views\Projects\Android.cshtml"
              
                string timeSpanBE = "";
                int daysBE = (int)ViewData["daysBE"];
                if (daysBE == 0) timeSpanBE = "today";
                if (daysBE == 1) timeSpanBE = "yesterday";
                else if (daysBE > 0 && daysBE < 30) timeSpanBE = daysBE.ToString() + " days ago";
                else if (daysBE >= 30)
                {
                    int fullMonthsBE = (daysBE - (daysBE % 30)) / 30;
                    if (fullMonthsBE == 1) timeSpanBE = fullMonthsBE.ToString() + " month ago";
                    else timeSpanBE = fullMonthsBE.ToString() + " months ago";
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            <div class=\"d-flex justify-content-start\">\r\n                <img src=\"/Images/icons/dt.png\" width=\"20\" height=\"20\" class=\"d-inline-block mr-1 \"");
            BeginWriteAttribute("alt", " alt=\"", 2271, "\"", 2277, 0);
            EndWriteAttribute();
            WriteLiteral(@">Repositories: <a class=""pl-1"" target=""_blank"" href=""https://github.com/JankowskiZachariasz/AndroidApp""> Android app</a>, <a class=""pl-1"" target=""_blank"" href=""https://github.com/JankowskiZachariasz/ReceiptifyServer""> Server logic</a> 
            </div>

            <div class=""d-flex justify-content-start"">
                <img src=""/Images/icons/calendar.png"" width=""20"" height=""20"" class=""d-inline-block mr-1 """);
            BeginWriteAttribute("alt", " alt=\"", 2698, "\"", 2704, 0);
            EndWriteAttribute();
            WriteLiteral(">Last update: <a class=\"pl-1\" target=\"_blank\" href=\"https://github.com/JankowskiZachariasz/AndroidApp/commits/master\"> ");
#nullable restore
#line 62 "C:\Users\Zachariasz\Desktop\Zachariasz Jankowski\Views\Projects\Android.cshtml"
                                                                                                                                                                                                                                  Write(timeSpan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>, <a class=\"pl-1\" target=\"_blank\" href=\"https://github.com/JankowskiZachariasz/ReceiptifyServer/commits/master\"> ");
#nullable restore
#line 62 "C:\Users\Zachariasz\Desktop\Zachariasz Jankowski\Views\Projects\Android.cshtml"
                                                                                                                                                                                                                                                                                                                                                                Write(timeSpanBE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> \r\n            </div>\r\n\r\n            <div class=\"d-flex justify-content-start\">\r\n                <img src=\"/Images/icons/ppl.png\" width=\"20\" height=\"20\" class=\"d-inline-block mr-1 \"");
            BeginWriteAttribute("alt", " alt=\"", 3146, "\"", 3152, 0);
            EndWriteAttribute();
            WriteLiteral(@">Developer(s): <a class=""pl-1"" target=""_blank"" href=""https://github.com/JankowskiZachariasz""> Zachariasz Jankowski</a>
            </div>



            <hr>






            <div class=""sect  p-1 pl-2 rounded d-flex d-inline-block"" onclick=""toggle('1')""><h4 class=""mb-0"">Introduction</h4> <h4 id=""i1"" class=""mb-0 ml-auto mr-2"">+</h4> </div>
            <div id=""t1"" class=""par mb-2"">
                <div class=""p-2"">
                    <p class=""p-2"">
                            I am developing this project as a university assignment. Although it's a group effort, I only present code that I wrote myself (see github commits). The last section explains in more detail how we collaborate in our team. 
                            Our goal is to create an Android app that will be able to:
                            <ul>
                            <li>scan shopping receipts (by reading their text with OCR and extracting relevant information with our algorithms</li>
                            <");
            WriteLiteral(@"li>store all data in the database</li>
                            <li>enable users to create accounts that are secure and facilitate backing up their data</li>
                            <li>create interesting and useful statistics based on the user data</li>
                            </ul>
                    </p>
                </div>
            </div>

            <div class=""sect  p-1 pl-2 rounded d-flex d-inline-block"" onclick=""toggle('2')""><h4 class=""mb-0"">Project Structure</h4> <h4 id=""i2"" class=""mb-0 ml-auto mr-2"">+</h4> </div>
            <div id=""t2"" class=""par mb-2"">
                <div class=""p-2"">
                        <p class=""p-2"">
                        This project consists of two parts: the actual app and the server logic, which supports data backup and other functionalities. You can find links to both repositories at the top of this page.
                        The app is still in an early stage of its development, but I managed to develop the following functionalit");
            WriteLiteral(@"ies:
                        </p>
                        <ul>
                            <li><a class=""pl-1"" target=""_blank"" href=""https://github.com/JankowskiZachariasz/AndroidApp/blob/master/app/src/main/java/com/receiptify/DataSyncService.java"">DataSyncService.java</a> - service for syncing data with the server. It uses the ""Retrofit"" library to handle API calls.</li>
                            <li><a class=""pl-1"" target=""_blank"" href=""https://github.com/JankowskiZachariasz/AndroidApp/blob/master/app/src/main/java/com/receiptify/activities/ReceiptsView.java"">ReceiptsView.java</a> - recycler view for displaying receipts</li>
                            <li><a class=""pl-1"" target=""_blank"" href=""https://github.com/JankowskiZachariasz/AndroidApp/blob/master/app/src/main/java/com/receiptify/activities/AddReceipt.java"">AddReceipt.java</a> - CloudVision integration for OCR (heavily inspired by Google's example)</li>
                            <li><a class=""pl-1"" target=""_blank"" href=""https://github.com/");
            WriteLiteral(@"JankowskiZachariasz/AndroidApp/tree/master/app/src/main/java/com/receiptify/data"">data</a> - package for the local Room database</li>
                        </ul>
                        <a target=""_blank"" href=""\Images\projects\diagram.png""><img src=""\Images\projects\diagram.png"" class=""dontexceed d-inline-block mr-1 """);
            BeginWriteAttribute("alt", " alt=\"", 6549, "\"", 6555, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>  
                        <p class=""p-2"">
                        The back-end is a simple RESTful API developed with .NET Core. While developing it, I used <a class=""pl-1"" target=""_blank"" href=""https://jasonwatmore.com/post/2019/10/14/aspnet-core-3-simple-api-for-authentication-registration-and-user-management"">this</a> project from Jason Watmore's blog to learn how to implement a token-based authentication.  Once a user is logged in, they can manage their data using GET, POST, PUT, UPDATE, and DELETE Http requests. This time I decided not to use the migration-based database because I knew I would change its schema multiple times.
                        </p>
                </div>
            </div>

            

            <div class=""sect  p-1 pl-2 rounded d-flex d-inline-block"" onclick=""toggle('3')""><h4 class=""mb-0"">Databases</h4> <h4 id=""i3"" class=""mb-0 ml-auto mr-2"">+</h4> </div>
            <div id=""t3"" class=""par mb-2"">
                
                <div class=""p-2"">
         ");
            WriteLiteral(@"           <p class=""p-2"">
                        The databases for both front-end and back-end have undergone many changes, and this is the current ER diagram for front-end:
                    </p>
                <a target=""_blank"" href=""\Images\projects\AndroDB.png""><img src=""\Images\projects\AndroDB.png"" class=""dontexceed d-inline-block mr-1 """);
            BeginWriteAttribute("alt", " alt=\"", 7934, "\"", 7940, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>  
                    <p class=""p-2"">
                            <ul>
                            <li>The database on the server contains the additional ""owner"" column in each table and the table of users for authentication. </li>
                            <li>The SERVER_ID helps keep both databases consistent.</li>
                            <li>We are currently planning to add a table for amended data (edited or deleted) to make the app propagate any changes to the server before synchronization.</li>
                            </ul>
                        
                    </p>
                    
                </div>
            </div>

            <div class=""sect  p-1 pl-2 rounded d-flex d-inline-block"" onclick=""toggle('4')""><h4 class=""mb-0"">Syncing Data</h4> <h4 id=""i4"" class=""mb-0 ml-auto mr-2"">+</h4> </div>
            <div id=""t4"" class=""par mb-2"">
                <div class=""p-2"">
                     <p class=""p-2"">
                        Let's see how data is ex");
            WriteLiteral(@"changed between the client and server by analyzing the following example:
                        </p>
                        <p class=""p-2"">
While adding a new receipt, the user needs to choose one of the supported companies. For that reason, our application should pull an up-to-date list of companies from the server. A method from DataSyncService.java does exactly that. 
                        </p>                
<pre><code class=""lang-java ml-3 mr-3"">
    private synchronized void syncCompanies(){

        while(token==null)login();
        JsonArray companies_server = Companies_server();
        for(int i=0;i < companies_server.size();i++){
            Companies");
            BeginWriteAttribute("c", " c =", 9653, "", 9657, 0);
            EndWriteAttribute();
            WriteLiteral(@" new Companies(companies_server.get(i).getAsJsonObject().get(""id"").getAsString(),companies_server.get(i).getAsJsonObject().get(""name"").getAsString());
            dBreference.insert(c);
        }


        Toast.makeText(this,""Finished loading companies!"",Toast.LENGTH_LONG).show();
    }

    private synchronized JsonArray Companies_server(){
        JsonArray companies =null;
        try {");
            BeginWriteAttribute("companies", "\r\n            companies =", 10060, "", 10085, 0);
            EndWriteAttribute();
            WriteLiteral(@" service.getCompanies(token).execute().body();
        }catch (Exception e){e.printStackTrace();}

        return companies;
    }
</code></pre>
                        <p class=""p-2"">
                            It first makes sure that a valid token is present and authenticates with the server if it's not. It uses methods from the Retrofit interface to achieve that communication.
                        </p>
<pre><code class=""lang-java ml-3 mr-3"">
    private interface RESTfulServer {


        &#64POST(""users/register"")
        Call< JsonObject> register(&#64Body JsonObject locationPost);

        &#64POST(""users/authenticate"")
        Call< JsonObject> authenticate(&#64Body JsonObject locationPost);

        &#64GET(""companies"")
        Call< JsonArray> getCompanies(&#64Header(""Authorization"") String authHeader);

        &#64GET(""users/{id}"")
        Call< JsonObject> getUsers(&#64Path(""id"") int groupId, &#64Header(""Authorization"") String authHeader);

        &#64PUT(""users/{id}");
            WriteLiteral(@""")
        Call< JsonObject> setUsers(&#64Path(""id"") int groupId, &#64Header(""Authorization"") String authHeader, &#64Body JsonObject updated);


    }
</code></pre>
<p class=""p-2"">
The Server responds, sending a JSON file with all the supported companies.
</p>
<pre><code class=""lang-cs ml-3 mr-3"">
 [HttpGet]
        public IActionResult Get()
        {
            IEnumerable< Companies > companies = _companies.GetAll();
            JsonResult a = new JsonResult(companies);
            return Ok(a);
        }
</code></pre>
                </div>

            </div>

            <div class=""sect  p-1 pl-2 rounded d-flex d-inline-block"" onclick=""toggle('5')""><h4 class=""mb-0"">Team Work</h4> <h4 id=""i5"" class=""mb-0 ml-auto mr-2"">+</h4> </div>
            <div id=""t5"" class=""par mb-2"">
                <div class=""p-2"">
                        <p class=""p-2"" >
                        We develop this app in a group of 3 developers. On 4th February, we finished our first sprint. The two coll");
            WriteLiteral(@"eagues of mine are less familiar with Android development, so we have an opportunity to learn good agile practices by coding together. We meet every week to discuss current challenges and exchange our experiences and newly acquired skills. Good communication allows us even to work simultaneously on the same files and to merge them later without issues. We use GitHub to combine our code, Trello to manage sprints, and Slack to discuss various details. Our group is the best example of how politeness can boost any collaboration among programmers (as researched and published in <a href=""https://www.researchgate.net/publication/271384912_Would_you_mind_fixing_this_issue_An_Empirical_Analysis_of_Politeness_and_Attractiveness_in_Software_Developed_Using_Agile_Boards"" target=""_blank"">this paper</a> by one of our lecturers).
                         </p>  
              </div>
            </div>




        </div>




    </div>

    <div class=""d-flex justify-content-center bg-white  col-lg-6 offset-lg-");
            WriteLiteral("3 \">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1024067cc24b0a23f183e40c900f877f2a071e0320327", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</main>
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1024067cc24b0a23f183e40c900f877f2a071e0321865", async() => {
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
            WriteLiteral("\r\n<script>\r\n    toggle(\'1\');\r\n</script>\r\n\r\n");
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
