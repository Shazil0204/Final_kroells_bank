﻿
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
        newCell.textContent = "0";
        newRow.appendChild(newCell);
    }
    
    // Create a table cell for the Delete button
    const deleteButtonCell = document.createElement("td");
     // Create a button element with the delete function
    const deleteButton = document.createElement("button");
    deleteButton.textContent = "Delete";

    // Add a class to the button element for styling
    deleteButton.classList.add("button");
    
    // Append the button element to the button cell
    deleteButtonCell.appendChild(button);

       // Append the button cell to the new row
    newRow.appendChild(buttonCell);

    

    // Create a table cell for the save button
    const saveButtonCell = document.createElement("td");

     // Create a button element with the save function
    const saveButton = document.createElement("button");
    saveButton.textContent = "Save";

    // Add a class to the button element for styling
    saveButton.classList.add("button");

     // Append the button element to the button cell
    saveButtonCell.appendChild(button);

     // Append the button cell to the new row
    newRow.appendChild(buttonCell);
    
 

     // Append the new row to the table body, adding the row with the buttons to the table
    tableBody.appendChild(newRow);
}
