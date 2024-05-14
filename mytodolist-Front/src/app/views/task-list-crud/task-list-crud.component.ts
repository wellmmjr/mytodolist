import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-task-list-crud',
  templateUrl: './task-list-crud.component.html',
  styleUrls: ['./task-list-crud.component.scss']
})
export class TaskListCrudComponent {
  constructor(private router: Router) { }

  ngOnInit() : void{

  }

  navigateTaskListCreate(): void{
    this.router.navigate( 
      ['tasklist/create']
    )
  }


}
