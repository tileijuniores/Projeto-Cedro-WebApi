import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CasdastroRestauranteComponent } from './casdastro-restaurante.component';

describe('CasdastroRestauranteComponent', () => {
  let component: CasdastroRestauranteComponent;
  let fixture: ComponentFixture<CasdastroRestauranteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CasdastroRestauranteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CasdastroRestauranteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
