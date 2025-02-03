import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { TaskService } from '../services/task.service';
import { Task } from '../task';
import { Status } from '../status_enum';
import { NotificationService } from '../notification.service';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatInputModule } from '@angular/material/input';
import { MatNativeDateModule } from '@angular/material/core';

@Component({
  selector: 'app-add-task',
  standalone: true,
  imports: [FormsModule, MatDatepickerModule, MatInputModule, MatNativeDateModule],
  templateUrl: './add-task.component.html',
  styleUrl: './add-task.component.scss',
  providers: [TaskService]
})
export class AddTaskComponent {
taskName: string;
taskDescription: string;
taskAssignedTo: string;
taskDueDate: Date;
  tasks: Task[];

constructor(private router: Router, private taskService: TaskService, private notificationService: NotificationService) {
  this.taskService.getTasks().subscribe(tasks => this.tasks = tasks);
}

onSubmit() {
  console.log('Task Name: ' + this.taskName);
  console.log('Task Description: ' + this.taskDescription);
  console.log('Task Assigned To: ' + this.taskAssignedTo);
  console.log('Due Date: ' + this.taskDueDate);
  
  const newTask: Task = {
    id: 'unique_id',
    name: this.taskName,
    description: this.taskDescription,
    assignedTo: this.taskAssignedTo,
    dueDate: this.taskDueDate,
    status: Status.ToDo,
  };
  
  this.taskService.addTask(newTask)
      .subscribe(task => {
        this.notificationService.sendMessage("BroadcastMessage", [task])
        this.router.navigate(['/']);
      });
}

cancel() {
  this.router.navigate(['/']);
}
}
