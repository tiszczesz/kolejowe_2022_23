const inputs = document.querySelectorAll("input[type=range]");
console.log(inputs);
for(let i = 0; i<inputs.length; i++){
    inputs[i].nextElementSibling.innerHTML = inputs[i].value;
    inputs[i].addEventListener("input",function(e){
        console.log(e.target.value);
        e.target.nextElementSibling.innerHTML = e.target.value;
    });
}