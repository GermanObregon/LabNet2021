import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


import { BrowserModule } from '@angular/platform-browser';
import { ShipperModuleModule } from './shipper-module/shipper-module.module';



@NgModule({
  declarations: [
    AppComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ShipperModuleModule,


  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
