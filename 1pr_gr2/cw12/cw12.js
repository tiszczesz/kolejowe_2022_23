const btn = document.querySelector("img");

btn.addEventListener("click", function () {
    const div = document.createElement("div");
    div.innerHTML = "Hello from JS";
    document.querySelector("#result").appendChild(div);
});

btn.addEventListener("mouseenter",function(event){
    event.target.src = "media/b2.png";
});
btn.addEventListener("mouseleave",function(event){
    event.target.src = "media/b1.png";
});
btn.addEventListener("mousedown",function(e){
    e.target.src = "media/b3.png";
});
btn.addEventListener("mouseup",function(e){
    e.target.src = "media/b2.png";
});

document.querySelector("h1").addEventListener("click",function(){
    document.querySelector("#result").innerHTML = "";
});