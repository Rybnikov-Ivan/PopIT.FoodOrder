import { Component, OnInit } from '@angular/core';
import { MeatService, Meat } from 'src/services/meat.service';

@Component({
  selector: 'app-meat',
  templateUrl: './meat.component.html',
  styleUrls: ['./meat.component.css']
})
export class MeatComponent implements OnInit {
  dataSource: Meat[];

  constructor(private service: MeatService) {
    this.dataSource = service.getMeat();
   }

  ngOnInit(): void {
  }

}
