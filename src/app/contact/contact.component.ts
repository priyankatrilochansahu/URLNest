import { Component } from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent {
  formData = {
    name: '',
    email: '',
    message: ''
  };

  showForm = false;
  successMessage = '';

  onSubmit(): void {
    if (this.formData.name && this.formData.email && this.formData.message) {
      this.successMessage = `Message sent!\n\nName: ${this.formData.name}\nEmail: ${this.formData.email}\nMessage: ${this.formData.message}`;

      // Clear form data
      this.formData = { name: '', email: '', message: '' };

      // Optionally hide form after success, comment this if you want it to stay open
      // this.showForm = false;

      // Clear success message after 5 seconds
      setTimeout(() => {
        this.successMessage = '';
      }, 5000);
    } else {
      alert('Please fill in all fields.');
    }
  }
}