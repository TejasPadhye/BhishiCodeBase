import { Component, OnInit } from '@angular/core';
import { ServicePostDataService } from '../service-post-data.service';

@Component({
  selector: 'app-post-data',
  templateUrl: './post-data.component.html',
  styleUrls: ['./post-data.component.css']
})
export class PostDataComponent implements OnInit {

  members : any;
  
  constructor(private serviceData : ServicePostDataService) { }

  ngOnInit(): void {
  }

  

  saveMembers() : any{
    this.serviceData.saveMember('Ashutosh Joshi').subscribe(data =>
      {
        if(data != null && data != undefined)
        return data;
        else
        return null;
      });
  }

  // getMembers() : any{
  //   this.serviceData.getMembers().subscribe((data : any) =>{
  //     this.members = data;
  
  //   })
  // }
  
  

  

}
