import { Component, Inject} from '@angular/core';
import { Http } from '@angular/http';
@Component({
    selector: 'contacts',
    templateUrl: './contacts.component.html'
})

export class ContactsComponent {
    public contacts : Contact[] ;
    
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/contacts').subscribe(result => {
            this.contacts = result.json() as Contact[];
        }, error => console.error(error));
    }

    public getContacts() {
        this.contacts = [{ firstName: 'ion', lastName:'ionescu', email:'ion@g.com' }];
    }
}

interface Contact {
    firstName: string;
    lastName: string;
    email: string;
}

