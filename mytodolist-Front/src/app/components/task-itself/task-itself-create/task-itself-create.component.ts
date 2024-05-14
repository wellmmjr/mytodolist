import { Component } from '@angular/core';
import { TaskitselfService } from '../taskitself.service';

@Component({
  selector: 'app-task-itself-create',
  templateUrl: './task-itself-create.component.html',
  styleUrls: ['./task-itself-create.component.scss']
})
export class TaskItselfCreateComponent {
  constructor(private taskService: TaskitselfService) { }

  
}
