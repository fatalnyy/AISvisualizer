import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MDBBootstrapModule, WavesModule } from 'angular-bootstrap-md';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MDBBootstrapModule,
    WavesModule,
    RouterModule
  ],
  exports: [MDBBootstrapModule, WavesModule]
})
export class SharedModule { }
