"use strict";
// Problem 3: Employee Management
// Base Class
class Employee {
    id;
    name;
    salary;
    constructor(id, name, salary) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    // Getter
    getSalary() {
        return this.salary;
    }
    // Setter with validation
    setSalary(value) {
        if (value > 0) {
            this.salary = value;
        }
        else {
            console.log("Salary must be greater than 0");
        }
    }
    // Method
    displayDetails() {
        console.log(`Employee ID: ${this.id}`);
        console.log(`Name: ${this.name}`);
        console.log(`Salary: ${this.salary}`);
    }
}
// Derived Class
class Manager extends Employee {
    teamSize;
    constructor(id, name, salary, teamSize) {
        super(id, name, salary);
        this.teamSize = teamSize;
    }
    // Method Overriding
    displayDetails() {
        super.displayDetails();
        console.log(`Team Size: ${this.teamSize}`);
    }
}
// Object Creation
const emp = new Employee(1, "Keerthi", 30000);
emp.displayDetails();
emp.setSalary(35000);
console.log("Updated Salary:", emp.getSalary());
console.log("------");
const mgr = new Manager(2, "Rahul", 60000, 5);
mgr.displayDetails();
