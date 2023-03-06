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
        html += `<li><span>${item}</span>
                <span><img class='icon' src='media/edit.png' alt='edytuj'></span>
                <span><img class='icon' src='media/delete.png' alt='usuń'></span>
                </li>`;
    }
    return html + "</ul>";
}
document.querySelector("#result").innerHTML = generTodos(todos);
document.querySelector("#addToList").onclick = function(){
    todos.push(document.querySelector("#addNew").value);
    document.querySelector("#result").innerHTML = generTodos(todos);
    document.querySelector("#addNew").value = ""
};