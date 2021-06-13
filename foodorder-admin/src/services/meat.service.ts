import { Injectable } from '@angular/core';

export class Meat {
  Id: number | undefined;
  Name: string | undefined;
  Price: string | undefined;
}

let meat: Meat[] = [{
  "Id": 1,
  "Name": "Котлета по домашнему",
  "Price": "40"
}, {
  "Id": 2,
  "Name": "Курица",
  "Price": "50"
}, {
  "Id": 3,
  "Name": "Купаты",
  "Price": "70"
}, {
  "Id": 4,
  "Name": "Шашлык",
  "Price": "80"
}];

@Injectable({
  providedIn: 'root'
})
export class MeatService {

  constructor() { }

  getMeat() {
    return meat;
  }
}
