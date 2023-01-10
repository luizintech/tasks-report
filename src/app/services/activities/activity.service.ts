import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Activity } from 'src/app/models/Activity';
import { BaseService } from '../base/base.service';

@Injectable({
  providedIn: 'root'
})
export class ActivityService extends BaseService<Activity> {
  constructor(private http: HttpClient) {
    super(http, Activity);
  }
}