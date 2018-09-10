$(function () {


    $(".movie-overview-wrapper").click(function () {
        id = $(this).attr("id");
        movieID = id.split("-")[1];
        window.location.href = detailUrl + "?id=" + movieID;
    }

    );
    $(navItem).addClass("active");

});