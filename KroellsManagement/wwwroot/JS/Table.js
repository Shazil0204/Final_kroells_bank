const thead = document.getElementById('header');
const tbody = document.getElementById('tableBody');
const tfoot = document.getElementById('footer');

function Entry(buttonName) {
    switch (buttonName) {
        case "Accounts":
            var column = ["", "Account ID", "Balance", "Card ID", "", "", "", ""]
            break;
        case "Addresses":
            var column = ["", "Postal code", "City", "Street", "House Number", "", "", ""]
            break;
        case "Cards":
            var column = ["", "Card ID", "Card Number", "Expire Date", "CVV", "Client", "Pin","Spending"]
            break;
        case "Clients":
            var column = ["", "Client Name", "Username", "Password", "", "", "", ""]
            break;
        case "CPRs":
            var column = ["", "Client ID", "AdressID", "EmployeeID", "CPR Number", "", "", ""]
            break;
        case "Employees":
            var column = ["", "Position", "Username", "Password", "", "", "", ""]
            break;
        case "Jobs":
            var column = ["", "Income", "Job Name", "", "", "", "", ""]
            break;
        case "Loans":
            var column = ["", "Client ID", "APR", "Amount", "", "", "", ""]
            break;
        case "Transactions":
            var column = ["", "Account ID", "Amount", "Date", "", "", "", ""]
            break;
    }

    updateTable(column);
    deleteRows();
}

function updateTable(columnNames) {

    for (let i = 1; i < 8; i++) {
        const headerId = document.getElementById(`header${i}`)
        headerId.innerText = columnNames[i]
        const footerId = document.getElementById(`footer${i}`)
        footerId.innerText = columnNames[i]
    }

    //while (tbody.firstChild) {
    //    tbody.removeChild(tbody.firstChild);
    //}

    //const emptyParent = tbody.cloneNode(false);
    //tbody.parentNode.replaceChild(emptyParent, tbody);

    //if (tbody.firstChild) {
    //    tbody.firstChild.remove();
    //}

    if (tbody) {
        while (tbody.firstChild) {
            tbody.removeChild(tbody.firstChild);
        }
    }
}

function deleteRows() {
    var table = document.getElementById(table);
    var tbody = table.querySelector("tbody");

    while (tbody.firstChild) {
        tbody.removeChild(tbody.firstChild);
    }
}

function removeTable() {
    const table = document.getElementById("tableBody");

    table.parentNode.removeChild(table);
}


// //This function ruins the damn javascript on the website
//function clearTable() {

//    const table = document.getElementById("table");
//    // Loops through each row in the table (skips first row because its contains headers)
//    for (let i = 1; i < table.rows.length; i++) {
//        const row = table.rows[i];
//        // Lopp through each cell in the row and clear its content
//        for (let j = 0; j < row.cells.length; j++) {    
//            row.cells[j].innerText = "";
//        }
//    }
//}

    /*
    // Create and append new header cells
    const headerRow = document.createElement('tr');
    columnNames.forEach(columnName => {
        const th = document.createElement('th');
        th.textContent = columnName;
        headerRow.appendChild(th);
    });
    // Append the new header row to the table header
    thead.appendChild(headerRow);

    // Clear the footer
    tfoot.innerHTML = '';

    // Update the footer
    const footerRow = document.createElement('tr');
    columnNames.forEach(columnName => {
        const th = document.createElement('th');
        th.textContent = `Footer ${columnName}`;
        footerRow.appendChild(th);
    });
    // Append the new footer row to the table footer
    tfoot.appendChild(footerRow);

    // Clear the table body
    tbody.innerHTML = '';

    // Loop through the <th> elements and apply the function
    */



