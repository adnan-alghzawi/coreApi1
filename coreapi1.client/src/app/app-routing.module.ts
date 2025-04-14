import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditCategoryComponent } from './edit-category/edit-category.component';
import { AllCategoriesComponent } from './all-categories/all-categories.component';
import { AddCategoryComponent } from './add-category/add-category.component';
import { CategoryDetailsComponent } from './category-details/category-details.component';


const routes: Routes = [
  { path: 'editCategory/:id', component: EditCategoryComponent },
  { path: 'allCategory', component: AllCategoriesComponent },
  { path: 'allCategories', component: AllCategoriesComponent },
  { path: 'addCategory', component: AddCategoryComponent },
  { path: 'categoryDetails/:id', component: CategoryDetailsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
