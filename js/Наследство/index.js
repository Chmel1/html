class Animal{
    alive = true;

    eat(){
        console.log(`Этот ${this.name} ест`);
    }
    sleep(){
        console.log(`Этот ${this.name} спит`);
    }
}

class Rabbit extends Animal{
    name = "кролик"
}
class Fish extends Animal{
    name = "рыба"
}
const rabbit = new Rabbit



rabbit.sleep()
console.log(rabbit.alive);
rabbit.eat()