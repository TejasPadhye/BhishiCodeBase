import { Component, Input, OnInit } from '@angular/core';
import { MembersDataService } from '../services/members-data.service';

@Component({
  selector: 'app-show-lucky-member',
  templateUrl: './show-lucky-member.component.html',
  styleUrls: ['./show-lucky-member.component.css']
})
export class ShowLuckyMemberComponent implements OnInit {

  showLuckyMember = "";
  constructor(private winnersData : MembersDataService) { }

  ngOnInit(): void {
  }

  @Input()luckyMember : any;

  SaveLuckyMember(): any{
    //this.showLuckyMember = "Congratulations " + this.luckyMember + "!";
    //console.log(this.luckyMember);

    this.winnersData.SaveLuckyMember(this.luckyMember).subscribe(data =>
      {
        if(data != null && data != undefined)
        return data;
        else
        return null;
      });

  }
  
  

}
