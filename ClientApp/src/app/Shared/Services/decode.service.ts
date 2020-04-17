import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { DecodedMessages } from '../Models/decodedMessages.interface';
import { Content } from '@angular/compiler/src/render3/r3_ast';


@Injectable({
    providedIn: "root"
})
export class DecodeService {

    constructor(private readonly http: HttpClient) {
    }

  decodeFromFiles(files: FormData): Observable<DecodedMessages> {
    return this.http.post<DecodedMessages>(`${environment.aisMessagesAPI}/DecodeFromFiles`, files);
  }

  getProgress(): Observable<any> {
    return this.http.get<any>(`${environment.aisMessagesAPI}/GetProgress`);
  }
}
