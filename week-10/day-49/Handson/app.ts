import { DataManager } from "./data-manager";
import { User, Product } from "./models";
import { getFirstElement } from "./generic-function";

// User Manager
const userManager = new DataManager<User>();

userManager.add({ id: 1, name: "Samar" });
userManager.add({ id: 2, name: "Sahir" });

// Product Manager
const productManager = new DataManager<Product>();

productManager.add({ id: 200, title: "Bluetooth" });
productManager.add({ id: 404, title: "Earpods" });

// Output
console.log("Users:", userManager.getAll());
console.log("Products:", productManager.getAll());

// getting the first Element
console.log("First User:", getFirstElement(userManager.getAll()));
console.log("First Product:", getFirstElement(productManager.getAll()));