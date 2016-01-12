//JS functions file
function CheckStartsWith() {
    var txtStartsWithWords = $("#txtStartsWithWords");
    var txtStartsWithCondition = $("#txtStartsWithCondition");
    var startsWithContainer = $(".js-containerStartsWith");
    if (txtStartsWithWords.val().stringStartsWith(txtStartsWithCondition.val())) {
        if (!startsWithContainer.hasClass("logicSuccess")) startsWithContainer.toggleClass("logicSuccess");
        return true;
    }
    if (startsWithContainer.hasClass("logicSuccess")) startsWithContainer.toggleClass("logicSuccess");
    return false;
};

function CheckEndsWith() {
    var txtStartsWithWords = $("#txtEndsWithWords");
    var txtStartsWithCondition = $("#txtEndsWithCondition");
    var startsWithContainer = $(".js-containerEndsWith");
    if (txtStartsWithWords.val().stringEndsWith(txtStartsWithCondition.val())) {
        if (!startsWithContainer.hasClass("logicSuccess")) startsWithContainer.toggleClass("logicSuccess");
        return true;
    }
    if (startsWithContainer.hasClass("logicSuccess")) startsWithContainer.toggleClass("logicSuccess");
    return false;
};

function StripMarkupFromText() {
    var textArea = $("#txtWordsToStripHtml");
    textArea.val(String(textArea.val()).replace(/<[^>]+>/gm, ''));
}