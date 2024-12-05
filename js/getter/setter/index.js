class Person{
    constructor(firstName,lastName,age){
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    set firstName(newFirstName){
        if(typeof newFirstName === "string" && newFirstName.length > 0)
        {
            this._firstName = newFirstName;
        }
        else
        {
            console.error("Некорректное имя");
        }
    }
    set lastName(newlastName){
        if(typeof newlastName === "string" && newlastName.length > 0)
        {
            this._lastName = newlastName;
        }
        else
        {
            console.error("Некорректное имя");
        }
    }
    set age(newAge){
        if (newAge > 0 && typeof newAge === "number")
        {
            this._age = newAge;
        }
        else
        {
            console.error("Некорректный возраст");
        }
    }
    get firstName()
    {
        return this._firstName
    }

    get lastName()
    {
        return this._lastName
    }
    get age(){
        return this._age
    }
}

const person = new Person("Влад","Netribov",52)
console.log(person.firstName);

console.log(person.lastName);

console.log(person.age);
