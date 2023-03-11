import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-titulo',
  templateUrl: './titulo.component.html',
  styleUrls: ['./titulo.component.scss']
})
export class TituloComponent implements OnInit {
  nombre:string = "Maria";
  apellido:string ="Perez"
  alumno:any = {
    nombre: "Carlos",
    apellido: "Pineda",
    edad: 21
  }

  imagen:string = "https://www.edigitalagency.com.au/wp-content/uploads/Facebook-logo-blue-circle-large-transparent-png.png"

  inputNuevo:any ="Property Binding";

  correo:string ="";
  password:string ="";

  
  constructor() { }

  ngOnInit(): void {
  }

  ingresar(){
    console.log(this.correo)
    console.log(this.password);
  }

  llamarAlert(){
    alert("Has hecho doble click :)");
  }
  escribirModelo(){
    console.log(this.password);
  }
  escribirCorreo(){
    this.password = this.correo;
    console.log(this.correo);
  }


  escribir(evento:any){
    console.log(evento);
  }
}
