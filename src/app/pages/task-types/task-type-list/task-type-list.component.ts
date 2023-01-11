import { Component, OnInit } from '@angular/core';
import { TaskType } from 'src/app/models/TaskType';
import { TaskTypeService } from 'src/app/services/task-type/task-type.service';

@Component({
  selector: 'app-task-type-list',
  templateUrl: './task-type-list.component.html',
  styleUrls: ['./task-type-list.component.scss']
})
export class TaskTypeListComponent implements OnInit {

  public taskTypes: TaskType[] = [];

  constructor(
    private taskTypeService: TaskTypeService
  ) {

  }

  ngOnInit(): void {
    this.taskTypeService.listAll().subscribe((data: TaskType[]) => {
      this.taskTypes = data;
    });
  }

}
