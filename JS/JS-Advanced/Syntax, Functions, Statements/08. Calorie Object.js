function solve(array) {

    var menu = {calories: []};

    for (let index = 0; index < array.length - 1; index +=2) {
        let name = array[index];
        let calories = array[index + 1];

        let element = `${name}: ${calories}`;

        menu.calories.push(element);
    }

    console.log(`{ ${menu.calories.join(', ')} }`);
}

solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
console.log("#".repeat(20));
solve(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);

