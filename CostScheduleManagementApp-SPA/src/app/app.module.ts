import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContributorService } from './_service/contributor.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AlertifyService } from './_service/alertify.service';
import { HighchartsChartComponent } from 'highcharts-angular';
import { EditorService } from './_service/editor.service';
import { ContributorsListComponent } from './contributors/contributors-list.component';
import { ImprintListComponent } from './imprint/imprint-list.component';
import { RoyaltyTemplateComponent } from './royalty/royalty-template.component';
import { CostTemplateComponent } from './cost/cost-template.component';
import { SalesTemplateComponent } from './sales/sales-template.component';
import { ScheduleTemplateComponent } from './schedule/schedule-template.component';
import { FinalReportComponent } from './report/final-report.component';
import { HomePageComponent } from './home/home-page.component';

@NgModule({
  declarations: [
    AppComponent,
    HighchartsChartComponent,
    ContributorsListComponent,
    ImprintListComponent,
    RoyaltyTemplateComponent,
    CostTemplateComponent,
    SalesTemplateComponent,
    ScheduleTemplateComponent,
    FinalReportComponent,
    HomePageComponent
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
