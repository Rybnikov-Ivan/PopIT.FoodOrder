import { Component, OnInit } from '@angular/core';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {
  buttonOptions = {
    text: "Submit the Form",
    useSubmitBehavior: true
}
  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  onSubmit = () => {
    this.router.navigate(['/api']);
  }
}
