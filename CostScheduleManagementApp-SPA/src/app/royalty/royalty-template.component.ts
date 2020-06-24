import { Component, OnInit } from '@angular/core';
import { ContributorService } from '../_service/contributor.service';
import { AlertifyService } from '../_service/alertify.service'; 
import { NgForm } from '@angular/forms';
import { RoyaltyTemplate } from '../_model/RoyaltyTemplate';


@Component({
  selector: 'app-royalty-template',
  templateUrl: './royalty-template.component.html',
  styleUrls: ['./royalty-template.component.css']
})
export class RoyaltyTemplateComponent implements OnInit {
  private mm : string ;
  months;
  public royallityTemplate: any[];
  public royaltyTemps: RoyaltyTemplate[] = [];
  royaltyTemplateTitle: string = "Royalty Template";
  royaltyTemplateGridTitle: string = "Royalty Template Data"

  constructor(private contributorService: ContributorService, private alertify: AlertifyService) { 

    
    this.contributorService.getRoyaltyTypes().subscribe(result => {
        this.royallityTemplate = result;
      }, error => console.error(error));

  }

    ngOnInit() {  
    }  

    saveRoyaltyTemplate(){
    console.log("data saved");
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
