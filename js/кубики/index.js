function rollDice(){
    const numOfDice = document.querySelector("#numOfDice").value
    const diceResult = document.querySelector("#diceResult")
    const diceImages = document.querySelector("#diceImages")
    const values = [];
    const images = [];

    for(let i = 0; i< numOfDice; i++)
    {
        const value = Math.floor(Math.random() * 6) + 1;
        sum = values.reduce((accamulator,current) => accamulator + current,value)
        values.push(value);
        images.push(`<img src = "imgKubiki/Dice-${value}.png">`)
        
    }
    if (sum == 52)
    {
        diceResult.innerHTML = `Сумма кубика(ов): ${sum} <br> W`
    }
    else
    {
    diceResult.textContent = `Сумма кубика(ов): ${sum}`
    }
    diceImages.innerHTML = images.join(' ');
}