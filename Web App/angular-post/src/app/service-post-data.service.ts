import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServicePostDataService {
  url = 'https://localhost:7049/api/Members';

  constructor(private http : HttpClient) { }

  getMembers() : any {
    return this.http.get(this.url);
  }

  saveMember(member : string) : Observable<any>
{
  let url1 = this.url + '/PostMemberData';
  return this.http.post<any>(url1, member);
}
}


