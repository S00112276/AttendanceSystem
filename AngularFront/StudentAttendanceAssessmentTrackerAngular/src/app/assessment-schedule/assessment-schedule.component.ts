import { Component, OnInit } from '@angular/core';

import { PercentPipe } from '@angular/common';

@Component({
  selector: 'app-assessment-schedule',
  templateUrl: './assessment-schedule.component.html',
  styleUrls: ['./assessment-schedule.component.css']
})

export class AssessmentScheduleComponent implements OnInit {
  
  assessments: any[] = [
    {
      moduleId: "1",
      dueDate: "23/03/2018",
      location: "D2037",
      percentage: .5,
      description: "Final Exam",
    },
    {
      moduleId: "2",
      dueDate: "21/03/2018",
      location: "D2039",
      percentage: .5,
      description: "Final Exam",
    },
    {
      moduleId: "3",
      dueDate: "20/03/2018",
      location: "C1002",
      percentage: .7,
      description: "Final Exam",
    },
    {
      moduleId: "3",
      dueDate: "06/03/2018",
      location: "D1031",
      percentage: .1,
      description: "Moodle Quiz",
    }
  ];

  modules: any[] = [
    {
      moduleId: "1",
      moduleName: "Database Development"
    },
    {
      moduleId: "2",
      moduleName: "Rich Application Development"
    },
    {
      moduleId: "3",
      moduleName: "Software Qulaity & Testing"
    },
  ];

  displayedColumns = ['description', 'module', 'dueDate'];

  constructor() { 
  }

  findModuleNames() {
    for (let i = 0; i < this.assessments.length; i++) {
      for (let j = 0; j < this.modules.length; j++) {
        if (this.assessments[i].moduleId == this.modules[j].moduleId) {
          this.assessments[i].moduleName = this.modules[j].moduleName
        }   
      }      
    }
  }

  ngOnInit() {
    this.findModuleNames();
  }

}
