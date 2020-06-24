import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CostTemplateComponent } from './cost-template.component';

describe('CostTemplateComponent', () => {
  let component: CostTemplateComponent;
  let fixture: ComponentFixture<CostTemplateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CostTemplateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CostTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
