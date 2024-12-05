const checkBox = document.querySelector("#checkBox1");

const golButton = document.querySelector("#golButton");
const stariyBogButton = document.querySelector("#stariyBogButton");
const goidaButton = document.querySelector("#goidaButton");

const submitButton = document.querySelector("#submitButton");

const subResult = document.querySelector("#subResult");
const memResult = document.querySelector("#memResult");

submitButton.onclick = function(){
    if(checkBox.checked){
        subResult.textContent = `Ты Чиловый парень!`;
    }
    else{
        subResult.textContent = `Ты  не Чиловый парень(`;
    }

    if(golButton.checked){
        memResult.innerHTML = `<img class = "image" src="img/gooool.webp" alt="ГООООЛ">`
    }
    else if(stariyBogButton.checked){
        memResult.innerHTML = `<img class = "image" src="img/stariybog.webp" alt="Старый бог">`
    }
    else if(goidaButton.checked){
        memResult.innerHTML = `<img class = "image" src="img/goida.webp" alt="Гойда">`
    }
}