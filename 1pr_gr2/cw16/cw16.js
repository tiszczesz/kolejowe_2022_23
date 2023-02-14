document.querySelector("#run").onclick = function(){
    let firstname = document.querySelector("#firstname").value;
    let lastname = document.querySelector("#lastname").value;
    let birthday = document.querySelector("#birthday").value;
    let isOK = document.querySelector("#isOK").checked;
    console.log(firstname,lastname,birthday,isOK);
    if(isOK){
        document.querySelector("#result").innerHTML = 
        `
            <div>Imię: ${firstname} Nazwisko: ${lastname}
            data urodzenia: ${birthday}
            </div>
        `;
    }else{
        document.querySelector("#result")
          .innerHTML = "BRAK ZGODY NA PRZETWARZANIE DANYCH";
    }
}
