class Mobile {
    constructor() {
        this.pin = 0;
        this.messagerWriting = "";
        this.inbox = [];
        this.sentMessager = [];
        this.status = false;
    }

    checkStatusOnOff() {
        return (this.status === true) ? true : false;
    }

    turnOnOff(status) {
        this.status = (status === 1) ? true : false;
    }

    charge() {
        setInterval(function () {
            if (this.pin >= 0 && this.pin <= 100)
                this.pin += 1;
        }, 5000);
    }

    writingMessager(mess) {
        this.messagerWriting = mess;
    }

    toInbox(mess) {
        this.inbox.push(mess);
    }

    sentingMessager() {
        this.sentMessager.push(this.messagerWriting);
        return this.messagerWriting;
    }

    getInbox() {
        return this.inbox.join("######");
    }

    getSentMessager() {
        return this.sentMessager.join("######");
    }
}