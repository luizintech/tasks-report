import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { LayoutsModule } from './components/layouts/layouts.module';
import { TaskTypeListComponent } from './pages/maintenance-cruds/task-types/task-type-list/task-type-list.component';

@NgModule({
  declarations: [AppComponent, TaskTypeListComponent],
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
