import { menu } from './../../../pages/pages.menu';
import { NavItem } from './../../../models/NavItem';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss'],
})
export class SidenavComponent implements OnInit {
  sideMenu: NavItem[] = menu;

  constructor() {}

  ngOnInit() {
    this.sideMenu = menu;
  }
}
