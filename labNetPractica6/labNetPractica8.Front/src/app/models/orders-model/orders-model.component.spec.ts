import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OrdersModelComponent } from './orders-model.component';

describe('OrdersModelComponent', () => {
  let component: OrdersModelComponent;
  let fixture: ComponentFixture<OrdersModelComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [OrdersModelComponent]
    });
    fixture = TestBed.createComponent(OrdersModelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
