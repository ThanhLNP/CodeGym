const arrow_left = 37;
const arrow_top = 38;
const arrow_right = 39;
const arrow_down = 40;

class Hero {
	constructor(id, img, img_left, img_top, img_right, img_down, img_troll) {
		this.id = document.getElementById(id);
		this.img_left = img_left;
		this.img_top = img_top;
		this.img_right = img_right;
		this.img_down = img_down;
		this.img_troll = img_troll;
		this.id.setAttribute("src", img);
		this.id.setAttribute("width", "100px");
		this.left = Math.floor(Math.random() * window.innerWidth);
		this.top = Math.floor(Math.random() * window.innerHeight);
		this.id.style.left = this.left + "px";
		this.id.style.top = this.top + "px";
		this.id.style.position = "absolute";
		this.move = 20;
	}

	moveLeft() {
		if (this.left > 0) {
			this.id.setAttribute("src", this.img_left);
			this.left -= this.move;
			this.id.style.left = this.left + "px";
		} else {
			this.troll();
		}
	}

	moveRight() {
		if (this.left < window.innerWidth) {
			this.id.setAttribute("src", this.img_right);
			this.left += this.move;
			this.id.style.left = this.left + "px";
		} else {
			this.troll();
		}
	}

	moveTop() {
		if (this.top > 0) {
			this.id.setAttribute("src", this.img_top);
			this.top -= this.move;
			this.id.style.top = this.top + "px";
		} else {
			this.troll();
		}
	}

	moveDown() {
		if (this.top < window.innerHeight) {
			this.id.setAttribute("src", this.img_down);
			this.top += this.move;
			this.id.style.top = this.top + "px";
		} else {
			this.troll();
		}
	}

	troll() {
		this.id.setAttribute("src", this.img_troll);
	}
}

let pikachu = new Hero("hero", "pikachu.png", "pikachu_left.png", "pikachu_top.png", "pikachu_right.png", "pikachu_down.png", "troll.png");

function moveHero(evt) {
	switch (evt.keyCode) {
		case arrow_left:
		pikachu.moveLeft();
		break;
		case arrow_top:
		pikachu.moveTop();
		break;
		case arrow_right:
		pikachu.moveRight();
		break;
		case arrow_down:
		pikachu.moveDown();
		break;
	}
}

function docReady() {
	window.addEventListener("keydown", moveHero);
}

window.onload = docReady;