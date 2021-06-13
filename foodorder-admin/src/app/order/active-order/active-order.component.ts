import { Component, OnInit } from '@angular/core';
import { ActiveOrderService, ActiveOrder } from 'src/services/active-order.service';
import { Order } from 'src/services/iscompleted-order.service';

@Component({
  selector: 'app-active-order',
  templateUrl: './active-order.component.html',
  styleUrls: ['./active-order.component.css']
})
export class ActiveOrderComponent implements OnInit {
  dataSours: ActiveOrder[];
  allMode: string;
  checkBoxesMode: string;

  constructor(private service: ActiveOrderService) {
    this.dataSours = this.service.getOrders();
    this.allMode = 'allPages';
    this.checkBoxesMode = 'onClick';
   }

  ngOnInit(): void {
  }

  onSubmit(){
    ;
  }
}
