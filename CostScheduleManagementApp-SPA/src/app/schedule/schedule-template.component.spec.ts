import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ScheduleTemplateComponent } from './schedule-template.component';

describe('ScheduleTemplateComponent', () => {
  let component: ScheduleTemplateComponent;
  let fixture: ComponentFixture<ScheduleTemplateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ScheduleTemplateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ScheduleTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
