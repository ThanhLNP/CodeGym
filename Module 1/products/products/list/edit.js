$(".pl1").click(function(){window.open('https://youtu.be/F-eMt3SrfFU','_blank');});
$(".pr1").click(function(){window.open('https://youtu.be/09w9MTtZDEM','_blank');});
$(".pl2").click(function(){window.open('https://youtu.be/8cnIEq1cs4s','_blank');});
$(".pr2").click(function(){window.open('https://youtu.be/7y_eRUErIlY','_blank');});

//dang nhap
var mk=1234;
if (sessionStorage.getItem("mk") == mk){
	$(".mk").hide();
}else{
	$(".edit").hide();
};
function dangnhap(){
	if ($('#mk').val() == mk){
		sessionStorage.setItem("mk",$('#mk').val());
		$(".mk").hide();
		$(".edit").show();
	}else{
		alert("Mật khẩu sai!");
	};
};
$('#dn').click(function(){
	dangnhap();
});
$('#mk').keypress(function(event){
    if(event.keyCode == 13 || event.which == 13){
    	dangnhap();
    };
});

//tao danh sach
$(".hang").hide();

if (localStorage.getItem("data")==null) {
	localStorage.setItem("data",JSON.stringify(dt));
};
var data=[];
data=JSON.parse(localStorage.getItem("data"));

var yd, vt;
var c=$(".hang");
for (var i=0; i<data.length; i++){
	var clone=$(c).clone();
	var child=$(clone).children();
	$(child[0]).append(data[i].img);
	$(child[0]).append(data[i].name);
	$(child[1]).append(data[i].nation);
	$(child[2]).append(data[i].type);
	$(child[3]).append('<button type="button" class="btn btn-warning" d="">Chỉnh sửa</button>');
	$(child[4]).append('<button type="button" class="btn btn-danger" d="">Xóa</button>');
	$(child[3]).contents("button").attr("d",data[i].id);
	$(child[4]).contents("button").attr("d",data[i].id);
	$(clone).appendTo(".ditable");
	$(clone).show();
};

//xoa
$(".btn-danger").click(function(){
	yd=$(this).attr("d");
	for (var i=0; i<data.length; i++){
		if (data[i].id==yd) {
			data.splice(i,1);
			localStorage.setItem("data",JSON.stringify(data));
			window.location.reload();
		};
	};
});

//them
$("#new").click(function(){
	var push={};
	push.crewinfo=[];
	push.id=$('#id').val();
	push.name=$('#name').val();
	push.nation=$('#nation').val();
	push.type=$('#type').val();
	push.crew=parseInt($('#crew').val());
	for (var i=0; i<$('#crew').val(); i++){
		push.crewinfo.push($('#'+i).val());
	};
	push.info=$('#info').val();
	data.unshift(push);
	localStorage.setItem("data",JSON.stringify(data));
	window.location.href="edit.html";
});
$("#capnhap").click(function(){
	for (var i=0; i<$('#crew').val(); i++){
		$(".crewinfonew").append(
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

//chinh sua
$(".btn-warning").click(function(){
	yd=$(this).attr("d");
	for (var i=0; i<data.length; i++){
		if (data[i].id==yd) {localStorage.setItem("vt",i)};
	};
	window.location.href="chinhsua.html";
});