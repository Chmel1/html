hello(bye);



function hello(callback){
    console.log("Привет!");
    callback();
    
}

function bye(){
    console.log("Пока!");
    
}