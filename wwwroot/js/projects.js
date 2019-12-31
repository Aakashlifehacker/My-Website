var pics = ["Images/web", "/Images/rece","/Images/finch","/Images/android","/Images/gui"];
for(var i=1;i<=pics.length;i++){$(".k"+i).css("background-image", "url('"+pics[i-1]+".png')");}//setting background images for project tiles
var images = new Array();
for (i = 0; i < pics.length; i++) {images[i] = new Image(); images[i].src = pics[i]+"_hovered.png";}//preloading images


function resize() {
    var w6 = document.getElementById("ref6").clientWidth;
    var h6 = w6 * 3 / 4;
    var txt6 = h6 + "px"
    $(".rs6").css("height", txt6);

    // var w4 = document.getElementById("ref4").clientWidth;
    // var h4 = w4 * 3 / 4;
    // var txt4 = h4 + "px"
    // $(".rs4").css("height", txt4);


    for(var i=1;i<=5;i++){
        if(window.innerWidth >=992){
            $("#p"+i).css("visibility", "hidden");
        }
        else {
            $("#p"+i).css("visibility", "visible");
        }
    } 

    $(".article").css("min-height", window.innerHeight - 103);
}
$(document).ready(resize());



for(var i=1;i<=5;i++){
    $(".k"+i).hover(function () {
        var number = $(this).data('num');
        $(this).css("background-image", "url('"+pics[number-1]+"_hovered.png')");
       
       $("#p"+number).css("visibility", "visible");
        
    }, function () {
        var number = $(this).data('num');
            $(this).css("background-image", "url('"+pics[number-1]+".png')");
            
            if(window.innerWidth >=992)
            
        $("#p"+number).css("visibility", "hidden");

    });
}


