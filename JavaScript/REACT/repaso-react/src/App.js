import logo from './logo.svg';
import './App.css';
import { PrimerComponente } from './componentes/PrimerComponente';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
       <p>Esto es un repaso de React con Victor Robles</p>

       <PrimerComponente/> 

      </header>
    </div>
  );
}

export default App;
