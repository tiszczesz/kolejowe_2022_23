function showTime(elem) {
    const time = new Date();
    elem.innerHTML = time.toLocaleTimeString();
}

const timer = document.querySelector(".timer");
showTime(timer);
setInterval(function () {
    showTime(timer);
}, 1000);
const days = ["niedziela", "poniedziałek", "wtorek", "środa", "czwartek",
    "piątek", "sobota"];
const months = ["styczeń", "luty", "marzec", "kwiecień", "maj",
    "czerwiec", "lipiec", "sierpień", "wrzesień", "październik",
    "listopad", "grudzień"];
function setDate() {
    const currentDate = new Date();
    document.querySelector(".year").innerHTML = currentDate.getFullYear();
    document.querySelector(".month")
        .innerHTML = months[currentDate.getMonth()];
    document.querySelector(".date").innerHTML = currentDate.getDate();
    document.querySelector(".day")
        .innerHTML = days[currentDate.getDay()];
}
setDate();
