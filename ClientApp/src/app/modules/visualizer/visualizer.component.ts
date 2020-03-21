import { Component, OnInit } from '@angular/core';
import { Message } from '../../Shared/Models/message.interface';
import { DecodeService } from '../../Shared/Services/decode.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-visualizer',
  templateUrl: './visualizer.component.html',
  styleUrls: ['./visualizer.component.css']
})
export class VisualizerComponent implements OnInit {

  messages: Message[];

  constructor(private readonly decodeService: DecodeService, private readonly toastr: ToastrService) { }


  ngOnInit(): void {
  }

  clickedMethod() {
    let num: number = 7;
    let result: number = num + 10;
  }
  upload(files) {
    if (files.length === 0)
      return;
    let saveToDb: string = String(false);
    const formData = new FormData();
    formData.append(saveToDb, "saveToDb");

    for (let file of files)
      formData.append(file.name, file);

    this.decodeService.decodeFromFiles(formData).subscribe(response => {
      this.messages = response;
    }, error => {
        this.toastr.error(error, 'Problem!');
    });
  }
}
