import { Component, OnInit, ChangeDetectorRef, ViewChild, AfterViewInit } from '@angular/core';
import { RepositoryService } from '../../Shared/Services/repository.service';
import { ToastrService } from 'ngx-toastr';
import { MdbTablePaginationComponent, MdbTableDirective } from 'angular-bootstrap-md';
import { BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-messages-list',
  templateUrl: './messages-list.component.html',
  styleUrls: ['./messages-list.component.scss']
})
export class MessagesListComponent implements OnInit, AfterViewInit {

  //messages: Message[];
  //messages$: BehaviorSubject<Message[]> = new BehaviorSubject<Message[]>([]);
  //previous: Message[] = [];
  messagesHeaders: string[] = ["Id", "Type", "Repeat", "MMSI", "Status", "ROT [deg/min]", "SOG [knots]", "Accuracy", "LON [deg]",
                                "LAT [deg]", "COG [deg]", "HDG [deg]", "Timestamp [s]", "Maneuver", "RAIM"]
  @ViewChild(MdbTablePaginationComponent, { static: true }) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild(MdbTableDirective, { static: true }) mdbTable: MdbTableDirective;

  constructor(private readonly repositoryService: RepositoryService,
              private readonly toastr: ToastrService,
              private cdRef: ChangeDetectorRef) { }

  ngOnInit(): void {
    //this.getMessages();
  }

  ngAfterViewInit(): void {
    this.mdbTablePagination.setMaxVisibleItemsNumberTo(20);
    this.mdbTablePagination.calculateFirstItemIndex();
    this.mdbTablePagination.calculateLastItemIndex();
    this.cdRef.detectChanges();
  }

  //getMessages(): void {
  //  this.repositoryService.getAllMessages().subscribe(response => {
  //    this.messages$.next(response);
  //    this.mdbTable.setDataSource(response);
  //    this.previous = response;
  //  }, error => {
  //      this.toastr.error(error, "Problem!");
  //  })
  //}
}
