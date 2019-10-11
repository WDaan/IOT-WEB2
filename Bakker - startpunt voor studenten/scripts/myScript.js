// Via 'enumeraties' het overschrijden van de grens tussen 'groot'
// en 'klein' scherm opzoeken.
let ScreenWidth = { small: 0, large: 1 };
let previousScreenWidth = ScreenWidth.small;
let currentScreenWidth = ScreenWidth.small;

$().ready(function() {
  $("#menuButton").click(() => {
    $(".navField").toggle();
  });
});

$(window).resize(function() {
  Modernizr.mq("(max-width: 1000px)")
    ? (currentScreenWidth = ScreenWidth.small)
    : (currentScreenWidth = ScreenWidth.large);

  if (currentScreenWidth != previousScreenWidth) {
    if ((currentScreenWidth = ScreenWidth.small)) $(".navField").hide();
    else $(".navField").show();
  }
  previousScreenWidth = currentScreenWidth;
});
