import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Result } from 'src/app/dtos/Result';
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
    },
    private urlResourcePath: string
  ) {
    this.headers = new HttpHeaders({
      'content-Type': 'application/json',
      'Access-Control-Allow-Origin': `https://${window.location.host}`,
      'Access-Control-Allow-Credentials': "true",
      'Access-Control-Allow-Methods': 'GET, POST, PUT, DELETE, OPTIONS',
      'Access-Control-Allow-Headers': 'Origin, Content-Type, Accept'
    });
  }

  public listAll(): Observable<TEntity[]> {
    
    return this.httpClient
      .get<TEntity[]>(`${environment.taskManagerApi}/${this.urlResourcePath}`, {
        headers: this.headers });//;
        // .pipe(
        // map((response) =>
        //   //response.map((r) => new this.baseConstructor(r.toJSON()))
        //   JSON.parse(JSON.stringify(response))
        // )
      // );
  }

  public getById(id: number): Observable<TEntity> {
    return this.httpClient.get<TEntity>(
      `${environment.taskManagerApi}/${this.urlResourcePath}/${id}`,
      { headers: this.headers }
    );
  }

  public post(entity: TEntity): Observable<Result> {
    return this.httpClient.put<Result>(
      `${environment.taskManagerApi}/${this.urlResourcePath}`,
      entity,
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

  public put(id: number, entity: TEntity): Observable<Result> {
    return this.httpClient.put<Result>(
      `${environment.taskManagerApi}/${this.urlResourcePath}/${id}`,
      entity,
      { headers: this.headers }
    );
  }

  public delete(id: number): Observable<Result> {
    return this.httpClient.put<Result>(
      `${environment.taskManagerApi}/${this.urlResourcePath}/${id}`,
      { headers: this.headers }
    );
  }
}
