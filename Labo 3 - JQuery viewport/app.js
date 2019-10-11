let data = {
  HTML_width: null,
  HTML_height: null,
  Vwp_width: null,
  Vwp_height: null
};

$().ready(function() {
  getData();
  writeData();
});

$(window).resize(function() {
  getData();
  writeData();
});

function getData() {
  data.Vwp_height = $(window).height();
  data.Vwp_width = $(window).width();

  data.HTML_height = $("body").height();
  data.HTML_width = $("body").width();
}

function writeData() {
  $("#HTML_width").text(data.HTML_width);
  $("#HTML_height").text(data.HTML_height);

  $("#Vwp_width").text(data.Vwp_width);
  $("#Vwp_height").text(data.Vwp_height);
}
