/*const name = "Санек"
const age = 28
const isDevelooper = true
const power = 999999n
const sign = Symbol()
const something = undefined
const data = null

const user = 
{
    login: "123",
    password:"qwerty",
}*/

/*const user = 
{
    
}

user.name = "Санек"

console.log(user)*/

/*const propName = prompt("Свойство с каким именем добавить?")
const propValue = prompt(`Какое значение зщаписать в свойство ${propName} `)

const obj =
{
    [propName]:propValue
}
console.log(obj)*/


/* const user = 
{
    name:"Санек",
    age:28,
    isDeveloper:true
}

for (const key in user)
{
    console.log(user[key])
   
} */

/* const nums =
{
    2:"Второй",
    1:"Первый",
    3:"Третий"
}
for (const num in nums)
{
    console.log(nums[num])
} */

/* const obj1 = 
{   
    name:"Санек", 
    age:10
}
const obj2 = 
{
    name:"Санек", 
    age:10
}

const areObjectsEqual = (object1,object2) =>
{
    const keys1 = Object.keys(object1)
    const keys2 = Object.keys(object2)
    
    if (keys1.length !== keys2.length)
    {
        return false
    }

    for (const key in object1)
    {
        if (object1[key] !== object2[key])
        {
            return false
        }
    }

    return true
}

console.log
(   
    "Равны ли два объекта obj1 и obj2:",
    areObjectsEqual(obj1,obj2)
)
 */
/* const obj1=
{
    name:"alex",
    age:22
}
const obj2 = 

{
    ...obj1
}
obj2.name = "Max"

console.log("obj1:",obj1)
console.log("obj2:",obj2)
 */

/* const obj1 =
{
    name:"Alex"
}
const obj2 =
{
    age:52
}
const user = Object.assign({},obj1,obj2)

console.log('user:',user) */



/* const guest1=
{
    name:"Stariy",
    age:52,
    orderInfo:
    {
        romtype:2,
        stayDates:
        {
            from:"15.05.2024",
            to:"15.06.2024",
        }
    },
}

const guest2 = 
{
    name:"Goida",
    age:22
}

const logGuestInfo = (guest) =>
{
    console.log
    (
        `
        Имя:${guest.name}
        Возраст:${guest.age}
        Дата выдачи: ${guest.orderInfo?.stayDates.to ?? "Не указана"}
        `
    )
}

logGuestInfo(guest1)
logGuestInfo(guest2) */

/* const user=
{
    name:"Goida",
    age:22,
    isDeveloper: true/*  */
/* }

const 
{
    name,
    age,
    isDeveloper
} = user
console.log('name:',name)
 */

/* const logAddres = (
    {
        city,
        street,
        houseNumber,
        apartmentNumber
    }
) => 
{
    console.log 
    (
        `
            Адрес:
            г. ${city} ул. ${street} 
            д. ${houseNumber} кв. ${apartmentNumber}
        `
    )
}

logAddres
(
    {
        city:'Москва',
        street: "Yiou",
        houseNumber:'52',
        apartmentNumber:'812'
    }
) */ 

//КАЛЬКУЛЯТОР
/* const calculator = 
{
    read ()
    {
        this.a = +prompt("Введите первое число")
        this.b = +prompt("Введите второе число")
    },
    sum ()
    {
        return this.a + this.b
    },
    mul ()
    {
        return this.a * this.b
    }
};

calculator.read();
alert (`Сложение: ${calculator.sum()}`);
alert (`Произведение: ${calculator.mul()}`); */


//Ступенька
/* let ladder =
{
    step:0,
    up()
    {
        if(this.step >= 0)
        {
        this.step++;
        return this;
        }
    },
    down()
    {
        if(this.step>=1)
        {
        this.step--;
        return this;
        }
        else if (this.step===0)
        {
            console.log("Вы дошли до начала ступеньки, ваша текущая ступенька", this.step)
            return this
        }
        
    },
    ShowStep()
    {

        console.log("Текущая ступенька:", this.step);
        this.nextstep = (this.step + 1);
        this.Previousstep = (this.step - 1);
        console.log("Следуюший шаг вперед:", this.nextstep);
        console.log("Следуюший шаг назад:", this.Previousstep);
        return this;
        
        
    }
};
ladder
.up()
.up()
.up()
.down()
.ShowStep() */

////////РАБОТА СО СТРОКАМИ///////////
/* const name ="Александр";

console.log(name[2])
console.log(name.at(0))
console.log(name.toLowerCase())
console.log(name.toUpperCase())

const msg = "Попробуем найти эщкере"
console.log(msg.includes("эщкере"))
/* console.log (msg.substring(0,4)) 
console.log(msg.replaceAll("о","а"))

const str = "+7 999 999 99 99"
console.log(str.replaceAll( /\d/g,"#"))

const str1 = "Зверя нет сильней китайца СТАРЫЙ БОГ соси нам яйца "

console.log(str1.split(" "))

let msg1 = "Здарова Старый"
console.log(`Сообщение жо изменения: "${msg1}"`)

msg1= msg1.
trim().
toUpperCase().
slice(-6)
console.log(`После изменения: "${msg1}"`) */

/* const str = prompt("Ведите ваше имя")
const clear_str = str.trim().toLowerCase()

if(clear_str.length === 0)
{
    alert("Введите имя!")
}
if(clear_str.includes("админ"))
{
    alert("Нельзя такое")
} */

/////////МАСИВЫ/////////

/* const arr = 
[
    'Привет',
    100,
    true,
    {
        name:"alex"
    },
    ()=> console.log("yshkere"),
    [true,false,true]
]
arr.push('g','d')

arr.unshift('g','d')

console.log(arr)

console.log(arr.pop())

console.log(arr.shift())

console.log(arr.join(', '))

console.log(arr) */

/* const arr1 = ['A','B','D']
const arr2 = [...arr1]


arr2[0]='t'

console.log('arr1:',arr1)
console.log('arr2:',arr2) */

/* const arr1 = ['1','2']
const arr2 = ['3','4']

const AllArr = [...arr1,...arr2]
console.log(AllArr) */

const arr1 = ['1','2','3', ['1']]
const arr2 = ['1','2','3', ['1']]

const areArraysEqual = (array1, array2) =>
{
if(arr1.length !== arr2.length)
{
    return false
}

for (let i = 0;i<array1.length; i++)
{
    const value1 = array1[i]
    const value2 = array2[i]

    const areValuesArrays = Array.isArray(value1) && Array.isArray(value2)

    if(areValuesArrays)
    {
        if( !areArraysEqual(value1,value2))
        {
            return false 
        }
        else
        {
            continue
        }
    }

    if(value1 !== value2)
    {
        return false
    }
}

return true

}

console.log(areArraysEqual(arr1,arr2))