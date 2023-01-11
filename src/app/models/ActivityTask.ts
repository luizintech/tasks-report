import { BaseModel } from "./BaseModel";

export class ActivityTask 
    extends BaseModel
{
    public taskTypeId: number = 0;
    public activityId: number = 0;
    public url: string = "";
    public timeElapsedEntry: string = "00:00";

    constructor() {
        super();
    }

    public static override toUrlResource(): string {
        return "ActivityTask";
    }
}