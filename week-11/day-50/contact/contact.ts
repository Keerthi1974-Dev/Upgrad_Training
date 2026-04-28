import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

// Pipes
import { PhoneFormatPipe } from '../phone-format-pipe';
import { StatusPipe } from '../status-pipe';
import { SearchPipe } from '../search-pipe';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [CommonModule, FormsModule, PhoneFormatPipe, StatusPipe, SearchPipe],
  templateUrl: './contact.html',
  styleUrls: ['./contact.css']
})
export class Contact {


  searchText: string = '';
  showCount: number = 5;

  contacts = [
    { name: 'keerthi', email: 'keerthi@gmail.com', phone: '9876543210', status: true },
    { name: 'ram', email: 'ram@gmail.com', phone: '9123456780', status: false },
    { name: 'sita', email: 'sita@gmail.com', phone: '9988776655', status: true },
    { name: 'john', email: 'john@gmail.com', phone: '9871234567', status: false },
    { name: 'alex', email: 'alex@gmail.com', phone: '9012345678', status: true },
    { name: 'mike', email: 'mike@gmail.com', phone: '9090909090', status: false },
    { name: 'lisa', email: 'lisa@gmail.com', phone: '8888888888', status: true },
    { name: 'david', email: 'david@gmail.com', phone: '7777777777', status: true },
    { name: 'rohit', email: 'rohit@gmail.com', phone: '6666666666', status: false },
    { name: 'anita', email: 'anita@gmail.com', phone: '5555555555', status: true }
  ];

  toggleStatus(contact: any) {
    contact.status = !contact.status;
  }

  showMore() {
    this.showCount = this.contacts.length;
  }

  showLess() {
    this.showCount = 5;
  }
}