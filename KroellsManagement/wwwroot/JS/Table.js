// Get the element with the ID 'header' and store it in the 'thead' variable
const thead = document.getElementById('header');

// Get the element with the ID 'tableBody' and store it in the 'tbody' variable
const tbody = document.getElementById('tableBody');

// Get the element with the ID 'footer' and store it in the 'tfoot' variable
const tfoot = document.getElementById('footer');

// This function will serve as a table content switcher
function Entry(buttonName) {
    switch (buttonName) {
        // If button "Accounts" is pressed it fill these into the header and footer
        case "Accounts":
            var column = ["", "Account ID", "Balance", "Card ID", "", "", "", ""]
            break;
        // If button "Addresses" is pressed it fill these into the header and footer
        case "Addresses":
            var column = ["", "Postal code", "City", "Street", "House Number", "", "", ""]
            break;
        // If button "Cards" is pressed it fill these into the header and footer
        case "Cards":
            var column = ["", "Card ID", "Card Number", "Expire Date", "CVV", "Client", "Pin", "Spending"]
            break;
            // If button "Clients" is pressed it fill these into the header and footer
        case "Clients":
            var column = ["", "Client Name", "Username", "Password", "", "", "", ""]
            break;
        // If button "CPRs" is pressed it fill these into the header and footer
        case "CPRs":
            var column = ["", "Client ID", "AdressID", "EmployeeID", "CPR Number", "", "", ""]
            break;
        // If button "Employees" is pressed it fill these into the header and footer
        case "Employees":
            var column = ["", "Position", "Username", "Password", "", "", "", ""]
            break;
        // If button "Jobs" is pressed it fill these into the header and footer
        case "Jobs":
            var column = ["", "Income", "Job Name", "", "", "", "", ""]
            break;
        // If button "Loans" is pressed it fill these into the header and footer
        case "Loans":
            var column = ["", "Client ID", "APR", "Amount", "", "", "", ""]
            break;
            // If button "Transactions" is pressed it fill these into the header and footer
        case "Transactions":
            var column = ["", "Account ID", "Amount", "Date", "", "", "", ""]
            break;
    }
    // Calls updateTable function
    updateTable(column);
    // Calls clearTable function
    clearTable();
}
// this function will replace what is supposed go into footer and the header
function updateTable(columnNames) {
    // Iterates through all the header and footer elements, and at each iteration, it replaces the header's value with the value obtained from the 'entry'.
    for (let i = 1; i < 8; i++) {
        const headerId = document.getElementById(`header${i}`)
        headerId.innerText = columnNames[i]
        const footerId = document.getElementById(`footer${i}`)
        footerId.innerText = columnNames[i]
    }
    // While tbody has a first child, it will be removed.
    while (tbody.firstChild) {
        // removes the firstchild of the tbody
        tbody.removeChild(tbody.firstChild);
    }
}

//This function ruins the damn javascript on the website
function clearTable() {

    const table = document.getElementById("table");
    // Loops through each row in the table (skips first row because its contains headers)
    for (let i = 1; i < table.rows.length; i++) {
        const row = table.rows[i];
        // Lopp through each cell in the row and clear its content
        for (let j = 0; j < row.cells.length; j++) {
            row.cells[j].innerText = "";
        }
    }
}