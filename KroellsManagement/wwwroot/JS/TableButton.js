function getButtonIdAndCallCSharpMethod(button) {
    var buttonId = button.id; 
    DotNet.invokeMethod("KroellsManagement.Pages", "GetTable", buttonId);
}