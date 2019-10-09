let interval;

function Drive() {
  $("#car").animate(
    {
      left: "+=10%"
    },
    { easing: "linear" }
  );
  $("#tree").animate(
    {
      left: "-=10%"
    },
    { easing: "linear" }
  );

  if ($("#tree").position().left <= -250) {
    if (interval) clearInterval(interval);
    $("#tree")
      .stop(true)
      .css({ left: $(window).width() });
    $("#car")
      .stop(true)
      .css({ left: -350 });
    Animate();
  }
}

function Animate() {
  interval = setInterval(Drive, 200);
}
