function TimeUpdate(elem) {
    const time = new Date();
    elem.innerHTML = time.toLocaleTimeString();
}

const timer = document.querySelector(".timer");
TimeUpdate(timer);
setInterval(function () {
    TimeUpdate(timer);
}, 1000);

const months = ["styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec",
    "lipiec", "sierpień", "wrzesień",
    "październik", "listopad", "grudzień"];
const days = ["niedziela", "poniedziałek", "wtorek",
    "środa", "czwartek", "piątek", "sobota"];

function DateUpdate(){
    const currentDate = new Date();
    document.querySelector(".year").innerHTML = currentDate.getFullYear();
    document.querySelector(".date").innerHTML = currentDate.getDate();
    document.querySelector(".month").innerHTML = months[currentDate.getMonth()];
    document.querySelector(".day").innerHTML = days[currentDate.getDay()];
}

DateUpdate();