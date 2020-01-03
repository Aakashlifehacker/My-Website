


$(document).ready(function () {
    $(".hov").hover(function () {
        $(this).css("background-color", "yellow");
    }, function () {
        $(this).css("background-color", "white");
    });
});





function myFunction() {
    var copyText = document.getElementById("em");
    copyText.select();
    copyText.setSelectionRange(0, 99999);
    document.execCommand("copy");
};