const todos = [
    "Nakarmić kota",
    "Zjeść coś dobrego",
    "Zrobić to co zwykle po jedzeniu",
    "Pouczyć się JS",
    "Pograć na konsoli",
    "Pełny relaks...","nowy..."
];

function generTodos(todos){
    let html = "<ul>";
    for(let item of todos){
        html += "<li>"+item+"</li>";
    }
    return html + "</ul>";
}
document.querySelector("#result").innerHTML = generTodos(todos);