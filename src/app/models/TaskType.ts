import { Resources } from './Resources';

export class TaskType extends Resources {
  
  name: string = '';

  constructor() {
    super();
  }

  public static override toUrlResource(): string {
    return "TaskType";
  }
}
