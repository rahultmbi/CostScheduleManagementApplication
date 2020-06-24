import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-schedule-template',
  templateUrl: './schedule-template.component.html',
  styleUrls: ['./schedule-template.component.css']
})
export class ScheduleTemplateComponent implements OnInit {

  scheduleTemplateTitle: string = "Schedule Template";

  public scheduleTemplatesData = [];

  constructor() { }

  ngOnInit() {
  }

}
