import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperTableComponent } from './shipper-table.component';

describe('ShipperTableComponent', () => {
  let component: ShipperTableComponent;
  let fixture: ComponentFixture<ShipperTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShipperTableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShipperTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
