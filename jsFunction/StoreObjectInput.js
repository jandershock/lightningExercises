const isPurchaseAmountGreaterThan100 = (purchaseObj) => {
    if (!purchaseObj.amount) return "Invalid purchase amount"
    else if (purchaseObj.amount > 100) return true;
    else if (purchaseObj.amount === 100) return "Purchase is exactly 100";
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

let purchase3 = {
    name: "Waffles",
    amount: 100
}

let purchase4 = {
    name: "Null Bacon",
    amount: null
}

console.log(isPurchaseAmountGreaterThan100(purchase1));
console.log(isPurchaseAmountGreaterThan100(purchase2));
console.log(isPurchaseAmountGreaterThan100(purchase3));
console.log(isPurchaseAmountGreaterThan100(purchase4));
console.log(isPurchaseAmountGreaterThan100("purchase1"));