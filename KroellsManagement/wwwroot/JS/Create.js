
function Create() {
    console.log("Works")

    // Optains reference on our table by the id.
    let table = document.getElementById("table");
    let bodyt = table.querySelector("tbody");

    data.forEach(function (array) {
        let newRow = bodyt.insertRow();
        console.log("foreach")
        for (let i = 0; i < array.length; i++) {
            let cell = newRow.insertCell(i);
            cell.innerHTML = "";
            console.log("done")
        }
    })
    
    
}