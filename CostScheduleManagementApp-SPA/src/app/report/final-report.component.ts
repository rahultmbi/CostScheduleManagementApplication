import { Component, OnInit } from '@angular/core';
import { ISalesTemplates } from '../_model/CostTemplate';
import { AlertifyService } from '../_service/alertify.service';
import { ContributorService } from '../_service/contributor.service';

@Component({
  selector: 'app-final-report',
  templateUrl: './final-report.component.html',
  styleUrls: ['./final-report.component.css']
})
export class FinalReportComponent implements OnInit {

  public costTemplate: any[];
  public scheduleTemplate: any[];
  reportTitle: string = "Cost Calculation Report";
  public costTemplatesData: ISalesTemplates[] = [];

  constructor(private contributorService: ContributorService, private alertify: AlertifyService) {

    this.contributorService.getCostTemplateData().subscribe(result => {
      this.costTemplate = result;
    }, error => console.error(error));

    this.contributorService.getSecheduleTemplate().subscribe(result => {
      this.scheduleTemplate = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}

