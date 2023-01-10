export abstract class Resources {
  public toJSON(): any {
    return JSON.parse(JSON.stringify(this));
  }
}
