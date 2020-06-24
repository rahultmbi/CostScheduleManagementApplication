import { Component, OnInit } from '@angular/core';
import { IImprint } from '../_model/Imprint';
import { NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { ContributorService } from '../_service/contributor.service';

@Component({
  selector: 'app-imprint-list',
  templateUrl: './imprint-list.component.html',
  styleUrls: ['./imprint-list.component.css']
})
export class ImprintListComponent implements OnInit {

  public imprintTitle: string = 'Imprint / Edition';
  public imprintObj: IImprint = {
    contriutorName: null,
    title: null,
    editorName: null,
    coverType: null,
    ISBN: null,
    type: null
  };

  public imprintTable: any[];

  authors: any[];
  editors: any[];
  editionTypes: any[];
  materials: any[];

  constructor(private contributorService: ContributorService) { }

  ngOnInit() {
    this.contributorService.getContributor().subscribe(result => {
      this.authors = result;
    }, error => console.error(error));

    this.contributorService.getEditors().subscribe(result => {
      this.editors = result;
    }, error => console.error(error));

    this.contributorService.getDummyValue().subscribe(result => {
      this.editionTypes = result;
    }, error => console.error(error));

    this.contributorService.getMaterial().subscribe(result => {
      this.materials = result;
    }, error => console.error(error));

    this.contributorService.getImprints().subscribe(result => {
      this.imprintTable = result;
    }, error => console.error(error));

  }

  saveImprint(form: NgForm) {
    console.log("form submit: " + JSON.stringify(form.value));
    this.contributorService.saveImprintData(form.value)
      .subscribe(
        data => {
          console.log('Imprint data is saved!');
        },
        error => {
          console.log(error);
        }
      );
  }
}
