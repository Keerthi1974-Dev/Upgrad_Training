import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-demo',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class Demo {

  count: number = 0;
  uname: string = 'Narasimha';

  button1ClickHandler(): void {
    this.count++;
  }

  button2ClickHandler(): void {
    alert("Hi " + this.uname);
  }
}