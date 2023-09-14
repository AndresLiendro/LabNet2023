import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EliminarOrdersComponent } from './eliminar-orders.component';

describe('EliminarOrdersComponent', () => {
  let component: EliminarOrdersComponent;
  let fixture: ComponentFixture<EliminarOrdersComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EliminarOrdersComponent]
    });
    fixture = TestBed.createComponent(EliminarOrdersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
