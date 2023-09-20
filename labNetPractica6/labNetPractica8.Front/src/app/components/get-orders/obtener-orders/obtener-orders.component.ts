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
  styleUrls: ['./obtener-orders.component.css']
})
export class ObtenerOrdersComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['shipName', 'shipCity', 'shipRegion', 'shipAddress', 'Acciones'];
  dataSource = new MatTableDataSource<Orders>();
  loading: boolean = false;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor (private _snackBar: MatSnackBar, private _orderService: OrdersService) { }

  ngOnInit(): void {
    this.obtenerOrders();
  }

  ngAfterViewInit () {
    this.dataSource.paginator = this.paginator;
    this.paginator._intl.itemsPerPageLabel = 'Items';
    this.dataSource.sort = this.sort;
  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

      if (this.dataSource.paginator) {
        this.dataSource.paginator.firstPage();
      }
  }

  obtenerOrders() {
      this._orderService.getOrders().subscribe(data => {
      this.dataSource.data = data;
    });
  }

  eliminarOrders() {
    this.loading = true;

    setTimeout(() => {
      this.loading = false;
      this._snackBar.open('La orden fue eliminada con exito', '', {
        duration: 3000,
        horizontalPosition: 'right',
      });
    }, 2800);
  }
}
