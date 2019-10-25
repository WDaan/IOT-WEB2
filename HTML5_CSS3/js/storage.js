class Note {
  constructor(id, content) {
    this.id = `note-${id}`;
    this.content = content;
  }
}

//save note when pressing enter key
const input = document.getElementById("note_input");
input.addEventListener("keyup", e => {
  let key = e.which || e.keyCode;
  if (key === 13) {
    addNote();
  }
});

const notes_container = document.getElementById("notes-container");

function addNote() {
  let text = document.getElementById("note_input").value;

  if (text !== "") {
    //remove empty message on first note add
    let notes = localStorage.getItem("notes");
    if (notes.length <= 2 || notes === null) {
      const empty = document.getElementById("empty_notes");
      empty.parentNode.removeChild(empty);
    }

    //save to localstorage
    const note = saveToLocalStorage(text);

    //add note to DOM
    drawNote(note);

    //empty input field
    document.getElementById("note_input").value = "";
  } else {
    alert("Please input something");
  }
}

function drawNote(note) {
  //create card
  const card = document.createElement("div");
  card.classList.add("card", "note");
  card.id = note.id;
  const card_content = document.createElement("div");
  card_content.classList.add("card-content");

  //create colums
  const columns = document.createElement("div");
  columns.classList.add("columns");

  //create text part
  const column1 = document.createElement("div");
  column1.classList.add("column");

  const note_content = document.createElement("div");
  note_content.innerHTML = note.content;

  column1.appendChild(note_content);

  //create delete button
  const button = document.createElement("div");
  button.classList.add("button", "delete-button");
  button.style.float = "right";
  //delete function
  button.setAttribute("onclick", `deleteNote('${note.id}')`);

  const icon = document.createElement("i");
  icon.classList.add("fas", "fa-trash-alt");
  button.appendChild(icon);

  //add both to columns
  columns.appendChild(column1);
  columns.appendChild(button);

  //add columns to DOM
  card_content.appendChild(columns);
  card.appendChild(card_content);

  notes_container.appendChild(card);
}

function saveToLocalStorage(note_content) {
  //if there are no notes yet
  if (localStorage.getItem("notes") == null) {
    let id = 0;
    let notes = [];
    const note = new Note(id, note_content);
    notes.push(note);

    //store
    localStorage.setItem("notes", JSON.stringify(notes));
    id++;
    localStorage.setItem("id", id);

    return note;
  } else {
    //if there are notes, retrieve them & add new one
    let id = localStorage.getItem("id");
    let notes = JSON.parse(localStorage.getItem("notes"));
    const note = new Note(id, note_content);
    notes.push(note);

    //store
    localStorage.setItem("notes", JSON.stringify(notes));
    id++;
    localStorage.setItem("id", id);

    return note;
  }
}

function deleteNote(id) {
  //remove from DOM
  const card = document.getElementById(id);
  card.parentNode.removeChild(card);
  //remove from storage
  let notes = JSON.parse(localStorage.getItem("notes"));
  notes = notes.filter(el => el.id !== id);
  localStorage.setItem("notes", JSON.stringify(notes));

  //if there are no notes left, reset id;
  if (notes.length === 0) {
    localStorage.setItem("id", 0);
    drawEmpty();
  }
}

//check if there are already notes in local storage, if not show a card with appropriate message
window.onload = ev => {
  //2 because 2 brackets in stringyfied aray.
  let notes = localStorage.getItem("notes");
  if (notes.length <= 2 || notes === null) {
    drawEmpty();
  } else {
    //if not empty draw previous entered notes
    const notes = JSON.parse(localStorage.getItem("notes"));
    notes.forEach(el => {
      drawNote(el);
    });
  }
};

//draw empty note message
function drawEmpty() {
  const card = document.createElement("div");
  card.classList.add("card");
  card.id = "empty_notes";
  const card_content = document.createElement("div");
  card_content.classList.add("card-content");
  card_content.innerHTML = "No notes were found";
  card.appendChild(card_content);

  notes_container.appendChild(card);
}
