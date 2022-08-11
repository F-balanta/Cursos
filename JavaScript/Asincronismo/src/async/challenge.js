import fetch from 'node-fetch';
const API = "https://api.escuelajs.co/api/v1";

async function fechData(urlAPi){
    const response = await fetch(urlAPi);
    const data = await response.json();
    return data;
}

const anotherFunction = async(urlAPi)=>{
    try{
        const products = await fechData(`${urlAPi}/products`);
        //Hara la peticion sobre un elemento
        const product = await fechData(`${urlAPi}/products/${products[0].id}`)
        const category = await fechData(`${urlAPi}/categories/${product.category.id}`)

        console.log(products);
        console.log(product.tittle);
        console.log(category.name);
    }catch(error){
        console.error(error);
    }
}


anotherFunction(API);