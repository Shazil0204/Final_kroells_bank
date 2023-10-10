
const createButton = document.querySelector('.editbar button.button');
// Function to add a new row to the table
function AddRow() {
    // Get a reference to the table body element by its ID
    const tableBody = document.getElementById("tableBody");
     // Create a new row element
    const newRow = document.createElement("tr");
    console.log("Adding a new row");

    // Create and append 7 table cells with meaningful values to the new row
    for (let i = 1; i <= 7; i++) {
        const newCell = document.createElement("td");
        newCell.textContent = "New Value " + i; // Set meaningful values
        newRow.appendChild(newCell);
    }
    // Create a table cell for the button
    const buttonCell = document.createElement("td");
     // Create a button element
    const button = document.createElement("button");
    button.textContent = "Delete";

    // Add a class to the button element for styling
    button.classList.add("button");
    
    // Append the button element to the button cell
    buttonCell.appendChild(button);

       // Append the button cell to the new row
    newRow.appendChild(buttonCell);

     // Append the new row to the table body, adding the row with the button to the table
    tableBody.appendChild(newRow);
}
