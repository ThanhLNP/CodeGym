function tryRemoveFromArray(arr, index) {
	if (index < 0 || index >= arr.length || !Number.isInteger(index)) {
		return arr;
	}

	let new_array = [];

	for (let i = 0; i < arr.length; i++) {
		if (i !== index) {
			new_array[new_array.length] = arr[i];
		}
	}
	console.log(new_array);
	return new_array;
}

function innerHTMLArray(arr, index, id) {
	let p = document.getElementById(id);

	if (!Array.isArray(arr)) {
		return p.innerHTML = "Giá trị truyền vào không phải là mảng";
	}

	let new_arr = tryRemoveFromArray(arr, index);
	p.innerHTML = "Mảng " + arr.join(", ") + " sau khi bỏ phần tử tại vị trí " + index
		+ " trở thành: " + new_arr.join(", ");
}

let arr = [12, 6, 3, 7, 21, 5, 7];
innerHTMLArray(arr, 2, "p1");
innerHTMLArray(arr, 0, "p2");
innerHTMLArray(arr, 7, "p3");
innerHTMLArray(arr, -2, "p4");