import { Component } from '@angular/core';
import { AdnanService } from '../service/adnan.service';

@Component({
  selector: 'app-all-products',
  templateUrl: './all-products.component.html',
  styleUrl: './all-products.component.css'
})
export class AllProductsComponent {
  constructor(private _ser: AdnanService) { }

  ngOnInit() {
    this.getAllProducts();
  }

  container: any;

  getAllProducts() {
    this._ser.getProducts().subscribe((data: any) => {
      this.container = data;

    })
  }
}
