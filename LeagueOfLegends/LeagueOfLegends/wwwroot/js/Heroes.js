var heroes = heroes || {};

heroes.getHeroesList = function () {
    dataTableOption = $("#tblHeroes").DataTable({
        "processing": true, // for show progress bar  
        "serverSide": true, // for process server side  
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "ajax": {
            "url": "/Heroes/GetHeroesList",
            "type": "POST",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "name",
                "name": "Name",
                "autoWidth": true,
                "title": "Tên",
                "searchable": true,
                "orderable": true
            },
            {
                "data": "typeNameStr",
                "name": "TypeNameStr",
                "autoWidth": true,
                "title": "Vai trò",
                "searchable": false,
                "orderable": false
            },
            {
                "data": "id",
                "render": function (data, type, full, meta) {
                    return '<a class="btn btn-outline-info text-dark mr-2" onclick="heroes.getHeroes(' + data + ')" href="javascript:void(0);">Chi tiết</a>' +
                        '<a class="btn btn-outline-warning text-dark mr-2 ml-2" onclick="types.showModalUpdate(this, ' + data + ')" href="javascript:void(0);">Chỉnh sửa</a>' +
                        '<a class="btn btn-outline-danger text-dark ml-2" onclick="types.deleteTypes(this, ' + data + ')" href="javascript:void(0);">Xóa</a>';
                },
                "width": "30%",
                "title": "Thao tác",
                "searchable": false,
                "orderable": false,
                "className": 'dt-body-center'
            }
        ]
    });
};

heroes.getHeroes = function (id) {
    $.ajax({
        url: '/Heroes/GetHeroes/' + id,
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.code === 1) {
                var response = data.response;
                $(".modal-title").text(response.name);
                $("#typeNameDetail").text(response.typeNameStr);
                $("#healthDetail").text(response.health);
                $("#healthRegenDetail").text(response.healthRegen);
                $("#attackDamageDetail").text(response.attackDamage);
                $("#armorDetail").text(response.armor);
                $("#magicResistDetail").text(response.magicResist);
                $("#movementSpeedDetail").text(response.movementSpeed);
            }
        }
    });

    $("#modalDetail").modal('show');
};

heroes.reloadDataTable = function () {
    dataTableOption.ajax.reload(null, false);
};

heroes.init = function () {
    heroes.getHeroesList();
};

$(document).ready(function () {
    heroes.init();
});