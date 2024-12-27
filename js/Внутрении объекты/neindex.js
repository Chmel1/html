class Person{
    constructor(name,age, ...address){
        this.name = name;
        this.age = age;
        this.address = new Address(...address); 
    }
};

class Address {
    constructor(street,city,country){
        this.street = street;
        this.city = city;
        this.country = country;
    }
};

const person1 = new Person("Влад", 52, "ул. Конч д. 123", "Гойдаланск", "Расисия");
for(const propa in person1.address){
    console.log(person1.address[propa]);
    
}
console.log(person1);
