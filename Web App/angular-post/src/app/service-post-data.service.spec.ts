import { TestBed } from '@angular/core/testing';

import { ServicePostDataService } from './service-post-data.service';

describe('ServicePostDataService', () => {
  let service: ServicePostDataService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServicePostDataService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
