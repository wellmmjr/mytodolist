import { TestBed } from '@angular/core/testing';

import { TaskitselfService } from './taskitself.service';

describe('TaskitselfService', () => {
  let service: TaskitselfService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TaskitselfService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
