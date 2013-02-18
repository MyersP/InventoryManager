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
        addItems($("#Color"), $("#GarmentInfo_ColorModel"), $("#AddNewColor").val());
    });

    $("#ColorAdd").click(function () {
        addItems($("#Color"), $("#GarmentInfo_ColorModel"), $("#GarmentInfo_ColorModel").find(":selected").text());
    });

    $("#ColorRemove").click(function () {
        $("#Color").find("option:selected").remove();
    });
    //end Color

    //start cut
    $("#GarmentCutNew").click(function () {
        addItems($("#GarmentCut"), $("#GarmentInfo_GarmentCutNamesModel"), $("#AddNewCut").val());
    });

    $("#GarmentCutAdd").click(function () {
        addItems($("#GarmentCut"), $("#GarmentInfo_GarmentCutNamesModel"), $("#GarmentInfo_GarmentCutNamesModel").find(":selected").text());
    });

    $("#GarmentCutRemove").click(function () {
        $("#GarmentCut").find("option:selected").remove();
    });
    //end cut

    //start embel
    $("#GarmentEmbelishmentNew").click(function () {
        addItems($("#GarmentEmbelishment"), $("#GarmentInfo_EmbelishmentNamesModel"), $("#AddNewEmbelishment").val());
    });

    $("#GarmentEmbelishmentAdd").click(function () {
        addItems($("#GarmentEmbelishment"), $("#GarmentInfo_EmbelishmentNamesModel"), $("#GarmentInfo_EmbelishmentNamesModel").find(":selected").text());
    });

    $("#GarmentEmbelishmentRemove").click(function () {
        $("#GarmentEmbelishment").find("option:selected").remove();
    });
    //end embel

    //start region
    $("#GarmentRegionNew").click(function () {
        addItems($("#GramentRegion"), $("#GarmentInfo_GarmentRegionModel"), $("#AddNewRegion").val());
    });

    $("#GarmentRegionAdd").click(function () {
        addItems($("#GarmentRegion"), $("#GarmentInfo_GarmentRegionModel"), $("#GarmentInfo_GarmentRegionModel").find(":selected").text());
    });

    $("#GarmentRegionRemove").click(function () {
        $("#GarmentRegion").find("option:selected").remove();
    });
    //end region

    //start era
    $("#GarmentEraNew").click(function () {
        addItems($("#GarmentEra"), $("#GarmentInfo_EraModel"), $("#AddNewEra").val());
    });

    $("#GarmentEraAdd").click(function () {
        addItems($("#GarmentEra"), $("#GarmentInfo_EraModel"), $("#GarmentInfo_EraModel").find(":selected").text());
    });

    $("#GarmentEraRemove").click(function () {
        $("#GarmentEra").find("option:selected").remove();
    });
    //end era

    //start use
    $("#GarmentUseNew").click(function () {
        addItems($("#GarmentUse"), $("#GarmentInfo_UseModel"), $("#AddNewUse").val());
    });

    $("#GarmentUseAdd").click(function () {
        addItems($("#GarmentUse"), $("#GarmentInfo_UseModel"), $("#GarmentInfo_UseModel").find(":selected").text());
    });

    $("#GarmentUseRemove").click(function () {
        $("#GarmentUse").find("option:selected").remove();
    });
    //end use

    //start source
    $("#ItemSourceNew").click(function () {
        addItems($("#ItemSource"), $("#GarmentInfo_ItemSourceModel"), $("#AddNewItemSource").val());
    });

    $("#ItemSourceAdd").click(function () {
        addItems($("#ItemSource"), $("#GarmentInfo_ItemSourceModel"), $("#GarmentInfo_ItemSourceModel").find(":selected").text());
    });

    $("#ItemSourceRemove").click(function () {
        $("#ItemSource").find("option:selected").remove();
    });
    //end source


    //GarmentCutRemove
    //

});