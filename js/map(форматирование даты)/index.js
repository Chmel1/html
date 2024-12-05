const date = ["2024-11-11","2025-10-10","2026-09-09"];
const formatedDate = date.map(Data)
function Data(element){
    const parts = element.split("-")
    return (`${parts[2]}.${parts[1]}.${parts[0]}`);
}
console.log(formatedDate);
