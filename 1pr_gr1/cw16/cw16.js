let counter = 0;
function updateCounter(){
    document.querySelector(".timer").innerHTML = counter;
}
updateCounter();
setInterval(function(){
    counter++;
    updateCounter();
},1000);
