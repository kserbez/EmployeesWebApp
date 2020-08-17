import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatNativeDateModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatSelectModule } from '@angular/material/select';
import { MatTableModule } from '@angular/material/table';
import { MatSnackBarModule } from '@angular/material/snack-bar';


import { AppComponent } from '~/app/app.component';
import { EmployeesComponent } from '~/app/components/employees/employees.component';
import { AddEmployeeComponent } from '~/app/components/add-employee/add-employee.component';
import { AddPositionComponent } from '~/app/components/add-position/add-position.component';


@NgModule({
  declarations: [
    AppComponent,
    EmployeesComponent,
    AddEmployeeComponent,
    AddPositionComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    NoopAnimationsModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    MatNativeDateModule,
    MatDatepickerModule,
    MatSelectModule,
    MatTableModule,
    MatSnackBarModule,
  ],
  providers: [
  ],
  bootstrap: [
    AppComponent,
  ],
  entryComponents: [
    // because https://stackoverflow.com/questions/56390787/angular-8-error-error-no-component-factory-found/56390853
    AddEmployeeComponent,
    AddPositionComponent,
  ]
})
export class AppModule { }
