import { Component, OnInit } from '@angular/core';
import { PercentPipe } from '@angular/common';
import { AttendanceService } from '../shared/attendance.service';

@Component({
  selector: 'app-attendance',
  templateUrl: './attendance.component.html',
  styleUrls: ['./attendance.component.css']
})
export class AttendanceComponent implements OnInit {

  constructor(public _attendanceService: AttendanceService) {
  }

  ngOnInit() {
    this._attendanceService.getStudents().subscribe(students => {
      students.forEach(student => {
        this.students.push(student);
      });
    })
  }

  students: any[] = [];
  tempStudents: any[] = [];
  selectedModule;

  modules = [
    {
      title: 'Maths',
      enrolledStudents: [
        '1', '2', '3', '4', '5', '6', '7', '8'
      ]
    },
    {
      title: 'English',
      enrolledStudents: [
        '1', '2', '3', '4', '5', '6', '7', '8'
      ]
    },
    {
      title: 'Irish',
      enrolledStudents: [
        '1', '2', '3', '4', '5', '6', '7', '8'
      ]
    },
    {
      title: 'History',
      enrolledStudents: [
        '1', '2', '3', '4', '5', '6', '7', '8'
      ]
    },
    {
      title: 'Geography',
      enrolledStudents: [
        '1', '2', '3', '4', '5', '6', '7', '8'
      ]
    },
    {
      title: 'Science',
      enrolledStudents: [
        '1', '2', '3', '4', '5', '6', '7', '8'
      ]
    }];

  createRecord(selectedModule) {
    this.selectedModule = selectedModule.title;
    this._attendanceService.selectedModule = selectedModule.title;
    this._attendanceService.students = [];
    for (let i = 0; i < selectedModule.enrolledStudents.length; i++) {
      for (let j = 0; j < this.students.length; j++) {
        if (selectedModule.enrolledStudents[i] == this.students[j].id) {
          this._attendanceService.students.push(this.students[j]);
        }
        else {
          console.log("Not a match");
        }
      }
    }
  }
}