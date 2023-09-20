import { Component, OnInit} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { Orders } from 'src/app/models/orders-model/orders';
import { OrdersService } from 'src/app/services/order-service/orders.service';

@Component({
  selector: 'app-agregar-editar-orders',
  templateUrl: './agregar-editar-orders.component.html',
  styleUrls: ['./agregar-editar-orders.component.css']
})
export class AgregarEditarOrdersComponent implements OnInit {
  loading: boolean = false;
  form: FormGroup;
  id: number;
  operacion: string = 'Agregar';

  constructor(private fb: FormBuilder,
    private _orderService: OrdersService,
    private _snackBar: MatSnackBar,
    private router: Router,
    private aRoute: ActivatedRoute) {

    this.form = this.fb.group({
      nombre: ['', Validators.compose([Validators.required, Validators.minLength(2), Validators.maxLength(40),])],
      ciudad: ['', Validators.compose([Validators.required, Validators.minLength(2), Validators.maxLength(15),])],
      region: ['', Validators.compose([Validators.required, Validators.minLength(2), Validators.maxLength(15),])],
      direccion: ['', Validators.compose([Validators.required, Validators.minLength(2), Validators.maxLength(60),])],
    })

    this.id = Number(this.aRoute.snapshot.paramMap.get('id'));
  }

  ngOnInit(): void {
    if(this.id != 0) {
      this.operacion = 'Editar';
      this.obtenerOrder(this.id)
    }
  }

  obtenerOrder(id: number) {
    this.loading = true;
    this._orderService.getOrdersById(id).subscribe(data => {
      this.loading = false;
      this.form.setValue({
        nombre: data.shipName,
        ciudad: data.shipCity,
        region: data.shipRegion,
        direccion: data.shipAddress
      })
    });
  }

  agregarEditarOrder() {

    const order: Orders = {
      shipName: this.form.get('nombre')?.value,
      shipCity: this.form.value.ciudad,
      shipRegion: this.form.get('region')?.value,
      shipAddress: this.form.value.direccion,
    }

    if(this.id != 0) {
      order.id = this.id;
      this.editarOrder(this.id, order);

    } else {
      this.agregarOrder(order);
    }
  }

  agregarOrder(order: Orders) {
    this.loading = true;
    this._orderService.addOrder(order).subscribe(data =>{
      this.msgExito('agregada');
      this.router.navigate(['/listaOrders'])
      this.loading = false;
    });
  }

  editarOrder(id: number, order: Orders) {
    this.loading = true;
    this._orderService.updateOrder(id, order).subscribe(() => {
      this.loading = false;
      this.msgExito('editada');
      this.router.navigate(['/listaOrders'])
    });
  }

  msgExito(text: string) {
    this._snackBar.open(`La orden fue ${text} con exito`, '', {
      duration: 3000,
      horizontalPosition: 'right',
    });
  }
}
