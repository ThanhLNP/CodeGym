function findMinScore(arr) {
	let min = arr[0];

	for (let i = 1; i < arr.length; i++) {
		if (min > arr[i]) {
			min = arr[i];
		}
	}

	return min;
}

function innerHTMLMinScore(arr, id) {
	let p = document.getElementById(id);

	if (!Array.isArray(arr)) {
		return p.innerHTML = "Giá trị truyền vào không phải là mảng";
	}

	if (arr.length == 0) {
		return p.innerHTML = "Danh sách trống!";
	}

	let min = findMinScore(arr);
	p.innerHTML = min + " là điểm thấp nhất trong danh sách điểm thi: " + arr.join(", ");
}

let arr1 = [];
innerHTMLMinScore(arr1, "p1");

let arr2 = ['s', 4, 0, 5, 1];
innerHTMLMinScore(arr2, "p2");

let arr3 = [8, 6, 2, 6, 1, '0', '-4'];
innerHTMLMinScore(arr3, "p3");