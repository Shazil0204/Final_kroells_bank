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
            var column = ["", "Address ID", "Postal code", "City", "Street", "House Number", "", ""]
            break;
        // If button "Cards" is pressed it fill these into the header and footer
        case "Cards":
            var column = ["", "Card ID", "Card Number", "Expire Date", "CVV", "Client", "Pin", "Spending"]
            break;
            // If button "Clients" is pressed it fill these into the header and footer
        case "Clients":
            var column = ["", "Client ID", "Client Name", "Username", "Password", "", "", ""]
            break;
        // If button "CPRs" is pressed it fill these into the header and footer
        case "CPRs":
            var column = ["", "CPR ID", "Client ID", "AdressID", "EmployeeID", "CPR Number", "", ""]
            break;
        // If button "Employees" is pressed it fill these into the header and footer
        case "Employees":
            var column = ["", "Employee ID", "Position", "Username", "Password", "", "", ""]
            break;
        // If button "Jobs" is pressed it fill these into the header and footer
        case "Jobs":
            var column = ["", "Job ID", "Income", "Job Name", "", "", "", ""]
            break;
        // If button "Loans" is pressed it fill these into the header and footer
        case "Loans":
            var column = ["", "Loan ID", "Client ID", "APR", "Amount", "", "", ""]
            break;
            // If button "Transactions" is pressed it fill these into the header and footer
        case "Transactions":
            var column = ["", "Transaction ID", "Account ID", "Amount", "Date", "", "", ""]
            break;
    }
    // Calls updateTable function
    UpdateTable(column);
    // Calls clearTable function
    ClearTable();
}

// this function will replace what is supposed go into footer and the header
function UpdateTable(columnNames) {
    // Iterates through all the header and footer elements, and at each iteration, it replaces the header's value with the value obtained from the 'entry'.
    for (let i = 1; i < 8; i++) {
        const headerId = document.getElementById(`header${i}`)
        headerId.innerText = columnNames[i]
        const footerId = document.getElementById(`footer${i}`)
        footerId.innerText = columnNames[i]
    }
}

// Function to clear the table.
function ClearTable() {
    // Optains the table body by using the id
    const table = document.getElementById("tableBody");
    // while loop that repeatedly delets the first row of the table until there are no rows left.
    while (table.rows.length >0) {
        table.deleteRow(0);
    }
}