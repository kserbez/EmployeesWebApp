import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Position } from '~/models/position.model';


@Component({
  selector: 'add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['add-employee.component.scss'],
})
export class AddEmployeeComponent {
  constructor(private dialogRef: MatDialogRef<AddEmployeeComponent>,
              private snackBar: MatSnackBar,
              @Inject('BASE_URL') private baseUrl: string,
              private http: HttpClient) {}

  allPositions: Position[] = [];

  surname: string;
  name: string;
  position: Position;
  sallary: number;
  dateFrom: Date;
  dateTo: Date | null;

  ngOnInit() {
    // TODO fetch all positions
  }


  close(): void {
    this.dialogRef.close();
  }
}
