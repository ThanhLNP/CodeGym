function isGameWon() {
    for (let i = 0; i < 4; i++) {
        for (let j = 0; j < 4; j++) {
            if (grid.getGrid()[i][j] == 2048) {
                return true;
            }
        }
    }
    return false;
}

function isGameOver() {
    for (let i = 0; i < 4; i++) {
        for (let j = 0; j < 4; j++) {
            if (grid.getGrid()[i][j] == 0) { //còn vị trí trống
                return false;
            }
            if (i !== 3 && grid.getGrid()[i][j] === grid.getGrid()[i + 1][j]) { // còn có thể ghép được
                return false;
            }
            if (j !== 3 && grid.getGrid()[i][j] === grid.getGrid()[i][j + 1]) {
                return false;
            }
        }
    }
    return true;
}