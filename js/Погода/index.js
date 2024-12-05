const textBox = document.querySelector("#textBox");
const toFahrenheit = document.querySelector("#toFahrenheit");
const toCelsius = document.querySelector("#toCelsius");
const result = document.querySelector("#result")
let temp;

function convert(){
    if(toFahrenheit.checked)
    {
        temp = Number(textBox.value);
        temp = temp * 9 / 5 + 32
        result.textContent = temp.toFixed(2) + " Граудсов по фаренгейту"
    }
    else if(toCelsius.checked)
    {
        temp = Number(textBox.value);
        temp = (temp -32) * (5/9)
        result.textContent = temp.toFixed(2) + " Граудсов по Цельсию"
    }
    else
    {
        result.textContent = "Выберите метод"
    }
}