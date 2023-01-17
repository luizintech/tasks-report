import { Component, OnInit } from '@angular/core';
import { Activity } from 'src/app/models/Activity';
import { ActivityService } from 'src/app/services/activities/activity.service';

@Component({
  selector: 'app-activity-list',
  templateUrl: './activity-list.component.html',
  styleUrls: ['./activity-list.component.scss']
})
export class ActivityListComponent implements OnInit {

  public activities: Activity[] = [];

  constructor(
    private activityService: ActivityService
  ) { }

  ngOnInit(): void {
    this.activityService.listAll().subscribe((data: Activity[]) => {
      this.activities = data;
    })
  }

}
