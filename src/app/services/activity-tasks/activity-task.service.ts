import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActivityTask } from 'src/app/models/ActivityTask';
import { BaseService } from '../base/base.service';

@Injectable({
  providedIn: 'root'
})
export class ActivityTaskService extends BaseService<ActivityTask> {
  constructor(private http: HttpClient) {
    super(http, ActivityTask);
  }
}
