import { Component, OnInit } from '@angular/core';
import { SoupService, Soup } from 'src/services/soup.service';

@Component({
  selector: 'app-soup',
  templateUrl: './soup.component.html',
  styleUrls: ['./soup.component.css']
})
export class SoupComponent implements OnInit {
  dataSource: Soup[];

  constructor(private service: SoupService) {
    this.dataSource = service.getSoups();
  }

  ngOnInit(): void {
  }

}
