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
document.querySelector("#list").innerHTML = generBooks(books);