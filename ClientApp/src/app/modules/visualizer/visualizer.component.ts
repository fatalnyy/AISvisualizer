import { Component, OnInit } from '@angular/core';
import { DecodeService } from '../../Shared/Services/decode.service';
import { ToastrService } from 'ngx-toastr';
import { DecodedMessages } from '../../Shared/Models/decodedMessages.interface';

@Component({
  selector: 'app-visualizer',
  templateUrl: './visualizer.component.html',
  styleUrls: ['./visualizer.component.scss']
})
export class VisualizerComponent implements OnInit {

  decodedMessages: DecodedMessages;

  constructor(private readonly decodeService: DecodeService, private readonly toastr: ToastrService) { }


  ngOnInit(): void {
  }

  clickedMethod() {
    let num: number = 7;
    let result: number = num + 10;
  }
  public uploadFiles = (files) => {
    if (files.length === 0)
      return;

    let saveToDb: string = String(true);
    const formData = new FormData();
    formData.append(saveToDb, "saveToDb");

    for (let file of files)
      formData.append("files", file);

    this.decodeService.decodeFromFiles(formData).subscribe(response => {
      this.decodedMessages = response;
    }, error => {
        this.toastr.error(error, 'Problem!');
    });
  }
}
