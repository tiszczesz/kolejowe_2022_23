fetch('https://jsonplaceholder.typicode.com/posts')
    .then(response => response.json())
    .then(json => {
        //  console.log(json);
        fetch('https://jsonplaceholder.typicode.com/users')
            .then(response => response.json())
            .then(users => {
                console.log(users);
                generTable(json, users);
            });

    });

function generTable(data,users) {
    const table = document.createElement('table');
    table.className = 'table table-striped';
    const tHead = table.insertRow();
    tHead.innerHTML = `<th>UserId</th><th>tytuł</th><th>treść</th>`;
    document.querySelector('#root').appendChild(table);
    for (let elem of data) {
        const row = table.insertRow();
        const user = users.find(u=>{return u.id==elem.userId})
        console.log(user);
        console.log(elem.userId);
        row.innerHTML = `<td>${user.name}</td>
        <td>${elem.title}</td>
        <td>${elem.body}</td> `;
    }
}