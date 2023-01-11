import { NavItem } from './../models/NavItem';

export const menu: NavItem[] = [
  {
    displayName: 'Reports',
    iconName: 'fas fa-clock',
    route: 'reports',
  },
  {
    displayName: 'Tipos de Tarefas',
    iconName: 'fas fa-wrench',
    route: 'task-types',
  },
  /*{
    displayName: 'Menu 2',
    iconName: 'fas fa-clock',
    route: 'entradasGADE',
  },
  {
    displayName: 'Menu 3',
    iconName: 'fas fa-clock',
    children: [
      {
        displayName: 'Menu 3.1',
        iconName: 'fas fa-clock',
        route: '/misexpedientes',
      },
      {
        displayName: 'Menu 3.2',
        iconName: 'fas fa-clock',
        route: '/todos',
      },
    ],
  },
  {
    displayName: 'Menu 4',
    iconName: 'fas fa-clock',
    children: [
      {
        displayName: 'Menu 4.1',
        iconName: 'fas fa-clock',
        route: '/busquedaperfiles',
      },
    ],
  },*/
];
