import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Result } from 'src/app/dtos/Result';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TaskTypeService {

  private resourceName = "TaskType";

  constructor(private http: HttpClient) { }

  public listAll(): Observable<TaskType[]> {
    let headers = new HttpHeaders({
      'content-Type': 'application/json',
      'Access-Control-Allow-Origin': window.location.host
    });

    return this.http.get<TaskType[]>(`${environment.taskManagerApi}/${this.resourceName}`, 
      { headers: headers });
  }

  public getById(id: number): Observable<TaskType[]> {
    let headers = new HttpHeaders({
      'content-Type': 'application/json',
      'Access-Control-Allow-Origin': window.location.host
    });

    return this.http.get<TaskType[]>(`${environment.taskManagerApi}/${this.resourceName}/${id}`, 
      { headers: headers });
  }

  public post(taskType: TaskType): Observable<Result> {
    let headers = new HttpHeaders({
      'content-Type': 'application/json',
      'Access-Control-Allow-Origin': window.location.host
    });

    return this.http.post<Result>(`${environment.taskManagerApi}/${this.resourceName}`, 
      taskType,
      { headers: headers });
  }

  public put(id: number, taskType: TaskType): Observable<Result> {
    let headers = new HttpHeaders({
      'content-Type': 'application/json',
      'Access-Control-Allow-Origin': window.location.host
    });

    return this.http.put<Result>(`${environment.taskManagerApi}/${this.resourceName}/${id}`, 
      taskType,
      { headers: headers });
  }

  public delete(id: number): Observable<Result> {
    let headers = new HttpHeaders({
      'content-Type': 'application/json',
      'Access-Control-Allow-Origin': window.location.host
    });

    return this.http.put<Result>(`${environment.taskManagerApi}/${this.resourceName}/${id}`, 
      { headers: headers });
  }

}
