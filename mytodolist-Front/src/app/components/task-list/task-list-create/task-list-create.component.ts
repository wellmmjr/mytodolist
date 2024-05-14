import { Component } from '@angular/core';
import { TaskList } from '../tasklist.model';
import { TasklistService } from '../tasklist.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-task-list-create',
  templateUrl: './task-list-create.component.html',
  styleUrls: ['./task-list-create.component.scss']
})
export class TaskListCreateComponent {
  taskList: TaskList = {
    titulo: ''
  }


  constructor(private tasklistService: TasklistService, private router: Router) { }

  ngOnInit(): void {

    
  }

  createTaskList(): void {
    this.tasklistService.create(this.taskList).subscribe(() => {
      this.
    })
  }

  cancel(): void{
    this.router.navigate(["/tasklist"])
  }
}
