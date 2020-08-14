import { Employee } from './employee.model';
import { Position } from './position.model';

export interface EmployeePosition {
  id: number;
  employee: Employee;
  position: Position;
  sallary: number;
  dateFrom: any;
  dateTo: any | null;
};