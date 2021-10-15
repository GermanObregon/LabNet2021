import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ShipperFormComponent } from './shipper-module/shipper-form/shipper-form.component';
import { ShipperTableComponent } from './shipper-module/shipper-table/shipper-table.component';


const routes: Routes = [
  {
    path: 'shippers',
    component: ShipperFormComponent

  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
