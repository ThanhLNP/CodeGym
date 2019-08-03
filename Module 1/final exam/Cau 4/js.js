class Rectangle {
	constructor(x, y, width, height, color) {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
		this.color = color;
	}

	setX(x) {
		this.x = x;
	}
	setY(y) {
		this.y = y;
	}
	setWidth(width) {
		this.width = width;
	}
	setHeight(height) {
		this.height = height;
	}
	setColor(color) {
		this.color = color;
	}

	getX() {
		return this.x;
	}
	getY() {
		return this.y;
	}
	getWidth() {
		return this.width;
	}
	getHeight() {
		return this.height;
	}
	getColor() {
		return this.color;
	}

	render(id) {
		let c = document.getElementById(id);
		let ctx = c.getContext("2d");
		ctx.fillStyle = this.color;
		ctx.fillRect(this.x, this.y, this.width, this.height);
	}
}

let rectangle = new Rectangle(10, 10, 200, 100, "#000000");
rectangle.render("myCanvas");