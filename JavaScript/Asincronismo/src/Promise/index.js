const promise = new promise(function(resolve, reject) {
    resolve("Todo ha sido correcto");
})

const cows = 15;

const countCows = new Promise((resolve, reject)=>{
    if(cows > 10){
        resolve(`We hace ${cows} cow on the farm`);
    }else{
        reject('There is no cows on the farm')
    }
})

countCows.then((result)=>{
    console.log(result);
}) .catch((error)=>{
    console.log(error);
}).finally(()=>console.log('Finished'));