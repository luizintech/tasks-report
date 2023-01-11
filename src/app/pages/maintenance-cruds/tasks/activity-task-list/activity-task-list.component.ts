import { Component, OnInit } from '@angular/core';
import { ActivityTask } from 'src/app/models/ActivityTask';
import { ActivityTaskService } from 'src/app/services/activity-tasks/activity-task.service';

@Component({
  selector: 'app-activity-task-list',
  templateUrl: './activity-task-list.component.html',
  styleUrls: ['./activity-task-list.component.scss']
})
export class ActivityTaskListComponent implements OnInit {

  public tasks: ActivityTask[] = [];

  constructor(
    private taskService: ActivityTaskService
  ) { }

  ngOnInit(): void {
    this.taskService.listAll().subscribe((data: ActivityTask[]) => {
      this.tasks = data;
    })
  }

}
