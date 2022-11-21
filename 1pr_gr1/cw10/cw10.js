const color = document.querySelector("#color");
console.log(color);
color.nextElementSibling.innerHTML = color.value;
color.addEventListener("change",function(){
    console.log("change");
});
color.addEventListener("input",function(e){
    console.log("input: "+e.target.value);
    e.target.nextElementSibling.innerHTML = e.target.value;
    document.body.style.backgroundColor 
             = `rgb(${e.target.value},255,255)`;
});