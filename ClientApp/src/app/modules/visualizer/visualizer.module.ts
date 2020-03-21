import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VisualizerComponent } from './visualizer.component';
import { DecodeService } from '../../Shared/Services/decode.service';



@NgModule({
  declarations: [VisualizerComponent],
  imports: [
    CommonModule
  ],
  providers: [
    DecodeService
  ]
})
export class VisualizerModule { }
