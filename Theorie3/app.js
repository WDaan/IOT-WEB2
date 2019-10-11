const NUM_DATA_POINTS = 20;

const tbody = document.getElementById("tbody");

$.getJSON(
  `https://www.rubu.be/iot/co2/co2.php?numberOfDataPoints=${NUM_DATA_POINTS}`,
  data => {
    //create td's with id
    for (let i = 0; i < NUM_DATA_POINTS; i++) {
      let trow = document.createElement("tr");
      let th = document.createElement("th");
      let tdata = document.createElement("td");
      tdata.setAttribute("align", "center");
      trow.id = i;
      trow.classList.add("trow");
      trow.appendChild(th);
      trow.appendChild(tdata);

      tbody.append(trow);
    }

    setNumbers(data.data);
  }
);

//sets the numbers in the table
const setNumbers = data => {
  $(".trow").each((index, el) => {
    let th = el.childNodes[0];
    let td = el.childNodes[1];

    th.innerHTML = data[index].time;
    td.innerHTML = data[index].co2;
  });
};
