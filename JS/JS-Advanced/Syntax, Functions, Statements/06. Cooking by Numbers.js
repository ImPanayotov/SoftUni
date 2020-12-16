function solve(array){
    let num = +array[0];

    for (let index = 1; index <= 5; index++) {
        const cmd = array[index];

        if (cmd === 'chop') {
            num /= 2;
        }
        else if (cmd === 'dice') {
            num = Math.sqrt(num);
        }
        else if (cmd === 'spice') {
            num += 1;
        }
        else if (cmd === 'bake') {
            num *= 3;
        }
        else if (cmd === 'fillet') {
            num -= num / 5;
        }

        console.log(num);
    }
}


solve(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);
solve(['9', 'dice', 'spice', 'chop', 'bake', 'fillet']);
