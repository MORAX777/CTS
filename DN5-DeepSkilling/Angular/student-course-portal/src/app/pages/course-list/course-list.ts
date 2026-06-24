import { Component } from '@angular/core';
import { CourseCard } from '../../components/course-card/course-card';

@Component({
  selector: 'app-course-list',
  imports: [CourseCard],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList {

  courses = [
    {
      name: 'Angular',
      code: 'ANG101',
      credits: 4
    },
    {
      name: 'Java',
      code: 'JAVA201',
      credits: 3
    },
    {
      name: 'Database Systems',
      code: 'DB301',
      credits: 4
    }
  ];
}