const API_URL = "https://jsonplaceholder.typicode.com";

const xhr = new XMLHttpRequest();

function onRequestHandler(){
    if(this.readyState === 4 && this.status === 200){

        //? 0 = UNSET, no se ha llamado al metodo open()
        //? 1 = OPENED, se ha llamado al metodo open().
        //? 2 = HEADERS_RECEIVED, se está llamando al metodo send(),
        //? 3= LOADING, está cargando, es decir, está recibiendo la respuesta.
        //? 4 =DONE, se ha completado la operación.
        const data = JSON.parse(this.response);
        const HTMLresponse = document.querySelector("#app");

        const tpl = data.map(user => `<li>${user.name} 📧 ${user.email}</li>`)
        HTMLresponse.innerHTML = `<ul>${tpl}</ul>`
    }
}

xhr.addEventListener('load', onRequestHandler);
xhr.open('GET', `${API_URL}/users`);
xhr.send();