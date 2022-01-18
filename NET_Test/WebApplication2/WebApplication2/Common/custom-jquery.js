function callAjax(url) {

    $.ajax({
        url: url,
        type: "GET",
        success: function(result){
        $("#divResultList").html(result);
        }
    })

}