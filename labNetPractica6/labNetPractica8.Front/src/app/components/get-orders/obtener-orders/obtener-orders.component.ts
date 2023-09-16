import { AfterViewInit, Component, OnInit, ViewChild, } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Orders } from 'src/app/models/orders-model/orders';

const listOrders: Orders[] = [
  { shipName: 'Prueba', shipCity: 'Ciudad de Prueba', shipRegion: 'RJE' },
  { shipName: 'Prueba1', shipCity: 'Ciudad de Prueba1', shipRegion: 'RJE1' },
  { shipName: 'Prueba2', shipCity: 'Ciudad de Prueba2', shipRegion: 'RJE2' },
  { shipName: 'Prueba3', shipCity: 'Ciudad de Prueba3', shipRegion: 'RJE3' },
  { shipName: 'Prueba4', shipCity: 'Ciudad de Prueba4', shipRegion: 'RJE4' },
  { shipName: 'Prueba5', shipCity: 'Ciudad de Prueba5', shipRegion: 'RJE5' },
  { shipName: 'Prueba6', shipCity: 'Ciudad de Prueba6', shipRegion: 'RJE6' },
  { shipName: 'Prueba7', shipCity: 'Ciudad de Prueba7', shipRegion: 'RJE7' },
];

@Component({
  selector: 'app-obtener-orders',
  templateUrl: './obtener-orders.component.html',
  styleUrls: ['./obtener-orders.component.css']
})
export class ObtenerOrdersComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['shipName', 'shipCity', 'shipRegion', 'Acciones'];
  dataSource = new MatTableDataSource<Orders>(listOrders);
  
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor () { }

  ngOnInit(): void {
    
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
}
