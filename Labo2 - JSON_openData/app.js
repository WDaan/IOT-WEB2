$.getJSON(
  "https://datatank.stad.gent/4/mobiliteit/bezettingparkingsrealtime.json",
  data => {
    data.forEach(el => {
      createBlock(el);
    });
  }
);

function createBlock(el) {
  let colum = `<div class="element">
    <div class="card" style="background-color: ${getColor(
      el.parkingStatus.availableCapacity,
      el.totalCapacity
    )}">
      <div class="card-content">
        <p class="title">${el.name}</p>
        <p class="subtitle">${el.address}</p>
        <p class="">${el.contactInfo}</p>
        <p class="">Locatie : ${el.address}</p>
        <p class="">Bezetting: ${el.parkingStatus.availableCapacity} / ${
    el.totalCapacity
  }</p>
      </div>
    </div>
  </div>`;

  $("#grid").append(colum);
}

function getColor(occ, max) {
  // roodtinten want meer dan helft bezet
  if (occ / max > 0.5) {
    return `rgb(${Math.floor(255 * (occ / max))}, 100 ,100)`;
  } else {
    //anders groen
    return `rgb(10, ${(1 - occ / max) * 255} ,100)`;
  }
}
