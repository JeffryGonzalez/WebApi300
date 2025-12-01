import { HttpClient } from '@angular/common/http';
import { Component, ChangeDetectionStrategy, OnInit, inject } from '@angular/core';
import { FeatureNav } from 'app-ui/feature-nav';
import { client } from '../api-clients/software/client.gen';

@Component({
  selector: 'app-vendors',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [FeatureNav],
  template: `
    <app-feature-nav sectionName="Vendor Management" [links]="[{
      label: 'Create Vendor', link: '/vendors/create', exact: false, icon: 'none' }
    ]">

    </app-feature-nav>
  `,
  styles: ``,
})
export class Vendors implements OnInit {
  #client = inject(HttpClient);

  ngOnInit(): void {
    client.setConfig({
      baseUrl: '/api',
      httpClient: this.#client,
    })
  }
}
