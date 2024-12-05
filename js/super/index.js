class Animal{
    constructor(name,age){
        this.name = name;
        this.age = age;
    }
}
class Rabbit extends Animal{
    constructor(name,age,runSpeed){
        super(name,age);
        
        this.runSpeed = runSpeed;
    }
}
class Fish extends Animal{
    constructor(name,age,swimSpeed){
        super(name,age);
        this.swimSpeed = swimSpeed;
    }
}

const rabbit = new Rabbit("Скибиди кролик",2,52)
const fish = new Fish("Скибиди рыба",1,12)

console.log(rabbit);
