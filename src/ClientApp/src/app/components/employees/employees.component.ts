import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatDialog } from '@angular/material/dialog';
import { AddEmployeeComponent } from '~/app/components/add-employee/add-employee.component';
import { AddPositionComponent } from '~/app/components/add-position/add-position.component';
import { EmployeePosition } from '~/models/employee-position.model';


export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}
const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H'},
  {position: 2, name: 'Helium', weight: 4.0026, symbol: 'He'},
  {position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li'},
  {position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be'},
  {position: 5, name: 'Boron', weight: 10.811, symbol: 'B'},
  {position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C'},
  {position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N'},
  {position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O'},
  {position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F'},
  {position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne'},
];


@Component({
  selector: 'employees',
  templateUrl: 'employees.component.html',
  styleUrls: ['employees.component.scss'],
})
export class EmployeesComponent {
  animal: string;
  name: string;

  displayedColumns: string[] = ['i', 'position', 'employee', 'salary'];
  dataSource: EmployeePosition[] = [];

  constructor(public dialog: MatDialog, http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<EmployeePosition[]>(baseUrl + `api/employee`).subscribe(result => {
      console.log('%c Employees:', 'color: green');
      console.log(result);
      this.dataSource = result;
    }, error => console.error(error));
  }

  addEmployee(): void {
    const dialogRef = this.dialog.open(AddEmployeeComponent, {
      width: 'auto',
      data: {name: this.name, animal: this.animal}
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The \'addEmployee\' dialog was closed');
      this.animal = result;
    });
  }

  addPosition(): void {
    const dialogRef = this.dialog.open(AddPositionComponent, {
      width: 'auto',
      data: {name: this.name, animal: this.animal}
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The \'addPosition\' dialog was closed');
      this.animal = result;
    });
  }

}
