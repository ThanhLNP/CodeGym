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
	$(child[3]).append(data[i].crew);
	$(clone).attr("id",data[i].id);
	$(clone).appendTo(".ditable");
	$(clone).show();
};

$(".click").click(function(){
	yd=$(this).attr("id");
	for (var i=0; i<data.length; i++){
		if (data[i].id==yd) {localStorage.setItem("vt",i)};
	};
	window.location.href="detail.html";
});

$(".pl1").click(function(){window.open('https://youtu.be/F-eMt3SrfFU','_blank');});
$(".pr1").click(function(){window.open('https://youtu.be/09w9MTtZDEM','_blank');});
$(".pl2").click(function(){window.open('https://youtu.be/8cnIEq1cs4s','_blank');});
$(".pr2").click(function(){window.open('https://youtu.be/7y_eRUErIlY','_blank');});


//detail
vt=Number(localStorage.getItem("vt"));
$(".name").append(data[vt].name);
$(".nation").append(data[vt].nation);
$(".type").append(data[vt].type);
for (var i=0; i<data[vt].crewinfo.length; i++){
	$(".crewinfo").append(data[vt].crewinfo[i]+"&emsp;");
}
$(".info").append(data[vt].info);
if (data[vt].nation=="Mỹ") {$(".name").append("<img src='usa.png'>");}
if (data[vt].nation=="Trung Quốc") {$(".name").append("<img src='china.png'>");}
if (data[vt].nation=="Liên Xô") {$(".name").append("<img src='ussr.png'>");}
$(".img").append(data[vt].img);