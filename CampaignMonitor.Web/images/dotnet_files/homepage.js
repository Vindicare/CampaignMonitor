//Angular configuration

var LandingPageController = function ($scope) { };

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
LandingPageController.$inject = ['$scope'];

var CampaignMonitor = angular.module('CampaignMonitor', ['ngRoute']);

CampaignMonitor.controller('LandingPageController', LandingPageController);

var configFunction = function ($routeProvider) {
    $routeProvider.
       when('/dotnet', {
            templateUrl: 'home/dotnet'
        })
        .when('/javascript', {
            templateUrl: 'home/javascript'
        })        
        .when('/sql', {
            templateUrl: 'home/sql'
        });
}
configFunction.$inject = ['$routeProvider'];

CampaignMonitor.config(configFunction);


//Javascript functions

//JS extensions file
String.prototype.stringStartsWith = function stringStartsWith(string) {
    return this.slice(0, string.length) == string;
}

String.prototype.stringEndsWith = function stringEndsWith(string) {
    return string == '' || this.slice(-string.length) == string;
}

//Functionality for js partial
function CheckStartsWith() {
    var txtStartsWithWords = $("#txtStartsWithWords");
    var txtStartsWithCondition = $("#txtStartsWithCondition");
    if (txtStartsWithWords.val().stringStartsWith(txtStartsWithCondition.val())) {        
        txtStartsWithWords.val() = "<span class='hightlight'>" + txtStartsWithCondition.val() + "</span>";
        return true;
    }
    return false;
};

function StripMarkupFromText() {
    var textArea = $("#txtWordsToStripHtml");
    textArea.val(String(textArea.val()).replace(/<[^>]+>/gm, ''));
}