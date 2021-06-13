import { Injectable } from '@angular/core';

export class Order {
  Id: number | undefined;
  Name: string | undefined;
  Code: string | undefined;
  Soup: string | undefined;
  Garnish: string | undefined;
  Meat: string | undefined;
  Beverage: string | undefined;
  date: string | undefined;
}

let orders: Order[] = [{
  "Id": 1,
  "Name": "Иван",
  "Code": "2017-12345",
  "Soup": "Гороховый",
  "Garnish": "Рис",
  "Meat": "Котлета по домашнему",
  "Beverage": "Cок",
  "date": "14.06.2021 15:00"
}];

@Injectable({
  providedIn: 'root'
})
export class IscompletedOrderService {

  constructor() { }

  getOrders(){
    return orders;
  }
}
