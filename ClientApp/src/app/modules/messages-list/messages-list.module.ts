import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MessagesListComponent } from './messages-list.component';
import { RepositoryService } from '../../Shared/Services/repository.service';



@NgModule({
  declarations: [MessagesListComponent],
  imports: [
    CommonModule
  ],
  providers: [
    RepositoryService
  ]
})
export class MessagesListModule { }
