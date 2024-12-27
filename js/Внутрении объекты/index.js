const body = document.querySelector("body")

body.style.backgroundColor = "black"
body.style.color = "white"

const person = {
    name: "Илюха",
    age: 52,
    achivments: [
        "дота пластилин",
        "рангхигс отличник"
    ],
    addres:{
        street: "ул. Пушкина",
        city: "Гойда",
        house: "д. Калатушкина"
    }
    
}

for(const property in person.addres)
{
    console.log(person.addres[property]);
    
}

