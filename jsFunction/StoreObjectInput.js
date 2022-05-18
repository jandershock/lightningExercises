const isPurchaseAmountGreaterThan100 = (purchaseObj) => {
    if (purchaseObj.amount > 100) return true;
    else return false;
}

let purchase1 = {
    name: "Apples",
    amount: 200
}

let purchase2 = {
    name: "Strawberries",
    amount: 50
}

console.log(isPurchaseAmountGreaterThan100(purchase1), isPurchaseAmountGreaterThan100(purchase2));