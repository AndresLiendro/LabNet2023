import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

//Modulos
import { SharedModule } from './shared/shared.module';

//Componentes
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
    AppRoutingModule,
    BrowserModule,
    BrowserAnimationsModule,
    SharedModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
