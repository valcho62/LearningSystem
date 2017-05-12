$(function () {
    var chat = $.connection.chatHub;

   chat.client.getMessage = function(name, message) {

       if (name === $('#user-name')) {
           var licontent = '<li id = "mine">';
       } else {
           var licontent = '<li id = "not-mine">';
       }
       $('#chat-conversation').append(licontent + message + '</li>');
   }
})
