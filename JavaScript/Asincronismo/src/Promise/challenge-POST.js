import fetch from 'node-fetch';


//Insertar datos dentro de una API

const API = 'https://api.escuelajs.co/api/v1';

function postData(urlApi, data){
    // Indicamos a la funcion fetch que usaremos para guardar informacion 
    // agregandole una estructura de datos a fetch
    const response = fetch(urlApi,{
        // Metodo a utilizar
        method:'POST',
        // Permisos
        mode: 'cors',
        //Si no hay autenticacion entonces no están pasando datos
        credentials: 'same-origin',
        headers: {
            'Content-Type': 'application/json'
        },
        // Convertimos esos datos en JSOn //! Serializamos los datos
        body: JSON.stringify(data)
    })
    return response;
}
const data ={
    "title": "212",
    "price": 2163416546544,
    "description": "A description",
    "categoryId": 1,
    "images": ["https://placeimg.com/640/480/any"]
  }
  // Enviamos los datos al metodo postdata
  postData(`${API}/products`, data)
  // transformamos esos datos en json
  .then(response => response.json())
  // Imprimimo los datos por consola
  .then(data=>console.log(data));