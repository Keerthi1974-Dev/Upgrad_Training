"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.getFirstElement = getFirstElement;
function getFirstElement(items) {
    if (items.length === 0) {
        throw new Error("Array is empty");
    }
    return items[0];
}
