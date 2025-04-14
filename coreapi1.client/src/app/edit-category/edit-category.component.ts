import { Component } from '@angular/core';
import { AdnanService } from '../service/adnan.service';
import { ActivatedRoute, Router } from '@angular/router'; // ← أضف Router
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-edit-category',
  templateUrl: './edit-category.component.html',
  styleUrl: './edit-category.component.css'
})
export class EditCategoryComponent {
  constructor(
    private _ser: AdnanService,
    private _active: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit() { }

  editCategory(data: any) {
    let id = this._active.snapshot.paramMap.get('id');

    var form = new FormData();
    form.append('CategoryName', data.CategoryName);
    form.append('CategoryDescription', data.CategoryDescription);

    this._ser.editCategory(id, form).subscribe((data: any) => {
      alert("Category Updated Successfully");
      this.router.navigate(['/allCategories']);
    });
  }

  
}
