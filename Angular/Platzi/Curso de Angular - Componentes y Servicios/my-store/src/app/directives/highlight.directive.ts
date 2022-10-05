import { Directive, ElementRef,HostListener } from '@angular/core';

@Directive({
  selector: '[appHighlight]'
})
export class HighlightDirective {

  @HostListener('mouseenter') onMouseEnter(){
  this.element.nativeElement.style.backgroundColor = 'red';
  }
  @HostListener('mouseleave') onMouseLeave(){
    this.element.nativeElement.style.backgroundColor = '';
  }
  constructor(private element: ElementRef) {
    //Devuelve el elemento nativo de HTML. Una ves obtenido elemento nativo
    // se puede hacer lo que uiqera con el. Agregar estilos, manipularlos o hacer modificacionesde ese elemento en el DOM
    //this.element.nativeElement.style.backgroundColor = 'red';
  }
}
