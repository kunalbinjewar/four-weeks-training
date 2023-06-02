import { Component } from '@angular/core';

@Component({
  selector: 'app-template',
  templateUrl: './template.component.html',
  styleUrls: ['./template.component.css']
})
export class TemplateComponent {
  formData: {
    name: string | Event;
    email: string | Event;
    password: string | Event;
    message: string | Event;
  }
  constructor() {
    this.formData = {
      name:'',
      email:'',
      password:'',
      message: '', 
    };
  }
  
  onSubmit() {
    // Handle form submission logic here
  }
  
  }
 

