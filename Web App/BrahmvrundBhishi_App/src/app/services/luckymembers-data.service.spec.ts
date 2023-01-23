import { TestBed } from '@angular/core/testing';

import { LuckymembersDataService } from './luckymembers-data.service';

describe('LuckymembersDataService', () => {
  let service: LuckymembersDataService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LuckymembersDataService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
