import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LayoutsComponent } from './layouts.component';
import { SidenavComponent } from './sidenav/sidenav.component';
import { HeaderComponent } from './header/header.component';

@NgModule({
  declarations: [LayoutsComponent, SidenavComponent, HeaderComponent],
  exports: [LayoutsComponent],
  imports: [CommonModule],
})
export class LayoutsModule {}
