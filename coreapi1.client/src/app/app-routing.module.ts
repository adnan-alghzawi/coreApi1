import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditCategoryComponent } from './edit-category/edit-category.component';
import { AllCategoriesComponent } from './all-categories/all-categories.component';


const routes: Routes = [
  { path: 'editCategory/:id', component: EditCategoryComponent },
  { path: 'allCategory', component: AllCategoriesComponent },
  { path: 'allCategories', component: AllCategoriesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
