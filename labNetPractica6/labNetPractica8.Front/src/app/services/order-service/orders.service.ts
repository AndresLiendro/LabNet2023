import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Orders } from 'src/app/models/orders-model/orders';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class OrdersService {

   private myAppUrl: string = environment.ordersApi;
   private myApiUrl: string = 'api/Orders/';

  constructor(private http: HttpClient) { }

  getOrders(): Observable<Orders[]>{
    return this.http.get<Orders[]>(`${this.myAppUrl}${this.myApiUrl}`);
  }
}
