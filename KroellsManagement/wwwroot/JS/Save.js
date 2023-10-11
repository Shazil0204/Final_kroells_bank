function getContentFromCell(cellId) {
    let cell = document.getElementById(cellId);
    console.log(cell)
    return cell ? cell.textContent : '';
}
