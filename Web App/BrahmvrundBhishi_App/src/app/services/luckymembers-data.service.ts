import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LuckymembersDataService {

  constructor(private http : HttpClient) { }

  getLuckyMembersHistory()
  {
    return this.http.get('https://localhost:7049/api/LuckyMembers');
  }
}
