import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShowMembersComponent } from './show-members/show-members.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ShowLuckyMemberComponent } from './show-lucky-member/show-lucky-member.component';
import { ShowLuckyMembersHistoryComponent } from './show-lucky-members-history/show-lucky-members-history.component'

@NgModule({
  declarations: [
    AppComponent,
    ShowMembersComponent,
    ShowLuckyMemberComponent,
    ShowLuckyMembersHistoryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
