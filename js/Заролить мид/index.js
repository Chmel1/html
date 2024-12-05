const rollButton = document.querySelector("#rollButton");
const rollLabel = document.querySelector("#rollLabel");
const min = 1;
const max = 100;
let randomNum = "";
rollButton.onclick = function() 
{
    randomNum=Math.floor(Math.random() *(max-min + 1) +min);
    rollLabel.textContent = randomNum;
    if (randomNum == 100 || randomNum == 52)
    {
        rollLabel.innerHTML = randomNum + "<br>W";
    }
}
