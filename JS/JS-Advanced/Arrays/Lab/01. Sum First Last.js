function solve(array) {
    let result = 0;
    let arrayLength = array.length;
    let num1 = Number(array.shift());

    if (arrayLength == 1){
        result = 2 * num1;
        console.log(result);
        return;
    }
    
    let num2 = Number(array.pop());

    result = num1 + num2;
    console.log(result);
}

solve(['5']);