import { Component, OnInit } from '@angular/core';
import { BeverageService, Beverage } from 'src/services/beverage.service';


@Component({
  selector: 'app-beverage',
  templateUrl: './beverage.component.html',
  styleUrls: ['./beverage.component.css']
})
export class BeverageComponent implements OnInit {
  dataSource: Beverage[];
  constructor(private service: BeverageService) {
    this.dataSource = service.getBeverages();
   }

  ngOnInit(): void {
  }

}
