import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { shipper } from '../models/shipper';

@Injectable({
  providedIn: 'root'
})
export class ShipperServiceService {

  endPoint: string = "Shippers/"
  constructor(private http :HttpClient) { }

  public crearShipper(shipperRequest :shipper):Observable<any>{
    let url = environment.apiUrl + this.endPoint;
    return this.http.post(url , shipperRequest);

  }
  public getShippers(): Observable<Array<shipper>>{
    let url = environment.apiUrl + this.endPoint;
    return this.http.get<Array<shipper>>(url);

  }
  public deleteShipper(id :number):Observable<any>{
    let url = environment.apiUrl + this.endPoint + id.toString() ;
    return this.http.delete(url);

  }
  public updateShipper(shipperRequest :shipper):Observable<any>{
    let url = environment.apiUrl + this.endPoint + shipperRequest.IdShipper.toString() ;
    shipperRequest.IdShipper = 0;
    return this.http.post(url , shipperRequest);
  }
}
