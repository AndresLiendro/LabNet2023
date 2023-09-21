import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, ObservedValueOf } from 'rxjs';
import { Orders } from 'src/app/models/orders-model/orders';

@Injectable({
  providedIn: 'root'
})
export class OrdersService {

  ordersApi: string = 'https://localhost:44342/';
  myApiUrl: string = 'api/Orders/';

  constructor(private http: HttpClient) { }

  getOrders(): Observable<Orders[]>{
    return this.http.get<Orders[]>(`${this.ordersApi}${this.myApiUrl}`);
  }

  getOrdersById(Id: number): Observable<Orders> {
    return this.http.get<Orders>(`${this.ordersApi}${this.myApiUrl}${Id}`);
  }

  deleteOrder(Id: number): Observable<void>{
    return this.http.delete<void>(`${this.ordersApi}${this.myApiUrl}${Id}`);
  }

  addOrder(order: Orders): Observable<Orders>{
    return this.http.post<Orders>(`${this.ordersApi}${this.myApiUrl}`, order);
  }

  updateOrder(Id: number, order: Orders): Observable<void>{
    return this.http.put<void>(`${this.ordersApi}${this.myApiUrl}${Id}`, order);
  }
}
