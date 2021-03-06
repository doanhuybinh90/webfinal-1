import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { PbPriceUsersComponent } from './priceUser/pbPriceUsers/pbPriceUsers.component';
import { PbDownloadEbooksComponent } from './downloadEbook/pbDownloadEbooks/pbDownloadEbooks.component';
import { PbOppinionsComponent } from './oppinion/pbOppinions/pbOppinions.component';
import { PbEbooksComponent } from './ebook/pbEbooks/pbEbooks.component';
import { PbSubjectsComponent } from './subject/pbSubjects/pbSubjects.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import {ShopEbookComponent} from './ebook/shop-ebook/shop-ebook.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                children: [
                    { path: 'priceUser/pbPriceUsers', component: PbPriceUsersComponent, data: { permission: 'Pages.PbPriceUsers' }  },
                    { path: 'downloadEbook/pbDownloadEbooks', component: PbDownloadEbooksComponent, data: { permission: 'Pages.PbDownloadEbooks' }  },
                    { path: 'oppinion/pbOppinions', component: PbOppinionsComponent, data: { permission: 'Pages.PbOppinions' }  },
                    { path: 'ebook/pbEbooks', component: PbEbooksComponent, data: { permission: 'Pages.PbEbooks' }  },
                    { path: 'ebook/shopEbook', component: ShopEbookComponent},
                    { path: 'subject/pbSubjects', component: PbSubjectsComponent, data: { permission: 'Pages.PbSubjects' }  },
                    { path: 'dashboard', component: DashboardComponent, data: { permission: 'Pages.Tenant.Dashboard' } }
                ]
            }
        ])
    ],
    exports: [
        RouterModule
    ]
})
export class MainRoutingModule { }
