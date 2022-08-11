function greeting(){
    let username = "osacar";

    function displayUsername(){
        return `Hello ${username}`;
    }
    return displayUsername();
}

const g = greeting();
console.log(g);
console.log(g());