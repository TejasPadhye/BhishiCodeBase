import { TestBed } from '@angular/core/testing';

import { SaveLuckyMemberService } from './save-lucky-member.service';

describe('SaveLuckyMemberService', () => {
  let service: SaveLuckyMemberService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SaveLuckyMemberService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
