let remote;
let tivi;
let videoHtml;
let statusHtml;

function channels(valueButton) {
    remote.id = valueButton;
    if (tivi.status) {
        videoHtml.src = remote.convertChannels(tivi);
    }
}

function status() {
    if (tivi.status) {
        videoHtml.style.display = "none";
        statusHtml.style.display = "block";
        tivi.status = false;
        location.reload();
    } else {
        tivi.status = true;
        statusHtml.style.display = "none";
        videoHtml.style.display = "block";
    }
}

window.onload = function () {
    tivi = new Tivi();
    remote = new Remote();
    videoHtml = document.getElementById("video");
    statusHtml = document.getElementById("channels");
}