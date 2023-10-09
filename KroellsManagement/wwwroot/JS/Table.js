const thead = document.getElementById('header');
const tbody = document.getElementById('tableBody');
const tfoot = document.getElementById('footer');
const table = document.getElementById('table')

function Entry(buttonName) {
    switch (buttonName) {
        case "Accounts":
            var column = ["", "Account ID", "Balance", "Card ID", "", "", "", ""]
            break;
        case "Addresses":
            var column = ["", "Postal code", "City", "Street", "House Number", "", "", ""]
            break;
        case "Cards":
            var column = ["", "Card Number", "Expire Date", "CVV", "Client Name", "Pin", "Spendig", ""]
            break;
        case "Clients":
            var column = ["", "Client Name", "Username", "Password Hashed", "", "", "", ""]
            break;
        case "CPRs":
            var column = ["", "Client ID", "AdressID", "EmployeeID", "CPR Number", "", "", ""]
            break;
        case "Employees":
            var column = ["", "Position", "Username", "Password Hashed", "", "", "", ""]
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
}

function updateTable(columnNames) { /*
    // deletes the footer and the header
    let deleteHeader = document.querySelectorAll('th')
    deleteHeader.forEach(element => {
        console.log(element);
        element.remove();
    }); */

    // Create the header
    //for (let i = 0; i < 7; i++) {
    //    const childElement = document.createElement("th");
    //    childElement.textContent = columnNames[i]
    //    thead.appendChild(childElement);
    //    console.log(childElement)
    //}
    for (let i = 1; i < 8; i++) {
        const headerId = document.getElementById(`header${i}`)
        headerId.innerText = columnNames[i]
        const footerId = document.getElementById(`footer${i}`)
        footerId.innerText = columnNames[i]
    }
    
    //const buttons = document.createElement('button')
    //thead.appendChild(buttons);
    //tfoot.appendChild(buttons);

    console.log(table)
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
}

function GetAccounts() {
    console.log('GetAccounts called');
    // Add your existing functionality here
}

function GetAddresses() {
    console.log('GetAddresses called');
    // Add your existing functionality here
}
