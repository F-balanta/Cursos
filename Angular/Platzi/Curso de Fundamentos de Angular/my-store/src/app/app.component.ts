import { Component } from '@angular/core';
import {Product} from './product.model'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  widthImg=10;

  name = 'Nicolas';
  age = 18;
  img = "https://i.imgur.com/onTVxbX.jpeg";
  btndisabled = true;
  person={
    name:'Nicolas',
    age: 18,
    avatar : "https://i.imgur.com/onTVxbX.jpeg"
  }

  names: string[] = ['Nicolas', 'Juli', 'Santi'];
  newName = '';
  box = {
    width : 100,
    height: 100,
    background: 'red'
  }
  products:Product[]  = [
    {
      name: 'Jueguetes',
      price: 45000,
      image: './assets/images/Juguetes.jpg',
      category: "all"
    },
    {
      name: 'El arte de la guerra',
      price: 58000,
      image: './assets/images/Artedelaguerra.jpg'
    },
    {
      name: "Chocolate",
      price: 500,
      image: './assets/images/Chocolate.jpg'
    },
    {
      name: "Bon Bon Bum",
      price: 25200,
      image:'./assets/images/BonBom.png'
    },
    {
      name: "Memoria Ram",
      price: 280000,
      image: './assets/images/MemoryRam.png'
    },
    {
      name: "Xiaomi Redmi Note 6",
      price: 650000,
      image: "./assets/images/XRN6.png"
    },
    {
      name: "Televisor 800 pulgadas",
      price: 2600000,
      image: "./assets/images/televisor.jpg"
    },
    {
      name: "PocoPhone X3",
      price: 850000,
      image: "./assets/images/PocophoneX3.jpg"
    }
  ];
  register={
    name:'',
    email:'',
    password:''
  }


  toggleButton(){
  this.btndisabled = !this.btndisabled;
  }

  increaseAge(){
    this.person.age += this.age;
  }

  onScroll(event: Event){
    const element = event.target as MathMLElement;
    console.log(element.scrollTop);
  }


  changeName(event: Event){
  const element = event.target as HTMLInputElement;
  this.person.name = element.value;
  }
  addName(){
    this.names.push(this.newName)
    this.newName = '';
  }
  deleteName(index:number){
    this.names.splice(index,1)
  }
  onRegister()
  {
    console.log(this.register)
  }
}

