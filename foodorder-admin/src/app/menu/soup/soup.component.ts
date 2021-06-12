import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import CustomStore from 'devextreme/data/custom_store';

var URL = "http://localhost:4200/api/soup";

@Component({
  selector: 'app-soup',
  templateUrl: './soup.component.html',
  styleUrls: ['./soup.component.css']
})
export class SoupComponent implements OnInit {
  dataSource: any;

  constructor(private http: HttpClient) {
    this.dataSource = new CustomStore({
      key: "Id",
      load: () => this.sendRequest(URL),
      insert: (values) => this.sendRequest(URL, "POST", {
        values: JSON.stringify(values)
      }),
      update: (key, values) => this.sendRequest(URL, "PUT", {
        key: key,
        values: JSON.stringify(values)
      }),
      remove: (key) => this.sendRequest(URL, "DELETE", {
        key: key
      })
    });
  }

  ngOnInit(): void {
  }

  sendRequest(url: string, method: string = "GET", data: any = {}): any {

    let httpParams = new HttpParams({ fromObject: data });
    let httpOptions = { withCredentials: true, body: httpParams };
    let result;

    switch(method) {
        case "GET":
            result = this.http.get(url, httpOptions);
            break;
        case "PUT":
            result = this.http.put(url, httpParams, httpOptions);
            break;
        case "POST":
            result = this.http.post(url, httpParams, httpOptions);
            break;
        case "DELETE":
            result = this.http.delete(url, httpOptions);
            break;
    }

    return result
        .toPromise()
        .then((data: any) => {
            return method === "GET" ? data.data : data;
        })
        .catch(e => {
            throw e && e.error && e.error.Message;
        });
  }
}
