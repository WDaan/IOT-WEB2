var i = 0;
function brackets() {
  var input_var = document.getElementById('input');
  if (i == 0) {
    input_var.value += '(';
    i = 1;
  } else if (i == 1) {
    input_var.value += ')';
    i = 0;
  }
}