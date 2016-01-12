//JS functions file

var GetPositiveDivisors = function () {

    var numberValue = $("#txtDivisibleValue").val();

    $.ajax({
        type: 'GET',
        url: "/dotnet/getpositivedivisors/?number=" + numberValue,
        async: true,
        dataType: 'json',
        accepts: {
            json: 'application/json'
        },
        contentType: "application/json",
    }).done(function (data) {           
        $("#txtPositiveDivisorsAnswer").html(data);
    });
};

var GetSurfaceArea = function () {

    var sideA = $("#txtSideA").val();
    var sideB = $("#txtSideB").val();
    var sideC = $("#txtSideC").val();

    $.ajax({
        type: 'GET',
        url: "/dotnet/getsurfacearea/?sideA=" + sideA + "&sideB=" + sideB + "&sideC=" + sideC,
        async: true,
        dataType: 'json',
        accepts: {
            json: 'application/json'
        },
        contentType: "application/json",
    })
       .done(function (data) {
           $("#txtSurfaceAreaAnswer").html(data);
       });
};

var FindCommonElements = function () {

    var intArrayValues = $("#txtIntArray").val();

    $.ajax({
        type: 'GET',
        url: "/dotnet/findcommonelements/",
        data: { 'intArrayValues': intArrayValues },
        async: true,
        dataType: 'json',
        accepts: {
            json: 'application/json'
        },
        contentType: "application/json",
    })
       .done(function (data) {
           $("#txtIntArrayCommonElementsAnswer").html(data);
       });
};