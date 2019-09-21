const remainingTime = () => {
  const date = new Date();
  const hours = (date.getHours() < 10 ? "0" : "") + date.getHours();
  const minutes = (date.getMinutes() < 10 ? "0" : "") + date.getMinutes();
  return `${hours} : ${minutes}`;
};

const Finished = () => {
    wekker.style.background = 'Red';
};

let wekker = document.getElementById("wekker");
let wekkerTime = document.getElementById("wekkerTime");

clocktime.innerHTML = remainingTime();

window.setInterval(() => {
  wekkerTime.innerHTML = remainingTime();
  Finished();
}, 1000);
