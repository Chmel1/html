const descreaseButton = document.querySelector("#decreaseBtn");
const resetButton = document.querySelector("#resetBtn");
const increaseButton = document.querySelector("#increaseBtn");
const countLabel = document.querySelector("#countLabel");
let count = 0;

increaseButton.onclick = function(){
    count++;
    countLabel.textContent = count;
}
descreaseButton.onclick = function(){
    count--;
    countLabel.textContent = count;
}
resetButton.onclick = function(){
    count = 0;
    countLabel.textContent = (count);
}
