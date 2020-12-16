function solve(array) {
    let number = 1;
    let newArray = [];

    for (let i = 0; i < array.length; i++) {
        const element = array[i];
        
        if(array[i] === 'add') {
            newArray.push(number);
        }
        else if (array[i] === 'remove') {
            newArray.pop();
        }

        number++;
    }

    if (newArray.length === 0) {
        console.log('Empty');
    }
    else {
        console.log(newArray.join('\n'));
    }
}

solve(['add', 'add', 'add', 'add']);
solve(['add', 'add', 'remove', 'add', 'add']);
solve(['remove', 'remove', 'remove']);
