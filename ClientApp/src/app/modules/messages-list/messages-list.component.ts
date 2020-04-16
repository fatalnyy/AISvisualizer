import { Component, OnInit, ChangeDetectorRef, ViewChild, AfterViewInit, ChangeDetectionStrategy } from '@angular/core';
import { RepositoryService } from '../../Shared/Services/repository.service';
import { ToastrService } from 'ngx-toastr';
import { MdbTablePaginationComponent, MdbTableDirective } from 'angular-bootstrap-md';
import { BehaviorSubject } from 'rxjs';
import { MessageType1 } from '../../Shared/Models/messageType1.interface';
import { MessageTypes } from '../../Shared/Helpers/messageTypes.enum';
import { MessageType123Headers } from '../../Shared/Helpers/messageType123Headers.enum';
import { MessageType4Headers } from '../../Shared/Helpers/messageType4Headers.enum';
import { MessageType5Headers } from '../../Shared/Helpers/messageType5Headers.enum';
import { MessageType9Headers } from '../../Shared/Helpers/messageType9Headers.enum';
import { MessageType21Headers } from '../../Shared/Helpers/messageType21Headers.enum';

@Component({
  selector: 'app-messages-list',
  templateUrl: './messages-list.component.html',
  styleUrls: ['./messages-list.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class MessagesListComponent<T> implements OnInit, AfterViewInit {

  messages: T[];
  messageType: string;
  messages$: BehaviorSubject<T[]> = new BehaviorSubject<T[]>([]);
  previous: T[] = [];
  messagesType123Headers: string[] = Object.values(MessageType123Headers);
  messagesType4Headers: string[] = Object.values(MessageType4Headers);
  messagesType5Headers: string[] = Object.values(MessageType5Headers);
  messagesType9Headers: string[] = Object.values(MessageType9Headers);
  messagesType21Headers: string[] = Object.values(MessageType21Headers);
  messageTypes: string[] = Object.values(MessageTypes);

  @ViewChild(MdbTablePaginationComponent, { static: true }) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild(MdbTableDirective, { static: true }) mdbTable: MdbTableDirective;

  constructor(private readonly repositoryService: RepositoryService<T>,
              private readonly toastr: ToastrService,
              private cdRef: ChangeDetectorRef) { }

  ngOnInit(): void {
    this.getMessages("1");

  }

  ngAfterViewInit(): void {
    this.mdbTablePagination.setMaxVisibleItemsNumberTo(12);
    this.mdbTablePagination.calculateFirstItemIndex();
    this.mdbTablePagination.calculateLastItemIndex();
    this.cdRef.detectChanges();
  }

  getMessages(type: string): void {
    this.repositoryService.getAllMessages(type).subscribe(response => {
      this.messages$.next(response);
      this.mdbTable.setDataSource(response);
      this.previous = response;
      this.messageType = type;
    }, error => {
        this.toastr.error(error, "Problem!");
    })
  }
}
