$(function() {
    var chat = $.connection.chatHub;

    $.connection.hub.start().done(function() {
        $('#send-message').click(function() {
            chat.server.getMessage($('#user-name').html,$('#message').val());
        })
    })
})