import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-task-itself-crud',
  templateUrl: './task-itself-crud.component.html',
  styleUrls: ['./task-itself-crud.component.scss']
})
export class TaskItselfCrudComponent {
  constructor(private router: Router) { }

  ngOnInit() : void{

  }

  navigateTaskCreate(): void{
    this.router.navigate( 
      ['task/create']
    )
  }
}
