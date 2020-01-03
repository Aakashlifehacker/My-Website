
function like(i) {

    
    if (document.getElementById("heart" + i).getAttribute("data-on")=="true")
        document.getElementById("heart" + i).setAttribute("data-on", "false")
    else document.getElementById("heart" + i).setAttribute("data-on", "true");
    if (document.getElementById("heart" + i).getAttribute("data-on") == "true") {
        $.getJSON("/feed/like/" + i, function (data) {
            console.log(data.count);
            if (data.count == -2) {
                toastr.warning('Please sign in to like posts!');
                
            }
                
            else
               
                document.getElementById("Count" + i).innerHTML = data.count;
            
        });
        //jquery function is asynchronous so the animation is displayed instantly
        if (signed) {
            document.getElementById('heart' + i).src = '/Images/heart.gif';

            setTimeout(function () {

                document.getElementById('heart' + i).src = '/Images/heart_full.png';
            }, 400);//400ms - this is how long it takes for heart.gif to go through one cycle. after that .gif file is replaced with the static .png image
        }
        
    }

    else {
        $.getJSON("/feed/dislike/" + i, function (data) {
            console.log(data.count);
            if (data.count == -2) {
                toastr.warning('Please sign in to like posts!');
                
            }
            else
                document.getElementById("Count" + i).innerHTML = data.count;

        });

        //jquery function is asynchronous so the animation is displayed instantly
        if (signed) {
            document.getElementById('heart' + i).src = '/Images/heartR.gif';
            setTimeout(function () {

                document.getElementById('heart' + i).src = '/Images/heart.png';
            }, 400);//400ms - this is how long it takes for heartR.gif to go through one cycle. after that .gif file is replaced with the static .png image
        }

    }
   
}
