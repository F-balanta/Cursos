import {Component, OnInit, Input, Output, EventEmitter, OnChanges, AfterViewInit, OnDestroy, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-img',
  templateUrl: './img.component.html',
  styleUrls: ['./img.component.scss']
})
export class ImgComponent implements OnInit, OnChanges, AfterViewInit, OnDestroy {
  img : string ='';

  // eslint-disable-next-line @angular-eslint/no-input-rename
  @Input('img')
  set changeImg(newImg:string){
    this.img =newImg;
    console.log('change just img => ', this.img)
  }
  @Input() alt : string = '';
  @Output() loaded = new EventEmitter<string>();
  imageDefault = './assets/images/default.png';
  //counter = 0;
  //conunterFN: number | undefined;

  constructor() {
    // Before render
    // No async   ---Solo se crea una vez
    console.log('constructor', 'imgValue =>',this.img);
  }

  ngOnChanges(changes:SimpleChanges) {
    // Before render - during render
    // Changes input - run  N times
    // Metodo para detectar los cambios en los input
    console.log('ngOnChanges', 'imgValue =>',this.img);
    console.log('Changes: ',changes);
  }
  ngOnInit(): void {
    // run Before render
    // run async - la llamada a la api solo ocurre 1 vez cuando se inicializa el componente
    console.log('ngOnInit', 'imgValue =>',this.img);
    //this.conunterFN = window.setInterval(()=>{
    // this.counter += 1;
    //  console.log('run counter');
    //},1000);

  }
  ngAfterViewInit(){
    // run after render
    //handler son component
    console.log('ngAfterViewInit');
  }


  ngOnDestroy(){
    // Se corre solo cuando se vaya a eliminar un componente
    console.log('ngOnDestroy');
    //window.clearInterval(this.conunterFN);
  }


  imgError(){
    this.img = this.imageDefault;
  }

  imgLoaded(){
    console.log('Log Hijo');
    this.loaded.emit(this.img);
  }
}
