#pragma checksum "C:\Users\Ian Brinkerhoff\OneDrive\Desktop\repo\TypingGame\Group1Remastered-main\Group1Remastered-main\Typing-G1\Typing\Pages\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06bbfa3d7592fa880af975bb65545a546640f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Typing.Pages.Pages_Game), @"mvc.1.0.razor-page", @"/Pages/Game.cshtml")]
namespace Typing.Pages
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
#line 1 "C:\Users\Ian Brinkerhoff\OneDrive\Desktop\repo\TypingGame\Group1Remastered-main\Group1Remastered-main\Typing-G1\Typing\Pages\_ViewImports.cshtml"
using Typing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06bbfa3d7592fa880af975bb65545a546640f29", @"/Pages/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58f7fd1c281f4de1466f65b79606e943a1885af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Game : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("user1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onkeydown", new global::Microsoft.AspNetCore.Html.HtmlString("return event.key != \'Enter\';"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("user2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"gameScreen\">\r\n    <div class=\"left\" id=\"p1\">\r\n        <h2 id=\"currentUser\">");
#nullable restore
#line 7 "C:\Users\Ian Brinkerhoff\OneDrive\Desktop\repo\TypingGame\Group1Remastered-main\Group1Remastered-main\Typing-G1\Typing\Pages\Game.cshtml"
                        Write(UserStatus.currentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
        <h2 id=""scoreOne"">0</h2>
        <button id=""startBtn"" class=""myButton"" disabled>Start</button>
        <h3 id=""p1Final"" style=""visibility:collapse""></h3>
        <div class=""wordBox1 1"" style=""margin-top: 50px""><p id=""1""></p></div>
        <div class=""wordBox1 2"" style=""top:150px""><p id=""2""></p></div>
        <div class=""wordBox1 3"" style=""top:230px""><p id=""3""></p></div>
        <div class=""wordBox1 4"" style=""top:310px""><p id=""4""></p></div>
        <div class=""wordBox1 5"" style=""top:390px""><p id=""5""></p></div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b06bbfa3d7592fa880af975bb65545a546640f296047", async() => {
                WriteLiteral("\r\n            <input type=\"text\" name=\"user1\" id=\"tb1\"");
                BeginWriteAttribute("value", " value=\"", 831, "\"", 839, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""right"" id=""p2"">
        <h2 id=""opponent""></h2>
        <h2 id=""scoreTwo"">0</h2>
        <h3 id=""waiting"">Waiting on opponent...</h3>
        <h3 id=""p2Final"" style=""visibility:collapse""></h3>
        <div class=""wordBox 1"" style=""margin-top:50px""><p id=""6""></p></div>
        <div class=""wordBox 2"" style=""top:150px""><p id=""7""></p></div>
        <div class=""wordBox 3"" style=""top:230px""><p id=""8""></p></div>
        <div class=""wordBox 4"" style=""top:310px""><p id=""9""></p></div>
        <div class=""wordBox 5"" style=""top:390px""><p id=""10""></p></div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b06bbfa3d7592fa880af975bb65545a546640f298391", async() => {
                WriteLiteral("\r\n            <input type=\"text\" name=\"user2\" id=\"tb2\"");
                BeginWriteAttribute("value", " value=\"", 1589, "\"", 1597, 0);
                EndWriteAttribute();
                WriteLiteral(" readonly/>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b06bbfa3d7592fa880af975bb65545a546640f2910409", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"
<script>
    var arr =
        [
            ""BASEBALL"", ""RACECAR"", ""CACTUS"", ""SAMURAI"", ""HOCKEY"", ""WORD"", ""BUG"", ""DINOSAUR"", ""COMPUTER"", ""TYPING"",
            ""BASKETBALL"", ""MOUSE"", ""BENCH"", ""GRAPES"", ""SOCKS"", ""RIVER"", ""ZOO"", ""DRUM"", ""LIZARD"", ""BASKETBALL"",
            ""CHEESE"", ""PURSE"", ""WATER"", ""EYE"", ""COMB"", ""ROCK"", ""LEMON"", ""CAMERA"", ""JELLYFISH"", ""ORANGE"",
            ""SWING"", ""NOSE"", ""DRAGON"", ""BUTTERFLY"", ""FORK"", ""MOUTH"", ""HEAD"", ""MILK"", ""ARM"", ""PERSON"",
            ""KING"", ""GIRL"", ""WORM"", ""RABBIT"", ""BRAD"", ""PETERSON"", ""EGG"", ""BALLOON"", ""OWL"", ""BIRD"",
            ""FLY"", ""FALCON"", ""BLUE"", ""GRASS"", ""SNOWFLAKE"", ""JAIL"", ""MOUNTAIN"", ""TRUCK"", ""FALL"", ""HALLOWEEN"",
            ""COVER"", ""RACE"", ""TABLE"", ""IMAGE"", ""BREAD"", ""SLIDE"", ""BRIDGE"", ""COAT"", ""SHIRT"", ""BEAR"",
            ""ANGEL"", ""SEA"", ""CLOUD"", ""WINDOW"", ""LIPS"", ""PILLOW"", ""RAINBOW"", ""TORNADO"", ""AIRPLANE"", ""POLICE"",
            ""KEY"", ""HAMBURGER"", ""BONE"", ""MONSTER"", ""BOW"", ""ALLIGATOR"", ""BRACELET"", ""ANT"", ""WHALE"", ""TURTLE"",
            ""SWIM""");
            WriteLiteral(@", ""APPLE"", ""CARROT"", ""BOOK"", ""COIN"", ""CUPCAKE"", ""PENCIL"", ""BOAT"", ""FINGER"", ""DOOR""
        ];

    var currentUser = $(""#currentUser"").html();
</script>


<script>

    ""use strict"";
    var p2count = 5;
    var connection = new signalR.HubConnectionBuilder().withUrl(""/messageHub"").build();
    var msg,
        p1Score = 0,
        p2Score = 0;

    //Disables the form automatic post on 'enter'
    $(document).on(""keydown"", ""form"", function (event) {
        return event.key != ""Enter"";
    });

    var newGame = setInterval(sendNewGame, 200);

    //Sends msg when game loads to enable the start game button
    function sendNewGame() {
        var username = currentUser;
        var input = 'newGame';
        connection.invoke(""SendInput"", username, input).catch(function (err) {
            return console.error(err.toString());
        });
    }

    //When messages is received it checks it for key msgs, otherwise it takes
    //the users input as part of the game
    connect");
            WriteLiteral(@"ion.on(""ReceiveMessage"", function (username, input) {
        msg = input;
        if (msg == ""newGame"") {
            $('#opponent').html(username);
            $('#startBtn').prop('disabled', false);
        }
        else if (msg == ""ready"") {
            clearInterval(newGame);
            $('#waiting').html('Player Ready!');
            $('#opponent').html(username);
        }
        else if (msg == ""start"") {
            $('#waiting').hide();
            $('#opponent').html(username);
            popP();
            animateOne();
            animateTwo();
        }
        else {
            $('#opponent').html(username);
            var substring = msg;
            var $div = $('#gameScreen'),
                $half = $('#p2'),
                docWidth = $div.width(),
                halfW = $half.width()

            $('#tb2').val(substring);
            //Scans each word on users side with their input to look for matches
            $('.wordBox').each(function () {
      ");
            WriteLiteral(@"          var string = $(this).text();
                if (string == substring) {
                    p2Score++;
                    $('#scoreTwo').html(p2Score);
                    $('#tb2').val('');
                    $(this).text(arr[p2count]);
                    p2count++;
                    $(this).stop(true).css({
                        ""position"": ""absolute"",
                        ""left"": (docWidth - halfW) + ""px"",
                        ""text-align"": ""right""
                    });
                    //Stages of the game to ensure it gets more difficult as the game progresses
                    if (p2count < 10) {
                        $(this).animate({ left: (docWidth - 75) + 'px' }, 20000, 'linear', function () { gameOverP2(); });
                    } else if (p2count < 20) {
                        $(this).animate({ left: (docWidth - 75) + 'px' }, 17000, 'linear', function () { gameOverP2(); });
                    } else if (p2count < 30) {
                        $(");
            WriteLiteral(@"this).animate({ left: (docWidth - 75) + 'px' }, 15000, 'linear', function () { gameOverP2(); });
                    } else if (p2count < 40) {
                        $(this).animate({ left: (docWidth - 75) + 'px' }, 13000, 'linear', function () { gameOverP2(); });
                    } else if (p2count < 50) {
                        $(this).animate({ left: (docWidth - 75) + 'px' }, 12000, 'linear', function () { gameOverP2(); });
                    } else if (p2count < 60) {
                        $(this).animate({ left: (docWidth - 75) + 'px' }, 11000, 'linear', function () { gameOverP2(); });
                    } else if (p2count < 70) {
                        $(this).animate({ left: (docWidth - 75) + 'px' }, 10000, 'linear', function () { gameOverP2(); });
                    } else if (p2count < 80) {
                        $(this).animate({ left: (docWidth - 75) + 'px' }, 9000, 'linear', function () { gameOverP2(); });
                    } else if (p2count < 90) {
                   ");
            WriteLiteral(@"     $(this).animate({ left: (docWidth - 75) + 'px' }, 8000, 'linear', function () { gameOverP2(); });
                    } else {
                        $(this).animate({ left: (docWidth - 75) + 'px' }, 7000, 'linear', function () { gameOverP2(); });
                    }
                }
                //Bolds substring of string that user types
                else if (string.startsWith(substring)) {
                    $(this).html(
                        '<b>' + string.substr(0, substring.length) + '</b>' + string.substr(substring.length)
                    )
                } else {
                    $(this).css({
                        ""font-weight"": ""normal"",
                        ""font-size"": ""16px""
                    });
                }
            });
        }
    });

    connection.start().then(function () {
    }).catch(function (err) {
        return console.error(err.string());
    });

    //Everytime the player presses a key a new substring is sent to ");
            WriteLiteral(@"the opponents game
    $('#tb1').keyup(function () {
        var username = currentUser;
        var input = $('#tb1').val().toUpperCase();
        connection.invoke(""SendInput"", username, input).catch(function (err) {
            return console.error(err.toString());
        });
    });

    //Ensures both players are ready before starting the game
    $('#startBtn').click(function () {
        $('#startBtn').hide();
        if ($('#waiting').text() == 'Player Ready!') {
            $('#waiting').hide();
            sendStartMessage();
            popP();
            animateOne();
            animateTwo();
        } else {
            var username = currentUser;
            var input = 'ready';
            connection.invoke(""SendInput"", username, input).catch(function (err) {
                return console.error(err.toString());
            });
        }
    });

    //Message that is called when a users game screen loads to notify other player of readiness
    function sendStartM");
            WriteLiteral(@"essage() {
        var username = currentUser;
            var input = 'start';
            connection.invoke(""SendInput"", username, input).catch(function (err) {
                return console.error(err.toString());
            });
    }


</script>

<script>

    var p1count = 5;


    //on click populate p's with words
    function popP() {
        var x = 0;
        $(""p"").each(function () {
            $(this).text(arr[x]);
            x++;
            if (x >= 5) {
                x = 0;
            }
        });
    }

    //Register listener for Num Players

    //PLAYER 1 SIDE USING ANIMATE
    function animateOne() {
        var $div = $('#p1'),
            docWidth = $div.width(),
            num = 0,
            docHeight = $div.height();


        $('#user1').css({
            'left': (docWidth / 2) - 100 + 'px',
            'visibility': 'visible'
        });

        $('#user2').css({
            'left': ((docWidth / 2) + docWidth) - 100 + 'px',
    ");
            WriteLiteral(@"        'visibility': 'visible'
        });

        $.each($('#p1'), function (i, left) {
            var x = 0;
            $('div', left).each(function () {
                $(this).css({
                    'position': 'absolute',
                    'top': ((docHeight) * (x / 5) + 50) + 'px'
                });
                x++;
                $(this).animate({ left: (docWidth - 75) + 'px' }, 20000, 'linear', function () {
                    gameOverP1();
                });
            });
        })
    }


    //PLAYER 2 SIDE USING ANIMATE
    function animateTwo() {
        var $div = $('#gameScreen'),
            fullWidth = $div.width(),
            docHeight = $div.height(),
            num = 0;

        $.each($('#p2'), function (i, left) {
            var x2 = 0;
            $('div', left).each(function () {
                $(this).css({
                    'position': 'absolute',
                    'top': ((docHeight) * (x2 / 5) + 50) + 'px'
                ");
            WriteLiteral(@"});
                x2++;
                $(this).animate({ left: (fullWidth - 75) + 'px' }, 20000, 'linear', function () {
                    gameOverP2();
                });

            });
        })
    }

    //When player hits a key, it compares substring to words on players screen
    $('#tb1').keyup(function () {
        var substring = $('#tb1').val().toUpperCase();
        var $div = $('#p1'),
            docWidth = $div.width()
        $('.wordBox1').each(function () {
            var string = $(this).text();
            if (string == substring) {
                p1Score++;
                $('#scoreOne').html(p1Score);
                $('#tb1').val('');
                $(this).text(arr[p1count]);
                p1count++;
                $(this).stop(true).css({
                    ""position"": ""absolute"",
                    ""left"": ""-50px"",
                    ""text-align"": ""right""
                });
                if (p1count < 10) {
                    $(this).");
            WriteLiteral(@"animate({ left: (docWidth - 75) + 'px' }, 20000, 'linear', function () { gameOverP1(); });
                } else if (p1count < 20) {
                    $(this).animate({ left: (docWidth - 75) + 'px' }, 17000, 'linear', function () { gameOverP1(); });
                } else if (p1count < 30) {
                    $(this).animate({ left: (docWidth - 75) + 'px' }, 15000, 'linear', function () { gameOverP1(); });
                } else if (p1count < 40) {
                    $(this).animate({ left: (docWidth - 75) + 'px' }, 13000, 'linear', function () { gameOverP1(); });
                } else if (p1count < 50) {
                    $(this).animate({ left: (docWidth - 75) + 'px' }, 12000, 'linear', function () { gameOverP1(); });
                } else if (p1count < 60) {
                    $(this).animate({ left: (docWidth - 75) + 'px' }, 11000, 'linear', function () { gameOverP1(); });
                } else if (p1count < 70) {
                    $(this).animate({ left: (docWidth - 75) + 'px' }");
            WriteLiteral(@", 10000, 'linear', function () { gameOverP1(); });
                } else if (p1count < 80) {
                    $(this).animate({ left: (docWidth - 75) + 'px' }, 9000, 'linear', function () { gameOverP1(); });
                } else if (p1count < 90) {
                    $(this).animate({ left: (docWidth - 75) + 'px' }, 8000, 'linear', function () { gameOverP1(); });
                } else {
                    $(this).animate({ left: (docWidth - 75) + 'px' }, 7000, 'linear', function () { gameOverP1(); });
                }
            }
            else if (string.startsWith(substring)) {
                $(this).html(
                    '<b>' + string.substr(0, substring.length) + '</b>' + string.substr(substring.length)
                )
            } else {
                $(this).css({
                    ""font-weight"": ""normal"",
                    ""font-size"": ""16px""
                });
            }
        });
    });

    //Displays users game score when game is over
    f");
            WriteLiteral(@"unction gameOverP1() {
        var f1 = $('scoreOne').html();
        $(""#tb1"").prop(""disabled"", true);
        $('#p1Final').html(""Game Over!<br>Final score: "" + p1Score);
        $('#p1Final').css({
            'visibility': 'visible',
            'position': 'absolute',
            'left': '40%',
            'top': '40%',
            'text-align': 'center'
        });
        $('.wordBox1').each(function () {
            $(this).finish();
            $(this).stop();
        });
        $('.left').css(""background-color"", ""#ff9999"");
    }

    function gameOverP2() {
        var f2 = $('scoreTwo').html();
        $('#p2Final').html(""Game Over!<br>Final score: "" + p2Score);
        $('#p2Final').css({
            'visibility': 'visible',
            'position': 'absolute',
            'left': '70%',
            'top': '40%',
            'text-align': 'center'
        });
        $('.wordBox').each(function () {
            $(this).finish();
            $(this).stop();
        }");
            WriteLiteral(@");
        $('.right').css(""background-color"", ""#ff6666"" );
    }

    window.onload = sendNewGame();

</script>

<style>

    /* Control the left side */
    .left {
        width: 50%;
        float: left;
        background-color: #f9cb85;
        min-height: 100%;
        margin: 0;
        position: absolute;
    }

    /* Control the right side */
    .right {
        width: 50%;
        float: right;
        background-color: #e99c57;
        min-height: 100%;
        margin: 0;
    }

    html, body {
        height: 100%;
        margin: 0;
    }

    body {
        overflow: hidden;
        background-color: white;
        margin: 0 auto;
        position: relative;
        width: 100%;
        height: 100%;
    }

    header {
        display: block;
        width: 100%;
        height: 54px;
    }

    #gameScreen {
        border: 1px black solid;
        width: 100%;
        position: absolute;
        top: 54px;
        bottom: 60px;
      ");
            WriteLiteral(@"  left: 0;
    }

    h2 {
        text-align: left;
    }

    .wordBox, .wordBox1 {
        height: 50px;
        width: auto;
        margin: 5px;
        color: black;
        text-align: right;
    }

    #finalMsg {
        visibility: collapse;
    }

    p {
        text-align: left;
        margin: auto;
    }

    #p1, #p2 {
    }

    #user1, #user2 {
        position: absolute;
        bottom: 0px;
        visibility: hidden;
    }

    #startBtn {
        position: absolute;
        left: 40%;
        top: 40%;
        text-align: center;
    }

    #waiting {
        position: absolute;
        left: 65%;
        top: 40%;
        text-align: center;
    }

    #scoreOne {
        position: absolute;
        left: 50%;
        top: 0%;
        text-align: right;
    }

    #scoreTwo {
        position: absolute;
        left: 75%;
        top: 0%;
        text-align: center;
    }

    .myButton {
        box-shadow: 0px 0px 0px 2px #");
            WriteLiteral(@"9fb4f2;
        background-color: darkgray;
        border-radius: 10px;
        border: 1px solid #4e6096;
        display: inline-block;
        cursor: pointer;
        color: #ffffff;
        font-family: Trebuchet MS;
        font-size: 21px;
        font-weight: bold;
        padding: 15px 40px;
        text-decoration: none;
        text-shadow: 0px 1px 0px #283966;
    }

    .myButton:hover {
        background-color: #476e9e;
    }

    .myButton:active {
        position: relative;
        top: 1px;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Typing.Pages.GameModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Typing.Pages.GameModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Typing.Pages.GameModel>)PageContext?.ViewData;
        public Typing.Pages.GameModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
