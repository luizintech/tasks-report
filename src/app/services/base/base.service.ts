import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Result } from 'src/app/dtos/Result';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export abstract class BaseService<TEntity> {

  private headers: HttpHeaders;

  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({
      'content-Type': 'application/json',
      'Access-Control-Allow-Origin': window.location.host
    });
  }

  public listAll(type: string): Observable<TEntity[]> {
    return this.http.get<TEntity[]>(`${environment.taskManagerApi}/${type}`, 
      { headers: this.headers });
  }

  public getById(id: number, type: string): Observable<TEntity[]> {
    return this.http.get<TEntity[]>(`${environment.taskManagerApi}/${type}/${id}`, 
      { headers: this.headers });
  }

  public post(taskType: TEntity, type: string): Observable<Result> {
    return this.http.post<Result>(`${environment.taskManagerApi}/${type}`, 
      taskType,
      { headers: this.headers });
  }

  public put(id: number, taskType: TEntity, type: string): Observable<Result> {
    return this.http.put<Result>(`${environment.taskManagerApi}/${type}/${id}`, 
      taskType,
      { headers: this.headers });
  }

  public delete(id: number, type: string): Observable<Result> {
    return this.http.put<Result>(`${environment.taskManagerApi}/${type}/${id}`, 
      { headers: this.headers });
  }
}
