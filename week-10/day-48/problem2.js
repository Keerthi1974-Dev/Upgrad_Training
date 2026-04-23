"use strict";
// Problem 2: User Notification System
// 1. Required Parameter
function getWelcomeMessage(name) {
    return `Welcome ${name}!`;
}
// 2. Optional Parameter
function getUserInfo(name, age) {
    if (age !== undefined) {
        return `${name} is ${age} years old`;
    }
    return `${name}'s age is not provided`;
}
// 3. Default Parameter
function getSubscriptionStatus(name, isSubscribed = false) {
    return isSubscribed
        ? `${name} is subscribed`
        : `${name} is not subscribed`;
}
// 4. Return Type Boolean
function isEligibleForPremium(age) {
    return age > 18;
}
// 5. Arrow Function
const getAlertMessage = (message) => {
    return `Alert: ${message}`;
};
// 6. Lexical this
const NotificationService = {
    appName: "MyApp",
    sendNotification: (user) => {
        return `Hello ${user}, welcome to ${NotificationService.appName}`;
    }
};
// 7. Execution
console.log(getWelcomeMessage("Keerthi"));
console.log(getUserInfo("Keerthi", 22));
console.log(getUserInfo("Keerthi"));
console.log(getSubscriptionStatus("Keerthi", true));
console.log(getSubscriptionStatus("Keerthi"));
console.log("Eligible:", isEligibleForPremium(22));
console.log(getAlertMessage("Your account is updated"));
console.log(NotificationService.sendNotification("Keerthi"));
