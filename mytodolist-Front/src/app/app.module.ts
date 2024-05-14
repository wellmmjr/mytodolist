import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './template/header/header.component';
import { FootComponent } from './template/foot/foot.component';
import { NavComponent } from './template/nav/nav.component';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatSidenavModule} from '@angular/material/sidenav'
import {MatCardModule} from '@angular/material/card'
import {MatListModule} from '@angular/material/list';
import {MatButtonModule} from '@angular/material/button'
import { MatSnackBarModule } from '@angular/material/snack-bar'
import { HttpClientModule } from '@angular/common/http'
import { FormsModule } from '@angular/forms'
import { MatFormFieldModule} from '@angular/material/form-field'
import { MatInputModule } from '@angular/material/input';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort'


import localePt from '@angular/common/locales/pt'
import { registerLocaleData } from '@angular/common';
import { HomeComponent } from './views/home/home.component';
import { TaskListCrudComponent } from './views/task-list-crud/task-list-crud.component';
import { TaskItselfCrudComponent } from './views/task-itself-crud/task-itself-crud.component';
import { TaskListCreateComponent } from './components/task-list/task-list-create/task-list-create.component';
import { TaskItselfCreateComponent } from './components/task-itself/task-itself-create/task-itself-create.component';
import { TaskListUpdateComponent } from './components/task-list/task-list-update/task-list-update.component';
import { TaskListDeleteComponent } from './components/task-list/task-list-delete/task-list-delete.component';
import { TaskListReadComponent } from './components/task-list/task-list-read/task-list-read.component';
import { TaskListListComponent } from './components/task-list/task-list-list/task-list-list.component';
import { TaskItselfListComponent } from './components/task-itself/task-itself-list/task-itself-list.component';
import { TaskItselfDeleteComponent } from './components/task-itself/task-itself-delete/task-itself-delete.component';
import { TaskItselfReadComponent } from './components/task-itself/task-itself-read/task-itself-read.component';
import { TaskItselfUpdateComponent } from './components/task-itself/task-itself-update/task-itself-update.component';

registerLocaleData(localePt)

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FootComponent,
    NavComponent,
    HomeComponent,
    TaskListCrudComponent,
    TaskItselfCrudComponent,
    TaskListCreateComponent,
    TaskItselfCreateComponent,
    TaskListUpdateComponent,
    TaskListDeleteComponent,
    TaskListReadComponent,
    TaskListListComponent,
    TaskItselfListComponent,
    TaskItselfDeleteComponent,
    TaskItselfReadComponent,
    TaskItselfUpdateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatCardModule,
    MatButtonModule,
    MatSnackBarModule,
    HttpClientModule,
    FormsModule,
    MatInputModule,
    MatFormFieldModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
