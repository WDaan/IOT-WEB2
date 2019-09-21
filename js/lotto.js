const body = document.getElementsByTagName("body")[0];
const generate = document.getElementById("generate");

//generate & set the numbers
generate.onclick = ev => {
  let arr = [];
  while (arr.length < 6) {
    let r = Math.floor(Math.random() * 100) + 1;
    if (arr.indexOf(r) === -1) arr.push(r);
  }
  setNumbers(arr);
};

// create table
const table = document.createElement("table");
table.classList.add("table", "is-narrow");
table.style.width = "100%";
table.style.height = "50px";
const tbody = document.createElement("tbody");
const trow = document.createElement("tr");
trow.classList.add("is-selected");
//create table data
for (let i = 0; i < 6; i++) {
  const tdata = document.createElement("td");
  tdata.classList.add("subtitle", "is-4");
  tdata.setAttribute('align', 'center');
  tdata.id = i;
  trow.append(tdata);
}

tbody.append(trow);
table.append(tbody);
document.getElementById("table").append(table);

//sets the numbers in the table
const setNumbers = arr => {
  const tds = document.querySelectorAll("td");
  tds.forEach((el, index) => (el.innerHTML = arr[index]));
};
