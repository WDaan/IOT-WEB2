$("#email-input").keydown(e => {
  let key = e.which || e.keyCode;
  if (key === 13) {
    let email = $("#email-input").val();
    if (validateEmail(email)) $("#email-value").text(email);
    else {
      alert("No valid email!");
    }
  }
});

function validateEmail(email) {
  let re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
  return re.test(String(email).toLowerCase());
}

$("#slider-input").on("input", e => {
  $("#slider-value").text($("#slider-input").val());
});
