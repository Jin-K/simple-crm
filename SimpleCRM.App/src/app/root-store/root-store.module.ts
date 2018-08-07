import { NgModule }                                           from '@angular/core';
import { CommonModule }                                       from '@angular/common';
import { StoreModule }                                        from '@ngrx/store';
import { EffectsModule }                                      from '@ngrx/effects';
import { StoreDevtoolsModule }                                from '@ngrx/store-devtools';
import { StoreRouterConnectingModule, RouterStateSerializer } from '@ngrx/router-store';
import { storeFreeze }                                        from 'ngrx-store-freeze';

import { UserModule }                                         from './user/user.module';
import { reducers }                                           from './reducers';
import { INITIAL_APPLICATION_STATE }                          from './reducers/application-state';
import { environment }                                        from '../../environments/environment.prod';
import { CustomRouterStateSerializer }                        from './router-state-serializer';

@NgModule({
  imports: [
    CommonModule,
    StoreModule.forRoot(
      reducers,
      { metaReducers: [storeFreeze], initialState: INITIAL_APPLICATION_STATE }
    ),
    StoreDevtoolsModule.instrument({
      maxAge: 25,
      logOnly: environment.production
    }),
    StoreRouterConnectingModule.forRoot({
      stateKey: 'router',
    }),
    EffectsModule.forRoot([]),
    UserModule
  ],
  declarations: [],
  providers: [
    { provide: RouterStateSerializer, useClass: CustomRouterStateSerializer }
  ]
})
export class RootStoreModule { }
