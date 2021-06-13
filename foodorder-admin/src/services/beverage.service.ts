import { Injectable } from '@angular/core';

export class Beverage {
  Id: number | undefined;
  Name: string | undefined;
  Price: string | undefined;
}

let beverages: Beverage[] = [{
  "Id": 1,
  "Name": "Компот",
  "Price": "10"
}, {
  "Id": 2,
  "Name": "Чай",
  "Price": "10"
}, {
  "Id": 3,
  "Name": "Сок",
  "Price": "15"
}, {
  "Id": 4,
  "Name": "Кофе",
  "Price": "20"
}];

@Injectable({
  providedIn: 'root'
})
export class BeverageService {

  constructor() { }

  getBeverages() {
    return beverages;
  }
}
