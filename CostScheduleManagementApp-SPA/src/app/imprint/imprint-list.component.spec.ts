import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ImprintListComponent } from './imprint-list.component';

describe('ImprintListComponent', () => {
  let component: ImprintListComponent;
  let fixture: ComponentFixture<ImprintListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ImprintListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ImprintListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
