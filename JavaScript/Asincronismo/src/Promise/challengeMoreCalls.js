import fetch from 'node-fetch';
const API = '
';


function fetchData(UrlApi){
    return fetch(UrlApi);
};
// Obtenemos la api
fetchData(`${API}/products`)
//queremos mostrar lso datos de los productos
.then(response=> response.json())
.then(products=>{
    console.log(products);
    // PAra obtener la primera solicitud
    return fetchData(`${API}/products/${products[0].id}`)
})
// Para traer los datos converstire la respuesta en un Json
.then(response=>response.json())
// Pedimos los datos para las categorias y transformamos los datos obtenidos en json para ser leidos
.then(product=>{
    console.log(console.log(product.title));
    return fetchData(`${API}/categories/${product.category.id}`)
})
.then(response=>response.json())
.then(category =>{
    console.log(category.name);
}).catch(err=>console.log(err))
.finally(()=>console.log('Finished'));