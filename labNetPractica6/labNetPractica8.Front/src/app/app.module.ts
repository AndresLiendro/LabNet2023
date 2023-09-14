import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AgregarEditarOrdersComponent } from './components/add-update-orders/agregar-editar-orders/agregar-editar-orders.component';
import { EliminarOrdersComponent } from './components/delete-orders/eliminar-orders/eliminar-orders.component';
import { ObtenerOrdersComponent } from './components/get-orders/obtener-orders/obtener-orders.component';

@NgModule({
  declarations: [
    AppComponent,
    AgregarEditarOrdersComponent,
    EliminarOrdersComponent,
    ObtenerOrdersComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
