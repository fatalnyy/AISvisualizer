import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VisualizerComponent } from './visualizer.component';
import { DecodeService } from '../../Shared/Services/decode.service';
import { SharedModule } from '../../Shared/shared.module';



@NgModule({
  declarations: [VisualizerComponent],
  imports: [
    CommonModule,
    SharedModule
  ],
  providers: [
    DecodeService
  ]
})
export class VisualizerModule { }
