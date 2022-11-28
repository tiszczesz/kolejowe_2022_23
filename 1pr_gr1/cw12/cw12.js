const btn = document.querySelector("img");
btn.addEventListener("click", function () {
    const div = document.createElement("div");
    div.innerHTML = "To dzięki przyciskowi!!";
    document.querySelector("#wynik").appendChild(div);
});
btn.addEventListener("mouseenter", function (e) {
    e.target.src = "images/b2.png";
});
btn.addEventListener("mouseleave", function (e) {
    e.target.src = "images/b1.png";
});
btn.addEventListener("mousedown", function (e) {
    e.target.src = "images/b3.png";
});
btn.addEventListener("mouseup", function (e) {
    e.target.src = "images/b2.png";
});
document.querySelector("h1")
    .addEventListener("click", function () {
        document.querySelector("#wynik").innerHTML = "";
    });