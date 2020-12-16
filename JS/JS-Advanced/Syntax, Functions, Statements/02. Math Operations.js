function solve (num1, num2, operator){
    if(operator === '+'){
        return num1 + num2;
    }
    else if(operator === '-'){
        return num1 - num2;
    }
    else if(operator === '*'){
        return num1 * num2;
    }
    else if(operator === '/'){
        return num1 / num2;
    }
    else if(operator === '%'){
        return num1 % num2;
    }
    else if(operator === '**'){
        return Math.pow(num1, num2);
    }
}

console.log(solve(1, 1, '+'));
