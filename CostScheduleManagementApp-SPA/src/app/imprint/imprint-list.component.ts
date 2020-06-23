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
    contributorId: null,
    editorId: null,
    isbn: null,
    type: null
  };

  authors: Observable<string[]>;
  editors: Observable<string[]>;
  editionTypes: Observable<object[]>;
  materials: Observable<string[]>;

  constructor(private contributorService: ContributorService) { }

  ngOnInit() {
    this.authors = this.contributorService.getContributor();
    this.editors = this.contributorService.getEditors();
    this.editionTypes = this.contributorService.getDummyValue();
    this.materials = this.contributorService.getMaterial();
  }

  saveImprint(form: NgForm){
    console.log("form submit: "+JSON.stringify(form.value));
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
