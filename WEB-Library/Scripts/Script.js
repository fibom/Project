$(document).ready(function () {
    
    $("#getBookButton").click(function () {
        $.ajax({
            url: "/Book/GetBook",
            type: "GET",

            success: function (result) {
                $("#bookDetails").text(result.title);
            },
            error: function () {
                alert("Error occurred.");
            }
        });
    });
});