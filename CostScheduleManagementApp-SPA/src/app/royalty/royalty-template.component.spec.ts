import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RoyaltyTemplateComponent } from './royalty-template.component';

describe('RoyaltyTemplateComponent', () => {
  let component: RoyaltyTemplateComponent;
  let fixture: ComponentFixture<RoyaltyTemplateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RoyaltyTemplateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RoyaltyTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
