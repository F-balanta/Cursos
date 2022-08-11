function fruits(){
    //!Block scope
    // Las palabras definidas dentro de este bloque 
    if(true){
        var fruit1 = "manzana";
        let fruit2 = "Banano"; // Block scope
        const fruit3= "kiwi"; // Block scope
        
    console.log(fruit2);
    console.log(fruit3);
    }
    console.log(fruit1);
}
fruits();