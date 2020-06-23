import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
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

}
