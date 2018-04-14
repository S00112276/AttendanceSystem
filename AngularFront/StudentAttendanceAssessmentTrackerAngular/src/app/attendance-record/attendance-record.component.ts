import { Component, OnInit } from '@angular/core';
import { AttendanceService } from '../shared/attendance.service';

@Component({
  selector: 'app-attendance-record',
  templateUrl: './attendance-record.component.html',
  styleUrls: ['./attendance-record.component.css']
})
export class AttendanceRecordComponent implements OnInit {
  students = [];
  selectedModule =[];

  constructor(public _attendanceService: AttendanceService) { 
    this.students = this._attendanceService.students;    
    this.selectedModule = this._attendanceService.selectedModule;
  }

  ngOnInit() {
  }
}
