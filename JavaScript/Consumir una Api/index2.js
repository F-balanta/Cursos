const API_URL2 = "https://jsonplaceholder.typicode.com";

const HTMLresponse = document.querySelector("#app2")


fetch(`${API_URL2}/users`)
.then((response) => response.json())
.then((users) =>{
    const tpl = users.map((user) => `<li>${user.name}   📧${user.email}</li>`);
    HTMLresponse.innerHTML = `<ul>${tpl}</ul>`
});
