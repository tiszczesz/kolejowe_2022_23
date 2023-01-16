function TimeUpdate(elem) {
    const time = new Date();
    elem.innerHTML = time.toLocaleTimeString();
}

const timer = document.querySelector(".timer");
TimeUpdate(timer);
setInterval(function () {
    TimeUpdate(timer);
}, 1000);