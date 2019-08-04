class Remote {
    constructor() {
        this.id = "";
        this.before = 0;
    }

    increaseVolume(tivi) {
        if (tivi.volume < 100)
            tivi.volume++;
    }

    reductionVolume(tivi) {
        if (tivi.volume > 0)
            tivi.volume--;
    }

    convertChannels(tivi) {
        switch (this.id) {
            case "1":
                this.before = this.id;
                return tivi.channels[1];

            case "2":
                this.before = this.id;
                return tivi.channels[2];

            case "3":
                this.before = this.id;
                return tivi.channels[3];

            case "4":
                this.before = this.id;
                return tivi.channels[4];

            case "5":
                this.before = this.id;
                return tivi.channels[5];

            case "6":
                this.before = this.id;
                return tivi.channels[6];

            case "7":
                this.before = this.id;
                return tivi.channels[7];

            case "8":
                this.before = this.id;
                return tivi.channels[8];

            case "9":
                this.before = this.id;
                return tivi.channels[9];

            case "Up":
                if (this.before == 9) {
                    this.before = 1;
                }
                else {
                    this.before++;
                }
                return tivi.channels[this.before];

            case "Down":
                if (this.before == 1) {
                    this.before = 9;
                }
                else {
                    this.before--;
                }
                return tivi.channels[this.before];
        }
    }
}