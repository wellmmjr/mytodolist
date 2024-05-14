import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './views/home/home.component'
import {TaskListCrudComponent} from './views/task-list-crud/task-list-crud.component';
import {TaskItselfCrudComponent} from './views/task-itself-crud/task-itself-crud.component';
import { TaskListCreateComponent } from './components/task-list/task-list-create/task-list-create.component';
import { TaskListReadComponent } from './components/task-list/task-list-read/task-list-read.component';
import { TaskListListComponent } from './components/task-list/task-list-list/task-list-list.component';
import { TaskListDeleteComponent } from './components/task-list/task-list-delete/task-list-delete.component';
import { TaskListUpdateComponent } from './components/task-list/task-list-update/task-list-update.component';
import { TaskItselfCreateComponent } from './components/task-itself/task-itself-create/task-itself-create.component';
import { TaskItselfReadComponent } from './components/task-itself/task-itself-read/task-itself-read.component';
import { TaskItselfUpdateComponent } from './components/task-itself/task-itself-update/task-itself-update.component';
import { TaskItselfDeleteComponent } from './components/task-itself/task-itself-delete/task-itself-delete.component';
import { TaskItselfListComponent } from './components/task-itself/task-itself-list/task-itself-list.component';

const routes: Routes = [
  {
    path:"",
    component: HomeComponent
  },
  {
    path:'task',
    component: TaskItselfCrudComponent,
  },
  {
    path:'tasklist',
    component: TaskListCrudComponent,
  },
  {
    path:'tasklist/create',
    component: TaskListCreateComponent,
  },
  {
    path:'tasklist/update',
    component: TaskListUpdateComponent,
  },
  {
    path:'tasklist/delete',
    component: TaskListDeleteComponent,
  },
  {
    path:'tasklist/read',
    component: TaskListReadComponent,
  },
  {
    path:'tasklist/list',
    component: TaskListListComponent,
  },
  {
    path:'task/create',
    component: TaskItselfCreateComponent,
  },
  {
    path:'task/read',
    component: TaskItselfReadComponent,
  },
  {
    path:'task/update',
    component: TaskItselfUpdateComponent,
  },
  {
    path:'task/delete',
    component: TaskItselfDeleteComponent,
  },
  {
    path:'task/list',
    component: TaskItselfListComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
