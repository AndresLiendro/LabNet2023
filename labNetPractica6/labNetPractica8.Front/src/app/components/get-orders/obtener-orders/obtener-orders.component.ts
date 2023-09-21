import { AfterViewInit, Component, OnInit, ViewChild, } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Orders } from 'src/app/models/orders-model/orders';
import { OrdersService } from 'src/app/services/order-service/orders.service';

@Component({
  selector: 'app-obtener-orders',
  templateUrl: './obtener-orders.component.html',
  styleUrls: ['./obtener-orders.component.css'],
})
export class ObtenerOrdersComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['Nombre', 'Ciudad', 'Region', 'Address', 'Acciones'];
  dataOrders = new MatTableDataSource<Orders>;
  loading: boolean = false;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor (private _snackBar: MatSnackBar, private _orderService: OrdersService) { }

  ngOnInit(): void {
    this.obtenerOrders();
  }

  ngAfterViewInit () {
    this.dataOrders.paginator = this.paginator;
    this.dataOrders.sort = this.sort;
    if (this.dataOrders.data.length > 0) {
      this.paginator._intl.itemsPerPageLabel = 'Items';
    }
  }
  
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataOrders.filter = filterValue.trim().toLowerCase();

      if (this.dataOrders.paginator) {
        this.dataOrders.paginator.firstPage();
      }
  }

  obtenerOrders() {
    this.loading = true;
    this._orderService.getOrders().subscribe({
      next: (data) => {
        this.loading = false;
        this.dataOrders.data = data;
      },
      error: (e) => {
        this.loading = false;
        console.log("Ocurrio un error al comunicarse con el servidor")
      },
      complete: () => console.info('Se competo la operacion') 
    });
  }

  eliminarOrders(id: number) {
    this.loading = true;
    this._orderService.deleteOrder(id).subscribe(() => {
      this.msgExito();
      this.loading = false;
      this.obtenerOrders();
    });
  }
  
  msgExito() {
    this._snackBar.open('La orden fue eliminada con exito', '', {
      duration: 3000,
      horizontalPosition: 'right',
    });
  }
}
