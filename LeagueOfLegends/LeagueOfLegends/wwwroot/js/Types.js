var types = types || {};

types.getTypesList = function () {
    dataTableOption = $("#tbl").DataTable({
        "processing": true, // for show progress bar  
        "serverSide": true, // for process server side  
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "ajax": {
            "url": "/Types/GetTypesList",
            "type": "POST",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "name",
                "name": "Name",
                "autoWidth": true,
                "title": "Vai trò",
                "searchable": true,
                "orderable": true
            },
            {
                "data": "id",
                "render": function (data, type, full, meta) {
                    return '<a class="btn btn-outline-warning text-dark mr-2" onclick="types.showModalUpdate(this, ' + data + ')" href="javascript:void(0);">Chỉnh sửa</a>' +
                        '<a class="btn btn-outline-danger text-dark ml-2" onclick = "types.deleteTypes(' + data + ')" href = "javascript:void(0);">Xóa</a>';
                },
                "width": "40%",
                "title": "Thao tác",
                "searchable": false,
                "orderable": false,
                "className": 'dt-body-center'
            }
        ]
    });
};

types.showModalUpdate = function (elem, id) {
    var name = $(elem).closest('tr').find('td:nth-child(1)').text();
    $("#nameUpdate").val(name);

    $("#nameUpdate").data("id", id);

    $("#modalUpdate").modal('show');
};

types.showModalCreate = function () {
    $("#modalCreate").modal('show');
};

types.createTypes = function () {
    var typesObj = {};
    typesObj.Name = $("#nameCreate").val();

    $.ajax({
        url: '/Types/AddTypes',
        method: 'POST',
        dataType: 'json',
        data: JSON.stringify(typesObj),
        contentType: 'application/json',
        success: function (data) {
            if (data.response > 0) {
                types.reloadDataTable();
                $("#modalCreate").modal('hide');
                alert("Thêm thành công");
                $("#nameCreate").val("");
            }
            else {
                alert("Đã có lỗi xảy ra!");
            }
        }
    });
};

types.updateTypes = function () {
    var typesObj = {};
    typesObj.Id = $("#nameUpdate").data("id");
    typesObj.Name = $("#nameUpdate").val();

    $.ajax({
        url: '/Types/UpdateTypes',
        method: 'POST',
        dataType: 'json',
        data: JSON.stringify(typesObj),
        contentType: 'application/json',
        success: function (data) {
            if (data.response > 0) {
                types.reloadDataTable();
                $("#modalUpdate").modal('hide');
                alert("Cập nhập thành công");
            }
            else {
                alert("Đã có lỗi xảy ra!");
            }
        }
    });
};

types.deleteTypes = function (id) {
    var isDelete = confirm('A du sua?');
    if (isDelete) {
        $.ajax({
            url: '/Types/DeleteTypes/' + id,
            method: 'GET',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                if (data.response > 0) {
                    types.reloadDataTable();
                    alert("Xóa thành công");
                }
                else {
                    alert("Đã có lỗi xảy ra!");
                }
            }
        });
    }
};

types.reloadDataTable = function () {
    dataTableOption.ajax.reload(null, false);
};

types.init = function () {
    types.getTypesList();
};

$(document).ready(function () {
    types.init();
});