//JS extensions file
String.prototype.stringStartsWith = function stringStartsWith(string) {
    return string != '' && this.slice(0, string.length) == string;
}

String.prototype.stringEndsWith = function stringEndsWith(string) {
    return string != '' && this.slice(-string.length) == string;
}