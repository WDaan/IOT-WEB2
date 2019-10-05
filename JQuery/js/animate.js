function Drive() {
  $("#car").animate({
    left: "+=10%"
  });
  $("#tree").animate({
    left: "-=10%"
  });

  if ($("#car").position().left >= $(window).width() + 150) {
    console.log("car: ", $("#car").position());
    $("#car").position().left = 0;
  }
  if ($("#tree").position().left <= -150) {
    console.log("boom: ", $("#tree").position());
    $("#tree").css({ left: $(window).width() + 150 });
  }
}

function Animate() {
  setInterval(Drive, 200);
}
