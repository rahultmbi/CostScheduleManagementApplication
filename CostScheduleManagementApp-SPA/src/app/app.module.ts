import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContributorService } from './_service/contributor.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { AlertifyService } from './_service/alertify.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [
    ContributorService,
    AlertifyService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
