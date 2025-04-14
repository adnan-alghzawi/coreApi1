import { Component } from '@angular/core';
import { AdnanService } from '../service/adnan.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']  // ✅ مش styleUrl
})
export class AddCategoryComponent {
  categoryName = '';
  categoryDescription = '';

  constructor(private _ser: AdnanService, private router: Router) { }

  addCategory() {
    const data = {
      categoryName: this.categoryName,
      categoryDescription: this.categoryDescription
    };

    this._ser.addCategorries(data).subscribe(() => {
      alert("Added");
      this.router.navigate(['/allCategories']);
    });
  }
}
