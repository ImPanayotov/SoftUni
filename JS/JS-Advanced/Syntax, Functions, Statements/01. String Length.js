function solve(arr1, arr2, arr3) {
    let sumLenght;
    let averageLenght;

    let firstArgumentLength = arr1.length;
    let secondArgumentLength = arr2.length;
    let thirdArgumentLength = arr3.length;

    sumLenght = firstArgumentLength + secondArgumentLength + thirdArgumentLength;
    
    averageLenght = sumLenght / 3;

    console.log(sumLenght);
    console.log(Math.floor(averageLenght));
    
}

solve('pam', 'pan', 'duo')
