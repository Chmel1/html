const display = document.querySelector("#display");

function appendToDisplay(input){
    display.value += input
}
function clearDisplay(){
    display.value = ""
}
function calculate(){
    try {
        let expression = display.value;

        let parts = expression.split('/');
        
        // Если длина массива больше 1, это значит есть операция деления
        if (parts.length > 1) {
            // Проверяем, не делим ли мы на ноль
            let divisor = parseFloat(parts[1]); //Parsefloat преобразует строку в число
            if (divisor === 0) {
                throw new Error();
            }
        }

        // Если деление на ноль не найдено, выполняем вычисления
        display.value = eval(display.value);
    } catch (error) {
        display.value = "Ошибка";
    }
}