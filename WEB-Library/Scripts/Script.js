
$(document).ready(function () {
    $("#searchButton").on("click", function () {
        var query = $("#searchInput").val();
        if (query.length > 0) {
            $.ajax({
                url: "/Book/Search",
                type: "GET",
                data: { query: query },
                success: function (result) {
                    var bookInfo = JSON.parse(result);
                    $("#bookTitle").text(bookInfo.title);
                    $("#bookImage").attr("src", bookInfo.imageUrl);
                    var offset = $("#bookInfo").offset().top;
                    $("html, body").animate({ scrollTop: offset }, "slow");
                },
                error: function () {
                    $("#bookInfo").html("Ошибка при поиске книги.");
                }
            });
        } else {
            $("#bookInfo").empty();
        }
    });
});
