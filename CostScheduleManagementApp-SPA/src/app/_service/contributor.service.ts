import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ContributorService {

  constructor(private http: HttpClient) { }

  baseUrl = environment.apiUrl;

  getContributor() {
    return this.http.get(this.baseUrl + 'GetContributor');
  }

}
