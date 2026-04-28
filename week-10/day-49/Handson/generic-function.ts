export function getFirstElement<T>(items: T[]): T {
    if (items.length === 0) {
        throw new Error("Array is empty");
    }
    return items[0];
}