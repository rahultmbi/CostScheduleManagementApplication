import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContributorService } from './_service/contributor.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { AlertifyService } from './_service/alertify.service';
//import { ChartModule } from 'angular-highcharts';
import { HighchartsChartComponent } from 'highcharts-angular';
import { EditorService } from './_service/editor.service';

@NgModule({
  declarations: [
    AppComponent,
    HighchartsChartComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  //  ChartModule,
    
  ],
  providers: [
    ContributorService,
    AlertifyService,
    EditorService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
