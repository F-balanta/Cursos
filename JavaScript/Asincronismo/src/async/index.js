const fnAsync = ()=>{
    return new Promise((resolve, reject)=>{
        (true)
        ? setTimeout(()=>resolve('Async'),2000)
        :reject(new Error("Error!"));
    })
}
// Permitira trabajar con multiples elementos o ejecutar sin detener la ejecucion

const  anotherfunction = async()=>{
    const something = await fnAsync();
    console.log(something);
    console.log("Hello");
}

console.log("Before");
anotherfunction();
console.log("After");