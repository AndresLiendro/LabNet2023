import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObtenerOrdersComponent } from './obtener-orders.component';

describe('ObtenerOrdersComponent', () => {
  let component: ObtenerOrdersComponent;
  let fixture: ComponentFixture<ObtenerOrdersComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ObtenerOrdersComponent]
    });
    fixture = TestBed.createComponent(ObtenerOrdersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
