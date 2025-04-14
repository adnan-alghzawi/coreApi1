import { Component } from '@angular/core';
import { AdnanService } from '../service/adnan.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-category-details',
  templateUrl: './category-details.component.html',
  styleUrl: './category-details.component.css'
})
export class CategoryDetailsComponent {
  categoryId: any;
  category: any;

  constructor(private route: ActivatedRoute, private _ser: AdnanService) { }

  ngOnInit() {
    this.getCategoryById();
  }

  
  getCategoryById() {
    this.categoryId = this.route.snapshot.paramMap.get('id');
    console.log("Fetched categoryId:", this.categoryId);  // اضافه هذا السطر للتأكد من وصول الـ ID بشكل صحيح
    this._ser.getCategoryById(this.categoryId).subscribe((data: any) => {
      if (data) {
        this.category = data;  // تخزين البيانات هنا
      } else {
        console.error('No data returned for categoryId:', this.categoryId);
      }
    }, error => {
      console.error('Error fetching category data:', error);
    });
  }



}
