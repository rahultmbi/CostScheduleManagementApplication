import { Component, OnInit } from '@angular/core';
import { ContributorService } from '../_service/contributor.service';
import { AlertifyService } from '../_service/alertify.service';

@Component({
  selector: 'app-royalty-template',
  templateUrl: './royalty-template.component.html',
  styleUrls: ['./royalty-template.component.css']
})
export class RoyaltyTemplateComponent implements OnInit {

  public royallityTemplate: any[];
  costTemplateTitle: string = "Royalty Template";

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

}
