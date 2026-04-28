"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const data_manager_1 = require("./data-manager");
// User Manager
const userManager = new data_manager_1.DataManager();
userManager.add({ id: 1, name: "Samar" });
userManager.add({ id: 2, name: "Sahir" });
// Product Manager
const productManager = new data_manager_1.DataManager();
productManager.add({ id: 200, title: "Bluetooth" });
productManager.add({ id: 404, title: "Earpods" });
// Output
console.log("Users:", userManager.getAll());
console.log("Products:", productManager.getAll());
