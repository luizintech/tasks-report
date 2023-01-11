import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { TaskTypeListComponent } from './pages/task-types/task-type-list/task-type-list.component';

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
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules }),
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
