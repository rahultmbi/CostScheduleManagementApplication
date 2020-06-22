import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Http, Headers } from '@angular/http';
import { Contributor } from '../_model/Contributor';
import { Imprint } from '../_model/Imprint';

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
    return this.http.post(this.baseUrl + 'Contributor/saveImprintData/'+ imprint, {});
  }

}
