import React, {useState} from 'react'

export const PrimerComponente = () => {
   //let nombre = "Felipe" ;
   let web = "Victoroblesweb.es";

   const [nombre,setNombre] = useState("Felipe");

   let cursos = [
    "Master en JavaScript",
    "Master en Php",
    "Master en React",
    "Mater en CSS"
   ];
   const cambiarNombre = (Nuevonombre) => {

    setNombre(Nuevonombre)
   }
  return (
    <div>
        <h1>Mi Primer Componente</h1>
        <p>Este es un texto de mi componente</p>
        <p>mi nombre es: <strong className={nombre.length >= 4 ? 'verde' : 'rojo'}> {nombre}</strong></p>
        <p>Mi web es: {web}</p>

        <input type="text" onChange={e=>cambiarNombre(e.target.value)} placeholder="Cambbia tu Nombre"/>
        <button onClick={e=>{
            console.log(`El valor guardado en tu estado es: {nombre}`)
        }}>Mostrar el valor del estado</button>
        <button onClick={e=>cambiarNombre("FELIPE BALANTA")}>Cambiar Nombre</button>
        <ul>
            {
                cursos.map((curso, indice)=> {
                    return (<li key={indice}>
                        {curso}
                    </li>);
                })
            }
        </ul>
    </div>
  )
}
