import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogOverviewExampleDialog } from '../dialog-overview-example-dialog/dialog-overview-example-dialog';

/**
 * @title Dialog overview example
 */
@Component({
  selector: 'dialog-overview-example',
  templateUrl: 'dialog-overview-example.html',
  styleUrls: ['dialog-overview-example.scss'],
})
export class DialogOverviewExample {
  animal: string;
  name: string;

  constructor(public dialog: MatDialog) {}

  openDialog(): void {
    const dialogRef = this.dialog.open(DialogOverviewExampleDialog, {
      width: '250px',
      data: {name: this.name, animal: this.animal}
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      this.animal = result;
    });
  }

}
