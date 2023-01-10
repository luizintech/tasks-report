import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TaskType } from 'src/app/models/TaskType';
import { BaseService } from '../base/base.service';

@Injectable({
  providedIn: 'root'
})

export class TaskTypeService extends BaseService<TaskType> {
  constructor(private http: HttpClient) {
    super(http, TaskType);
  }
}
