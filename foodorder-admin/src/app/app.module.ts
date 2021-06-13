import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { DxButtonModule } from 'devextreme-angular/ui/button';
import { DxTextBoxModule } from "devextreme-angular/ui/text-box";
import { DxValidatorModule } from 'devextreme-angular/ui/validator';
import { DxDataGridModule } from 'devextreme-angular/ui/data-grid';
import { DxSelectBoxModule } from 'devextreme-angular/ui/select-box';
import { DxFormModule } from 'devextreme-angular/ui/form';
import { HttpClientModule } from '@angular/common/http';

import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { LoginFormComponent } from './login-form/login-form.component';
import { MenuComponent } from './menu/menu.component';
import { SoupComponent } from './menu/soup/soup.component';
import { MeatComponent } from './menu/meat/meat.component';
import { GarnishComponent } from './menu/garnish/garnish.component';
import { BeverageComponent } from './menu/beverage/beverage.component';
import { ActiveOrderComponent } from './order/active-order/active-order.component';
import { IscompletedOrderComponent } from './order/iscompleted-order/iscompleted-order.component';

const appRoutes: Routes =[
  { path: '', component: LoginFormComponent },
  { path: 'api', component: MenuComponent },
  { path: 'api/soup', component: SoupComponent },
  { path: 'api/meat', component: MeatComponent},
  { path: 'api/garnish', component: GarnishComponent },
  { path: 'api/beverage', component: BeverageComponent },
  { path: 'api/active', component: ActiveOrderComponent },
  { path: 'api/iscompleted', component: IscompletedOrderComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    LoginFormComponent,
    MenuComponent,
    SoupComponent,
    MeatComponent,
    GarnishComponent,
    BeverageComponent,
    ActiveOrderComponent,
    IscompletedOrderComponent
  ],
  imports: [
    BrowserModule,
    DxButtonModule,
    DxFormModule,
    DxTextBoxModule,
    DxValidatorModule,
    DxDataGridModule,
    DxSelectBoxModule,

    HttpClientModule,

    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
