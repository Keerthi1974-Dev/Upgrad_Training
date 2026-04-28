import { Student } from "./student.model";
import { getGrade, getTopper } from "./student.service";
import { formatName, calculateAverage } from "./utils";

const students: Student[] = [
    { id: 1, name: "Sahir", marks: 85 },
    { id: 2, name: "Samar", marks: 72 },
    { id: 3, name: "anita", marks: 90 }
];

// Formatted Names
students.forEach(s => {
    console.log("Formatted Name:", formatName(s.name));
});

// Grades
students.forEach(s => {
    console.log(`Grade of ${s.name}:`, getGrade(s.marks));
});

// Average
console.log("Average Marks:", calculateAverage(students));

// Topper
console.log("Topper:", getTopper(students));