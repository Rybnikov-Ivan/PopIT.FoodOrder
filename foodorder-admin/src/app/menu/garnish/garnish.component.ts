import { Component, OnInit } from '@angular/core';
import { GarnishService, Garnish } from 'src/services/garnish.service';

@Component({
  selector: 'app-garnish',
  templateUrl: './garnish.component.html',
  styleUrls: ['./garnish.component.css']
})
export class GarnishComponent implements OnInit {
  dataSource: Garnish[];
  constructor(private service: GarnishService) {
    this.dataSource = service.getGarnish();
  }

  ngOnInit(): void {
  }

}
