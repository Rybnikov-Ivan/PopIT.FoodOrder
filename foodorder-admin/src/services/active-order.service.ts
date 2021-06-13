import { Injectable } from '@angular/core';

export class ActiveOrder {
  Id: number | undefined;
  Name: string | undefined;
  Code: string | undefined;
  Soup: string | undefined;
  Garnish: string | undefined;
  Meat: string | undefined;
  Beverage: string | undefined;
  date: string | undefined;
}

let orders: ActiveOrder[] = [{
  "Id": 1,
  "Name": "Иван",
  "Code": "2017-12345",
  "Soup": "Гороховый",
  "Garnish": "Рис",
  "Meat": "Котлета по домашнему",
  "Beverage": "Cок",
  "date": "14.06.2021 15:00"
}, {
  "Id": 2,
  "Name": "Кирилл",
  "Code": "2020-12345",
  "Soup": "Щи",
  "Garnish": "Пюре",
  "Meat": "Курица",
  "Beverage": "Cок",
  "date": "14.06.2021 15:01"
}, {
  "Id": 3,
  "Name": "Алексей",
  "Code": "2020-54321",
  "Soup": "Борщ",
  "Garnish": "Гречка",
  "Meat": "Шашлык",
  "Beverage": "Чай",
  "date": "14.06.2021 15:02"
}];

@Injectable({
  providedIn: 'root'
})
export class ActiveOrderService {

  constructor() { }

  getOrders(){
    return orders;
  }
}
