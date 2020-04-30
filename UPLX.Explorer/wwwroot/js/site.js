// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('form').submit(function (e) {
        e.preventDefault();
        $.ajax({
            type: 'POST',
            url: '/Home/Search',
            dataType: 'json',
            data: $('form').serialize(),
            processData: false,
            success: function (data) {
                if (data.type === 'Patient') {
                    $('#patientTbl').dataTable({
                        destroy: true,
                        data: data.data,
                        "columns": [
                            {
                                render: function (data, type, row) {
                                    return "<div class='overflow'><a target='_blank' class='text-primary' style='text-decoration:none;' href='/Patient?patientId=" + row.patientId + "'>" + row.patientId + "</a></div>";
                                }
                            },
                            {
                                render: function (data, type, row) {
                                    var date = new Date(1970, 0, 1); // Epoch
                                    date.setSeconds(row.createdDate);
                                    return "<div>" + date.toLocaleDateString() + "</div>";
                                }
                            },
                            { "data": "bloodCode" },
                            { "data": "variables.gender" },
                            { "data": "location.nationality" },
                            { "data": "location.birthPlace" },
                            { "data": "location.accessibilityToHospital" }
                        ]
                    });
                }

                if (data.type === 'Consultation') {
                    $('#consultTbl').dataTable({
                        destroy: true,
                        data: data.data,
                        "columns": [
                            {
                                render: function (data, type, row) {
                                    return "<div class='overflow'>" + row.id + "</div>";
                                }
                            },
                            {
                                render: function (data, type, row) {
                                    return "<div class='overflow'><a target='_blank' class='text-primary' style='text-decoration:none;' href='/Patient?patientId=" + row.patientId + "'>" + row.patientId + "</a></div>";
                                }
                            },
                            { "data": "facility" },
                            { "data": "orgCountry" },
                            {
                                render: function (data, type, row) {
                                    var date = new Date(1970, 0, 1); // Epoch
                                    date.setSeconds(row.consultedDate);
                                    return "<div>" + date.toLocaleDateString() + "</div>";
                                }
                            },
                            { "data": "consOutcome" },
                            { "data": "remarks" }
                        ]
                    });
                }

                if (data.type === 'Prescription') {
                    $('#prescriptTbl').dataTable({
                        destroy: true,
                        data: data.data,
                        "columns": [
                            {
                                render: function (data, type, row) {
                                    return "<div class='overflow'><a target='_blank' class='text-primary' style='text-decoration:none;' href='/Patient?patientId=" + row.patientId + "'>" + row.patientId + "</a></div>";
                                }
                            },
                            { "data": "drugName" },
                            { "data": "drugType" },
                            { "data": "dose" },
                            { "data": "route" },
                            { "data": "quantity" },
                            { "data": "frequency" },
                            { "data": "description" }
                        ]
                    });
                }

                if (data.type === 'Issue') {
                    $('#issueTbl').dataTable({
                        destroy: true,
                        data: data.data,
                        "columns": [
                            {
                                render: function (data, type, row) {
                                    return "<div class='overflow'><a target='_blank' class='text-primary' style='text-decoration:none;' href='/Patient?patientId=" + row.patientId + "'>" + row.patientId + "</a></div>";
                                }
                            },
                            {
                                render: function (data, type, row) {
                                    var date = new Date(1970, 0, 1); // Epoch
                                    date.setSeconds(row.issueDate);
                                    return "<div>" + date.toLocaleDateString() + "</div>";
                                }
                            },
                            { "data": "issueType" },
                            { "data": "title" },
                            { "data": "visitCode" },
                            { "data": "occurrence" },
                            { "data": "outCome" },
                            { "data": "remarks" }
                        ]
                    });
                }
            }
        });

        return false;
    });
});

function addRow() {
    //copy the table row and clear the value of the input, then append the row to the end of the table
    $("#formTable tbody tr:first").clone().find("input").each(function () {
        $(this).val('');
    }).end().appendTo("#formTable");
}

function loadComponent(cpn) {
    var field = cpn.val();
    var filterCpn = cpn.parents().find("td.filterCpn");
    var valueGrp = filterCpn.children("div.valueGrp");
    var unitDiv = valueGrp.children("div.unitDiv");
    if (field === 'alcoholValue') {
        unitDiv.show();
    } else {
        unitDiv.hide();
    }
}

function Search(type) {
    if (type === 'patientId') {
        window.location.href = "/Patient?patientId=" + $("#txtSearch").val();
    }
}
