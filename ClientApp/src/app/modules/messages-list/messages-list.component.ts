import { Component, OnInit } from '@angular/core';
import { RepositoryService } from '../../Shared/Services/repository.service';
import { Message } from '../../Shared/Models/message.interface';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-messages-list',
  templateUrl: './messages-list.component.html',
  styleUrls: ['./messages-list.component.css']
})
export class MessagesListComponent implements OnInit {

  messages: Message[];

  constructor(private readonly repositoryService: RepositoryService, private readonly toastr: ToastrService) { }

  ngOnInit() {
    this.getMessages();
  }

  getMessages(): void {
    this.repositoryService.getAllMessages().subscribe(response => {
      this.messages = response;
    }, error => {
        this.toastr.error(error, "Problem!");
    })
  }
}
