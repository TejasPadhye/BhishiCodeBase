import { Component, OnInit } from '@angular/core';
import { LuckymembersDataService } from '../services/luckymembers-data.service'

@Component({
  selector: 'app-show-lucky-members-history',
  templateUrl: './show-lucky-members-history.component.html',
  styleUrls: ['./show-lucky-members-history.component.css']
})
export class ShowLuckyMembersHistoryComponent implements OnInit {

  luckyMembers : any;
  
  constructor(private luckyMembersData : LuckymembersDataService) { 
    this.luckyMembersData.getLuckyMembersHistory().subscribe((data : any) => {
      this.luckyMembersData = data;
      this.luckyMembers = luckyMembersData;
    })
  }

  ngOnInit(): void {
  }

}
