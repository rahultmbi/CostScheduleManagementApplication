import { Component, OnInit } from '@angular/core';
import { RoyaltyTemplate } from '../_model/RoyaltyTemplate';
import { AlertifyService } from '../_service/alertify.service';
import { ContributorService } from '../_service/contributor.service';

@Component({
  selector: 'app-royalty-template',
  templateUrl: './royalty-template.component.html',
  styleUrls: ['./royalty-template.component.css']
})
export class RoyaltyTemplateComponent implements OnInit {

  public royaltyTemplate: any[];
  public royaltyTemps: RoyaltyTemplate[] = [];
  royaltyTemplateTitle: string = "Royalty Template";
  royaltyTemplateGridTitle: string = "Royalty Template Data"

  constructor(private contributorService: ContributorService, private alertify: AlertifyService) {

    this.contributorService.getRoyaltyTypes().subscribe(result => {
      this.royaltyTemplate = result;
    }, error => console.error(error));

  }

  ngOnInit() {
    this.getRoyaltyTemplates();
  }

  getRoyaltyTemplates() {
    this.contributorService.getRoyaltyTemplates().subscribe(results => {
      results.forEach(royaltyT => {
        this.royaltyTemps.push(royaltyT);
      });
    }, error => {
      this.alertify.error(error);
    });
  }

}
