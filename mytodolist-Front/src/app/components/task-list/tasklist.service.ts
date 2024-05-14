import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { TaskList } from './tasklist.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TasklistService {

  baseUrl = ''

  constructor(private snackBar: MatSnackBar, private http: HttpClient) { }

  create(taskList: TaskList): Observable<TaskList> {
    return this.http.post<TaskList>(this.baseUrl, taskList)
  }

  read(id : string) : Observable <TaskList> {
    const url = `${this.baseUrl}/${id}`
    return this.http.get<TaskList>(url)
  }

  list() {
    return this.http.get<TaskList[]>(this.baseUrl)
  }

  update(taskList: TaskList) {
    const url = `${this.baseUrl}/${taskList.id}`
    return this.http.put<TaskList>(url, taskList)
  }

  delete(id: string) {
    const url = `${this.baseUrl}/${id}`
    return this.http.delete<TaskList>(url)
  }

  disable(taskList: TaskList) {
    const url = `${this.baseUrl}/active/${taskList.id}`
    return this.http.put<TaskList>(url, taskList)
  }
}
