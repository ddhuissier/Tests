import { TestBed } from '@angular/core/testing';

import { QuickTestsService } from './quick-tests.service';

describe('QuickTestsService', () => {
  let service: QuickTestsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(QuickTestsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
