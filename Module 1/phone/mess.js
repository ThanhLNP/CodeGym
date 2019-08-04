let nokia;
let iphone;
let sent;
let inputNokia

function ready() {
    nokia = new Mobile();
    iphone = new Mobile();

    document.getElementById("nokiaInput").oninput = function () {
        inputNokia = document.getElementById("nokiaInput").value;
        nokia.writingMessager(inputNokia);
    }

    document.getElementById("nokiaToSent").onclick = function () {
        sent = nokia.sentingMessager(inputNokia);
        alert(sent);
        iphone.toInbox(sent);
    }

    document.getElementById("iphoneInbox").onclick = function () {
        document.getElementById("iphoneInput").value = iphone.getInbox();
    }
}