import { BaseModel } from "./BaseModel";

export class Activity
    extends BaseModel
{
    public name: string = "";
    public start_date: Date = new Date();
    public start_end: Date = new Date();

    constructor() {
        super();
    }

    public static override toUrlResource(): string {
        return "Activity";
    }
}