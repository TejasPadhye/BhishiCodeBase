import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {Observable} from 'rxjs';
// import { URLSearchParams } from '@angular/http';

@Injectable({
  providedIn: 'root'
})
export class SaveLuckyMemberService {
  url = 'https://localhost:7049/api/Members';
  private headers: HttpHeaders;

  constructor(private http : HttpClient) { 
    this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
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



    this.url = this.url + '/Post';
      return this.http.post(this.url, luckyMember);



    //const headers = {'Content-Type' : 'application/json'};
    // return this.http.post<void>(this.url, luckyMember, {
    //   headers : new HttpHeaders({
    //     'Content-Type' : 'application/string'
    //   })
    // });
    // return this.http.post(this.url, {
    //   memberName : luckyMember
    // }).toPromise().then((data: any)=> {
    //   console.log(data);
    //   console.log(JSON.stringify(data.json.memberName));
    // })
    // .subscribe(
    //   (val) => {
    //       console.log("POST call successful value returned in body", 
    //                   val);
    //   },
    //   response => {
    //       console.log("POST call in error", response);
    //   },
    //   () => {
    //       console.log("The POST observable is now completed.");
    //   });
  }
}
