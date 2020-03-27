import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MDBBootstrapModule, WavesModule } from 'angular-bootstrap-md';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MDBBootstrapModule,
    WavesModule,
    RouterModule,
    NgbModule
  ],
  exports: [MDBBootstrapModule, WavesModule, NgbModule]
})
export class SharedModule { }
