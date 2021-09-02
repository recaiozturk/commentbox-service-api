GetComments();

function GetComments() {
    var html = [];

    $.getJSON("https://localhost:44378/api/Comment/Get", function (data) {


        $.each(data, function (key, value) {
            html.push(

                "<li> <div class='commentText'> <p class=''>" + value.Comment + "</p> <span class='date sub-text'>gönderen " + value.Name + "</span> </div></li>"
            );
        });

        $("#CommentsUl").empty().append(html);

    });
}

$("#CommentForm").submit(function (event) {

    //sayfa post back olmasın --ajax ile gidecek bilgiler
    event.preventDefault();

    $.ajax({
        url: "https://localhost:44378/api/Comment/Post",
        data: {
            Name: $("#Name").val(),
            Comment: $("#CommentArea").val()
        },
        type: "POST",
        complete: function () {

            GetComments();
            alert("yorumunuz alındı");

        },
        success: function () {

        }
    });

});