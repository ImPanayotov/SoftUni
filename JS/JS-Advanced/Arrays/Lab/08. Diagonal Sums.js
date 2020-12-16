function solve(array) {


    let primeDiagonal = 0;
    let secondDiagonal = 0;

    for(var i = 0; i < array.length; i++) {
        var cube = array[i];

        primeDiagonal += cube[i];
        secondDiagonal += cube[array.length - 1 -i];
    }

    console.log(`${primeDiagonal} ${secondDiagonal}`);
}

solve([[20, 40], [10, 60]]);

solve([[3, 5, 17], [-1, 7, 14], [1, -8, 89]]);