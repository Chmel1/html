function createGame(){
    let score = 0;

    function increaseScore(points){
        score += points;
        console.log(`${score - points}pts + ${points}pts`);
    }
    
    function deacreaseScore(points){
        score -= points;
        console.log(`${score + points}pts - ${points}pts`);
    }
    
    function getScore(){
        return score;
    }

    return {increaseScore,deacreaseScore,getScore}
}
let score = 100000000;
const game = createGame();

game.increaseScore(52);
game.deacreaseScore(42);
game.getScore()

console.log(`Финальный скор: ${game.getScore()}pts`);


