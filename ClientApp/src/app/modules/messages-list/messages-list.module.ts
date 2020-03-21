import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MessagesListComponent } from './messages-list.component';
import { RepositoryService } from '../../Shared/Services/repository.service';
import { SharedModule } from '../../Shared/shared.module';



@NgModule({
  declarations: [MessagesListComponent],
  imports: [
    CommonModule,
    SharedModule
  ],
  providers: [
    RepositoryService
  ]
})
export class MessagesListModule { }
