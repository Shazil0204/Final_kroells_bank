// Function to show the error message
function showError() {
    let errorMessage = document.getElementById("errorMessage");
    errorMessage.style.display = "block";

    // Automatically hide the error message after 5 seconds
    setTimeout(function () {
        errorMessage.style.display = "none";
    }, 5000);
}