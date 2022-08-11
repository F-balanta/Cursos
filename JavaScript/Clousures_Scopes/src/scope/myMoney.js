// function moneyBox(coins){
//     let savecoins = 0;
//     savecoins += coins
//     console.log(`Money Box: ${savecoins}`);
// }
// moneyBox(5);
// moneyBox(5);

function myMoneybox(){
    let savecoins=0;

    function countcoins(coins){
        savecoins += coins;
        console.log(`money Box ${savecoins}`)
    }
    return countcoins;
}

const mimoney = myMoneybox();
mimoney(5);
mimoney(5);

const moneyAna = myMoneybox();
moneyAna(10)
moneyAna(10)
moneyAna(10)
