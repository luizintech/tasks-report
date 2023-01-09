import { TestBed } from '@angular/core/testing';

import { TaskTypeService } from './task-type.service';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

describe('TaskTypeService', () => {
  let service: TaskTypeService;
  let httpTestingController: HttpTestingController;
  let taskTypeService: TaskTypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: []
    });

    httpTestingController = TestBed.inject(HttpTestingController);
    taskTypeService = TestBed.inject(TaskTypeService);
  });

  it('should be created', () => {
    expect(taskTypeService).toBeTruthy();
  });
});
