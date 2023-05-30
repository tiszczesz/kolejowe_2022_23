fetch('https://jsonplaceholder.typicode.com/users')
      .then(response => response.json())
      .then(json => generList(json));
console.log("Hello");

function generList(data){
    const ul = document.createElement('ul');
    ul.className = 'list-group';
    for(let u of data){
        const li = document.createElement('li');
        li.className = 'list-group-item';
        li.innerHTML = `id: ${u.id} name: ${u.name}`;
        ul.appendChild(li);
    }
    document.querySelector('#root').appendChild(ul);
}