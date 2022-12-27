import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ReportsComponent } from './reports.component';
import { ReportsRoutingModule } from './reports.routing';

@NgModule({
  declarations: [ReportsComponent],
  exports: [],
  imports: [CommonModule, ReportsRoutingModule],
  providers: [],
})
export class ReportsModule {}
