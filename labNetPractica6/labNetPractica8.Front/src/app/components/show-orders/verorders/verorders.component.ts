import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Orders } from 'src/app/models/orders-model/orders';
import { OrdersService } from 'src/app/services/order-service/orders.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-verorders',
  templateUrl: './verorders.component.html',
  styleUrls: ['./verorders.component.css']
})
export class VerordersComponent implements OnInit {
  id: number;
  order!: Orders;
  loading:boolean = false

  constructor(private _orderServicio: OrdersService,
    private aRoute: ActivatedRoute) {
      this.id = Number(this.aRoute.snapshot.paramMap.get('id'));
  }

  ngOnInit(): void {
    this.getOrders();
  }

  getOrders() {
    this.loading = true;
    this._orderServicio.getOrdersById(this.id).subscribe({
      next: (data) => {
        this.loading = false;
        this.order = data;
      },
      error: (e) => {
        this.loading = false;
        console.log("Ocurrio un error al comunicarse con el servidor")
      },
      complete: () => console.info('Se competo la operacion') 
  });
  }
}
