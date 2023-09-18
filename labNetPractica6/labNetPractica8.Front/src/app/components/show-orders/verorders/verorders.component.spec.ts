import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerordersComponent } from './verorders.component';

describe('VerordersComponent', () => {
  let component: VerordersComponent;
  let fixture: ComponentFixture<VerordersComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VerordersComponent]
    });
    fixture = TestBed.createComponent(VerordersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
