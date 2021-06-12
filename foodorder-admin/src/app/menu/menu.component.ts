import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpClientModule, HttpHeaders, HttpParams } from '@angular/common/http';
import CustomStore from 'devextreme/data/custom_store';
import { formatDate } from 'devextreme/localization';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  dataSource: any;
  customersData: any;
  shippersData: any;
  refreshModes: string[] | undefined;
  refreshMode: string | undefined;
  requests: string[] = [];

  constructor() {

}
  ngOnInit(): void {

  }
}
