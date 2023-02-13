document.querySelector("#run").onclick = function(){
    let firstname = document.querySelector("#firstname").value;
    let lastname = document.querySelector("#lastname").value;
    let birthDay = document.querySelector("#birthDay").value;
    let isOK = document.querySelector("#isOK").checked;
    console.log(firstname,lastname,birthDay,isOK);
    if(isOK){
        document.querySelector("#result").innerHTML = `
            Imię: ${firstname} <br>
            Nazwisko: ${lastname} <br>
            Data urodzenia ${birthDay}
        `;
        document.querySelector("#result").style.color = "blue";
    }else{
        document.querySelector("#result").innerHTML = "Brak zgody";
        document.querySelector("#result").style.color = "red";
    }
}