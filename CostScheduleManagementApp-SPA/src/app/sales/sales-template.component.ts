import { Component, OnInit } from '@angular/core';
import { AlertifyService } from 'src/app/_service/alertify.service';
import { ContributorService } from 'src/app/_service/contributor.service';
import { SalesTemplates } from '../_model/SalesTemplates';

@Component({
  selector: 'sales-template',
  templateUrl: './sales-template.component.html',
  styleUrls: ['./sales-template.component.css']
})
export class SalesTemplateComponent implements OnInit {

  public saleTemps: SalesTemplates[] = [];
  salesTempTitle: string = "Sales Templates"
  public salesType: any[];

  constructor(private contributorService: ContributorService,
    private alertify: AlertifyService) { 

      this.contributorService.getSalesTypes().subscribe(result => {
        this.salesType = result;
        console.log(this.salesType);
      }, error => console.error(error));

    }

  ngOnInit() {

    this.getSalesTemplates();
  }

  getSalesTemplates() {
    this.contributorService.getSalesTemplates().subscribe(results => {
        results.forEach(salesT => {
            this.saleTemps.push(salesT);
        });
    }, error => {
        this.alertify.error(error);
    });
}

}

