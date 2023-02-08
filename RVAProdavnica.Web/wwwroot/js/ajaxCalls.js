function TableSearch(dataObject, url, data) {
    $.ajax({
        method: "GET",
        url: url,
        data: data,
        success: function (response) {
            var len = $(response).find('.counter-rows').length;
            if (len != null && len > 0) {
                dataObject.append(response);
                $(".row-helper").fadeIn();
            }
        },
        error: function () {
            alert("Error!");
        }
    });
}
