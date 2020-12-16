function solve (array) {
    let newArray = [];

    for (let index = 0; index < array.length; index++) {
        const element = array[index];

        if (element < 0) {
            newArray.unshift(element);
        }
        else {
            newArray.push(element);
        }
    }

    console.log(newArray.join('\n'));
}

solve([7, -2, 8, 9]);
solve([3, -2, 0, -1]);
