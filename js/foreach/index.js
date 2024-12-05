let numbers = ["бананчики","гоооол"];

numbers.forEach(toUpperCase);
numbers.forEach(display);

function display(element){
    
    console.log(element);
}

function toUpperCase(element,index,array){
    array[index]=element.toUpperCase()
}