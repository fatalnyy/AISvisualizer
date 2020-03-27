import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from "@angular/common/http";

import { Observable } from "rxjs/internal/Observable";
import { environment } from "../../../environments/environment";

@Injectable({
  providedIn: "root"
})
export class RepositoryService<T> {

  constructor(private readonly http: HttpClient) {
  }

  getAllMessages(type: string): Observable<T[]> {
    const params = new HttpParams()
      .set('type', type);
    return this.http.get<T[]>(`${environment.aisMessagesAPI}/GetAllMessages`, { params });
  }
}
