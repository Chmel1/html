const prices = [5,30,52,1111]

const total = prices.reduce(sum);

function sum(accumulator,element){
    return accumulator + element
}
console.log(total);
