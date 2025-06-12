import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SearchRequest } from '../searchrequest';
import { SearchOutput } from '../searchoutput';

@Component({
  selector: 'app-search-query',
  templateUrl: './search-query.component.html',
  styleUrls: ['./search-query.component.css']
})
export class SearchQueryComponent {
  queryText = '';
  results: SearchOutput[] = [];

  constructor(private http: HttpClient) {}

  submitQuery() {
    console.log("test")
    const request: SearchRequest = { query: this.queryText };

    this.http.post<SearchOutput[]>('https://localhost:44332/api/search', request)
      .subscribe(
        (data) => {
          this.results = data;
          console.log(this.results, 'result')
        },
        (error) => {
          console.error('api call failed:', error);
        }
      );
  }
}