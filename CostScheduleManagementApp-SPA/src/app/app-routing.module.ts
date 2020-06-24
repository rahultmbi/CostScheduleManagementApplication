import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ContributorsListComponent } from './contributors/contributors-list.component';
import { ImprintListComponent } from './imprint/imprint-list.component';
import { RoyaltyTemplateComponent } from './royalty/royalty-template.component';
import { SalesTemplateComponent } from './sales/sales-template.component';
import { ScheduleTemplateComponent } from './schedule/schedule-template.component';
import { CostTemplateComponent } from './cost/cost-template.component';
import { FinalReportComponent } from './report/final-report.component';
import { HomePageComponent } from './home/home-page.component';


const routes: Routes = [
  { path: 'welcome', component: HomePageComponent },
  { path: 'imprint', component: ImprintListComponent },
  { path: 'royalty', component: RoyaltyTemplateComponent },
  { path: 'sales', component: SalesTemplateComponent },
  { path: 'schedule', component: ScheduleTemplateComponent },
  { path: 'cost', component: CostTemplateComponent },
  { path: 'report', component: FinalReportComponent },
  { path: 'contributors', component: ContributorsListComponent },
  { path: '', redirectTo: 'welcome', pathMatch: 'full' },
  { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
