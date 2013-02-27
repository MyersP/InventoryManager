$(document).ready(function () {


    function addItems(addList, listBox, textToAdd) {
        addList.children().each(function () {

            if ($(this).val() == "") {
                $(this).remove();
            }
        });

        var count = listBox.children().length;
        count = count + addList.find("option").length;
        count = count + 1;

        if ($.trim(textToAdd) != "") {
            addList.append("<option value=" + count + ">" + textToAdd + "</option>");
        }
    }

    //start color
    $("#ColorNew").click(function () {
        addItems($("#Color"), $("#ColorModel"), $("#AddNewColor").val());
    });

    $("#ColorAdd").click(function () {
        addItems($("#Color"), $("#ColorModel"), $("#ColorModel").find(":selected").text());
    });

    $("#ColorRemove").click(function () {
        $("#Color").find("option:selected").remove();
    });
    //end Color

    //start cut
    $("#GarmentCutNew").click(function () {
        addItems($("#GarmentCut"), $("#CutNamesModel"), $("#AddNewCut").val());
    });

    $("#GarmentCutAdd").click(function () {
        addItems($("#GarmentCut"), $("#CutNamesModel"), $("#CutNamesModel").find(":selected").text());
    });

    $("#GarmentCutRemove").click(function () {
        $("#GarmentCut").find("option:selected").remove();
    });
    //end cut

    //start embel
    $("#GarmentEmbelishmentNew").click(function () {
        addItems($("#GarmentEmbelishment"), $("#EmbelishmentNamesModel"), $("#AddNewEmbelishment").val());
    });

    $("#GarmentEmbelishmentAdd").click(function () {
        addItems($("#GarmentEmbelishment"), $("#EmbelishmentNamesModel"), $("#EmbelishmentNamesModel").find(":selected").text());
    });

    $("#GarmentEmbelishmentRemove").click(function () {
        $("#GarmentEmbelishment").find("option:selected").remove();
    });
    //end embel

    //start region
    $("#RegionNew").click(function () {
        addItems($("#GarmentRegion"), $("#RegionModel"), $("#AddNewRegion").val());
    });

    $("#RegionAdd").click(function () {
        addItems($("#GarmentRegion"), $("#RegionModel"), $("#RegionModel").find(":selected").text());
    });

    $("#RegionRemove").click(function () {
        $("#GarmentRegion").find("option:selected").remove();
    });
    //end region

    //start era
    $("#EraNew").click(function () {
        addItems($("#EraList"), $("#EraModel"), $("#AddNewEra").val());
    });

    $("#EraAdd").click(function () {
        addItems($("#EraList"), $("#EraModel"), $("#EraModel").find(":selected").text());
    });

    $("#EraRemove").click(function () {
        $("#EraList").find("option:selected").remove();
    });
    //end era

    //start use
    $("#UseNew").click(function () {
        addItems($("#UsesList"), $("#UsesModel"), $("#AddNewUse").val());
    });

    $("#UseAdd").click(function () {
        addItems($("#UsesList"), $("#UsesModel"), $("#UsesModel").find(":selected").text());
    });

    $("#UseRemove").click(function () {
        $("#UsesList").find("option:selected").remove();
    });
    //end use

    //start source
    $("#ItemSourceNew").click(function () {
        addItems($("#ItemSource"), $("#ItemSourceModel"), $("#AddNewItemSource").val());
    });

    $("#ItemSourceAdd").click(function () {
        addItems($("#ItemSource"), $("#ItemSourceModel"), $("#ItemSourceModel").find(":selected").text());
    });

    $("#ItemSourceRemove").click(function () {
        $("#ItemSource").find("option:selected").remove();
    });
    //end source


    //GarmentCutRemove
    //

});