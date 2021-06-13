import { Injectable } from '@angular/core';

export class Garnish {
  Id: number | undefined;
  Name: string | undefined;
  Price: string | undefined
}

let garnish: Garnish[] = [{
  "Id": 1,
  "Name": "Гречка",
  "Price": "15"
}, {
  "Id": 2,
  "Name": "Макароны",
  "Price": "15"
}, {
  "Id": 3,
  "Name": "Рис",
  "Price": "10"
}, {
  "Id": 4,
  "Name": "Пюре",
  "Price": "20"
}];

@Injectable({
  providedIn: 'root'
})
export class GarnishService {

  constructor() { }

  getGarnish() {
    return garnish;
  }
}
