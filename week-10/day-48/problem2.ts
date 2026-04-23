// Problem 2: User Notification System

// 1. Required Parameter
function getWelcomeMessage(name: string): string {
    return `Welcome ${name}!`;
}

// 2. Optional Parameter
function getUserInfo(name: string, age?: number): string {
    if (age !== undefined) {
        return `${name} is ${age} years old`;
    }
    return `${name}'s age is not provided`;
}

// 3. Default Parameter
function getSubscriptionStatus(name: string, isSubscribed: boolean = false): string {
    return isSubscribed
        ? `${name} is subscribed`
        : `${name} is not subscribed`;
}

// 4. Return Type Boolean
function isEligibleForPremium(age: number): boolean {
    return age > 18;
}

// 5. Arrow Function
const getAlertMessage = (message: string): string => {
    return `Alert: ${message}`;
};

// 6. Lexical this
const NotificationService = {
    appName: "MyApp",

    sendNotification: (user: string): string => {
        return `Hello ${user}, welcome to ${NotificationService.appName}`;
    }
};

// 7. Execution
console.log(getWelcomeMessage("Sahir"));
console.log(getUserInfo("Sahir", 22));
console.log(getUserInfo("Sahir"));
console.log(getSubscriptionStatus("Sahir", true));
console.log(getSubscriptionStatus("Sahir"));
console.log("Eligible:", isEligibleForPremium(22));
console.log(getAlertMessage("Your account is updated"));
console.log(NotificationService.sendNotification("Sahir"));