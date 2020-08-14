import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
// import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
// import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
// import { HomeComponent } from './components/home/home.component';
// import { CounterComponent } from './components/counter/counter.component';
// import { FetchDataComponent } from './components/fetch-data/fetch-data.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

import { EmployeesComponent } from './components/employees/employees.component';
import { DialogOverviewExampleDialog } from './components/dialog-overview-example-dialog/dialog-overview-example-dialog';


@NgModule({
  declarations: [
    AppComponent,
    // NavMenuComponent,
    // HomeComponent,
    // CounterComponent,
    // FetchDataComponent,

    EmployeesComponent,
    DialogOverviewExampleDialog,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    // RouterModule.forRoot([
    //   { path: '', component: HomeComponent, pathMatch: 'full' },
    //   { path: 'counter', component: CounterComponent },
    //   { path: 'fetch-data', component: FetchDataComponent },
    //   { path: 'dialog-example', component: EmployeesComponent },
    // ]),
    NoopAnimationsModule,
    BrowserAnimationsModule,

    MatButtonModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
  ],
  providers: [
  ],
  bootstrap: [
    AppComponent,
  ],
  entryComponents: [
    DialogOverviewExampleDialog, // https://stackoverflow.com/questions/56390787/angular-8-error-error-no-component-factory-found/56390853
  ]
})
export class AppModule { }
