import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

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

  savescheduleTemplate(scheduleTemplateForm: NgForm){

  }

}
