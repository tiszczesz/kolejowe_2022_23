fetch('https://jsonplaceholder.typicode.com/todos')
      .then(response => response.json())
      .then(json => generList(json));

function generList(data){
    const root = document.querySelector("#root");
    const ul = document.createElement('ul');
    ul.className = 'list-group'
    for(let index = 0 ; index < data.length; index++){
        const li = document.createElement('li');
        li.className = 'list-group-item';
        li.innerHTML = `${data[index].title}`;
        ul.appendChild(li);
    }
    root.appendChild(ul);
}