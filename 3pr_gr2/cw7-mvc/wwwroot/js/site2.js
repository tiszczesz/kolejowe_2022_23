setTimeout(() => {
    let div = document.createElement("div");
    div.innerHTML = "Czas: "+ new Date().toLocaleDateString();
    document.body.appendChild(div);
}, 2000);