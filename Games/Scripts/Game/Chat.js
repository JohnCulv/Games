var $chatWindow = $("#chatWindow");
var chatCount = 0;

function postComplete(chat) {
    $("<p><b>"+ chat.user + "</b>: " + chat.message + "</p>").attr(
        { id: 'chat' + chatCount }
        ).appendTo($chatWindow);

    $("#chat" + chatCount).hide().fadeIn(1000);
    chatCount++;
};

