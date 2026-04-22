"use strict";
class Car {
    lisense;
    constructor(num = 100) {
        this.lisense = num;
    }
    move() {
        return this.lisense;
    }
}
// instance of Car class can be created by new keyword
//console.log(new Car().lisense); // this calls the constructor of car class ----
// // we can also access the property and method using object reference
let ob = new Car();
console.log(ob.move());
