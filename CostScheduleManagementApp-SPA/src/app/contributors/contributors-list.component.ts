import { Component } from '@angular/core';
import { AlertifyService } from 'src/app/_service/alertify.service';
import { ContributorService } from 'src/app/_service/contributor.service';
import { IContributor } from '../_model/Contributor';

@Component({
    selector: 'contributor-list',
    templateUrl: './contributors-list.component.html'
})

export class ContributorsListComponent {
    public contributors: IContributor[] = [];
    contributorTitle: string = "Contributors"

    constructor(private contributorService: ContributorService,
        private alertify: AlertifyService) { }

    ngOnInit() {
        this.getContributor();
    }

    getContributor() {
        this.contributorService.getContributor().subscribe(results => {
           // this.alertify.success('Contributors Details: ' + results);
            results.forEach(contributor => {
                this.contributors.push(contributor);
            });
        }, error => {
            this.alertify.error(error);
        });
    }
}