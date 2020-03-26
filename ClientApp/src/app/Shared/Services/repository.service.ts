import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

import { Observable } from "rxjs/internal/Observable";
import { environment } from "../../../environments/environment";

@Injectable({
  providedIn: "root"
})
export class RepositoryService {

  constructor(private readonly http: HttpClient) {
  }

  //getAllMessages(): Observable<Message[]> {
  //  return this.http.get<Message[]>(`${environment.aisMessagesAPI}/GetAllMessages`);
  //}
}
