import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MDBBootstrapModule, WavesModule } from 'angular-bootstrap-md';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MDBBootstrapModule,
    WavesModule,
    RouterModule,
    NgbModule,
    AngularFontAwesomeModule
  ],
  exports: [MDBBootstrapModule, WavesModule, NgbModule, AngularFontAwesomeModule]
})
export class SharedModule { }
