import { Routes, RouterModule } from '@angular/router';
import { EntityComponent }      from './entity.component';

const routes: Routes = [
  { path: '', component: EntityComponent, pathMatch: 'full' }
];

export const EntityRoutes = RouterModule.forChild(routes);