// Problem 3: Employee Management

// Base Class
class Employee {
    public id: number;
    protected name: string;
    private salary: number;

    constructor(id: number, name: string, salary: number) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    // Getter
    public getSalary(): number {
        return this.salary;
    }

    // Setter with validation
    public setSalary(value: number): void {
        if (value > 0) {
            this.salary = value;
        } else {
            console.log("Salary must be greater than 0");
        }
    }

    // Method
    public displayDetails(): void {
        console.log(`Employee ID: ${this.id}`);
        console.log(`Name: ${this.name}`);
        console.log(`Salary: ${this.salary}`);
    }
}


class Manager extends Employee {
    private teamSize: number;

    constructor(id: number, name: string, salary: number, teamSize: number) {
        super(id, name, salary);
        this.teamSize = teamSize;
    }

    // Method Overriding
    public displayDetails(): void {
        super.displayDetails();
        console.log(`Team Size: ${this.teamSize}`);
    }
}

// Object 
const emp = new Employee(1, "Sahir", 30000);
emp.displayDetails();
emp.setSalary(35000);
console.log("Updated Salary:", emp.getSalary());

console.log("--------------------------------------");

const mgr = new Manager(2, "Samar", 60000, 5);
mgr.displayDetails();