
var hidde = true;
$(document).ready(function () {
    if (hidde) {
        $("#form-search").hide();
    }
    CKEDITOR.replace('noidungviet');

});

function showform() {
    $("#form-search").fadeToggle(1800);
   
}
function vietbai(){
    $("#card-Post").slideToggle(1500);
}
function showUser(){
    $(".user").show();
}
function hideUser(){
    $(".user").hide();
}


