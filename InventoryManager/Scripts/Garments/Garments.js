$(document).ready(function () {


    function AddItems(addList, count, value) {

        count = count + addList.children().length;
        count = count++;

        addList.children().each(function () {

            if ($(this).val() == "") {
                $(this).remove();
            }
        });

       addList.append("<option value=" + count + ">" + value + "</option>");
    }

    $("#ColorNew").click(function () {
       var count = $("#ColorModel").children().length;
        AddItems($("#Color"), count, $("#AddNewColor").val()); 
    });

    $("#GarmentCutNew").click(function () {
        var count = $("#GarmentCutNamesModel").children().length;
        AddItems($("#GarmentCut"), count, $("#AddNewCut").val());
    });

    $("#GarmentEmbelishmentNew").click(function () {
        var count = $("#EmbelishmentNamesModel").children().length;
        AddItems($("#GarmentEmbelishment"), count, $("#AddNewEmbelishment").val());
    });

    $("#GamentRegionNew").click(function () {
        var count = $("#GamentRegionModel").children().length;
        AddItems($("#GamentRegion"), count, $("#AddNewRegion").val());
    });

    $("#GarmentEraNew").click(function () {
        var count = $("#GarmentEraModel").children().length;
        AddItems($("#GarmentEra"), count, $("#AddNewEra").val());
    });

    $("#GarmentUseNew").click(function () {
        var count = $("#GarmentUseModel").children().length;
        AddItems($("#GarmentUse"), count, $("#AddNewUse").val());
    });

    $("#ItemSourceNew").click(function () {
        var count = $("#ItemSourceModel").children().length;
        AddItems($("#ItemSource"), count, $("#AddNewItemSource").val());
    });
    

});