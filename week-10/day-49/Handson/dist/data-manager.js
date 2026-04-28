"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.DataManager = void 0;
class DataManager {
    constructor() {
        this.items = [];
    }
    add(item) {
        this.items.push(item);
    }
    getAll() {
        return this.items;
    }
}
exports.DataManager = DataManager;
