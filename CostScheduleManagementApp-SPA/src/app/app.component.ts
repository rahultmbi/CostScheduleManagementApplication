import { Component, OnInit } from '@angular/core';
import { ContributorService } from 'src/app/_service/contributor.service';
import { AlertifyService } from 'src/app/_service/alertify.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'CostScheduleManagementApp-SPA';

  constructor(private contributorService: ContributorService, private alertify: AlertifyService) { }

  ngOnInit(){

  }

  getContributor(){
    this.contributorService.getContributor().subscribe(data => {
      this.alertify.success('Contributors Details: ' + data);
    }, error => {
      this.alertify.error(error);
    });
  }

}
