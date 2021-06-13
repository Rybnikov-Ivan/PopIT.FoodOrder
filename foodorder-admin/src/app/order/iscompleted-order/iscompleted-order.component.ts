import { Component, OnInit } from '@angular/core';
import { IscompletedOrderService, Order } from 'src/services/iscompleted-order.service';
import { exportDataGrid } from 'devextreme/excel_exporter';
import * as Excel from "exceljs/dist/exceljs.min.js";
import saveAs from 'file-saver';

@Component({
  selector: 'app-iscompleted-order',
  templateUrl: './iscompleted-order.component.html',
  styleUrls: ['./iscompleted-order.component.css']
})
export class IscompletedOrderComponent implements OnInit {
  dataSource: Order[];

  constructor(private service: IscompletedOrderService) {
    this.dataSource = this.service.getOrders();
   }

  ngOnInit(): void {
  }

  onExporting(e) {
    const workbook = new Excel.Workbook();
    const worksheet = workbook.addWorksheet('Employees');

    exportDataGrid({
      component: e.component,
      worksheet: worksheet,
      autoFilterEnabled: true
    }).then(() => {
      workbook.xlsx.writeBuffer().then((buffer) => {
        saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'DataGrid.xlsx');
      });
    });
    e.cancel = true;
  }
}
