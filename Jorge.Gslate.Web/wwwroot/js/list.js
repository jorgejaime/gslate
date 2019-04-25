var prokectList = (function () {


    $(document).ready(function () {
        $('#project-table').DataTable({
            "processing": true,
            "serverSide": true,
            "language": {
                "url": "/lib/datatables/languages/datatable.es.json"
            },
            "searching": false,
            'ajax': {
                'type': "POST",
                'contentType': "application/json",
                'url': "/Home/List",
                'data': function (d) {

                    var filter = {
                        id: $("#filter-user").val(),  
                    }
                    d.filter = filter;

                    return JSON.stringify(d);
                }
            },
            "responsive": true,
            "columns": [

                { "data": "id" },
                { "data": "startDate" },
                {
                    "data": "timeToStart",
                    "render": function (data, type, row, meta) {
                        if (data < 0 ) {
                            return "Started"
                        }
                        return data
                    }
                },
                { "data": "endDate" },
                { "data": "credits" },
                {
                    "data": "isActive",
                    "render": function (data, type, row, meta) {
                        if (data == true) {
                            return "Active"
                        }
                        return "Inactive"
                    }
                },
                
                
            ],
            "order": [[1, 'asc']],
           dom: 'Blfrtpi',
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print'
            ]
        });

        $('#filter-user').change(function () {
            reloadTable();
        });

      

    });




    var reloadTable = function () {
        var $table = $("#project-table");
        var table = $table.DataTable();
        table.ajax.reload(null, true); 
    }



   return {
       reloadTable: reloadTable
   }


}());