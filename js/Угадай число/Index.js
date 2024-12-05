const minNum = 1;
const maxNum = 100;
const answer = Math.floor(Math.random() * (maxNum-minNum + 1) + minNum);
console.log(answer);

let attempts = 0;
let guess;
let running = true;
while(running == true)
{
    guess = +prompt(`Угадайте номер между ${minNum} - ${maxNum}`)
    
    if(isNaN(guess) || guess > maxNum || guess < minNum)
    {
        alert("Введенно некоректное число")
    }
    else
    {
        attempts++;
        if(guess < answer)
        {
            alert("Так мало попробуй еще раз")
        }
        else if (guess > answer)
        {
            alert("Так много попробуй еще раз")
        }
        else
        {
            alert(`Правильно! Ответ был ${answer}. У тебя это заняло ${attempts} попыток`)
            running =false;
        }
    }
}
