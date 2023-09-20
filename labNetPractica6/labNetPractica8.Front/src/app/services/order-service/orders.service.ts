import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, ObservedValueOf } from 'rxjs';
import { Orders } from 'src/app/models/orders-model/orders';

@Injectable({
  providedIn: 'root'
})
export class OrdersService {

  ordersApi: string = 'https://localhost:44342/'
  myApiUrl: string = 'api/Orders/' as string;

  constructor(private http: HttpClient) { }

  getOrders(): Observable<Orders[]>{
    return this.http.get<Orders[]>(`${this.ordersApi}${this.myApiUrl}`);
  }

  getOrdersById(id: number): Observable<Orders> {
    return this.http.get<Orders>(`${this.ordersApi}${this.myApiUrl}${id}`);
  }

  deleteOrder(id: number): Observable<void>{
    return this.http.delete<void>(`${this.ordersApi}${this.myApiUrl}${id}`);
  }

  addOrder(order: Orders): Observable<Orders>{
    return this.http.post<Orders>(`${this.ordersApi}${this.myApiUrl}`, order);
  }

  updateOrder(id: number, order: Orders): Observable<void>{
    return this.http.put<void>(`${this.ordersApi}${this.myApiUrl}${id}`, order);
  }
}
