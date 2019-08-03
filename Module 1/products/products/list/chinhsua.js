$(".pl2").click(function(){window.open('https://youtu.be/8cnIEq1cs4s','_blank');});
$(".pr2").click(function(){window.open('https://youtu.be/7y_eRUErIlY','_blank');});

var data=[];
data=JSON.parse(localStorage.getItem("data"));

var vt=Number(localStorage.getItem("vt"));
$('#id').val(data[vt].id);
$('#name').val(data[vt].name);
$('#nation').val(data[vt].nation);
$('#type').val(data[vt].type);
$('#info').val(data[vt].info);
$('#crew').val(data[vt].crew);
for (var i=0; i<data[vt].crewinfo.length; i++){
	$(".crewinfoedit").append(data[vt].crewinfo[i]+"&emsp;");
};

var x=false;

$("#capnhap").click(function(){
	$(".crewinfoedit").empty();
	data[vt].crewinfo=[];
	x=true;
	for (var i=0; i<$('#crew').val(); i++){
		$(".crewinfoedit").append(
			'<p><select class="crewinfo" id="'+i+'">\
				<option value="Chỉ huy">Chỉ huy</option>\
				<option value="Pháo thủ">Pháo thủ</option>\
				<option value="Lái xe">Lái xe</option>\
				<option value="Liên lạc viên">Liên lạc viên</option>\
				<option value="Nạp đạn viên">Nạp đạn viên</option>\
			</select></p>'
		);
	};
});

$("#save").click(function(){
	data[vt].id=$('#id').val();
	data[vt].name=$('#name').val();
	data[vt].nation=$('#nation').val();
	data[vt].type=$('#type').val();
	data[vt].crew=parseInt($('#crew').val());
	if (x==true) {
		for (var i=0; i<$('#crew').val(); i++){
			data[vt].crewinfo.push($('#'+i).val());
		}
	};
	data[vt].info=$('#info').val();
	localStorage.setItem("data",JSON.stringify(data));
	window.location.href="edit.html";
});