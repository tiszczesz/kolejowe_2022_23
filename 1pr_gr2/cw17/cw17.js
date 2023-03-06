const books = [
    "ABC programowania w JS",
    "Rybki akwariowe",
    "Góry polskie - przewodnik",
    "Encyklopedia głupoty"
]
function generBooks(books){
    let html  = "<ul>";
    for(let b of books){
        html += `<li>${b}</li>`;
    }
    return html+"</ul>";
}
document.querySelector("#addNew").onclick = function(){
    books.push(document.querySelector("#newTitle").value);
    document.querySelector("#list").innerHTML = generBooks(books);
}
document.querySelector("#list").innerHTML = generBooks(books);