//alert("hey");
///////////
//$(function () {
        //    $.connection.hub.logging = true;
        //    chat = $.connection.Hub();

        //    chat.client.newMessage = onNewMessage;

        //    $('#join').click(onJoin);
        //    $('#send').click(onSend);
        //    $('#sendprivate').click(onSendPrivate);


        //    $.connection.hub.start({ transport: "longPolling" });
        //    //{ transport: "longPolling" }
        //});*@





        $(function () {
            $.connection.hub.logging = true;
            //chat connects the chathub alias chat in chathub hub
            chat = $.connection.chat;
            chat.client.newMessage = onNewMessage;

            $('#join').click(onJoin);
            $('#send').click(onSend);
            $('#sendprivate').click(onSendPrivate);
            ///hub.start starts the negotiation process between client n server this uses longpolling
            $.connection.hub.start({ transport: 'longPolling'});
        });
  




function onNewMessage(message) {
    // ... todo: validation !!!! :)
    $('#messages').append('<li>' + message + '</li>');
};

function onJoin() {
    chat.server.joinRoom($('#room').val());
};
//this calls the SendMessage method in the chathub class
function onSend() {
    //do validation
    chat.server.sendMessage($('#message').val());
};
function onSendPrivate() {
    chat.server.sendMessageToRoom($('#room').val(), $('#message').val());
};

$.connection.hub.error(function (err) {
    alert("An error occured: " + err);
});

////////////mooniter/////////////

           var moniter;
$(function () {
    moniter = $.connection.moniter;
    moniter.client.newEvent = onNewEvent;
    $.connection.hubs.start();
});

function onNewEvent(eventType, client) {
    $('#messages').append('<li>' + eventType + ' from ' + client + '</li>');
};
////////////////////////////////


//////maps//////////////




//////////////////////////

