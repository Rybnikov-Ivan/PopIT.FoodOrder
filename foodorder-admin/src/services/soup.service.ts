import { Injectable } from '@angular/core';

export class Soup {
  Id: number | undefined;
  Name: string | undefined;
  Price: string | undefined;
}

let soups: Soup[] = [{
  "Id": 1,
  "Name": "Гороховый",
  "Price": "50"
}, {
  "Id": 2,
  "Name": "Борщ",
  "Price": "55"
}, {
  "Id": 3,
  "Name": "Щи",
  "Price": "40"
}, {
  "Id": 4,
  "Name": "Солянка",
  "Price": "60"
}];

@Injectable({
  providedIn: 'root'
})
export class SoupService {

  constructor() { }

  getSoups() {
    return soups;
  }
}
