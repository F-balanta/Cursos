import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'changeVocals'
})
export class ChangeVocalsPipe implements PipeTransform {

  transform(value: string, ): string {

    return value.split('').map(vocal=>vocal.replace('a','@')
        .replace('e', '3')
        .replace('i', '1')
        .replace('o', '0')
        .replace('u', 'w')).join();
  }

}
