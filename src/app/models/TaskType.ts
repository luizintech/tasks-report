import { BaseModel } from './BaseModel';

export class TaskType extends BaseModel {
  
  name: string = '';

  constructor() {
    super();
  }

  public static override toUrlResource(): string {
    return "TaskType";
  }
}
