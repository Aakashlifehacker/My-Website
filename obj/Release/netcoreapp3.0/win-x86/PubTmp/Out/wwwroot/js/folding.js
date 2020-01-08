
function toggle(a) {

    var panel = document.getElementById("t" + a)
    if (panel.style.maxHeight) {
        panel.style.maxHeight = null;
        document.getElementById("i" + a).innerHTML = "+";
    } else {
        panel.style.maxHeight = panel.scrollHeight + "px";
        document.getElementById("i" + a).innerHTML = "-";
    }
}