$(document).ready(function() {
  $(".title, li").hover(function(event) {
    $(this)
      .children(".content")
      .slideToggle();
  });
  event.stopPropagation();
});
