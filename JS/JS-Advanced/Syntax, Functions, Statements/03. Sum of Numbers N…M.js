function solve (n, m){
    var sum = 0;
    let num1 = +n;
    let num2 = +m;

    for (let index = num1; index <= num2; index++) {
        
        sum += index;
    }

    return sum;
}

console.log(solve(1, 5))
