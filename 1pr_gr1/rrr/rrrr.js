async function getData(){
    const response = await fetch('https://jsonplaceholder.typicode.com/posts/');
    const json = await response.json();    
    console.log(json);
}
getData();
// fetch('https://jsonplaceholder.typicode.com/posts')
//       .then(response => response.json())
//       .then(json => console.log(json))