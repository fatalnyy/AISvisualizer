import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Message } from '../Models/message.interface';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';


@Injectable({
    providedIn: "root"
})
export class DecodeService {

    constructor(private readonly http: HttpClient) {
    }

  decodeFromFiles(files: FormData): Observable<Message[]> {
    return this.http.post<Message[]>(`${environment.aisMessagesAPI}/DecodeFromFiles`, files);
  }
}
