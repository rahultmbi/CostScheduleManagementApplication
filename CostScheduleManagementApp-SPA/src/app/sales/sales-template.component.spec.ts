import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SalesTemplateComponent } from './sales-template.component';

describe('SalesTemplateComponent', () => {
  let component: SalesTemplateComponent;
  let fixture: ComponentFixture<SalesTemplateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SalesTemplateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SalesTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
