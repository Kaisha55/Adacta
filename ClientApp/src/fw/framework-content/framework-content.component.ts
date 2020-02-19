import { Component, OnInit } from '@angular/core';
import { MenuService } from '../services/menu.service';
import { ScreenService } from '../services/screen.service';

@Component({
  selector: 'fw-framework-content',
  templateUrl: './framework-content.component.html',
  styleUrls: ['./framework-content.component.css']
})
export class FrameworkContentComponent implements OnInit {

  constructor(private menuService: MenuService, private screenService: ScreenService) { }

  ngOnInit() {
  }

}
