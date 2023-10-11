function getContentFromCell(cellId) {
    let cell = document.getElementById(cellId);
    return cell ? cell.textContent : '';
}
