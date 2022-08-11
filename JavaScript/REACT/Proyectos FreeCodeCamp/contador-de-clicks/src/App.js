import './App.css';
import Boton from './componentes/Boton';
import Contador from './componentes/Contador';
import freeCodeCampLogo from './imagenes/logo-freecodecamp.jpg'
import { useState} from 'react'

function App() {

  const [numClics, setNumClics] = useState(0);

  const manejarClic= ()=>{
    setNumClics(numClics + 1);

  };

  const reiniciarContador = ()=>{
    setNumClics(0);

  };



  return (
    <div className="App">
      <div className='freecodecapm-logo-contenedor'>
        <img 
          className='freecodecapm-logo'
          src={freeCodeCampLogo}
          alt='Logo de freeCodeCamp'/>
      </div>
      <div className='contenedor-principal'>
        <Contador
        numClics={numClics}
        />
        <Boton
        texto='Clic'
        esBotonDeClick={true}
        manejarClic={manejarClic}
        />
        <Boton
          texto='Reiniciar'
          esBotonDeClick={false}
          manejarClic={reiniciarContador}
        />
      </div>
    </div>
  );
}

export default App;
