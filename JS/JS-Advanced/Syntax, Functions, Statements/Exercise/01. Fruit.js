function CalculateNeededMoney(fruitToBuy, weight, pricePerKilo){
    let moneyNeeded = weight / 100 * pricePerKilo / 10;

    console.log(`I need $${moneyNeeded.toFixed(2)} to buy ${(weight / 1000).toFixed(2)} kilograms ${fruitToBuy}.`);
}


CalculateNeededMoney('orange', 2500, 1.80);