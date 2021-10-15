import { Component, Input, OnInit, Output } from '@angular/core';
import { EventEmitter } from '@angular/core';

import { shipper } from '../models/shipper';
import { ShipperServiceService } from '../Service/shipper-service.service';

@Component({
  selector: 'app-shipper-table',
  templateUrl: './shipper-table.component.html',
  styleUrls: ['./shipper-table.component.scss']
})
export class ShipperTableComponent implements OnInit {

  @Input() Entryshippers :Array<shipper>;
  @Output() sendShipperEdit = new EventEmitter<shipper>();
  @Output() sendIdDelete = new EventEmitter<number>();



  constructor(private shipperService :ShipperServiceService) { }

  ngOnInit(): void {

  }

  public borrarItem(index :number){
    this.sendIdDelete.emit(this.Entryshippers[index].IdShipper)

  }

  public sendItemEdit(index :number){


    this.sendShipperEdit.emit(this.Entryshippers[index]);

  }


}
