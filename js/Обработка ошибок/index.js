try{
    const dividend = prompt("Введите дивидент:");
const divisor = prompt("Введите дивизор:");

if(dividend < 0 || divisor < 0){
    throw new Error("Данные не могут быть меньше 0")
}

const result = dividend / divisor;
console.log(result);
}
catch(error){
    alert(`Ошибка: ${error.message}`)
}
