import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgregarEditarOrdersComponent } from './agregar-editar-orders.component';

describe('AgregarEditarOrdersComponent', () => {
  let component: AgregarEditarOrdersComponent;
  let fixture: ComponentFixture<AgregarEditarOrdersComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AgregarEditarOrdersComponent]
    });
    fixture = TestBed.createComponent(AgregarEditarOrdersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
