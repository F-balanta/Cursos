const btnFlotante = document.querySelector('.btn-flotante');
const footer = document.querySelector('.footer');

console.log(btnFlotante)
console.log(footer)

btnFlotante.addEventListener('click', mostrarocultarFooter);

function mostrarocultarFooter(){
    if(footer.classList.contains('activo')){
        footer.classList.remove('activo');
        btnFlotante.classList.remove('activo')
        btnFlotante.textContent = 'Idioma y Moneda'; 
    }
    else{
        footer.classList.add('activo');
        btnFlotante.classList.add('activo');
        btnFlotante.textContent = 'X Cerrar'; 
    }
}