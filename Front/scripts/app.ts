import {Component, View} from 'angular2/core';

@Component({
    selector: 'my-app'
})
@View({
    template: `
    Message: {{ message }}
    <br/><input [(ngModel)]="message"/>
`
})
export class AppComponent {
    message: string;
}