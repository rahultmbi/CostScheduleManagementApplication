import { Component, OnInit } from '@angular/core';
import { ContributorService } from 'src/app/_service/contributor.service';
import { AlertifyService } from 'src/app/_service/alertify.service';
import { Contributor } from './_model/Contributor';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'CostScheduleManagementApp-SPA';
  //contributor: Contributor[];
  public contributor: string[] = [];

  constructor(private contributorService: ContributorService, private alertify: AlertifyService) { }

  ngOnInit(){
    
  }

  getContributor(){
    const availableFruits: string[] = ["banana", "orange", "apple", "strawberry", "pear"];
    this.contributorService.getContributor().subscribe(data => {
      this.alertify.success('Contributors Details: ' + data);
      console.log("data");
      availableFruits.forEach((fruit) => { this.contributor.push(fruit); });
    }, error => {
      this.alertify.error(error);
    });
  }

}
