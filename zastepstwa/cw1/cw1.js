const dane = [
    {login:"login1",password:"qaz",date:"2022-09-09"},
    {login:"login2",password:"qaz",date:"2022-09-09"},
    {login:"login3",password:"qaz",date:"2022-08-09"},
    {login:"login4",password:"qaz",date:"2022-05-09"},
    {login:"login5",password:"qaz",date:"2022-03-09"},
];
document.querySelector("#gen").onclick 
   = function(){
    document
    .querySelector("#result")
    .innerHTML = "Tu bedzie tabelka!!!!";
};