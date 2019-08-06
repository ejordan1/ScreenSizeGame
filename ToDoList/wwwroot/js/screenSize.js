// javascript code here

console.log("javascript code started");
setScreenWidth();



setInterval(function(){
    console.log("still running js!");
    console.log("SCREEN WIDTH: " + window.innerWidth);
    setScreenWidth();
}, 100);

function setScreenWidth(){
    $('#Width').val(window.innerWidth);
}