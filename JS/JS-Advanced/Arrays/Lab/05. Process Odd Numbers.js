function solve(array) {
    let oddArray = [];

    for (let index = 0; index < array.length; index++) {
        const element = array[index];
        
        if (index % 2 !== 0) {
            oddArray.unshift(element * 2);
        }
    }

    console.log(oddArray.join(' '));
}

solve([10, 15, 20, 25]);
solve([3, 0, 10, 4, 7, 3]);
