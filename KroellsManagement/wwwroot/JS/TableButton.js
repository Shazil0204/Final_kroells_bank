window.MyInterop = {
    getAddresses: function () {
        console.log("Entered function");
        DotNet.invokeMethod('KroellsManagement.Pages.AdminModel', 'GetAddresses');
    },
    // Define similar functions for other actions
};  