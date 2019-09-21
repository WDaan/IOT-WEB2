let totalSeconds = 0;
let inititalTotalSeconds = 0;
let wekker = document.getElementById("wekker");
let wekkerTime = document.getElementById("wekkerTime");
let progress = document.getElementById("progress");

let timer;
let finished_interval;

function runTimer() {
  return window.setInterval(() => {
    totalSeconds--;
    let minutes = Math.floor(totalSeconds / 60);
    let seconds = Math.floor(totalSeconds % 60);

    minutes = (minutes < 10 ? "0" : "") + minutes;
    seconds = (seconds < 10 ? "0" : "") + seconds;

    wekkerTime.innerHTML = `${minutes}:${seconds}`;

    //progressbar
    progress.setAttribute("value", inititalTotalSeconds - totalSeconds);

    if (totalSeconds <= 0) {
      clearInterval(timer);
      document.getElementById("timer_input_seconds").innerHTML = 0;
      document.getElementById("timer_input_minutes").innerHTML = 0;
      finished();
    }
  }, 1000);
}

function startTimer() {
  if (!timer) {
    let input_seconds = document.getElementById("timer_input_seconds").value;
    let input_minutes = document.getElementById("timer_input_minutes").value;

    seconds = parseInt(input_seconds);
    minutes = parseInt(input_minutes);
    totalSeconds = seconds + minutes * 60;
    inititalTotalSeconds = totalSeconds;

    progress.setAttribute("max", inititalTotalSeconds);

    //reset input fields
    input_seconds = document.getElementById("timer_input_seconds");
    input_minutes = document.getElementById("timer_input_minutes");
    input_seconds.value = 0;
    input_minutes.value = 0;

    if (totalSeconds > 0) timer = runTimer();
  } else {
    if (totalSeconds > 0 && !timer) timer = runTimer();
  }
}

function stopTimer() {
  clearInterval(timer);
}

function resetTimer() {
  clearInterval(timer);
  clearInterval(finished_interval);
  timer = null;
  totalSeconds = 0;
  inititalTotalSeconds = 0;
  wekkerTime.innerHTML = `00:00`;
  document.body.style.backgroundColor = "White";
  wekker.style.backgroundImage = `linear-gradient( 91.9deg,  rgba(75,207,250,1) 6.2%, rgba(25,159,249,1) 98.9% )`;
  const seconds = document.getElementById("timer_input_seconds");
  seconds.value = 0;
  const minutes = document.getElementById("timer_input_minutes");
  minutes.value = 0;

  progress.setAttribute("value", 0);
}

const finished = () => {
  wekker.style.background = "Red";
  finished_interval = setInterval(() => {
    if (document.body.style.backgroundColor === "white") {
      document.body.style.backgroundColor = "red";
    } else {
      document.body.style.backgroundColor = "white";
    }
  }, 300);
};
