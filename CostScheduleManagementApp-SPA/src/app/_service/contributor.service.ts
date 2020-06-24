import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { IImprint } from '../_model/Imprint';
import { SalesTemplates } from '../_model/SalesTemplates';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ContributorService {

  constructor(private http: HttpClient) { }

  baseUrl = environment.apiUrl;


  getContributor() {
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getContributor');
  }

  saveImprintData(imprint: IImprint) {
    return this.http.post<any[]>(this.baseUrl + 'Contributor/saveImprintData', {imprint});
  }

  getSalesTypes() {
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getSalesTypes');
  }

  getRoyaltyTypes() {
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getRoyaltyTypes');
  }

  getMaterial() {
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getMaterial');
  }

  getEditionType() {
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getEditionType');
  }

  getEditors(){
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getEditors');
  }

  saveSalesTemplate(salesTemplate: SalesTemplates) {
    return this.http.post(this.baseUrl + 'Contributor/saveSalesTemplate/' + salesTemplate, {});

  }

  getSalesTemplates() {
    return this.http.get<any[]>(this.baseUrl + 'Sales/getSalesTemplates');
  }

  getImprints() {
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getImprints');
  }

  getSecheduleTemplate() {
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getScheduleTemplate');
  }
  
  getDummyValue(): Observable<object[]> {
    return of([{
      "editionTypeId": 1,
      "type": "CD"
  },
  {
      "editionTypeId": 2,
      "type": "Book"
  }]);
  }

  saveCostTemplate(salesTemplate: string) {
    return this.http.post(this.baseUrl + 'Contributor/saveCostTempleteData', salesTemplate);

  }

  getCostTemplateData() {
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getCostTemplateData');
  }

  getRoyaltyTemplates() {
    return this.http.get<any[]>(this.baseUrl + 'RoyaltyTemplate/getRoyaltyTemplates');
  }
}
