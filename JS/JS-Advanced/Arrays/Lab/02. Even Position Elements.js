function solve(array) {
    let evenNumbers =[];

    for (let index = 0; index < array.length; index++) {
        const element = array[index];

        if (index % 2 === 0){
            evenNumbers.push(element);
        }
    }

        console.log(evenNumbers.join(' '));
}

solve(['20', '30', '40']);
solve(['5', '10']);