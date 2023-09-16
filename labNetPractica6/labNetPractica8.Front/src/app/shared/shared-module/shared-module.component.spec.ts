import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SharedModuleComponent } from './shared-module.component';

describe('SharedModuleComponent', () => {
  let component: SharedModuleComponent;
  let fixture: ComponentFixture<SharedModuleComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SharedModuleComponent]
    });
    fixture = TestBed.createComponent(SharedModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
