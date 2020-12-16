function solve (array) {

    let biggestElement = Number.MIN_SAFE_INTEGER;

    for(var i = 0; i < array.length; i++) {
        var cube = array[i];

        for(var j = 0; j < cube.length; j++) {
            if (cube[j] > biggestElement){
                biggestElement = cube[j];
            }
        }
    }

    console.log(biggestElement);
}

solve([[20, 50, 10], [8, 33, 145]]);
solve([[3, 5, 7, 12], [-1, 4, 33, 2], [8, 3, 0, 4]]);
