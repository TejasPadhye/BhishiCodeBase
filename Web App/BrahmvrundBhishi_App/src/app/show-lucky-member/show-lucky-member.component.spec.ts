import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowLuckyMemberComponent } from './show-lucky-member.component';

describe('ShowLuckyMemberComponent', () => {
  let component: ShowLuckyMemberComponent;
  let fixture: ComponentFixture<ShowLuckyMemberComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowLuckyMemberComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowLuckyMemberComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
