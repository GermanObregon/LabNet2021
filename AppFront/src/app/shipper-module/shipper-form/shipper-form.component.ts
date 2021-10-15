import { Component, Input, OnInit, Output } from '@angular/core';
import { ReactiveFormsModule, FormBuilder, FormGroup,  Validators } from '@angular/forms';

import { shipper} from '../models/shipper';

import { ShipperServiceService } from '../Service/shipper-service.service';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-shipper-form',
  templateUrl: './shipper-form.component.html',
  styleUrls: ['./shipper-form.component.scss']
})
export class ShipperFormComponent implements OnInit {

  public formShipper : FormGroup;
  public shipperAux = new shipper();
  public Sendshippers :shipper[] =[];

  constructor(private readonly formBuilder : FormBuilder , private shipperService :ShipperServiceService , private toastr: ToastrService) { }

  ngOnInit(): void {
    this.initForm();
    this.getShippers();
    this.shipperAux.IdShipper = 0;


  }

  initForm(){
    this.formShipper = this.formBuilder.group({
      nombre : ["", [Validators.required, Validators.maxLength(40)]],
      telefono : ["",[Validators.required, Validators.maxLength(24), Validators.pattern('^[0-9]+$')]]

    }
    );

  }
  get f(){return this.formShipper.controls;}

  setShipper(shipper :shipper){

    this.shipperAux = shipper;

    this.formShipper.setValue({nombre : this.shipperAux.NombreCompania , telefono : this.shipperAux.Telefono});
  }

  Guardar(){


    if (this.shipperAux.IdShipper != 0){

      this.shipperAux.NombreCompania = this.formShipper.get('nombre').value;
      this.shipperAux.Telefono = this.formShipper.get('telefono').value;
      this.shipperService.updateShipper(this.shipperAux).subscribe(res =>{
        this.getShippers();
        this.formShipper.reset();
        this.toastr.success('Se edito con exito');
        },
        error =>{
          this.toastr.error('No se pudo editar el elemento')

        });





    }
    else{

      this.shipperAux.NombreCompania = this.formShipper.get('nombre').value;
      this.shipperAux.Telefono = this.formShipper.get('telefono').value;


      this.shipperService.crearShipper(this.shipperAux).subscribe(res=>{
        this.formShipper.reset();
        this.getShippers();
        this.toastr.success('Se guardo con exito')
      },
      error =>{
        this.toastr.error('No se pudo guardar el elemento')
      });

    }



  }
  deleteShipper(id :number){

    this.shipperService.deleteShipper(id).subscribe(res =>{
      this.getShippers();
      this.toastr.success('Elemento eliminado')

    },
    error =>{
      this.toastr.error('No se pudo eliminar el elemento')

    });

  }
  getShippers(){
    this.shipperService.getShippers().subscribe(res=>{
      this.Sendshippers = res.slice();

    });


  }

}
