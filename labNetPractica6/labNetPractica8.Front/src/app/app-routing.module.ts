import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

//Components
import { ObtenerOrdersComponent } from './components/get-orders/obtener-orders/obtener-orders.component';
import { AgregarEditarOrdersComponent } from './components/add-update-orders/agregar-editar-orders/agregar-editar-orders.component';
import { EliminarOrdersComponent } from './components/delete-orders/eliminar-orders/eliminar-orders.component';
import { VerordersComponent } from './components/show-orders/verorders/verorders.component';

const routes: Routes = [
  { path: '', redirectTo: 'listaOrders', pathMatch: 'full'},
  {path: 'listaOrders', component: ObtenerOrdersComponent},
  {path: 'verOrders/:id', component: VerordersComponent},
  {path: 'agregarOrders', component: AgregarEditarOrdersComponent},
  {path: 'editarOrders/:id', component: AgregarEditarOrdersComponent},
  {path: 'eliminarOrders/:id', component: EliminarOrdersComponent},
  { path: '**', redirectTo: 'listaOrders', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
