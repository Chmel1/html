const ulElement = document.querySelectorAll("ul")

ulElement.forEach(ulElement =>{
    const firstChild = ulElement.firstElementChild
    firstChild.style.backgroundColor = "yellow"
})