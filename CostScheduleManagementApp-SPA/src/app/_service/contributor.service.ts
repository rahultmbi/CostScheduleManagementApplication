import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Http, Headers } from '@angular/http';

@Injectable({
  providedIn: 'root'
})
export class ContributorService {

  constructor(private http: HttpClient) { }

  baseUrl = environment.apiUrl;

  getContributor() {
    let headers = new HttpHeaders();
    headers.append('Access-Control-Allow-Origin' , '*');
    return this.http.get<any[]>(this.baseUrl + 'Contributor/GetContributor', {headers: headers});
  }

}
