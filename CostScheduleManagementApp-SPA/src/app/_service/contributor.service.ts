import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Http, Headers } from '@angular/http';
import { Imprint } from '../_model/Imprint';
import { SalesTemplates } from '../_model/SalesTemplates';

@Injectable({
  providedIn: 'root'
})
export class ContributorService {

  constructor(private http: HttpClient) { }

  baseUrl = environment.apiUrl;


  getContributor(){
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getContributor');
  }

  saveImprintData(imprint: Imprint){
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

}
