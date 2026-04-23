// Problem 1: User Profile Data Handling

// 1.Declaration of variables
const userName: string = "Sahir";
let age: number = 22;
const email: string = "Sahir@gmail.com";
const isSubscribed: boolean = true;

// 2. Type Inference
let country = "India";       // inferred as string
let points = 100;           // inferred as number

// 3. updating variables
age = age + 1; // increment age

// Template Literals
const profileMessage = `Hello ${userName}, you are ${age} years old and your email is ${email}`;

// Operators
const isEligibleForPremium = age > 18 && isSubscribed;

// Output
console.log("User Profile:");
console.log(profileMessage);
console.log("Country:", country);
console.log("Points:", points);
console.log("Updated Age:", age);
console.log("Eligible for Premium:", isEligibleForPremium);