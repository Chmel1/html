function displayPerson({name,age,isAlive}){
    console.log(`Имя: ${name}`);
    console.log(`Возраст: ${age}`);
    console.log(`Жив?: ${isAlive}`);
}

const perosn1 = {
    name: "iou",
    age: 52,
    isAlive: true
};

const perosn2 = {
    name: "uoi",
    age: 25,
    isAlive: false
};

displayPerson(perosn1)