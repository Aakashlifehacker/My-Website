var i = document.getElementById('insta');
var b = document.getElementById('blog');
var t = document.getElementById('twitter');



function Filtering() {
    var wrapper = $('.posts'),
        items = wrapper.children();
    var ids = items.length;

    for (var j = 0; j <= ids; j++)
    {
        var insta = document.getElementById("ii" + j)
        if (insta != null) {
            if (i.checked) {
 
                $("#ii" + j).css("visibility", "visible");
                $("#ii" + j).css("position", "static");
                insta.style.maxHeight = "100%";
               
                
            }
            else {
                insta.style.maxHeight = "0px";
                $("#ii" + j).css("visibility", "hidden");
                $("#ii" + j).css("position", "absolute");
                $("#ii" + j).css("top", "-9999px");
                $("#ii" + j).css("left", "-9999px");

                
            }
        }

        var blog = document.getElementById("bb" + j) 
        if (blog != null) {
            if (b.checked) {
                blog.style.maxHeight = "100%";
                $("#bb" + j).css("visibility", "visible");
                $("#bb" + j).css("position", "static");
                
            }
            else {
                blog.style.maxHeight = "0px";
                $("#bb" + j).css("visibility", "hidden");
                $("#bb" + j).css("position", "absolute");
                $("#bb" + j).css("top", "-9999px");
                $("#bb" + j).css("left", "-9999px");
                
            }
        }

        var tweet = document.getElementById("tt" + j) 
        if (tweet != null) {
            if (t.checked) {
                tweet.style.maxHeight = "100%";
                $("#tt" + j).css("visibility", "visible");
                $("#tt" + j).css("position", "static");
                
            }
            else {
                tweet.style.maxHeight = "0px";
                $("#tt" + j).css("visibility", "hidden");
                $("#tt" + j).css("position", "absolute");
                $("#tt" + j).css("top", "-9999px");
                $("#tt" + j).css("left", "-9999px");
                
            }
        }
    }

    CauseOverflow();

}

function Filtering_endtask() {
    var wrapper = $('.posts'),
        items = wrapper.children();
    var ids = items.length;

    for (var j = 0; j <= ids; j++) {
        var insta = document.getElementById("ii" + j)
        if (insta != null) {
            if (i.checked) {

                $("#ii" + j).css("visibility", "visible");
                $("#ii" + j).css("position", "static");
                insta.style.maxHeight = "100%";


            }
            else {
                insta.style.maxHeight = "0px";
                $("#ii" + j).css("visibility", "hidden");
                $("#ii" + j).css("position", "absolute");
                $("#ii" + j).css("top", "-9999px");
                $("#ii" + j).css("left", "-9999px");


            }
        }

        var blog = document.getElementById("bb" + j)
        if (blog != null) {
            if (b.checked) {
                blog.style.maxHeight = "100%";
                $("#bb" + j).css("visibility", "visible");
                $("#bb" + j).css("position", "static");

            }
            else {
                blog.style.maxHeight = "0px";
                $("#bb" + j).css("visibility", "hidden");
                $("#bb" + j).css("position", "absolute");
                $("#bb" + j).css("top", "-9999px");
                $("#bb" + j).css("left", "-9999px");

            }
        }

        var tweet = document.getElementById("tt" + j)
        if (tweet != null) {
            if (t.checked) {
                tweet.style.maxHeight = "100%";
                $("#tt" + j).css("visibility", "visible");
                $("#tt" + j).css("position", "static");

            }
            else {
                tweet.style.maxHeight = "0px";
                $("#tt" + j).css("visibility", "hidden");
                $("#tt" + j).css("position", "absolute");
                $("#tt" + j).css("top", "-9999px");
                $("#tt" + j).css("left", "-9999px");

            }
        }
    }


}


