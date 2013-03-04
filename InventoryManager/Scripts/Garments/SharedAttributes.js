$(document).ready(function () {
    var submitElements = $("#SubmitTheseElements");

    function addItems(addList, selectedModel, textToAdd, listName) {

        addList.children().each(function () {

            if ($(this).val() == "") {
                $(this).remove();
            }
        });

        var count = selectedModel.children().length;
        count = count + addList.find("option").length;
        count = count + 1;

        if ($.trim(textToAdd) != "") {
            addList.append("<option value=" + count + ">" + textToAdd + "</option>");
            submitElements.append('<input name="' + listName + '" value="' + textToAdd + '" />');
        }
    }

    function removeItems(addList, listName) {
        var selectedText = addList.find("option:selected");
        selectedText.remove();

        var inputs = $('input[name="' + listName + '"]');

        for (var i = 0; i < inputs.length; i++) {
            inputs.remove('[value="' + selectedText.text() + '"]');
        }
    }

    var color = $("#Color");
    var colorModel = $("#ColorModel");
    var colorListName = "ColorList";
    //start color
    $("#ColorNew").click(function () {
        var addColor = $("#AddNewColor");
        addItems(color, colorModel, addColor.val(), colorListName);
        addColor.val("");
    });

    $("#ColorAdd").click(function () {
        addItems(color, colorModel, colorModel.find(":selected").text(), colorListName);
        // colorModel.find(':selected').remove();
    });

    $("#ColorRemove").click(function () {
        removeItems(color, colorListName);

    });
    //end Color

    //start cut
    var cutListName = "CutList";
    var cut = $("#GarmentCut");
    var cutModel = $("#CutNamesModel");
    $("#GarmentCutNew").click(function () {
        var addcut = $("#AddNewCut");
        addItems(cut, cutModel, addcut.val(), cutListName);
        addcut.val("");
    });

    $("#GarmentCutAdd").click(function () {
        addItems(cut, cutModel, cutModel.find(":selected").text(), cutListName);
        // cutModel.find(':selected').remove();
    });

    $("#GarmentCutRemove").click(function () {
        removeItems(cut, cutListName);
    });
    //end cut

    //start embel
    var embelListName = "EmbelishmentList";
    var embel = $("#GarmentEmbelishment");
    var embelModel = $("#EmbelishmentNamesModel");
    $("#GarmentEmbelishmentNew").click(function () {
        var embelNew = $("#AddNewEmbelishment");
        addItems(embel, embelModel, embelNew.val(), embelListName);
        embelNew.val("");
    });

    $("#GarmentEmbelishmentAdd").click(function () {
        var embelFound = embelModel.find(":selected");
        addItems(embel, embelModel, embelFound.text(), embelListName);
        // embelFound.remove();
    });

    $("#GarmentEmbelishmentRemove").click(function () {
        removeItems(embel, embelListName);

    });
    //end embel

    //start region
    var regionListName = "RegionList";
    var garmentRegion = $("#GarmentRegion");
    var regionModel = $("#RegionModel");
    $("#RegionNew").click(function () {
        var regionAdd = $("#AddNewRegion");
        addItems(garmentRegion, regionModel, regionAdd.val(), regionListName);
        regionAdd.val("");
    });

    $("#RegionAdd").click(function () {
        addItems(garmentRegion, regionModel, regionModel.find(":selected").text(), regionListName);
    });

    $("#RegionRemove").click(function () {
        removeItems(garmentRegion, regionListName);
    });
    //end region

    //start era
    var eraListName = "EraList";
    var eraNameList = $("#EraNameList");
    var eraModel = $("#EraModel");
    $("#EraNew").click(function () {
        var eraAdd = $("#AddNewEra");
        addItems(eraNameList, eraModel, eraAdd.val(), eraListName);
        eraAdd.val("");
    });

    $("#EraAdd").click(function () {
        addItems(eraNameList, eraModel, eraModel.find(":selected").text(), eraListName);
    });

    $("#EraRemove").click(function () {
        removeItems(eraNameList, eraListName);
    });
    //end era

    //start Patterns
    var patternListName = "PatternList";
    var patternNameList = $("#PatternNameList");
    var patternModel = $("#PatternNumbersModel");
    $("#PatternNew").click(function () {
        var patternAdd = $("#AddNewPattern");
        addItems(patternNameList, patternModel, patternAdd.val(), patternListName);
        patternAdd.val("");
    });

    $("#PatternAdd").click(function () {
        addItems(patternNameList, patternModel, patternModel.find(":selected").text(), patternListName);
    });

    $("#PatternRemove").click(function () {
        removeItems(patternNameList, patternListName);
    });
    //end Patterns

    //start use
    var useNewListName = "UsesList";
    var useNew = $("#UsesNameList");
    var useNewModel = $("#UsesModel");
    $("#UseNew").click(function () {
        var useAdd = $("#AddNewUse");
        addItems(useNew, useNewModel, useAdd.val(), useNewListName);
        useAdd.val("");
    });

    $("#UseAdd").click(function () {
        addItems(useNew, useNewModel, useNewModel.find(":selected").text(), useNewListName);
    });

    $("#UseRemove").click(function () {
        removeItems(useNew, useNewListName);
    });
    //end use

    //start trim
    var trimListName = "TrimList";
    var trimNameList = $("#TrimNameList");
    var trimModel = $("#TrimModel");
    $("#TrimNew").click(function () {
        var trimAdd = $("#AddNewTrim");
        addItems(trimNameList, trimModel, trimAdd.val(), trimListName);
        trimAdd.val("");
    });

    $("#TrimAdd").click(function () {
        addItems(trimNameList, trimModel, trimModel.find(":selected").text(), trimListName);
    });

    $("#TrimRemove").click(function () {
        removeItems(trimNameList, trimListName);
    });
    //end trim

    //start source
    var itemSourceListName = "ItemSourceList";
    var itemSource = $("#ItemSource");
    var itemSourceModel = $("#ItemSourceModel");
    $("#ItemSourceNew").click(function () {
        var itemAdd = $("#AddNewItemSource");
        addItems(itemSource, itemSourceModel, itemAdd.val(), itemSourceListName);
        itemAdd.val("");
    });

    $("#ItemSourceAdd").click(function () {
        addItems(itemSource, itemSourceModel, itemSourceModel.find(":selected").text(), itemSourceListName);
    });

    $("#ItemSourceRemove").click(function () {
        removeItems(itemSource, itemSourceListName);
    });
    //end source


    //GarmentCutRemove
    //

});