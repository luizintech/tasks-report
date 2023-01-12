import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { ActivityListComponent } from './pages/maintenance-cruds/activities/activity-list/activity-list.component';
import { TaskTypeListComponent } from './pages/maintenance-cruds/task-types/task-type-list/task-type-list.component';
import { ActivityTaskListComponent } from './pages/maintenance-cruds/tasks/activity-task-list/activity-task-list.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: '/reports',
    pathMatch: 'full',
  },
  {
    path: 'reports',
    // canActivate: [AuthGuard],
    loadChildren: () =>
      import('./pages/reports/reports.module').then((m) => m.ReportsModule),
  },
  { path: 'task-types', component: TaskTypeListComponent },
  { path: "activities", component: ActivityListComponent },
  { path: "tasks", component: ActivityTaskListComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules }),
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
