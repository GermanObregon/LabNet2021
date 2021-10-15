import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ShipperTableComponent } from './shipper-table/shipper-table.component';
import { ShipperFormComponent } from './shipper-form/shipper-form.component';
import { FooterComponent } from './footer/footer.component';
import { NavComponent } from './nav/nav.component';











@NgModule({
  declarations: [ShipperTableComponent, ShipperFormComponent, FooterComponent, NavComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatButtonModule,
    MatIconModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule



  ]
})
export class ShipperModuleModule { }
