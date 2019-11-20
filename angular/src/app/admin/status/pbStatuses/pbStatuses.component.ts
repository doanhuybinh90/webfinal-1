import { Component, Injector, ViewEncapsulation, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PbStatusesServiceProxy, PbStatusDto  } from '@shared/service-proxies/service-proxies';
import { NotifyService } from '@abp/notify/notify.service';
import { AppComponentBase } from '@shared/common/app-component-base';
import { TokenAuthServiceProxy } from '@shared/service-proxies/service-proxies';
import { CreateOrEditPbStatusModalComponent } from './create-or-edit-pbStatus-modal.component';
import { ViewPbStatusModalComponent } from './view-pbStatus-modal.component';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { Table } from 'primeng/components/table/table';
import { Paginator } from 'primeng/components/paginator/paginator';
import { LazyLoadEvent } from 'primeng/components/common/lazyloadevent';
import { FileDownloadService } from '@shared/utils/file-download.service';
import * as _ from 'lodash';
import * as moment from 'moment';

@Component({
    templateUrl: './pbStatuses.component.html',
    encapsulation: ViewEncapsulation.None,
    animations: [appModuleAnimation()]
})
export class PbStatusesComponent extends AppComponentBase {

    @ViewChild('createOrEditPbStatusModal', { static: true }) createOrEditPbStatusModal: CreateOrEditPbStatusModalComponent;
    @ViewChild('viewPbStatusModalComponent', { static: true }) viewPbStatusModal: ViewPbStatusModalComponent;
    @ViewChild('dataTable', { static: true }) dataTable: Table;
    @ViewChild('paginator', { static: true }) paginator: Paginator;

    advancedFiltersAreShown = false;
    filterText = '';
    statusNameFilter = '';
    descriptionFilter = '';




    constructor(
        injector: Injector,
        private _pbStatusesServiceProxy: PbStatusesServiceProxy,
        private _notifyService: NotifyService,
        private _tokenAuth: TokenAuthServiceProxy,
        private _activatedRoute: ActivatedRoute,
        private _fileDownloadService: FileDownloadService
    ) {
        super(injector);
    }

    getPbStatuses(event?: LazyLoadEvent) {
        if (this.primengTableHelper.shouldResetPaging(event)) {
            this.paginator.changePage(0);
            return;
        }

        this.primengTableHelper.showLoadingIndicator();

        this._pbStatusesServiceProxy.getAll(
            this.filterText,
            this.statusNameFilter,
            this.descriptionFilter,
            this.primengTableHelper.getSorting(this.dataTable),
            this.primengTableHelper.getSkipCount(this.paginator, event),
            this.primengTableHelper.getMaxResultCount(this.paginator, event)
        ).subscribe(result => {
            this.primengTableHelper.totalRecordsCount = result.totalCount;
            this.primengTableHelper.records = result.items;
            this.primengTableHelper.hideLoadingIndicator();
        });
    }

    reloadPage(): void {
        this.paginator.changePage(this.paginator.getPage());
    }

    createPbStatus(): void {
        this.createOrEditPbStatusModal.show();
    }

    deletePbStatus(pbStatus: PbStatusDto): void {
        this.message.confirm(
            '',
            (isConfirmed) => {
                if (isConfirmed) {
                    this._pbStatusesServiceProxy.delete(pbStatus.id)
                        .subscribe(() => {
                            this.reloadPage();
                            this.notify.success(this.l('SuccessfullyDeleted'));
                        });
                }
            }
        );
    }

    exportToExcel(): void {
        this._pbStatusesServiceProxy.getPbStatusesToExcel(
        this.filterText,
            this.statusNameFilter,
            this.descriptionFilter,
        )
        .subscribe(result => {
            this._fileDownloadService.downloadTempFile(result);
         });
    }
}
