import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowLuckyMembersHistoryComponent } from './show-lucky-members-history.component';

describe('ShowLuckyMembersHistoryComponent', () => {
  let component: ShowLuckyMembersHistoryComponent;
  let fixture: ComponentFixture<ShowLuckyMembersHistoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowLuckyMembersHistoryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowLuckyMembersHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
