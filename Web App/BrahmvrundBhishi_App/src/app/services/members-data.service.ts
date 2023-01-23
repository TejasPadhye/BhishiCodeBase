import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MembersDataService {
  url = 'https://localhost:7049/api/Members';

  constructor(private http : HttpClient) { }

  getMembers() : any
  {
    return this.http.get(this.url);
  }

  SaveLuckyMember(luckyMember : string) : Observable<any>
  {
      // let urlSearchParams = new URLSearchParams();
      // urlSearchParams.append('memberName', luckyMember);
      // this.http.post('/api', urlSearchParams).subscribe(
      //       data => {
      //         alert('ok');
      //       },
      //       error => {
      //         console.log(JSON.stringify(error.json()));
      //       }
      //     )



    let url1 = this.url + '/PostMemberData';
      return this.http.post<any>(url1, luckyMember);
  }
}
