const fruits = 
[
    {name:"Яблоко", color: "red", calories: 52}, 
    {name:"Груша", color: "green", calories: 53}
];

const maxFruits = fruits.reduce((max,fruit) =>
    fruit.calories > max.calories ? fruit : max
);
console.log(maxFruits.calories);
