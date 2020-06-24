import { Component, OnInit } from '@angular/core';
import { ContributorService } from '../_service/contributor.service';
import { AlertifyService } from '../_service/alertify.service';
import { NgForm } from '@angular/forms';
import { ISalesTemplates } from '../_model/CostTemplate';
import { RoyaltyTemplate } from '../_model/RoyaltyTemplate';

@Component({
  selector: 'app-cost-template',
  templateUrl: './cost-template.component.html',
  styleUrls: ['./cost-template.component.css']
})
export class CostTemplateComponent implements OnInit {

  public imprints: any[];
  public royallityTemplate: any[];
  public salesTemplate: any[];
  costTemplateTitle: string = "Cost Template";
  public costTemplatesData: ISalesTemplates[] = [];
  public royaltyTemps: RoyaltyTemplate[] = [];

  constructor(private contributorService: ContributorService, private alertify: AlertifyService) { 

    this.contributorService.getImprints().subscribe(result => {
      this.imprints = result;
    }, error => console.error(error));

    this.contributorService.getRoyaltyTypes().subscribe(result => {
        this.royallityTemplate = result;
      }, error => console.error(error));

      this.contributorService.getSalesTemplates().subscribe(result => {
        this.salesTemplate = result;
      }, error => console.error(error));

        this.contributorService.getRoyaltyTemplates().subscribe(results => {
            results.forEach(royaltyT => {
                this.royaltyTemps.push(royaltyT);
            });
        }, error => {
            this.alertify.error(error);
        });
  }

  ngOnInit() {
    this.getCostTemplates();
  }

  saveCostTemplate(costTemplateForm: NgForm){
    console.log("form submit: "+JSON.stringify(costTemplateForm.value));
    this.contributorService.saveCostTemplate(JSON.stringify(costTemplateForm.value))
    .subscribe(
      data => {
        console.log('Imprint data is saved!' + JSON.stringify(data));
      },
      error => {
        console.log(error);
      }
    );
  }

  getCostTemplates() {
    this.contributorService.getCostTemplateData().subscribe(results => {
        results.forEach(costT => {
            this.costTemplatesData.push(costT);
        });
    }, error => {
        this.alertify.error(error);
    });
  }


}
