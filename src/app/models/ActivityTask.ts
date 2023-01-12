import { Activity } from "./Activity";
import { BaseModel } from "./BaseModel";
import { TaskType } from "./TaskType";

export class ActivityTask 
    extends BaseModel
{
    public taskTypeId: number = 0;
    public activityId: number = 0;
    public activity: Activity = new Activity();
    public taskType: TaskType = new TaskType();
    public url: string = "";
    public timeElapsed: string = "00:00";
    public timeElapsedEntry: string = "00:00";

    constructor() {
        super();
    }

    public static override toUrlResource(): string {
        return "ActivityTask";
    }
}