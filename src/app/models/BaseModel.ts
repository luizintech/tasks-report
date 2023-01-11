export abstract class BaseModel {
  id: number = 0;
  createdAt: Date = new Date();
  deletedAt: Date = new Date();

  public static toUrlResource() {
    return "";
  }

  public toJSON(): any {
    return JSON.parse(JSON.stringify(this));
  }
}
