import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Position } from '~/models/position.model';

export interface DialogData {
  animal: string;
  name: string;
}

@Component({
  selector: 'add-position',
  templateUrl: './add-position.component.html',
})
export class AddPositionComponent {
  constructor( private dialogRef: MatDialogRef<AddPositionComponent>,
               private snackBar: MatSnackBar,
               @Inject('BASE_URL') private baseUrl: string,
               private http: HttpClient) {}

  positionName: string = '';

  addPosition(http: HttpClient): void {
    const position = {
      name: this.positionName,
    };
    this.http.post<Position>(this.baseUrl + `api/position`, position).subscribe(result => {
      console.log('%c Adding new position:', 'color: green');
      console.log(result);
      this.snackBar.open(`Должность '${position.name}' успешно добавлена!`);
      this.close();
    }, error => {
      let message: string;
      if (error.status === 409) {
        message = `Не удалось создать должность: '${this.positionName}' уже существует!`;
      } else {
        message = 'Неизвестная ошибка: не удалось создать должность, обратитесь к администратору!';
      }
      this.snackBar.open(message);
    });
  }

  close(): void {
    this.dialogRef.close();
  }

}
