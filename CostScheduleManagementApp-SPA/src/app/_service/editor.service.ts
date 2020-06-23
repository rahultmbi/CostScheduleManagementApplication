import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EditorService {

  constructor(private http: HttpClient) { }

  baseUrl = environment.apiUrl;

  getEditors(){
    return this.http.get<any[]>(this.baseUrl + 'Contributor/getEditors');
  }

}
