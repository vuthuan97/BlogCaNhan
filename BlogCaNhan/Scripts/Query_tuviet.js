function fnSuccess(data) {
    var tb = data.substring(2);
    var key = data.substring(0, 1);
    if (key == "t") {
        $("#box-tb").addClass('alert-success');
        document.getElementById("thongbao").innerHTML = tb;
        $(".thongbaoblog").show();
        
    }
    else if (key == "f") {
        $("#box-tb").addClass('alert-danger');
        document.getElementById("thongbao").innerHTML = tb;
        $(".thongbaoblog").show();
    }
    setTimeout(function () {
        $(".thongbaoblog").css("display","none");
    }, 4000);

}
function fnFail(err) {
    alert("err" + err);
}