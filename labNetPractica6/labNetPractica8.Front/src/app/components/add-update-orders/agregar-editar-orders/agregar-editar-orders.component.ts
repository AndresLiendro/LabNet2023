import { Component, OnInit} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Orders } from 'src/app/models/orders-model/orders';

@Component({
  selector: 'app-agregar-editar-orders',
  templateUrl: './agregar-editar-orders.component.html',
  styleUrls: ['./agregar-editar-orders.component.css']
})
export class AgregarEditarOrdersComponent implements OnInit {
  loading: boolean = false;
  form: FormGroup;

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      nombre: ['', Validators.compose([Validators.required, Validators.minLength(2), Validators.maxLength(10),])],
      ciudad: ['', Validators.compose([Validators.required, Validators.minLength(2), Validators.maxLength(10),])],
      region: ['', Validators.compose([Validators.required, Validators.minLength(2), Validators.maxLength(10),])],
      direccion: ['', Validators.compose([Validators.required, Validators.minLength(2), Validators.maxLength(10),])],
    })
  }

  ngOnInit(): void {
    
  }

  agregarOrder() {

    const order: Orders = {
      shipName: this.form.get('nombre')?.value,
      shipCity: this.form.value.ciudad,
      shipRegion: this.form.get('region')?.value,
      shipAddress: this.form.value.direccion,
    }
  }
}
