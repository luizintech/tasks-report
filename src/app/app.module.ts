import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { LayoutsModule } from './components/layouts/layouts.module';
import { TaskTypeListComponent } from './pages/maintenance-cruds/task-types/task-type-list/task-type-list.component';
import { ActivityListComponent } from './pages/maintenance-cruds/activities/activity-list/activity-list.component';
import { ActivityTaskListComponent } from './pages/maintenance-cruds/tasks/activity-task-list/activity-task-list.component';

@NgModule({
  declarations: [AppComponent, TaskTypeListComponent, ActivityListComponent, ActivityTaskListComponent],
  imports: [
    BrowserModule, 
    AppRoutingModule, 
    LayoutsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
