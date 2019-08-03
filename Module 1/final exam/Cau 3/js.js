function isPrime(int) {
	if (int < 2) {
		return false;
	}

	for (let i = 2; i <= Math.sqrt(int); i++) {
		if (int % i == 0) {
			return false;
		}
	}

	return true;
}

function innerHTMLPrime(int, id) {
	let p = document.getElementById(id);

	if (!Number.isInteger(int) || int <= 0) {
		return p.innerHTML = int + " không phải là số tự nhiên khác 0";
	}

	if (isPrime(int)) {
		return p.innerHTML = int + " là số nguyên tố";
	} else {
		return p.innerHTML = int + " không phải là số nguyên tố";
	}
}

let num1 = 2.2;
innerHTMLPrime(num1, "p1");

let num2 = 17;
innerHTMLPrime(num2, "p2");