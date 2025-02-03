import { Injectable } from '@angular/core';
import { Task } from '../task';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class TaskService {

  constructor(private httpClient: HttpClient) { }

  baseUrl="http://localhost:7123/api/Task";

  readonly httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
    })
  };

  getTasks(): Observable<Task[]> {
    return this.httpClient.get<Task[]>(this.baseUrl);
  }

  addTask(newTask: Task) {
    const newTaskJson = <Task>{
      name: newTask.name,
      description: newTask.description,
      assignedTo: newTask.assignedTo,
      dueDate: newTask.dueDate,
      status: newTask.status,
      
    };

    return this.httpClient.post<Task>(`${this.baseUrl}/CreateTask`, newTaskJson, { headers: this.httpOptions.headers, responseType: 'text' as 'json' });
  }

  editTask(task: Task) {
    return this.httpClient.put<Task>(`${this.baseUrl}/UpdateTask/${task.id}`, task);
  }

  deleteTask(task: Task) {
    return this.httpClient.delete<void>(`${this.baseUrl}/DeleteTask/${task.id}`,{ headers: this.httpOptions.headers, responseType: 'text' as 'json' });
  }

}
