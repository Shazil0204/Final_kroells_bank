const thead = document.getElementById('header');
const tbody = document.getElementById('tableBody');
const tfoot = document.getElementById('footer');

function updateTable(columnNames) {
    DeleteAll();

    // Update the table header with the specified column names
    const headerRow = thead.querySelector('tr');
    columnNames.forEach(columnName => {
        const th = document.createElement('th');
        th.textContent = columnName;
        headerRow.appendChild(th);
    }); 
    /*
    // Update the footer
    const footerRow = tfoot.querySelector('tr');
    footerRow.innerHTML = '';
    columnNames.forEach(columnName => {
        const th = document.createElement('th');
        th.textContent = `Footer ${columnName}`;
        footerRow.appendChild(th);
    });

    // Clear the table body
    tbody.innerHTML = '';
    */
    // Loop through the <th> elements and apply the function
}

function DeleteAll() {
    console.log("del")



    while (thead.firstChild) {
        thead.removeChild(thead.firstChild)
        console.log("deleting")
    }

    while (tfoot.firstChild) {
        tfoot.removeChild(tfoot.firstChild)
        console.log("deleting")
    }
}

function GetAccounts() {
    console.log('GetAccounts called');
    // Add your existing functionality here
}

function GetAddresses() {
    console.log('GetAddresses called');
    // Add your existing functionality here
}