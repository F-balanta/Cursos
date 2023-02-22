// Eventos que suceden con el Scroll del mouse

// Scroll vertical
window.addEventListener("scroll", () => {
  //Cantidad de scrollig dado vertical
  //const scrollPX = window.scrollY;
  //console.log(scrollPX);
  //console.log("scrolling")

  // MIentras se hace scroll, haga una animación
  const premium = document.querySelector(".premium");
  // Indica a que distancia se encuentra un elemento
  const ubicacion = premium.getBoundingClientRect();
  //console.log(ubicacion);

  if (ubicacion.top < 784) {
    console.log("El elemento ya es visible");
  } else {
    console.log("Aun no, da mas scroll");
  }
});
