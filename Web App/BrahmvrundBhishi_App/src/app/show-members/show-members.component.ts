import { Component, OnInit } from '@angular/core';
import { MembersDataService } from '../services/members-data.service'

@Component({
  selector: 'app-show-members',
  templateUrl: './show-members.component.html',
  styleUrls: ['./show-members.component.css']
})
export class ShowMembersComponent implements OnInit {

  members : any;
  loadChildComponent = false;

  constructor(private membersData : MembersDataService) { 
    this.membersData.getMembers().subscribe((data : any) => {
      this.members = data;
    })
  }

  ngOnInit(): void {
  }

  userData = "";
  title = "Show Members";
  luckyMember = "";
  membersArray : string[] = [];

  showLuckyMember(){
    this.membersArray = this.members;
    let totalMembers = this.membersArray.length;
    let randomNumber = Math.floor(Math.random() * (totalMembers - 1) + 1);

    this.luckyMember = this.membersArray[randomNumber];
    this.loadChildComponent = true;
    this.luckyMember = "Congratulations " + this.luckyMember + "!";
  }

}
