function showTime(elem){
    const time = new Date();
    elem.innerHTML = time.toLocaleTimeString();
}

const timer = document.querySelector(".timer");
showTime(timer);
setInterval(function(){
    showTime(timer);
},1000);