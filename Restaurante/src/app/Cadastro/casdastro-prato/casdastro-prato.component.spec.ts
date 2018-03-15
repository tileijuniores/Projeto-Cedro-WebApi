import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CasdastroPratoComponent } from './casdastro-prato.component';

describe('CasdastroPratoComponent', () => {
  let component: CasdastroPratoComponent;
  let fixture: ComponentFixture<CasdastroPratoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CasdastroPratoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CasdastroPratoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
