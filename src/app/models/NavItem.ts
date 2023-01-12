export interface NavItem {
  displayName: string;
  iconName?: string;
  route?: string;
  disabled?: boolean;
  children?: NavItem[];
}
