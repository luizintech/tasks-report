export abstract class Resources {
  id: number = 0;

  public static toUrlResource() {
    return "";
  }

  public toJSON(): any {
    return JSON.parse(JSON.stringify(this));
  }
}
