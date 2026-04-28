"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const student_service_1 = require("./student.service");
const utils_1 = require("./utils");
const students = [
    { id: 1, name: "Sahir", marks: 85 },
    { id: 2, name: "Samar", marks: 72 },
    { id: 3, name: "anita", marks: 90 }
];
// Formatted Names
students.forEach(s => {
    console.log("Formatted Name:", (0, utils_1.formatName)(s.name));
});
// Grades
students.forEach(s => {
    console.log(`Grade of ${s.name}:`, (0, student_service_1.getGrade)(s.marks));
});
// Average
console.log("Average Marks:", (0, utils_1.calculateAverage)(students));
// Topper
console.log("Topper:", (0, student_service_1.getTopper)(students));
