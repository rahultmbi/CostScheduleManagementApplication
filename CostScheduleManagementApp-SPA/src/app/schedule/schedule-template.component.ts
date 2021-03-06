import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { IscheduleTemplate } from '../_model/scheduleTemplate';
import { AlertifyService } from '../_service/alertify.service';
import { ContributorService } from '../_service/contributor.service';

@Component({
  selector: 'app-schedule-template',
  templateUrl: './schedule-template.component.html',
  styleUrls: ['./schedule-template.component.css']
})
export class ScheduleTemplateComponent implements OnInit {
  public months: string[] = [];
  scheduleTemplateTitle: string = "Schedule Template";

  public scheduleTemplatesData: IscheduleTemplate[] = [];

  constructor(private contributorService: ContributorService, private alertify: AlertifyService) { }

  ngOnInit() {
    console.log(this.getscheduleTemplates());
    this.months = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
  }

  savescheduleTemplate(scheduleTemplateForm: NgForm) {
    console.log("Data Saved!");
  }

  getscheduleTemplates() {
    this.contributorService.getSecheduleTemplate().subscribe(results => {
      results.forEach(scheduleT => {
        this.scheduleTemplatesData.push(scheduleT);
      });

    }, error => {
      this.alertify.error(error);
    });
  }

}