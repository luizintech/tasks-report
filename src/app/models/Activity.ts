import { BaseModel } from "./BaseModel";

export class Activity
    extends BaseModel
{
    public name: string = "";
    public startDate: Date = new Date();
    public endDate: Date = new Date();

    constructor() {
        super();
    }

    public static override toUrlResource(): string {
        return "Activity";
    }
}