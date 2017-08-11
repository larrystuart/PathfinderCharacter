import { Component, Input, Output, EventEmitter } from '@angular/core';
import { PagerService } from '../../shared/pager.service';

@Component({
    selector: 'pager',
    templateUrl: './pager.component.html',
    styleUrls: ['./pager.component.css'],
    providers: [PagerService]
})
export class PagerComponent {
    private _data: any[];

    // pager object
    public pager: any = {};
    //@Input() data: any = [];
    @Input() set data(value: any[]) {
        this._data = value;
        this.setPage(1);
    }
    @Output() dataViewChange: EventEmitter<any> = new EventEmitter<any>(true);

    constructor(private pagerService: PagerService) {
        
    }

    public setPage(page: number) {
        if (page < 1 || page > this.pager.totalPages) {
            return;
        }

        // get pager object from service
        this.pager = this.pagerService.getPager(this._data.length, page, 10);

        // pass the new viewable filtered data subset back to the parent
        this.dataViewChange.emit({
            data: this._data.slice(this.pager.startIndex, this.pager.endIndex + 1),
            pager: this.pager
        });
    }
    
}
