import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultaRestaurantesComponent } from './consulta-restaurantes.component';

describe('ConsultaRestaurantesComponent', () => {
  let component: ConsultaRestaurantesComponent;
  let fixture: ComponentFixture<ConsultaRestaurantesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ConsultaRestaurantesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ConsultaRestaurantesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
