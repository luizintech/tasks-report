import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Result } from 'src/app/dtos/Result';
import { TaskType } from 'src/app/models/TaskType';
import { environment } from 'src/environments/environment';

export abstract class BaseCons<T> {
  constructor(model?: Partial<T>) {
    console.log('base Cons', model);
  }

  public toJSON(): any {
    return JSON.parse(JSON.stringify(this));
  }
}

export abstract class BaseService<TEntity extends BaseCons<TEntity>> {
  private headers: HttpHeaders;

  constructor(
    private httpClient: HttpClient,
    private baseConstructor: {
      new (m: Partial<TEntity>): TEntity;
    }
  ) {
    this.headers = new HttpHeaders({
      'content-Type': 'application/json',
      'Access-Control-Allow-Origin': window.location.host,
    });
  }

  public listAll(): Observable<TEntity[]> {
    return this.httpClient
      .get<TEntity[]>(`${environment.taskManagerApi}/${TaskType.toUrlResource()}`, {
        headers: this.headers,
      })
      .pipe(
        map((response) =>
          response.map((r) => new this.baseConstructor(r.toJSON()))
        )
      );
  }

  public getById(id: number): Observable<TEntity[]> {
    return this.httpClient.get<TEntity[]>(
      `${environment.taskManagerApi}/${TaskType.toUrlResource()}/${id}`,
      { headers: this.headers }
    );
  }

  public post(taskType: TEntity): Observable<Result> {
    return this.httpClient.put<Result>(
      `${environment.taskManagerApi}/${TaskType.toUrlResource()}`,
      taskType,
      { headers: this.headers }
    );
  }

  /*
  ========== ANALISAR ESSA ABORDAGEM =============
  public post(
    taskType: Partial<TEntity> & { toJSON: () => TEntity },
    type: string
  ): Observable<Result> {
    return this.httpClient
      .post<Result>(
        `${environment.taskManagerApi}/${type}`,
        taskType.toJSON(),
        { headers: this.headers }
      )
      .pipe(map((result) => new this.baseConstructor(result)));
  }*/

  public put(id: number, taskType: TEntity): Observable<Result> {
    return this.httpClient.put<Result>(
      `${environment.taskManagerApi}/${TaskType.toUrlResource()}/${id}`,
      taskType,
      { headers: this.headers }
    );
  }

  public delete(id: number): Observable<Result> {
    return this.httpClient.put<Result>(
      `${environment.taskManagerApi}/${TaskType.toUrlResource()}/${id}`,
      { headers: this.headers }
    );
  }
}
