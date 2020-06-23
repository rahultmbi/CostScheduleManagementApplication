import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { SalesTemplates } from '../_model/SalesTemplates';
import { IImprint } from '../_model/Imprint';

@Injectable({
  providedIn: 'root'
})
export class ContributorService {

  constructor(private http: HttpClient) { }

  baseUrl = environment.apiUrl;


  getContributor(){
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getContributor');
  }

  saveImprintData(imprint: IImprint){
    return this.http.post<any[]>(this.baseUrl + 'Contributor/saveImprintData/'+ imprint, {});
  }

  getSalesTypes(){
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getSalesTypes');
  }

  getRoyaltyTypes(){
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getRoyaltyTypes');
  }

  getMaterial(){
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getMaterial');
  }

  getEditionType(){
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getEditionType');
  }

  saveSalesTemplate(salesTemplate: SalesTemplates){
    return this.http.post(this.baseUrl + 'Contributor/saveSalesTemplate/'+ salesTemplate, {});

  }

  getSalesTemplates(){
    return this.http.get<any[]>(this.baseUrl + 'Sales/getSalesTemplates');
  }

  getImprints(){
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getImprints');
  }

}
