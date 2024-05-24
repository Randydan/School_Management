import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { inject } from '@angular/core';
import { RouterLink } from '@angular/router';
import { CourseService } from '../../services/course.service';
import { Courses } from '../../Types/course';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-course',
  standalone: true,
  imports: [FormsModule,AsyncPipe, RouterLink],
  templateUrl: './course.component.html',
  styleUrl: './course.component.css'
})
export class CourseComponent implements OnInit{

  courses: Courses[] =[];
  ngOnInit(): void {
    this.courseService.getcourses().subscribe({
      next:(course)=>{
       this.courses = course;
      }
    })
  }
  courseService = inject(CourseService);
  
}
