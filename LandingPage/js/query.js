$(document).ready(function() {
    $(".contactclass").click(function () {
        $('html,body').animate({
            scrollTop: $("#D_contact").offset().top
        }, 500);
    });
});

$(document).ready(function() {
    $(".aboutclass").click(function () {
        $('html,body').animate({
            scrollTop: $("#aboutid").offset().top
        }, 1);
    });
});