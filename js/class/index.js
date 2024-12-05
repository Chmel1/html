class Product{
    constructor(name,price){
        this.name = name;
        this.price = price;
    }
    displayProduct(){
        console.log(`Продукт: ${this.name}`);
        console.log(`Цена: ${this.price.toFixed(0)}р.`);
    }
    calculateTotal(salesTax){
        return this.price + (this.price * salesTax)
    }
}
const salesTax = 0.13;

const product1 = new Product("Гойда", 199);
product1.displayProduct();
const total = product1.calculateTotal(salesTax)
console.log(`Полная цена с учетом налога(13%): ${total.toFixed(0)}р.`);
