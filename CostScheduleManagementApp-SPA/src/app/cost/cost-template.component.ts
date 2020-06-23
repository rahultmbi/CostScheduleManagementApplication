import { Component, OnInit } from '@angular/core';
import { ContributorService } from '../_service/contributor.service';
import { AlertifyService } from '../_service/alertify.service';

@Component({
  selector: 'app-cost-template',
  templateUrl: './cost-template.component.html',
  styleUrls: ['./cost-template.component.css']
})
export class CostTemplateComponent implements OnInit {

  public imprints: any[];
  public royallityTemplate: any[];
  costTemplateTitle: string = "Cost Template";

  constructor(private contributorService: ContributorService, private alertify: AlertifyService) { 

    this.contributorService.getRoyaltyTypes().subscribe(result => {
      this.imprints = result;
    }, error => console.error(error));

    this.contributorService.getRoyaltyTypes().subscribe(result => {
        this.royallityTemplate = result;
      }, error => console.error(error));
  }

  ngOnInit() {
  }

}
